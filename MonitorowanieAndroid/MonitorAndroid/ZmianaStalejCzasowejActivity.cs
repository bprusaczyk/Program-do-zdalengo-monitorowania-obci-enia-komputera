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
    [Activity(Label = "ZmianaStalejCzasowejActivity")]
    public class ZmianaStalejCzasowejActivity : Activity
    {
        TextView stalaTekst;
        EditText edycjaStalejCzasowej;
        Button zmienPrzycisk;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.zmianaStalejCzasowej);
            stalaTekst = FindViewById<TextView>(Resource.Id.stalaCzasowa);
            edycjaStalejCzasowej = FindViewById<EditText>(Resource.Id.edycjaSTALEJcZASOWEJ);
            zmienPrzycisk = FindViewById<Button>(Resource.Id.zmienPrzycisk);
            zmienPrzycisk.Click += ZmienPrzycisk_Click;
            pobierzStalaCzasowa();
        }

        private void ZmienPrzycisk_Click(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(edycjaStalejCzasowej.Text, out a))
            {
                Toast.MakeText(Application.Context, "Wpisz liczbę", ToastLength.Long).Show();
                return;
            }
            using (RequestSocket rs = new RequestSocket(">tcp://" + AdresIp.IP + ":5555"))
            {
                rs.SendFrame("CZAS=" + edycjaStalejCzasowej.Text);
                rs.ReceiveFrameString();
                Toast.MakeText(Application.Context, "Zmieniono", ToastLength.Long).Show();
                stalaTekst.Text = edycjaStalejCzasowej.Text + " ms";
            }
        }

        private void pobierzStalaCzasowa()
        {
            using (RequestSocket rs = new RequestSocket(">tcp://" + AdresIp.IP + ":5555"))
            {
                rs.SendFrame("CZAS");
                stalaTekst.Text = rs.ReceiveFrameString()+" ms";
            }
        }
    }
}