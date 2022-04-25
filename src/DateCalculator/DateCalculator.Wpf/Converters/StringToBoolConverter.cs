using System.Globalization;
using System.Windows.Data;

namespace DateCalculator.Wpf.Converters
{
    public class StringToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter is not string param)
            {
                return false;
            }

            return param.Equals(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var param = parameter as string;
            var boolValue = value as bool?;

            if (param is null || boolValue is null || !boolValue.Value)
            {
                return string.Empty;
            }
            else
            {
                return param;
            }
        }
    }
}
