using CleanFitness.Views;
using Xamarin.Forms;

namespace CleanFitness.Actions;

public enum NavLocation
{
    FirstLaunch,
    Home,

    Calories,

    Exercises,

    Stats,

    Recipes,
}

public class Navigator
{
    public static Navigator I { get; private set;}

    /// <summary>
    /// Location where Views get inserted
    /// </summary>
    private Frame _Frame;
    private NavLocation _lastLocation;

    public Navigator(Frame frame)
    {
        if (null != I) throw new System.Exception("Can't create multiple navigators.");
        I = this;

        _Frame = frame;
    }

    public void GoTo(NavLocation location)
    {
        ContentView content = null;

        switch (location)
        {
            case NavLocation.FirstLaunch:
                CF.VML.FirstLaunchVM.LoadData();
                content = new FirstLaunchView();
                break;
            case NavLocation.Home:
                CF.VML.HomeVM.LoadData();
                content = new HomeView();
                break;
            case NavLocation.Calories:
                CF.VML.CaloriesVM.LoadData();
                content = new CaloriesView();
                break;
        }

        if (null != content)
        {
            switch (_lastLocation)
            {
                case NavLocation.FirstLaunch:
                    CF.VML.FirstLaunchVM.CleanData();
                    break;
                case NavLocation.Home:
                    CF.VML.HomeVM.CleanData();
                    break;
                case NavLocation.Calories:
                    CF.VML.CaloriesVM.CleanData();
                    break;
            }
            _lastLocation = location;

            _Frame.Content = content.Content;
        }
    }
}
