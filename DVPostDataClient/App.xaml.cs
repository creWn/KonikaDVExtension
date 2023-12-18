using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows;

namespace DVPostDataClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MessageBox.Show("Run");
            this.StartupUri = new System.Uri("MainWindow.xaml", System.UriKind.Relative);
        }

    }
}
