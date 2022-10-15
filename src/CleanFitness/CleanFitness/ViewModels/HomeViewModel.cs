using CleanFitness.Actions;
using CleanFitness.Models;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;

namespace CleanFitness.ViewModels;

public class HomeViewModel : IViewModel
{
    public event PropertyChangedEventHandler PropertyChanged;

    private string _statsView;
    public string StatsView => CF.UpperHtml + _statsView + CF.LowerHtml;

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
        _statsView = 
            $"<div class=\"row\"><div class=\"col-1\">Name</div><div class=\"col-2\">{name.Value}</div></div>" +
            $"<div class=\"row\"><div class=\"col-1\">Height</div><div class=\"col-2\">{height.Reading.ToString("0")} cm</div></div>" +
            $"<div class=\"row\"><div class=\"col-1\">Weight</div><div class=\"col-2\">{weight.Reading.ToString("0")} kg</div></div>" +
            $"<div class=\"row\"><div class=\"col-1\">Age</div><div class=\"col-2\">{age.Value} years old</div></div>";
    }
}
