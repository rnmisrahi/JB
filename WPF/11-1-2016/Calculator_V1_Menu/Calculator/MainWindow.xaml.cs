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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Window _additionWindow;
        public Window AdditionWindow 
        {
            get
            {
                if (_additionWindow == null)
                {
                    _additionWindow = new Addition();
                    _additionWindow.Closing += _additionWindow_Closing;
                }
                return _additionWindow;
            }
        }

        private Window _subtractionWindow;
        public Window SubtractionWindow
        {
            get
            {
                if (_subtractionWindow == null)
                {
                    _subtractionWindow = new Subtraction();
                    _subtractionWindow.Closing += _subtractionWindow_Closing;
                }
                return _subtractionWindow;
            }
        }

        void _subtractionWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _subtractionWindow=null;
        }

        void _additionWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _additionWindow = null;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, RoutedEventArgs e)
        {
            AdditionWindow.Show();
            AdditionWindow.Focus();
        }

        private void btnSubtraction_Click(object sender, RoutedEventArgs e)
        {
            SubtractionWindow.Show();
            SubtractionWindow.Focus();
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
