using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FirstWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
            StartupUri = new Uri("SecondWindow.xaml", UriKind.Relative);
            StartupUri = new Uri("StackPanelWindow.xaml", UriKind.Relative);
            StartupUri = new Uri("CanvasWindow.xaml", UriKind.Relative);

        }
    }
}
