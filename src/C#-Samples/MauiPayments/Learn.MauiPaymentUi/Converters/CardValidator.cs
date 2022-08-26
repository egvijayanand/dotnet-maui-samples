using System.Text.RegularExpressions;

namespace Learn.MauiPaymentUi.Converters
{
    public class CardValidator
    {
        public static readonly Regex AmexRegex = new(@"^3[47][0-9]{5,}$");
        public static readonly Regex DinersRegex = new(@"^3(?:0[0-5]|[68][0-9])[0-9]{4,}$");
        public static readonly Regex DiscoverRegex = new(@"^6(?:011|5[0-9]{2})[0-9]{3,}$");
        public static readonly Regex JcbRegex = new(@"^(?:2131|1800|35[0-9]{3})[0-9]{3,}$");
        public static readonly Regex MasterRegex = new(@"^5[1-5][0-9]{5,}|222[1-9][0-9]{3,}|22[3-9][0-9]{4,}|2[3-6][0-9]{5,}|27[01][0-9]{4,}|2720[0-9]{3,}$");
        public static readonly Regex VisaRegex = new(@"^4[0-9]{6,}$");
    }
}
