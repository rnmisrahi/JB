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
        SecondWindow second;
        public MainWindow()
        {
            InitializeComponent();
            second = new SecondWindow();
            second.Show();
        }

        private void btnBind_Click(object sender, RoutedEventArgs e)
        {
            Binding binding = new Binding("Text");
            // binding.ElementName = "txtProject";
            binding.Source = second.txtProject;      // Should be a public property
            // binding.Path = new PropertyPath("Text");
            binding.Mode = BindingMode.OneWay;
            txtSolution.TextChanged += txtSolution_TextChanged;
            txtSolution.SetBinding(TextBox.TextProperty, binding);
        }

        private void btnUnbind_Click(object sender, RoutedEventArgs e)
        {
            BindingOperations.ClearBinding(txtSolution, TextBox.TextProperty);
        }

        private void txtSolution_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtSolution.IsFocused)
            {
                string temp = txtSolution.Text;
                int index = txtSolution.CaretIndex;
                BindingOperations.ClearBinding(txtSolution, TextBox.TextProperty);
                txtSolution.TextChanged -= txtSolution_TextChanged;
                txtSolution.Text = temp;
                txtSolution.CaretIndex = index;
            }
        }
    }
}
