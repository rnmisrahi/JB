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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for Subtraction.xaml
    /// </summary>
    public partial class Subtraction : Window
    {
        public Subtraction()
        {
            InitializeComponent();
        }
        
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int? first = txtFirst.Text.ParseInt();
            if (first == null)
            {
                MessageBox.Show("First operand is not a number");
            }
            else
            {
                int? second = txtSecond.Text.ParseInt();
                if (second == null)
                {
                    MessageBox.Show("Second operand is not a number");
                }
                else
                {
                    int total = (int)(first - second);
                    txtTotal.Text = total.ToString();
                }
            }
        }

        private void OnOperandTextChanged(object sender, TextChangedEventArgs e)
        {
            txtTotal.Text = string.Empty;
        }
    }
}
