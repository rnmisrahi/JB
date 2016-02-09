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
using System.Windows.Shapes;

namespace BindingIntroduction
{
    /// <summary>
    /// Interaction logic for BindWindow2.xaml
    /// </summary>
    public partial class BindWindow2 : Window
    {
        public BindWindow2()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            WindowSource ws = new WindowSource();
            ws.Show();
            Binding bind = new Binding();
            bind.Source = ws.txtSource;
            bind.Path = new PropertyPath("Text");
            txtTarget.SetBinding(TextBox.TextProperty, bind);
        }
    }
}
