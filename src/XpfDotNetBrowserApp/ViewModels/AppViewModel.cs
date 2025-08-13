using System.Windows.Input;

namespace XpfDotNetBrowserApp.ViewModels;

/// <summary>
/// Handles all the app-level commands and others.
/// </summary>
public sealed class AppViewModel : ViewModelBase
{ 
    private ICommand? _refreshCommand;
    private ICommand? _backCommand;
    private ICommand? _forwardCommand;

    public static AppViewModel Instance { get; } = new ();
    
    public ICommand? RefreshCommand
    {
        get => _refreshCommand;
        set
        {
            _refreshCommand = value;
            OnPropertyChanged(nameof(RefreshCommand));
        }
    }
    
    public ICommand? BackCommand
    {
        get => _backCommand;
        set
        {
            _backCommand = value;
            OnPropertyChanged(nameof(BackCommand));
        }
    }
    
    public ICommand? ForwardCommand
    {
        get => _forwardCommand;
        set
        {
            _forwardCommand = value;
            OnPropertyChanged(nameof(ForwardCommand));
        }
    }
}