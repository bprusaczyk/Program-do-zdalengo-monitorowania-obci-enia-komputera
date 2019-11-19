using NetMQ;
using NetMQ.Sockets;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorowanieSerwer
{
    public partial class Form1 : Form
    {
        int interwal = 1000;

        public Form1()
        {
            InitializeComponent();
            Task t = Task.Run(() => nasluchuj());
        }

        private void startPrzycisk_Click(object sender, EventArgs e)
        {
            startPrzycisk.Enabled = false;
            Task t = Task.Run(() => publikuj());
        }

        void publikuj()
        {
            PerformanceCounter ram = new PerformanceCounter("Memory", "Available MBytes");
            PerformanceCounter cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);
            PerformanceCounter nwm = new PerformanceCounter("Process", "Private Bytes", Process.GetCurrentProcess().ProcessName);
            using (PublisherSocket ps = new PublisherSocket())
            {
                ps.Bind("tcp://*:12345");
                while (true)
                {
                    if (zuzycieRamu.Checked)
                    {
                        float wartosc = ram.NextValue();
                        ps.SendMoreFrame("RAM").SendFrame(wartosc.ToString());
                        MethodInvoker mi = new MethodInvoker(() => aktualizujPaskiPostepu(pasekZuzyciaRamu, wartosc, tekstZuzycieRamu, WyswietlanyTekst.Ram));
                        Invoke(mi);
                    }
                    if (zuzycieCpu.Checked)
                    {
                        float wartosc = cpu.NextValue();
                        ps.SendMoreFrame("CPU").SendFrame(wartosc.ToString());
                        MethodInvoker mi = new MethodInvoker(() => aktualizujPaskiPostepu(pasekZuzyciaCpu, wartosc, tekstZuzycieCpu, WyswietlanyTekst.Cpu));
                        Invoke(mi);
                    }
                    if (zuzycieProces.Checked)
                    {
                        float wartosc = nwm.NextValue() / 1024 / 1024;
                        ps.SendMoreFrame("NWM").SendFrame(wartosc.ToString());
                        MethodInvoker mi = new MethodInvoker(() => aktualizujPaskiPostepu(progressBar3, wartosc, label3, WyswietlanyTekst.Nwm));
                        Invoke(mi);
                    }
                    Thread.Sleep(interwal);
                }
            }
        }

        void aktualizujPaskiPostepu(ProgressBar pb, float wartosc, Label l, WyswietlanyTekst wt)
        {
            pb.Value = (int)wartosc;
            switch (wt)
            {
                case WyswietlanyTekst.Ram:
                    l.Text = "Dostępna pamięć: " + wartosc.ToString() + " MB";
                    break;
                case WyswietlanyTekst.Cpu:
                    l.Text = "Zuzycie procesora: " + wartosc.ToString() + "%";
                    break;
                case WyswietlanyTekst.Nwm:
                    l.Text = "Aplikacja zużywa: " + wartosc.ToString() + " MB";
                    break;
                default:
                    break;
            }
        }

        void nasluchuj()
        {
            using (ResponseSocket rs = new ResponseSocket("@tcp://*:5555"))
            {
                while (true)
                {
                    string odp = rs.ReceiveFrameString();
                    switch (odp)
                    {
                        case "TEMATY":
                            string wynik = string.Empty;
                            if (zuzycieRamu.Checked)
                            {
                                wynik += "zużycie RAM-u/";
                            }
                            if (zuzycieCpu.Checked)
                            {
                                wynik += "obciążenie CPU/";
                            }
                            if (zuzycieProces.Checked)
                            {
                                wynik += "zużycie pamięci przez proces serwera/";
                            }
                            rs.SendFrame(wynik);
                            break;
                        case "CZAS":
                            rs.SendFrame(interwal.ToString());
                            break;
                        case "WYŁzużycie RAM-u":
                            Invoke(new MethodInvoker(() => zuzycieRamu.Checked = false));
                            rs.SendFrame("OK");
                            break;
                        case "WYŁobciążenie CPU":
                            Invoke(new MethodInvoker(() => zuzycieCpu.Checked = false));
                            rs.SendFrame("OK");
                            break;
                        case "WYŁzużycie pamięci przez proces serwera":
                            Invoke(new MethodInvoker(() => zuzycieProces.Checked = false));
                            rs.SendFrame("OK");
                            break;
                        case "WŁzużycie RAM-u":
                            Invoke(new MethodInvoker(() => zuzycieRamu.Checked = true));
                            rs.SendFrame("OK");
                            break;
                        case "WŁobciążenie CPU":
                            Invoke(new MethodInvoker(() => zuzycieCpu.Checked = true));
                            rs.SendFrame("OK");
                            break;
                        case "WŁzużycie pamięci przez proces serwera":
                            Invoke(new MethodInvoker(() => zuzycieProces.Checked = true));
                            rs.SendFrame("OK");
                            break;
                        default:
                            if (odp.Substring(0, 5) == "CZAS=")
                            {
                                interwal = Convert.ToInt32(odp.Substring(5));
                                rs.SendFrame("OK");
                            }
                            break;
                    }
                }
            }
        }
            

        enum WyswietlanyTekst
        {
            Ram, Cpu, Nwm
        }
    }
}
