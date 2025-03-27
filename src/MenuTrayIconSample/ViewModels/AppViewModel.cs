using System.Windows.Input;
using MenuTrayIconSample.Commands;

namespace MenuTrayIconSample.ViewModels;

/// <summary>
/// Handles all the app-level commands and others.
/// </summary>
public sealed class AppViewModel : ViewModelBase
{
    private ICommand _sampleDialogCommand;
    private ICommand _clearCommand;
    private ICommand _appExitCommand;
    
    public static AppViewModel Instance { get; } = new ();
    
    public ICommand SampleDialogCommand
    {
        get => _sampleDialogCommand;
        set
        {
            _sampleDialogCommand = value;
            OnPropertyChanged(nameof(SampleDialogCommand));
        }
    }
    
    public ICommand ClearCommand
    {
        get => _clearCommand;
        set
        {
            _clearCommand = value;
            OnPropertyChanged(nameof(ClearCommand));
        }
    }
    
    public ICommand AppExitCommand
    {
        get => _appExitCommand;
        set
        {
            _appExitCommand = value;
            OnPropertyChanged(nameof(AppExitCommand));
        }
    }
    
    public ICommand DummyCommand { get; set; } = new RelayCommand(() => { });
}