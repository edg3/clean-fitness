namespace CleanFitness.Actions;

/// <summary>
/// Short hand way to get access to anything globally
/// </summary>
public static class CF
{
    public static DB DB => DB.I;
    public static ViewModelLocator VML => ViewModelLocator.I;
    public static Navigator Nav => Navigator.I;
}
