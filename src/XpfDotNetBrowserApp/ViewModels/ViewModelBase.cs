using System.ComponentModel;

namespace XpfDotNetBrowserApp.ViewModels;

/// <summary>
/// Base class of all ViewModels.
/// </summary>
public abstract class ViewModelBase : INotifyPropertyChanged
{ 
    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}