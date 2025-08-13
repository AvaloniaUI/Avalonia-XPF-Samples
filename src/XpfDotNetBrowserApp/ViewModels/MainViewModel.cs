using System.Windows.Input;
using DotNetBrowser.Browser;
using DotNetBrowser.Engine;
using DotNetBrowser.Navigation.Events;
using XpfDotNetBrowserApp.Commands;

namespace XpfDotNetBrowserApp.ViewModels;

public class MainViewModel : ViewModelBase
{
    private readonly IEngine _engine;

    private ICommand? _navigateUrlCommand;
    private ICommand? _refreshCommand;
    private ICommand? _backCommand;
    private ICommand? _forwardCommand;

    public ICommand? NavigateUrlCommand
    {
        get => _navigateUrlCommand;
        set
        {
            _navigateUrlCommand = value;
            OnPropertyChanged(nameof(NavigateUrlCommand));
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

    public IBrowser Browser { get; }

    public string? Url
    {
        get => Browser.Url;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                Browser.Navigation.LoadUrl(value).Wait();
            }

            OnPropertyChanged(nameof(Url));
        }
    }

    public MainViewModel()
    {
        var builder = new EngineOptions.Builder
        {
            // You can use the RenderingMode.Offscreen to allow XPF/Avalonia to draw over
            // the embedded browser's content by transferring the browser's texture to Avalonia's.
            // On the otherhand, you can use RenderingMode.HardwareAccelerated to embed an
            // actual Chromium window. This might not work/be buggy on some platforms so we're setting
            // it on Offscreen Mode for now.
            RenderingMode = RenderingMode.OffScreen
        };

        var engineOptions = builder
            .Build();

        _engine = EngineFactory.Create(engineOptions);
        Browser = _engine.CreateBrowser();

        NavigateUrlCommand = new RelayCommand<string>(NavigateUrl);
        AppViewModel.Instance.RefreshCommand = RefreshCommand = new RelayCommand(() => Browser.Navigation.Reload());

        AppViewModel.Instance.BackCommand =
            BackCommand = new RelayCommand(() => Browser.Navigation.GoBack());

        AppViewModel.Instance.ForwardCommand =
            ForwardCommand = new RelayCommand(() => Browser.Navigation.GoForward());

        Browser.Navigation.FrameLoadFinished += NavigationOnFrameLoadFinished;
        Url = "en.wikipedia.org";
        Browser.Navigation.RemoveEntryAt(0); // just to remove the initial about:blank page.
    }

    private void NavigateUrl(string obj)
    {
        if (!string.IsNullOrWhiteSpace(obj))
            Url = obj.Trim();
    }

    public void DisposeBrowser()
    {
        Browser.Dispose();
        _engine.Dispose();
    }

    private void NavigationOnFrameLoadFinished(object? sender, FrameLoadFinishedEventArgs e)
    {
        if (e.Frame.IsMain)
        {
            //Navigation is finished, notify that the URL is possibly updated.
            OnPropertyChanged(nameof(Url));
        }
    }
}