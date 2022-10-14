using CleanFitness.Actions;
using Xamarin.Forms;

namespace CleanFitness;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        new DB();

        new Navigator(frmContent);
        if (!CF.DB.Connected)
        {
            CF.Nav.GoTo(NavLocation.FirstLaunch);
        }
        else
        {
            CF.Nav.GoTo(NavLocation.Home);
        }
    }
}
