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

namespace BindingIntroduction
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //SecondWindow sw;

        public MainWindow()
        {
            InitializeComponent();
            //sw = new SecondWindow();
            //sw.Show();
        }

        private void btnBind_Click(object sender, RoutedEventArgs e)
        {
            //Binding binding = new Binding();
            ////binding.ElementName = "txtProject";
            //binding.Source = sw.txtProject;
            //binding.Path = new PropertyPath("Text");
            //binding.Mode = BindingMode.OneWay;
            //txtSolution.TextChanged += txtSolution_TextChanged;
            //txtSolution.SetBinding(TextBox.BackgroundProperty, binding);
        }

        private void btnUnbind_Click(object sender, RoutedEventArgs e)
        {
            BindingOperations.ClearBinding(txtSolution, TextBox.TextProperty);
        }

        private void txtSolution_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (txtSolution.IsFocused)
            //{
            //    string temp = txtSolution.Text;
            //    int index = txtSolution.CaretIndex;
            //    BindingOperations.ClearBinding(txtSolution, TextBox.TextProperty);
            //    txtSolution.TextChanged -= txtSolution_TextChanged;
            //    txtSolution.Text = temp;
            //    txtSolution.CaretIndex = index;
            //}
        }

        private void btnPage_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
            Binding binding = new Binding();
            binding.Source = w.txtSource;
            binding.Path = new PropertyPath("Text");
            binding.Mode = BindingMode.OneWay;
            //txtSolution.TextChanged += txtSolution_TextChanged;
            txtSolution.SetBinding(TextBox.TextProperty, binding);

        }
    }
}
