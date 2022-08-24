namespace MauiBMICalculator.Converters;

public class BMIOpacityConverter : IValueConverter
{
    public float FromValue { get; set; }
    public float ToValue { get; set; }

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var _value = System.Convert.ToSingle(value, new NumberFormatInfo() { NumberDecimalDigits = 1 });

        if (_value >= FromValue && _value <= ToValue)
            return 1.0f;

        return 0.4f;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
        throw new NotImplementedException();
}

