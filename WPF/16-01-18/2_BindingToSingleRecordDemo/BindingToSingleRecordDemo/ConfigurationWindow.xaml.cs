using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BindingToSingleRecordDemo
{
    public partial class ConfigurationWindow : Window
    {
        private ConfigurationData _data;

        public ConfigurationWindow()
        {
            InitializeComponent();
        }

        public ConfigurationWindow(ConfigurationData data)
        {
            _data = data;
            InitializeComponent();
            DataContext = _data;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_data.ToString(), "Saved options");
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            DataContext = _data;
            _data.Title = "Change configuration options";
        }
    }
}
