using System.ComponentModel;

namespace CleanFitness.Actions;

/// <summary>
/// Specifies loading methods for the MVVM architecture
/// </summary>
public interface IViewModel : INotifyPropertyChanged
{
    void LoadData();
    void CleanData();
}
