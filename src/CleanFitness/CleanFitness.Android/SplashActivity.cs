﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanFitness.Droid;

[Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
public class SplashActivity : AppCompatActivity
{
    public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
    {
        base.OnCreate(savedInstanceState, persistentState);
    }

    protected override void OnResume()
    {
        try
        {
            base.OnResume();
            var intent = new Intent(this, typeof(MainActivity));
            intent.AddFlags(ActivityFlags.NoAnimation);
            if (Intent.Extras != null)
            {
                intent.PutExtras(Intent.Extras);
            }
            StartActivity(intent);
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex);
        }
    }
}