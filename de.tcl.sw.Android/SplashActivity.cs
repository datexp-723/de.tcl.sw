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
using Android.Support.V7.App;
using System.Threading.Tasks;

namespace de.tcl.sw.Droid
{
    [Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {

        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            //Logger.LogDebug("SplashActivity.OnCreate");

            base.OnCreate(savedInstanceState, persistentState);
        }

        protected override void OnResume()
        {
            //Logger.LogDebug("SplashActivity.OnResume");

            base.OnResume();

            Task.Factory.StartNew(() =>
            {
                //Logger.LogDebug("SplashActivity.StartTaskMainActivity");
                StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            });
        }
    }
}