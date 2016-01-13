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
    /// Interaction logic for Addition.xaml
    /// </summary>
    public partial class Addition : Window
    {
        public Addition()
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
                    int total = 0 ;
                    switch(cmbOperator.Text) 
                    {
                        case "+":
                            total = (int)(first + second);
                            break;
                        case "-":
                            total = (int)(first - second);
                            break;
                        case "*":
                            total = (int)(first * second);
                            break;
                        case "/":
                            total = (int)(first / second);
                            break;
                    }
                    txtTotal.Text = total.ToString();
                }
            }
        }

        private void OnOperandTextChanged(object sender, TextChangedEventArgs e)
        {
            txtTotal.Text = string.Empty;
        }

        private void btnAddition_Click(object sender, RoutedEventArgs e)
        {
            cmbOperator.Text = "+";
        }

        private void btnSubtraction_Click(object sender, RoutedEventArgs e)
        {
            cmbOperator.Text = "-";
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
