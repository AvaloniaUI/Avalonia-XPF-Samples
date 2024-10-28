using System.Threading.Tasks;
using Avalonia;
using Avalonia.Browser;
using AvaloniaUI.Xpf;
using AvaloniaUI.Xpf.Helpers;

namespace WpfCalculator.Platform;

internal class Program
{
    public static async Task Main(string[] args)
    {
        await AppBuilder.Configure<DefaultXpfAvaloniaApplication>()
            .WithAvaloniaXpf()
            .StartBrowserAppAsync("out");

        App.Start();
    }
}
