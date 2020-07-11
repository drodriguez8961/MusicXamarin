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

namespace MusicXamarin.Droid
{
    [Activity(Label = "MusicXamarin", Icon = "@mipmap/icon", Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true)]
    class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            StartActivity(typeof(MainActivity));
        }
    }
}