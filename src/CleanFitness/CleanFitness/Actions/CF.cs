using Android.Graphics;
using Android.Util;
using System;

namespace CleanFitness.Actions;

/// <summary>
/// Short hand way to get access to anything globally
/// </summary>
public static class CF
{
    public static DB DB => DB.I;
    public static ViewModelLocator VML => ViewModelLocator.I;
    public static Navigator Nav => Navigator.I;
    public static INotify Notifier { get; set; }

    // Html helpers
    public static string UpperHtml =>
        "<html><head><style>" +
        "body{background-color:#efefef;color:#090909}" +
        ".row{width:99%;padding:4px;}" +
        ".col-1{padding:2px;display:inline-block;width:32%;text-align:end;color:#00A5FF;}" +
        ".col-2{padding:2px;display:inline-block;width:64%}" +
        "</style></head><body>";
    public static string LowerHtml =>
        "</body></html>";

    // Date helper
    public static bool IsToday(DateTime when)
    {
        return (when.Year == DateTime.Now.Year && when.Month == DateTime.Now.Month && when.Day == DateTime.Now.Day);
    }

    // Popups
    public async static void Popup(string title, string message, string cancel)
    {
        await MainPage.I.DisplayAlert(title, message, cancel);
    }

    // Source: https://stackoverflow.com/questions/38875613/how-to-store-image-to-sqlite-in-xamarin-android
    public static string Base64Encode(string plainText)
    {
        var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
        return System.Convert.ToBase64String(plainTextBytes);
    }
    public static Bitmap Base64Decode(string base64EncodedData)
    {
        //byte[] imageAsBytes = System.Text.Encoding.UTF8.GetBytes(Base64.Decode(base64EncodedData, Base64Flags.Default).ToString().ToCharArray());
        //return BitmapFactory.DecodeByteArray(imageAsBytes, 0, imageAsBytes.Length);
        //var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
        //return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
        return BitmapFactory.DecodeByteArray(base64EncodedBytes, 0, base64EncodedBytes.Length);
    }
}
