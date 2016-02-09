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
    /// Interaction logic for ResearchWindow.xaml
    /// </summary>
    public partial class ResearchWindow : Window
    {
        public ResearchWindow()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            chkCheck.Content = "New checkbox text";
        }
    }
}
