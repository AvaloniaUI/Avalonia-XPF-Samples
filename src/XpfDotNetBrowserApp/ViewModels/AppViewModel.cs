using System.Windows.Input;

namespace XpfDotNetBrowserApp.ViewModels;

/// <summary>
/// Handles all the app-level commands and others.
/// </summary>
public sealed class AppViewModel : ViewModelBase
{
    private ICommand? _sampleDialogCommand;
    private ICommand? _refreshCommand;
    private ICommand? _appExitCommand;
    private ICommand? _backCommand;
    private ICommand? _forwardCommand;

    public static AppViewModel Instance { get; } = new ();
    
    public ICommand? SampleDialogCommand
    {
        get => _sampleDialogCommand;
        set
        {
            _sampleDialogCommand = value;
            OnPropertyChanged(nameof(SampleDialogCommand));
        }
    }
    
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
    
    public ICommand? AppExitCommand
    {
        get => _appExitCommand;
        set
        {
            _appExitCommand = value;
            OnPropertyChanged(nameof(AppExitCommand));
        }
    }
}