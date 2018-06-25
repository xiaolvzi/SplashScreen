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

namespace App70.Droid
{
    [Activity(Label = "SplashActivity", Theme = "@style/MainTheme", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.splash_layout);
            // Create your application here
        }

        protected override void OnResume()
        {
            base.OnResume();
            Toast.MakeText(this, "1111", ToastLength.Short).Show();
            Handler handler = new Handler();
            handler.PostDelayed(() => {
                StartActivity(typeof(MainActivity));
                OverridePendingTransition(0, 0);
            }, 3000);
            
        }
    }
}