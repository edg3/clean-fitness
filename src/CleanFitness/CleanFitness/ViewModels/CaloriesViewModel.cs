using CleanFitness.Actions;
using CleanFitness.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace CleanFitness.ViewModels;

public class CaloriesViewModel : IViewModel
{
    public event PropertyChangedEventHandler PropertyChanged;

    private Command _goBack;
    public Command GoBack => _goBack ??= new Command(() => { CF.Nav.GoTo(NavLocation.Home); });

    public ObservableCollection<MBaseCalories_Tracking> CaloriesTrack { get; private set; } = new ObservableCollection<MBaseCalories_Tracking>();


    private ObservableCollection<MBaseCalories> searchResults = new ObservableCollection<MBaseCalories>();
    public ObservableCollection<MBaseCalories> SearchResults
    {
        get => searchResults;
    }

    private MBaseCalories_Tracking _caloriesTrackSelected = null;
    public MBaseCalories_Tracking CaloriesTrackSelected
    {
        get => _caloriesTrackSelected;
        set
        {
            _caloriesTrackSelected = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CaloriesTrackSelected)));
        }
    }

    private MBaseCalories searchResultSelected = null;
    public MBaseCalories SearchResultSelected
    {
        get => searchResultSelected;
        set
        {
            searchResultSelected = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SearchResultSelected)));

            if (null != searchResultSelected)
            {
                CaloriesCount = (int)searchResultSelected.CaloriesPer100g;
            }
        }
    }

    private string _caloriesName = "";
    public string CaloriesName
    {
        get => _caloriesName;
        set
        {
            _caloriesName = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CaloriesName)));
        }
    }

    private int _caloriesCount = 0;
    public int CaloriesCount
    {
        get => _caloriesCount;
        set
        {
            _caloriesCount = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CaloriesCount)));
        }
    }

    private int _caloriesWeight = 0;
    public int CaloriesWeight
    {
        get => _caloriesWeight;
        set
        {
            _caloriesWeight = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CaloriesWeight)));
        }
    }

    private Command _deleteSelectedTracking;
    public Command DeleteSelectedTracking => _deleteSelectedTracking ??= new Command(() =>
    {
        if (null == CaloriesTrackSelected)
        {
            CF.Popup("Oops...","Please select the tracked value to Delete.", "Ok");
        }
        else
        {
            var selected = CaloriesTrackSelected;
            CaloriesTrackSelected = null;
            selected.Deleted = true;
            CF.DB.Update(selected);
            CF.Popup("Success","The Track you selected has been deleted. TODO: implement the 'see deleted' to bring them back, or just look at them, or such.", "Ok");
            CF.Nav.GoTo(NavLocation.Home);
        }
    });

    public string SearchTerm { get; set; } = "";
    private Command _searchForCalories;
    public Command SearchForCalories => _searchForCalories ??= new Command(() =>
    {
        SearchResultSelected = null;
        SearchResults.Clear();

        // 3 or more implies it should be a cleaner answer set
        if (SearchTerm.Length > 2)
        {
            CF.DB.Get<MBaseCalories>(a => a.Name.ToLower().Contains(SearchTerm.ToLower()))
                .ToList()
                .ForEach(b => SearchResults.Add(b));
        }
    });

    private Command _act_Speed240g;
    public Command Act_Speed240g => _act_Speed240g ??= new Command(() =>
    {
        CaloriesWeight = 240;
    });

    private Command _act_Speed25g;
    public Command Act_Speed25g => _act_Speed25g ??= new Command(() =>
    {
        CaloriesWeight = 25;
    });

    private Command _act_CokeClassicGlass;
    public Command Act_CokeClassicGlass => _act_CokeClassicGlass ??= new Command(() =>
    {
        CaloriesName = "Coke (approx. glass)";
        CaloriesWeight = 240;
        CaloriesCount = 58;
    });

    // TODO Sort these measurments out to my own averages
    private Command _act_HeartyMealSize;
    public Command Act_HeartyMealSize => _act_HeartyMealSize ??= new Command(() =>
    {
        // Extra dinner plate weight?
        CaloriesWeight = 400;
    });

    private Command _act_MainMealSize;
    public Command Act_MainMealSize => _act_MainMealSize ??= new Command(() =>
    {
        // Usual dinner plate weight?
        CaloriesWeight = 300;
    });

    private Command _act_MiniMealSize;
    public Command Act_MiniMealSize => _act_MiniMealSize ??= new Command(() =>
    {
        // Small dinner plate weight?
        CaloriesWeight = 200;
    });

    private Command _act_AvgBreakfastSize;
    public Command Act_AvgBreakfastSize => _act_AvgBreakfastSize ??= new Command(() =>
    {
        // Approx. breakfast bowl size?
        CaloriesWeight = 226;
    });

    private Command _act_AvgLunchSize;
    public Command Act_AvgLunchSize => _act_AvgLunchSize ??= new Command(() =>
    {
        // Approx. Lunch serving? This may be way off, lazy here
        CaloriesWeight = 250;
    });

    private Command _addCalories;
    public Command AddCalories => _addCalories ??= new Command(() =>
    {
        if (CaloriesName.Length < 4 || CaloriesCount < 0 || CaloriesWeight < 1)
        {
            CF.Popup("Oh dear...", "Please supply a value for the Name, the Calories per 100g, and the Weight in grams. It's okay if you have 0 for Calories if it has none, but this is to track everything.", "Alright");
        }
        else
        {
            // TODO: Work out what will happen with portions of things which aren't quite usable at this state
            //       e.g. 345g steaks + approx. 200g salad ingredients, makes 4 servings => 2 servings used dinner time, 2 for lunch packs for tomorrow, calories total made, calories in left overs made => approx. calories, not 100% accurate, but serves the purpose
            var newCals = new MBaseCalories_Tracking
            {
                When = DateTime.Now,
                CaloriesEaten = (CaloriesCount / 100.0) * CaloriesWeight,
                Information = CaloriesName
                // TODO: think about it, having the added stats things will likely only be cool on the recipes when creating/editing them, calories count we just want to watch our calories, I believe
            };
            CF.DB.Insert(newCals);
            CF.Nav.GoTo(NavLocation.Home);
        }
    });

    public string CaloriesSoFar
    {
        get
        {
            var heightId = CF.DB.Get<MPersonalStat>(a => a.Name == "Height").First().Id;
            var height = CF.DB.Get<MPersonalStatRecord>(a => a.PersonalStatId == heightId).OrderBy(a => a.Id).Last();
            var weightId = CF.DB.Get<MPersonalStat>(a => a.Name == "Weight").First().Id;
            var weight = CF.DB.Get<MPersonalStatRecord>(a => a.PersonalStatId == weightId).OrderBy(a => a.Id).Last();
            var age = CF.DB.Get<MPersonalStat>(a => a.Name == "Age").First();

            var dtNow = DateTime.Now.Date;
            var caloriesToday = CF.DB.Get<MBaseCalories_Tracking>(a => a.When >= DateTime.Today && !a.Deleted).Sum(a => a.CaloriesEaten);
            double caloriesAmount = (10 * weight.Reading) + (6.25 * height.Reading) - (5 * int.Parse(age.Value)) - 83;

            return $"{caloriesToday.ToString("0")} / {caloriesAmount.ToString("0")} - You've got {(caloriesAmount - caloriesToday).ToString("0")} left";
        }
    }

    public void CleanData()
    {

    }

    public void LoadData()
    {
        CaloriesTrack.Clear();
        CF.DB.Get<MBaseCalories_Tracking>(a => (a.When >= DateTime.Today) && !a.Deleted).ForEach(b => CaloriesTrack.Add(b));
    }
}
