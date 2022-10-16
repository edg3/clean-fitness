using CleanFitness.Actions;
using CleanFitness.Models;
using System;
using System.ComponentModel;
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
    public Command GoCalories => _goCalories ??= new Command(new Action(() => { CF.Nav.GoTo(NavLocation.Calories); }));

    private Command _goExercises;
    public Command GoExercises => _goExercises ??= new Command(new Action(() => { CF.Nav.GoTo(NavLocation.Exercises); }));

    private Command _goStats;
    public Command GoStats => _goStats ??= new Command(new Action(() => { CF.Nav.GoTo(NavLocation.Stats); }));

    private Command _goRecipes;
    public Command GoRecipes => _goRecipes ??= new Command(new Action(() => { CF.Nav.GoTo(NavLocation.Recipes); }));

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
        var dtNow = DateTime.Now.Date;
        var caloriesToday = CF.DB.Get<MBaseCalories_Tracking>(a => a.When.Date == dtNow).Sum(a => a.CaloriesEaten);
        double caloriwsAmount = (10 * weight.Reading) + (6.25 * height.Reading) - (5 * int.Parse(age.Value)) - 83;//9.99 * weight.Reading + 6.25 * height.Reading - 4.92 * int.Parse(age.Value);
        _statsView =
            $"<div class=\"row\"><div class=\"col-1\">Name</div><div class=\"col-2\">{name.Value}</div></div>" +
            $"<div class=\"row\"><div class=\"col-1\">Height</div><div class=\"col-2\">{height.Reading.ToString("0")} cm</div></div>" +
            $"<div class=\"row\"><div class=\"col-1\">Weight</div><div class=\"col-2\">{weight.Reading.ToString("0")} kg</div></div>" +
            $"<div class=\"row\"><div class=\"col-1\">Age</div><div class=\"col-2\">{age.Value} years old</div></div>" +
            $"<br><br>" +
            $"<div class=\"row\"><div class=\"col-1\">Calories</div><div class=\"col-2\">{caloriesToday}/{caloriwsAmount.ToString()}</div></div>";

    }
}
