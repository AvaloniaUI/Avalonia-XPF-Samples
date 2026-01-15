using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.OpenGL;
using Avalonia.OpenGL.Controls;
using Avalonia.Rendering.Composition;
using OpenGLSample.OpenGL;

// ReSharper disable StringLiteralTypo

namespace OpenGLSample
{
    public partial class OpenGlPage : UserControl
    {
        public OpenGlPage()
        {
            InitializeComponent();
            GL.Init(Knobs);

            AttachedToVisualTree += delegate
            {
                if (TopLevel.GetTopLevel(this) is Window)
                    Snapshot.IsVisible = true;
            };
        }

        private async void SnapshotClick(object sender, RoutedEventArgs e)
        {
            var v = ElementComposition.GetElementVisual(this)!;
            var snap = await v.Compositor.CreateCompositionVisualSnapshot(v, 1.5);
            await new Window()
            {
                Content = new ScrollViewer()
                {
                    HorizontalScrollBarVisibility = ScrollBarVisibility.Auto,
                    VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                    Content = new Image()
                    {
                        Source = snap
                    }
                }
            }.ShowDialog((Window)TopLevel.GetTopLevel(this)!);
        }
    }

   
}
