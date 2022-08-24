using System.Collections;
using System.Globalization;

namespace ClassFlyXaml.Converters;

public class IndexToColorConverter : IValueConverter
{
    public Color EvenColor { get; set; }
    public Color OddColor { get; set; }

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        int index;
        var itemSource = ((CollectionView)parameter).ItemsSource;
        if (itemSource is IList list)
        {
            index = list.IndexOf(value);
        }
        else
        {
            index = ((IEnumerable<Object>)itemSource).ToList().IndexOf(value);
        }
        return index % 2 == 0 ? EvenColor : OddColor;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
