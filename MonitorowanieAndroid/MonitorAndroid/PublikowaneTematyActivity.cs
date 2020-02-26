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
    [Activity(Label = "PublikowaneTematyActivity")]
    public class PublikowaneTematyActivity : Activity
    {
        ListView lv;
        List<string> lista = new List<string>();
        ArrayAdapter aa;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PublikowaneTematy);
            lv = FindViewById<ListView>(Resource.Id.listaTematow);
            pobierzObecniePublikowaneTematy();
            aa = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, lista);
            lv.Adapter = aa;
            
        }

        private void pobierzObecniePublikowaneTematy()
        {
            using (RequestSocket rs = new RequestSocket(">tcp://" + AdresIp.IP + ":5555"))
            {
                rs.SendFrame("TEMATY");
                string odp = rs.ReceiveFrameString();
                string[] pom = odp.Split('/');
                foreach (string item in pom)
                {
                    if (item != string.Empty)
                        lista.Add(item);
                }
            }
        }
    }
}