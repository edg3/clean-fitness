using CleanFitness.Actions;
using Xamarin.Forms;

namespace CleanFitness;

public partial class App : Application
{
    public App(INotify notifier)
    {
        InitializeComponent();

        CF.Notifier = notifier;

        MainPage = new MainPage();
    }

    protected override void OnStart()
    {
    }

    protected override void OnSleep()
    {
    }

    protected override void OnResume()
    {
    }
}
