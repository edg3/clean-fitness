using CleanFitness.Views;
using Xamarin.Forms;

namespace CleanFitness.Actions;

public enum NavLocation
{
    FirstLaunch,
    Home
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
                content = new FirstLaunchView();
                CF.VML.FirstLaunchVM.LoadData();
                break;
            case NavLocation.Home:
                content = new HomeView();
                CF.VML.HomeVM.LoadData();
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
            }
            _lastLocation = location;

            _Frame.Content = content.Content;
        }
    }
}
