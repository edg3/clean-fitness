using CleanFitness.ViewModels;

namespace CleanFitness.Actions;

/// <summary>
/// Creates VM instances for MVVM binding
/// </summary>
public class ViewModelLocator
{
    public static ViewModelLocator I { get; private set; }
    public ViewModelLocator()
    {
        if (null != I) throw new System.Exception("Can't create more than 1 view model locator.");
        I = this;
    }

    public FirstLaunchViewModel FirstLaunchVM { get; }
        = new FirstLaunchViewModel();
    public HomeViewModel HomeVM { get; }
        = new HomeViewModel();
}