namespace DateCalculator.Wpf.Converters
{
    public class DateTimeOffsetConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ArgumentNullException.ThrowIfNull(nameof(value));
            return value is DateTimeOffset dto ? dto.DateTime : (object)DateTime.MinValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ArgumentNullException.ThrowIfNull(nameof(value));

            if (value is DateTime dt)
            {
                var offset = dt.Kind switch
                {
                    DateTimeKind.Local => DateTimeOffset.Now.Offset,
                    DateTimeKind.Utc => DateTimeOffset.UtcNow.Offset,
                    _ => TimeSpan.Zero
                };

                return culture is null
                    ? dt.Kind == DateTimeKind.Local ? new DateTimeOffset(dt) : new DateTimeOffset(dt, offset)
                    : new DateTimeOffset(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, dt.Millisecond, dt.Microsecond, culture.Calendar, offset);
            }

            throw new InvalidOperationException(nameof(value));
        }
    }
}
