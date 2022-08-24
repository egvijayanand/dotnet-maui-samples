using System.Collections;
using System.Globalization;

namespace ClassFlyXaml.Converters;

public class IndexToObjectConverter : IValueConverter
{
    public object EvenObject { get; set; }
    public object OddObject { get; set; }

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

        return index % 2 == 0 ? EvenObject : OddObject;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
