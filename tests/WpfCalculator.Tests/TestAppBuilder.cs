using System.Threading;
using System.Windows.Threading;
using Avalonia;
using Avalonia.Headless;
using AvaloniaUI.Xpf;
using AvaloniaUI.Xpf.Helpers;
using WpfCalculator.Tests;

// Specify the Avalonia test application builder for this test assembly. It will be executed once.
[assembly: AvaloniaTestApplication(typeof(TestAppBuilder))]

// Unlike Avalonia, we want to share the same WPF Application between all tests in the assembly.
// This is needed before WPF is not designed to have multiple Application instances in the same AppDomain.
[assembly: AvaloniaTestIsolation(AvaloniaTestIsolationLevel.PerAssembly)]

// Disable parallelization of tests in this assembly, because WPF Application is shared.
[assembly: CollectionBehavior(CollectionBehavior.CollectionPerAssembly)]

namespace WpfCalculator.Tests;

public class TestAppBuilder
{
    // See https://docs.avaloniaui.net/docs/concepts/headless/headless-xunit
    // XPF specific: https://docs.avaloniaui.net/xpf/advanced/headless-testing
    public static AppBuilder BuildAvaloniaApp() => AppBuilder.Configure<DefaultXpfAvaloniaApplication>()
        .WithAvaloniaXpf()
        .UseSkia()
        .UseHeadless(new AvaloniaHeadlessPlatformOptions
        {
            // See https://docs.avaloniaui.net/docs/concepts/headless/#capturing-the-last-rendered-frame
            // We need that for frame capturing 
            UseHeadlessDrawing = false
        })
        .AfterSetup(_ =>
        {
            // Setup WPF application.
            var app = new App();
            app.InitializeComponent();

            // Force Application initialization callbacks early.
            // This is needed to ensure that Application is fully initialized before tests run.
            var frame = new DispatcherFrame();
            Dispatcher.CurrentDispatcher.InvokeAsync(() => frame.Continue = false);
            Dispatcher.PushFrame(frame);
            
            // Set WPF DispatcherSynchronizationContext as current SynchronizationContext.
            // By default, Avalonia sets AvaloniaSynchronizationContext.
            SynchronizationContext.SetSynchronizationContext(new DispatcherSynchronizationContext());
        });
}