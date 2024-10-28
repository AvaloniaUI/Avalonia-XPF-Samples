// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Windows;

namespace WpfCalculator
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static int Start()
        {
            var app = new App();
            app.InitializeComponent();

            // Note, this method returns early on Mobile and Browser.
            return app.Run();
        }
    }
}