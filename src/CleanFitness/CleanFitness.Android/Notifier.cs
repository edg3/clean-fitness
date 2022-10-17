using Android.Widget;
using CleanFitness.Actions;
using Plugin.LocalNotification;
using System;

namespace CleanFitness.Droid;

public class Notifier : INotify
{
    // Needs: Android 12+
    public async override void Add(DateTime when, string msg, NotificationChannel chan)
    {
        var notification = new NotificationRequest
        {
            NotificationId = (int)chan,
            Title = "Clean Fitness",
            Description = msg,
            //ReturningData = msg,
            Schedule =
            {
                NotifyTime = when
            }
        };
        await LocalNotificationCenter.Current.Show(notification);
    }
}