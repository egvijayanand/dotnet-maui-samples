namespace Learn.MauiPaymentUi
{
    public partial class App : Application
    {
        private void InitializeComponent()
        {
            Resources.MergedDictionaries.Add(new AppColors());
            Resources.MergedDictionaries.Add(new Styles());
            Resources.Add("CardConverter", new CardNumberToImageConverter()
            {
                Amex = "card_amex.png",
                Diners = "card_dinersclub.png",
                Discover = "card_discover.png",
                JCB = "card_jcb.png",
                MasterCard = "card_mastercard.png",
                Visa = "card_visa.png",
                Unknown = "card_unknown.png",
            });
            Resources.Add("CardLightConverter", new CardNumberToImageConverter()
            {
                Amex = "logo_amex.png",
                Diners = "logo_dinersclub.png",
                Discover = "logo_discover.png",
                JCB = "card_jcb.png",
                MasterCard = "logo_mastercard.png",
                Visa = "logo_visa.png",
                Unknown = "icon_cvv.png",
            });
            Resources.Add("CardColorConverter", new CardNumberToColorConverter()
            {
                Amex = Color.FromArgb("#3177CB"),
                Diners = Color.FromArgb("#1B4F8F"),
                Discover = Color.FromArgb("#E9752F"),
                JCB = Color.FromArgb("#9E2921"),
                MasterCard = Color.FromArgb("#394854"),
                Visa = Color.FromArgb("#2867BA"),
                Unknown = Color.FromArgb("#75849D"),
            });
            Resources.Add("Primary", Color.FromArgb("#E5E9EE"));
            Resources.Add("PrimaryDark", Color.FromArgb("#75849D"));
            Resources.Add("Secondary", Color.FromArgb("#B5BBC2"));
            Resources.Add("Accent", LightGray);
            Resources.Add("LightColor", LightGray);
        }
    }
}

