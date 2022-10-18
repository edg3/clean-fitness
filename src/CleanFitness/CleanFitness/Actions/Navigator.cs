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
            /* MAIN */
            case NavLocation.FirstLaunch:
                CF.VML.FirstLaunchVM.LoadData();
                content = new FirstLaunchView();
                break;
            case NavLocation.Home:
                CF.VML.HomeVM.RefreshNotifications();
                CF.VML.HomeVM.LoadData();
                content = new HomeView();
                break;

            /* CALORIES */
            case NavLocation.Calories:
                CF.VML.CaloriesVM.LoadData();
                content = new CaloriesView();
                break;

            /* EXERCISES */
            case NavLocation.Exercises:
                CF.VML.ExerciseVM.LoadData();
                content = new ExerciseView();
                break;
        }

        if (null != content)
        {
            switch (_lastLocation)
            {
                /* MAIN */
                case NavLocation.FirstLaunch:
                    CF.VML.FirstLaunchVM.CleanData();
                    break;
                case NavLocation.Home:
                    CF.VML.HomeVM.CleanData();
                    break;

                /* CALORIES */
                case NavLocation.Calories:
                    CF.VML.CaloriesVM.CleanData();
                    break;

                /* EXERCISES */
                case NavLocation.Exercises:
                    CF.VML.ExerciseVM.CleanData();
                    break;
            }
            _lastLocation = location;

            _Frame.Content = content.Content;
        }
    }
}
