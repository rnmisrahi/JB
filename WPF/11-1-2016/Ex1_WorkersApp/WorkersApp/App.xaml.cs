using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WorkersApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            // StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
            StartupUri = new Uri("XO.xaml", UriKind.Relative);
        }
    }
}
