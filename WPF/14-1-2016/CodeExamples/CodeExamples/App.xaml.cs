using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CodeExamples
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        TextBox txtName = null;
        public App()
        {
            Window basics = new Window
            {
                Title="Code Basics",
                Height=400,
                Width=400,
                FontSize=20,
            };

            StackPanel sp = new StackPanel();
            basics.Content = sp;

            TextBlock title = new TextBlock
            {
                Text = "Code Basics",
                FontSize=24,
                TextAlignment=TextAlignment.Center,
            };
            sp.Children.Add(title);

            txtName = new TextBox();
            sp.Children.Add(txtName);
            txtName.Margin = new Thickness(10);

            Button btnSend = new Button
            {
                Content = "Send",
            };
            sp.Children.Add(btnSend);
            btnSend.Margin = new Thickness(10);
            btnSend.Click += BtnSend_Click;

            basics.Show();
        }

        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello " + txtName.Text + "!!!");
        }
    }
}
