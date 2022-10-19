using Android.Graphics;
using CleanFitness.Actions;
using CleanFitness.Models;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using Xamarin.Forms;

namespace CleanFitness.ViewModels;

public class HomeViewModel : IViewModel
{
    public event PropertyChangedEventHandler PropertyChanged;

    private string _statsView;
    public string StatsView => CF.UpperHtml + _statsView + CF.LowerHtml;

    private Command _goCalories;
    public Command GoCalories => _goCalories ??= new Command(() => { CF.Nav.GoTo(NavLocation.Calories); });

    private Command _goExercises;
    public Command GoExercises => _goExercises ??= new Command(() => { CF.Nav.GoTo(NavLocation.Exercises); });

    private Command _goStats;
    public Command GoStats => _goStats ??= new Command(() => { CF.Nav.GoTo(NavLocation.Stats); });

    private Command _goRecipes;
    public Command GoRecipes => _goRecipes ??= new Command(() => { CF.Nav.GoTo(NavLocation.Recipes); });

    private Command _doExport;
    public Command DoExport => _doExport ??= new Command(() => { DB.I.ExportDB(); });

    // Test
    public ImageSource GetImage
    {
        get
        {
            return (CF.DB.Get<MExercise>(a => true).First().Image);
        }
    }
    // End Test

    public void CleanData()
    {
        _statsView = null;
    }

    public void LoadData()
    {
        var name = CF.DB.Get<MPersonalStat>(a => a.Name == "Name").First();
        var heightId = CF.DB.Get<MPersonalStat>(a => a.Name == "Height").First().Id;
        var height = CF.DB.Get<MPersonalStatRecord>(a => a.PersonalStatId == heightId).OrderBy(a => a.Id).Last();
        var weightId = CF.DB.Get<MPersonalStat>(a => a.Name == "Weight").First().Id;
        var weight = CF.DB.Get<MPersonalStatRecord>(a => a.PersonalStatId == weightId).OrderBy(a => a.Id).Last();
        var age = CF.DB.Get<MPersonalStat>(a => a.Name == "Age").First();
        var caloriesToday = CF.DB.Get<MBaseCalories_Tracking>(a => a.When >= DateTime.Today && !a.Deleted).Sum(a => a.CaloriesEaten);
        double caloriesAmount = (10 * weight.Reading) + (6.25 * height.Reading) - (5 * int.Parse(age.Value)) - 83;
        _statsView =
            $"<div class=\"row\"><div class=\"col-1\">Name</div><div class=\"col-2\">{name.Value}</div></div>" +
            $"<div class=\"row\"><div class=\"col-1\">Height</div><div class=\"col-2\">{height.Reading.ToString("0")} cm</div></div>" +
            $"<div class=\"row\"><div class=\"col-1\">Weight</div><div class=\"col-2\">{weight.Reading.ToString("0.00")} kg</div></div>" +
            $"<div class=\"row\"><div class=\"col-1\">Age</div><div class=\"col-2\">{age.Value} years old</div></div>" +
            $"<br><br>" +
            $"<div class=\"row\"><div class=\"col-1\">Calories</div><div class=\"col-2\">{caloriesToday.ToString("0")}/{caloriesAmount.ToString("0")}</div></div>";

    }

    public void RefreshNotifications()
    {
        // Does replace in the channel so don't need to clean it more
        // TODO: Make it possible to set a Hour:minute in the day for the notifications

        // Tomorrow morning = that days set exercise, or a reminder to stay active for if no exercise
        var tomorrow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
        tomorrow = tomorrow + new TimeSpan(7, 0, 0);
        CF.Notifier.Add(tomorrow, "Good morning! Don't forget to exercise, or stretch, today.", NotificationChannel.N1);
        // In 4 days - this means you can skip a day and it will remind you you need to try more exercises in 4 days
        var future = tomorrow.AddDays(3);
        CF.Notifier.Add(future, "Oh dear, you haven't been back for a few days. Please try exercise, please try exercise, or stretch, today.", NotificationChannel.N2);
    }
}
