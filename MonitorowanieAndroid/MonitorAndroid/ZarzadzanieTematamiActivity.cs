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
using NetMQ.Sockets;
using NetMQ;

namespace MonitorAndroid
{
    [Activity(Label = "ZarzadzanieTematamiActivity")]
    public class ZarzadzanieTematamiActivity : Activity
    {
        Button wlaczP;
        Button wylaczP;
        RadioButton ram;
        RadioButton cpu;
        RadioButton proces;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ZarzadzanieTematami);
            wlaczP = FindViewById<Button>(Resource.Id.wlacz);
            wylaczP = FindViewById<Button>(Resource.Id.wylacz);
            ram = FindViewById<RadioButton>(Resource.Id.radioRam);
            cpu = FindViewById<RadioButton>(Resource.Id.radioCpu);
            proces = FindViewById<RadioButton>(Resource.Id.radioProces);
            wlaczP.Click += WlaczP_Click;
            wylaczP.Click += WylaczP_Click;
        }

        private void WylaczP_Click(object sender, EventArgs e)
        {
            string wiadomosc = null;
            if (ram.Checked)
            {
                wiadomosc = "zużycie RAM-u";
            }
            if (cpu.Checked)
            {
                wiadomosc = "obciążenie CPU";
            }
            if (proces.Checked)
            {
                wiadomosc = "zużycie pamięci przez proces serwera";
            }
            using (RequestSocket rs = new RequestSocket(">tcp://" + AdresIp.IP + ":5555"))
            {
                rs.SendFrame("WYŁ" + wiadomosc);
                rs.ReceiveFrameString();
            }
            Toast.MakeText(Application.Context, "Wyłączono", ToastLength.Long).Show();
        }

        private void WlaczP_Click(object sender, EventArgs e)
        {
            string wiadomosc = null;
            if (ram.Checked)
            {
                wiadomosc = "zużycie RAM-u";
            }
            if (cpu.Checked)
            {
                wiadomosc = "obciążenie CPU";
            }
            if (proces.Checked)
            {
                wiadomosc = "zużycie pamięci przez proces serwera";
            }
            using (RequestSocket rs = new RequestSocket(">tcp://" + AdresIp.IP + ":5555"))
            {
                rs.SendFrame("WŁ" + wiadomosc);
                rs.ReceiveFrameString();
            }
            Toast.MakeText(Application.Context, "Włączono", ToastLength.Long).Show();
        }
    }
}