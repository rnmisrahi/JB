using MembersApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MembersApp.Converters
{
    public class CityConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int cityID = (int)value;
            return CitiesRepository.GetName(cityID);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string cityName = (string)value;
            return CitiesRepository.GetId(cityName);
        }
    }
}
