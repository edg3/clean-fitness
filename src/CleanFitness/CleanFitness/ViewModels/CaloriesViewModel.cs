using CleanFitness.Actions;
using CleanFitness.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace CleanFitness.ViewModels;

public class CaloriesViewModel : IViewModel
{
    public event PropertyChangedEventHandler PropertyChanged;

    private Command _goBack;
    public Command GoBack => _goBack ??= new Command(new Action(() => { CF.Nav.GoTo(NavLocation.Home); }));

    public ObservableCollection<MBaseCalories_Tracking> CaloriesTrack { get; private set; } = new ObservableCollection<MBaseCalories_Tracking>();


    private ObservableCollection<MBaseCalories> searchResults = new ObservableCollection<MBaseCalories>();
    public ObservableCollection<MBaseCalories> SearchResults
    {
        get => searchResults;
    }

    private MBaseCalories searchResultSelected = null;
    public MBaseCalories SearchResultSelected
    {
        get => searchResultSelected;
        set
        {
            searchResultSelected = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SearchResultSelected)));
        }
    }

    public void CleanData()
    {

    }

    public void LoadData()
    {
        if (CaloriesTrack.Count == 0)
        {
            CF.DB.Get<MBaseCalories_Tracking>(a => CF.IsToday(a.When) && !a.Deleted).ForEach(b => CaloriesTrack.Add(b));
        }
    }
}
