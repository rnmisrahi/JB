using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BindingToSingleRecordDemo
{
    public class TemperatureConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double c = (double)value;
            double f = c * 9 / 5 + 32;
            return f;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double f = double.Parse((string)value);
            double c = (f - 32) * 5 / 9;
            return c;
        }
    }
}
