using NetMQ;
using NetMQ.Sockets;
using System;
using System.Globalization;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorowanieKlient
{
    public partial class Form1 : Form
    {
        bool subskrypcjaZuzyciaRAMu = false;
        bool subskrypcjaZuzyciaProcesora = false;
        bool subskrypcjaZuzycieProces = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            start.Enabled = false;
            stop.Enabled = true;
            subskrybujGrupa.Enabled = false;
            if (dostepnyRAM.Checked)
            {
                subskrypcjaZuzyciaRAMu = true;
                Task t = Task.Run(() => subskrybuj("RAM", ref subskrypcjaZuzyciaRAMu, pasekZuzycieRamu, TrescWiadomosci.Ram, tekstDostepnyRam));
            }
            if (zuzycieCpu.Checked)
            {
                subskrypcjaZuzyciaProcesora = true;
                Task t = Task.Run(() => subskrybuj("CPU", ref subskrypcjaZuzyciaProcesora, pasekZuzyciaCpu, TrescWiadomosci.Cpu, tekstDostepnyCpu));
            }
            if (zuzycieProces.Checked)
            {
                subskrypcjaZuzycieProces = true;
                Task t = Task.Run(() => subskrybuj("NWM", ref subskrypcjaZuzycieProces, pasekZuzyciaProces, TrescWiadomosci.Nwm, tekstZuzycieProces));
            }
        }

        void subskrybuj(string temat, ref bool subskrypcja, ProgressBar pb, TrescWiadomosci tw, Label l)
        {
            using (SubscriberSocket ss = new SubscriberSocket())
            {
                try
                {
                    ss.Connect("tcp://" + poleNaIp.Text + ":12345");
                }
                catch (SocketException se)
                {
                    MessageBox.Show(se.Message);
                    Invoke(new MethodInvoker(()=>
                    {
                        subskrybujGrupa.Enabled = true;
                        poleNaIp.Enabled = true;
                        polacz.Enabled = true;
                        stop.Enabled = false;
                        zarzadzajSerweremGrupa.Enabled = false;
                    }));
                    return;
                }
                
                ss.Subscribe(temat);
                while (subskrypcja)
                {
                    ss.ReceiveFrameString();
                    float wartosc = float.Parse(ss.ReceiveFrameString(), CultureInfo.CurrentCulture.NumberFormat);
                    MethodInvoker mi = new MethodInvoker(() => aktualizujPasekPostepu(pb, wartosc, tw, l));
                    Invoke(mi);
                }
            }
        }

        void aktualizujPasekPostepu(ProgressBar pb, float wartosc, TrescWiadomosci tw, Label l)
        {
            pb.Value = (int)wartosc;
            switch (tw)
            {
                case TrescWiadomosci.Ram:
                    l.Text = "Dostępny RAM: " + wartosc.ToString() + " MB";
                    break;
                case TrescWiadomosci.Cpu:
                    l.Text = "Zużycie procesora: " + wartosc.ToString() + "%";
                    break;
                case TrescWiadomosci.Nwm:
                    l.Text = "Proces serwera zużywa: " + wartosc.ToString() + " MB";
                    break;
                default:
                    break;
            }
        }

        private void polacz_Click(object sender, EventArgs e)
        {
            if (!dostepnyRAM.Checked && !zuzycieCpu.Checked && !zuzycieProces.Checked)
            {
                MessageBox.Show("Wybierz co najmniej jeden temat");
                return;
            }
            poleNaIp.Enabled = false;
            polacz.Enabled = false;
            start.Enabled = true;
            zarzadzajSerweremGrupa.Enabled = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            stop.Enabled = false;
            start.Enabled = true;
            subskrypcjaZuzyciaProcesora = false;
            subskrypcjaZuzyciaRAMu = false;
            subskrypcjaZuzycieProces = false;
            subskrybujGrupa.Enabled = true;
        }

        private void pobierzObecniePublikowaneTematy_Click(object sender, EventArgs e)
        {
            tematy.Items.Clear();
            using (RequestSocket rs = new RequestSocket(">tcp://" + poleNaIp.Text + ":5555"))
            {
                rs.SendFrame("TEMATY");
                string odp = rs.ReceiveFrameString();
                string[] pom = odp.Split('/');
                foreach (string item in pom)
                {
                    if(item!=string.Empty)
                        tematy.Items.Add(item);
                }
            }
        }

        private void pobierzStalaCzasowa_Click(object sender, EventArgs e)
        {
            using (RequestSocket rs = new RequestSocket(">tcp://" + poleNaIp.Text + ":5555"))
            {
                rs.SendFrame("CZAS");
                interwal.Text = rs.ReceiveFrameString();
            }
        }

        private void wylacz_Click(object sender, EventArgs e)
        {
           if (tematy.SelectedItem == null)
           {
               return;
           }
            using (RequestSocket rs = new RequestSocket(">tcp://" + poleNaIp.Text + ":5555"))
            {
                rs.SendFrame("WYŁ" + tematy.SelectedItem.ToString());
                rs.ReceiveFrameString();
            }
        }

        private void wlacz_Click(object sender, EventArgs e)
        {
            if (tematy.SelectedItem == null)
            {
                return;
            }
            using (RequestSocket rs = new RequestSocket(">tcp://" + poleNaIp.Text + ":5555"))
            {
                rs.SendFrame("WŁ" + tematy.SelectedItem.ToString());
                rs.ReceiveFrameString();
            }
        }

        private void zmienStalaCzasowa_Click(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(interwal.Text, out a))
            {
                MessageBox.Show("Wpisz liczbę");
                return;
            }
            using (RequestSocket rs=new RequestSocket(">tcp://" + poleNaIp.Text + ":5555"))
            {
                rs.SendFrame("CZAS=" + interwal.Text);
                rs.ReceiveFrameString();
            }
        }
    }

    enum TrescWiadomosci
    {
        Ram, Cpu, Nwm
    }
}
