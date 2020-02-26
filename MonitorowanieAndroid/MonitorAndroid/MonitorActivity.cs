using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;
using NetMQ.Sockets;
using System.Net.Sockets;
using NetMQ;
using System.Globalization;

namespace MonitorAndroid
{
    [Activity(Label = "MonitorActivity")]
    public class MonitorActivity : Activity
    {
        ProgressBar pasekZuzycieRamu;
        TextView tekstDostepnyRam;
        ProgressBar pasekZuzyciaCpu;
        TextView tekstDostepnyCpu;
        ProgressBar pasekZuzyciaProces;
        TextView tekstZuzycieProces;
        Button zmienStalaCzasowaPrzycisk;
        Button sprawdzPublikowaneTematyPrzycisk;
        Button zarzadzajTematamiPrzycisk;
        bool ram;
        bool cpu;
        bool proces;
        private bool subskrypcjaZuzyciaRAMu;
        private bool subskrypcjaZuzyciaProcesora;
        private bool subskrypcjaZuzycieProces;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.monitor);
            pasekZuzycieRamu = FindViewById<ProgressBar>(Resource.Id.pasekRam);
            pasekZuzyciaCpu = FindViewById<ProgressBar>(Resource.Id.pasekCpu);
            pasekZuzyciaProces = FindViewById<ProgressBar>(Resource.Id.pasekProces);
            tekstDostepnyRam = FindViewById<TextView>(Resource.Id.monitorTekstRam);
            tekstDostepnyCpu = FindViewById<TextView>(Resource.Id.monitorTekstCpu);
            tekstZuzycieProces = FindViewById<TextView>(Resource.Id.monitorTekstProces);
            zmienStalaCzasowaPrzycisk = FindViewById<Button>(Resource.Id.zmienStalaCzasowaPrzycisk);
            sprawdzPublikowaneTematyPrzycisk = FindViewById<Button>(Resource.Id.SprawdzPublikowaneTematy);
            zarzadzajTematamiPrzycisk = FindViewById<Button>(Resource.Id.ZarzadzajTematami);
            zmienStalaCzasowaPrzycisk.Click += ZmienStalaCzasowaPrzycisk_Click;
            sprawdzPublikowaneTematyPrzycisk.Click += SprawdzPublikowaneTematyPrzycisk_Click;
            zarzadzajTematamiPrzycisk.Click += ZarzadzajTematamiPrzycisk_Click;
            ram = Intent.GetBooleanExtra("ram", false);
            cpu = Intent.GetBooleanExtra("cpu", false);
            proces = Intent.GetBooleanExtra("proces", false);
            if (ram)
            {
                subskrypcjaZuzyciaRAMu = true;
                Task t = Task.Run(() => subskrybuj("RAM", ref subskrypcjaZuzyciaRAMu, pasekZuzycieRamu, TrescWiadomosci.Ram, tekstDostepnyRam));
            }
            if (cpu)
            {
                subskrypcjaZuzyciaProcesora = true;
                Task t = Task.Run(() => subskrybuj("CPU", ref subskrypcjaZuzyciaProcesora, pasekZuzyciaCpu, TrescWiadomosci.Cpu, tekstDostepnyCpu));
            }
            if (proces)
            {
                subskrypcjaZuzycieProces = true;
                Task t = Task.Run(() => subskrybuj("NWM", ref subskrypcjaZuzycieProces, pasekZuzyciaProces, TrescWiadomosci.Nwm, tekstZuzycieProces));
            }
        }

        private void ZarzadzajTematamiPrzycisk_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(ZarzadzanieTematamiActivity));
            StartActivity(i);
        }

        private void SprawdzPublikowaneTematyPrzycisk_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(PublikowaneTematyActivity));
            StartActivity(i);
        }

        private void ZmienStalaCzasowaPrzycisk_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(ZmianaStalejCzasowejActivity));
            StartActivity(i);
        }

        void subskrybuj(string temat, ref bool subskrypcja, ProgressBar pb, TrescWiadomosci tw, TextView l)
        {
            using (SubscriberSocket ss = new SubscriberSocket())
            {
                try
                {
                    ss.Connect("tcp://" + AdresIp.IP + ":12345");
                }
                catch (SocketException)
                {
                    Toast.MakeText(Application.Context, "Błąd połączenia", ToastLength.Long).Show();
                    return;
                }
                ss.Subscribe(temat);
                while (subskrypcja)
                {
                    ss.ReceiveFrameString();
                    float wartosc = float.Parse(ss.ReceiveFrameString(), CultureInfo.CurrentCulture.NumberFormat);
                    RunOnUiThread(() => aktualizujPasekPostepu(pb, wartosc, tw, l));
                }
            }
        }

        void aktualizujPasekPostepu(ProgressBar pb, float wartosc, TrescWiadomosci tw, TextView l)
        {
            pb.Progress = (int)wartosc;
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

        protected override void OnPause()
        {
            subskrypcjaZuzyciaProcesora = false;
            subskrypcjaZuzyciaRAMu = false;
            subskrypcjaZuzycieProces = false;
            base.OnPause();
        }

        protected override void OnStop()
        {
            subskrypcjaZuzyciaProcesora = false;
            subskrypcjaZuzyciaRAMu = false;
            subskrypcjaZuzycieProces = false;
            base.OnStop();
        }

        protected override void OnResume()
        {
            if (ram)
            {
                subskrypcjaZuzyciaRAMu = true;
                Task t = Task.Run(() => subskrybuj("RAM", ref subskrypcjaZuzyciaRAMu, pasekZuzycieRamu, TrescWiadomosci.Ram, tekstDostepnyRam));
            }
            if (cpu)
            {
                subskrypcjaZuzyciaProcesora = true;
                Task t = Task.Run(() => subskrybuj("CPU", ref subskrypcjaZuzyciaProcesora, pasekZuzyciaCpu, TrescWiadomosci.Cpu, tekstDostepnyCpu));
            }
            if (proces)
            {
                subskrypcjaZuzycieProces = true;
                Task t = Task.Run(() => subskrybuj("NWM", ref subskrypcjaZuzycieProces, pasekZuzyciaProces, TrescWiadomosci.Nwm, tekstZuzycieProces));
            }
            base.OnResume();
        }

        enum TrescWiadomosci
        {
            Ram, Cpu, Nwm
        }
    }
}