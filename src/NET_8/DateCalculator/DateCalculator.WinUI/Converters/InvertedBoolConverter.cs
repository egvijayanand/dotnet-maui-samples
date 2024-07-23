namespace DateCalculator.WinUI.Converters
{
    public class InvertedBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
            => !(bool)value;
        public object ConvertBack(object value, Type targetType, object parameter, string language)
            => !(bool)value;
    }
}
