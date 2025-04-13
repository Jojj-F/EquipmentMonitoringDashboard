using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace EquipmentMonitoringDashboard.Converters
{
    public class TemperatureToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double temp)
            {
                if (temp >= 70) return Brushes.DarkRed;
                if (temp >= 40) return Brushes.OrangeRed;
                if (temp >= 20) return Brushes.Goldenrod;
            }
            return Brushes.White;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
