namespace DateCalculator.UI.Themes
{
    public partial class MyTheme : ResourceDictionary
    {
        public MyTheme()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Add("Unknown", "#2B0B98".AsColor());
            Add("AppFont", "Roboto400");
            Add("AppFontSize", 14.0);
            Add("ItemSpacing", 5.0);
            Add("Primary", "#3700B3".AsColor());
            Add("White", White);
            Add("Black", Black);
            Add("BackgroundDark", "#121212".AsColor());
            Add("BackgroundLight", White);
            Add("TextDark", White);
            Add("TextLight", Black);
            Add("LightGray", "#E5E5E1".AsColor());
            Add("MidGray", "#969696".AsColor());
            Add("DarkGray", "#505050".AsColor());
            Add(new Style(typeof(Page))
            {
                ApplyToDerivedTypes = true,
                Setters =
                {
                    new() { Property = VisualElement.BackgroundColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("BackgroundDark"), AppTheme.Light or _ => AppResource<Color>("BackgroundLight") } },
                },
            });
            Add(new Style(typeof(StackLayout))
            {
                Setters =
                {
#if FORMS
                    new() { Property = StackLayout.SpacingProperty, Value = AppResource<Thickness>("ItemSpacing") },
#elif MAUI
                    new() { Property = StackBase.SpacingProperty, Value = AppResource<Thickness>("ItemSpacing") },
#endif
                },
            });
            Add(new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("TextDark"), AppTheme.Light or _ => AppResource<Color>("TextLight") } },
                    new() { Property = Label.FontFamilyProperty, Value = AppResource<string>("AppFont") },
                    new() { Property = Label.FontSizeProperty, Value = AppResource<double>("AppFontSize") },
                },
            });
            Add("Caption", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("LightGray"), AppTheme.Light or _ => AppResource<Color>("DarkGray") } },
                },
            });
            Add("BoldText", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontAttributesProperty, Value = FontAttributes.Bold },
                },
            });
            Add("TitleText", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = Device.GetNamedSize(NamedSize.Title, typeof(Label)) },
                },
            });
            Add("PrimaryAction", new Style(typeof(Button))
            {
                Setters =
                {
                    new() { Property = VisualElement.BackgroundColorProperty, Value = AppResource<Color>("Primary") },
                    new() { Property = Button.TextColorProperty, Value = AppResource<Color>("White") },
                    new() { Property = Button.FontFamilyProperty, Value = AppResource<string>("AppFont") },
                    new() { Property = Button.FontSizeProperty, Value = AppResource<double>("AppFontSize") },
                    new() { Property = Button.PaddingProperty, Value = new Thickness(14,10) },
                },
            });
        }
    }
}
