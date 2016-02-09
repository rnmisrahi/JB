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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private char[,] ChardBoard = new char[3,3];
        private Button[,] Buttons = new Button[3, 3];

        private void populateButtons()
        {
            Buttons[0, 0] = btnr0c0;
            Buttons[0, 1] = btnr0c1;
            Buttons[0, 2] = btnr0c2;
            Buttons[1, 0] = btnr1c0;
            Buttons[1, 1] = btnr1c1;
            Buttons[1, 2] = btnr1c2;
            Buttons[2, 0] = btnr2c0;
            Buttons[2, 1] = btnr2c1;
            Buttons[2, 2] = btnr2c2;
        }

        public MainWindow()
        {
            InitializeComponent();
            populateButtons();
        }


        private void updateBoard()
        {
        }

        private bool isX(int r, int c)
        {
            return (cellContent(r, c).Equals("X"));
        }

        private String cellContent(int r, int c)
        {
            if ((Buttons[r, c] != null) && (Buttons[r, c].Content != null))
                return (String)Buttons[r, c].Content;
            return "";
        }

        private bool columnFilled(int c)
        {
            int count = 0;
            for (int r = 0; r < 3; r++)
            {
                if (cellContent(r, c).Equals("X"))
                    count++;
            }
            if (count == 3)
                return true;
            return false;
        }

        private bool rowFilled(int r)
        {
            int count = 0;
            for (int c = 0; c < 3; c++)
            {
                if (cellContent(r, c).Equals("X"))
                    count++;
            }
            if (count == 3)
                return true;
            return false;
        }

        private bool playerWins()
        {
            for (int c = 0; c < 3; c++)
            {
                if (columnFilled(c))
                    return true;
            }
            for (int r = 0; r < 3; r++)
            {
                if (rowFilled(r))
                    return true;
            }
            if (diagonalFilled())
                return true;
            return false;
        }

        private void pickRandom()
        {
            foreach (UIElement elem in Board.Children)
            {
                if (elem != null)
                {
                    Button b = (elem as Button);
                    if (b.Content == null)
                    {
                        b.Content = "O";
                        return;
                    }

                }
            }

        }

        private bool diagonalFilled()
        {
            if (isX(0, 0) && isX(1, 1) && isX(2, 2))
                return true;
            if (isX(0, 2) && isX(1, 1) && isX(2, 0))
                return true;
            return false;
        }

        private void btnr0c0_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (sender as Button);
            string text = btn.Content as string;
            if (text == null)
            {
                btn.Content = "X";
                string s = Board.Name;
                if (playerWins())
                    MessageBox.Show("You Win!");
                pickRandom();
            }
            else {
                if (text.Equals("X"))
                {
                    MessageBox.Show("Button already selected");
                }
                else
                {
                    if (text.Equals("O"))
                    {
                        MessageBox.Show("Button selected by oponent");
                    }
                    else
                    {
                        MessageBox.Show("Something is there that is unrecognizable");
                    }
                }
            }

        }
    }
}
