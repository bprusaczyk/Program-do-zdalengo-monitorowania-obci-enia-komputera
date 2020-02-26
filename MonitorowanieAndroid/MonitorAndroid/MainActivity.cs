using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace MonitorAndroid
{
    [Activity(Label = "MonitorAndroid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        CheckBox ram;
        CheckBox cpu;
        CheckBox proces;
        Button subskrybuj;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            ram = FindViewById<CheckBox>(Resource.Id.startRam);
            cpu = FindViewById<CheckBox>(Resource.Id.startCpu);
            proces = FindViewById<CheckBox>(Resource.Id.startProces);
            subskrybuj = FindViewById<Button>(Resource.Id.subskrybuj);
            subskrybuj.Click += Subskrybuj_Click;
        }

        private void Subskrybuj_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(MonitorActivity));
            i.PutExtra("ram", ram.Checked);
            i.PutExtra("cpu", cpu.Checked);
            i.PutExtra("proces", proces.Checked);
            StartActivity(i);
        }
    }
}

