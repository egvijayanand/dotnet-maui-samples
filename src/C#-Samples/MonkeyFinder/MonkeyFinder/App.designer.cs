namespace MonkeyFinder
{
    public partial class App : Application
    {
        private void InitializeComponent()
        {
            Resources.Add("Primary", Color.FromArgb("#FFC107"));
            Resources.Add("PrimaryDark", Color.FromArgb("#FFA000"));
            Resources.Add("Accent", Color.FromArgb("#00BCD4"));
            Resources.Add("LightBackground", Color.FromArgb("#FAF9F8"));
            Resources.Add("DarkBackground", Black);
            Resources.Add("CardBackground", White);
            Resources.Add("CardBackgroundDark", Color.FromArgb("#1C1C1E"));
            Resources.Add("LabelText", Color.FromArgb("#1F1F1F"));
            Resources.Add("LabelTextDark", White);
            Resources.Add(new Style(typeof(Page))
            {
                ApplyToDerivedTypes = true,
                Setters =
                {
                    new() { Property = Page.BackgroundColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("DarkBackground"), AppTheme.Light or _ => AppResource<Color>("LightBackground") } },
                },
            });
            Resources.Add(new Style(typeof(NavigationPage))
            {
                ApplyToDerivedTypes = true,
                Setters =
                {
                    new() { Property = NavigationPage.BackgroundColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("DarkBackground"), AppTheme.Light or _ => AppResource<Color>("LightBackground") } },
                    new() { Property = NavigationPage.BarBackgroundColorProperty, Value = AppResource<Color>("Primary") },
                    new() { Property = NavigationPage.BarTextColorProperty, Value = White },
                },
            });
            Resources.Add("BaseLabel", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontFamilyProperty, Value = "OpenSansRegular" },
                    new() { Property = Label.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("LabelTextDark"), AppTheme.Light or _ => AppResource<Color>("LabelText") } },
                },
            });
            Resources.Add("MicroLabel", new Style(typeof(Label))
            {
                BasedOn = AppResource<Style>("BaseLabel"),
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 10 },
                },
            });
            Resources.Add("SmallLabel", new Style(typeof(Label))
            {
                BasedOn = AppResource<Style>("BaseLabel"),
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 12 },
                },
            });
            Resources.Add("MediumLabel", new Style(typeof(Label))
            {
                BasedOn = AppResource<Style>("BaseLabel"),
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 16 },
                },
            });
            Resources.Add("LargeLabel", new Style(typeof(Label))
            {
                BasedOn = AppResource<Style>("BaseLabel"),
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 20 },
                },
            });
            Resources.Add(new Style(typeof(RefreshView))
            {
                ApplyToDerivedTypes = true,
                Setters =
                {
                    new() { Property = RefreshView.RefreshColorProperty, Value = AppResource<Color>("Primary") },
                    new() { Property = RefreshView.BackgroundProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("DarkBackground"), AppTheme.Light or _ => AppResource<Color>("LightBackground") } },
                },
            });
            Resources.Add("ButtonOutline", new Style(typeof(Button))
            {
                Setters =
                {
                    new() { Property = Button.BackgroundProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("DarkBackground"), AppTheme.Light or _ => AppResource<Color>("LightBackground") } },
                    new() { Property = Button.TextColorProperty, Value = AppResource<Color>("Primary") },
                    new() { Property = Button.BorderColorProperty, Value = AppResource<Color>("Primary") },
                    new() { Property = Button.BorderWidthProperty, Value = 2 },
                    new() { Property = Button.HeightRequestProperty, Value = 40 },
                    new() { Property = Button.CornerRadiusProperty, Value = 20 },
                },
            });
            Resources.Add("CardView", new Style(typeof(Frame))
            {
                Setters =
                {
                    new() { Property = MauiFrame.BorderColorProperty, Value = Color.FromArgb("#DDDDDD") },
                    new() { Property = MauiFrame.HasShadowProperty, Value = true },
                    new() { Property = MauiFrame.PaddingProperty, Value = Thickness.Zero },
                    new() { Property = MauiFrame.BackgroundProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("CardBackgroundDark"), AppTheme.Light or _ => AppResource<Color>("CardBackground") } },
                    new() { Property = MauiFrame.CornerRadiusProperty, Value = 10 },
                    new() { Property = MauiFrame.IsClippedToBoundsProperty, Value = true },
                },
            });
        }
    }
}

