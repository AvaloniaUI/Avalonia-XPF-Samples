using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using Avalonia.Headless;
using Avalonia.Headless.XUnit;
using Avalonia.Rendering.Composition;
using AvaloniaUI.Xpf.WpfAbstractions;
using AvDispatcher = Avalonia.Threading.Dispatcher;

namespace WpfCalculator.Tests;

public class OperationTests : IDisposable
{
    [AvaloniaFact]
    public void Should_Raise_Click_Events()
    {
        // We use Application.MainWindow, because Application.StartupUri was set.
        // If not set, we would need to create and show the MainWindow manually here.
        // Note, as it is now, MainWindow is shared between tests, so tests must reset its state if needed.
        // See Dispose() method below.

        var mainWindow = (MainWindow)Application.Current.MainWindow!;
        mainWindow.button2.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
        mainWindow.button1.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));

        mainWindow.buttonMultiply.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));

        mainWindow.button2.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));

        mainWindow.buttonEqual.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));

        Assert.Equal("42", mainWindow.labelResult.Content);
    }

    [AvaloniaFact]
    public void Should_Use_Avalonia_Headless_Extensions()
    {
        var wpfWindow = (MainWindow)Application.Current.MainWindow!;
        var avWindow = XpfWpfAbstraction.GetAvaloniaWindowForWindow(wpfWindow);
        Assert.NotNull(avWindow);

        // It's still possible to raise fake TextInput WPF events directly,
        // But sometimes it's just easier to use helper methods.
        avWindow.KeyTextInput("2");
        avWindow.KeyTextInput("1");

        avWindow.KeyTextInput("*");

        avWindow.KeyTextInput("2");

        avWindow.KeyTextInput("=");

        Assert.Equal("42", wpfWindow.labelResult.Content);
    }

    [AvaloniaFact]
    public void Should_Capture_Latest_Frame()
    {
        var wpfWindow = (MainWindow)Application.Current.MainWindow!;
        var avWindow = XpfWpfAbstraction.GetAvaloniaWindowForWindow(wpfWindow);
        Assert.NotNull(avWindow);

        using var frame = avWindow.CaptureRenderedFrame();
        Assert.NotNull(frame);

        // After frame captured, it can be saved to the file or compared in-memory with expected frame.
        // In this test we just want to know that frame is not empty.

        using var memoryStream = new MemoryStream();
        frame.Save(memoryStream);

        Assert.True(memoryStream.Length > 0);
    }

    public void Dispose()
    {
        // Reset calculator state between tests.
        // Alternatively, we could create a new MainWindow instance for each test, and remove StartupUri from App.xaml.
        var wpfWindow = (MainWindow)Application.Current.MainWindow!;
        wpfWindow.buttonAllClear.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
    }
}