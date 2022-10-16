using CleanFitness.Actions;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace CleanFitness.ViewModels;

public class CaloriesViewModel : IViewModel
{
    public event PropertyChangedEventHandler PropertyChanged;

    private Command _goBack;
    public Command GoBack => _goBack ??= new Command(new Action(() => { CF.Nav.GoTo(NavLocation.Home); }));

    public void CleanData()
    {

    }

    public void LoadData()
    {

    }
}
