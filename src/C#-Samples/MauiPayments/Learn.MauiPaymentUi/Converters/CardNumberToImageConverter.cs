using System.Globalization;

namespace Learn.MauiPaymentUi.Converters
{
    public class CardNumberToImageConverter : CardValidator, IValueConverter
    {
        public ImageSource Amex { get; set; }
        public ImageSource Diners { get; set; }
        public ImageSource Discover { get; set; }
        public ImageSource JCB { get; set; }
        public ImageSource MasterCard { get; set; }
        public ImageSource Unknown { get; set; }
        public ImageSource Visa { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null)
                return Unknown;

            var number = value.ToString();
            var normalized = number.Replace("-", string.Empty);

            if (AmexRegex.IsMatch(normalized))
                return Amex;
            else if (DinersRegex.IsMatch(normalized))
                return Diners;
            else if (DiscoverRegex.IsMatch(normalized))
                return Discover;
            else if (JcbRegex.IsMatch(normalized))
                return JCB;
            else if (MasterRegex.IsMatch(normalized))
                return MasterCard;
            else if (VisaRegex.IsMatch(normalized))
                return Visa;
            else
                return Unknown;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
