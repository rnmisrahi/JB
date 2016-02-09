using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BindingToSingleRecordDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            // StartupUri = new Uri("ConfigurationWindow.xaml", UriKind.Relative);
            ConfigurationData data = new ConfigurationData
            {
                //Title = "Standard options",
                //ItemsInWindow = 18,
                //IsUppercase = true,
                //Color = "Red",
                //Temperature=36.66
            };

            ConfigurationWindow w = new ConfigurationWindow(data);
            w.Show();
        }
    }
}
