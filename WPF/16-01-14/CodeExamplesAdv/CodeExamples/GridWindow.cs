using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CodeExamples
{
    class GridWindow : Window
    {
        public GridWindow()
        {
            Title = "Grid window";
            Height = 400;
            Width = 400;
            FontSize = 20;

            Grid grid = new Grid();
            this.Content = grid;

            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());

            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());

            Button btn = new Button
            {
                Content = "Click Me",
                FontSize = 15,
            };

            grid.Children.Add(btn); // Add button to grid

            btn.SetValue(Grid.RowProperty, 1); // Register button to Row and Column dependency properties
            btn.SetValue(Grid.ColumnProperty, 1);
        }

        
    }
}
