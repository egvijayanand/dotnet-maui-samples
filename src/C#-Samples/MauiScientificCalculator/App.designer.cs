namespace MauiScientificCalculator
{
    public partial class App : Application
    {
        private void InitializeComponent()
        {
            Resources.Add("PrimaryColor", Color.FromArgb("#EFBB31"));
            Resources.Add("SecondaryColor", White);
            Resources.Add("PageBackgroundColor", Color.FromArgb("#16191E"));
            Resources.Add("BorderColor", Color.FromArgb("#33777777"));
            Resources.Add(new Style(typeof(ContentPage))
            {
                ApplyToDerivedTypes = true,
                Setters =
                {
                    new() { Property = NavigationPage.HasNavigationBarProperty, Value = false },
                    new() { Property = ContentPage.BackgroundColorProperty, Value = AppResource<Color>("PageBackgroundColor") },
                },
            });
            Resources.Add(new Style(typeof(Grid))
            {
                Setters =
                {
                    new() { Property = Grid.PaddingProperty, Value = Thickness.Zero },
                    new() { Property = Grid.MarginProperty, Value = Thickness.Zero },
                    new() { Property = Grid.RowSpacingProperty, Value = 0 },
                    new() { Property = Grid.ColumnSpacingProperty, Value = 0 },
                    new() { Property = Grid.VerticalOptionsProperty, Value = LayoutOptions.Fill },
                    new() { Property = Grid.HorizontalOptionsProperty, Value = LayoutOptions.Fill },
                    new() { Property = Grid.BackgroundColorProperty, Value = Transparent },
                },
            });
            Resources.Add("NumberButtonStyle", new Style(typeof(Button))
            {
                Setters =
                {
                    new() { Property = Button.FontSizeProperty, Value = 22 },
                    new() { Property = Button.FontFamilyProperty, Value = "RegularFont" },
                    new() { Property = Button.TextColorProperty, Value = White },
                    new() { Property = Button.BackgroundColorProperty, Value = Color.FromArgb("#202731") },
                    new() { Property = Button.BorderWidthProperty, Value = 0 },
                    new() { Property = Button.BorderColorProperty, Value = AppResource<Color>("BorderColor") },
                    new() { Property = Button.VerticalOptionsProperty, Value = LayoutOptions.Fill },
                    new() { Property = Button.HorizontalOptionsProperty, Value = LayoutOptions.Fill },
                    new() { Property = Button.CornerRadiusProperty, Value = 0 },
                    new() { Property = Button.PaddingProperty, Value = Thickness.Zero },
                    new() { Property = Button.MarginProperty, Value = new Thickness(0,0,1,1) },
                    new() { Property = Button.FontAutoScalingEnabledProperty, Value = false },
                },
            });
            Resources.Add("OperatorButtonStyle", new Style(typeof(Button))
            {
                Setters =
                {
                    new() { Property = Button.FontSizeProperty, Value = 22 },
                    new() { Property = Button.FontFamilyProperty, Value = "RegularFont" },
                    new() { Property = Button.TextColorProperty, Value = Black },
                    new() { Property = Button.BackgroundColorProperty, Value = Color.FromArgb("#EFBB31") },
                    new() { Property = Button.BorderWidthProperty, Value = 0 },
                    new() { Property = Button.BorderColorProperty, Value = AppResource<Color>("BorderColor") },
                    new() { Property = Button.VerticalOptionsProperty, Value = LayoutOptions.Fill },
                    new() { Property = Button.HorizontalOptionsProperty, Value = LayoutOptions.Fill },
                    new() { Property = Button.CornerRadiusProperty, Value = 0 },
                    new() { Property = Button.PaddingProperty, Value = Thickness.Zero },
                    new() { Property = Button.MarginProperty, Value = new Thickness(0,0,1,1) },
                    new() { Property = Button.FontAutoScalingEnabledProperty, Value = false },
                },
            });
            Resources.Add("ScientificOperatorButtonStyle", new Style(typeof(Button))
            {
                Setters =
                {
                    new() { Property = Button.FontSizeProperty, Value = 14 },
                    new() { Property = Button.FontFamilyProperty, Value = "RegularFont" },
                    new() { Property = Button.TextColorProperty, Value = White },
                    new() { Property = Button.BackgroundColorProperty, Value = Color.FromArgb("#2C3240") },
                    new() { Property = Button.BorderWidthProperty, Value = 1 },
                    new() { Property = Button.BorderColorProperty, Value = AppResource<Color>("BorderColor") },
                    new() { Property = Button.VerticalOptionsProperty, Value = LayoutOptions.Fill },
                    new() { Property = Button.HorizontalOptionsProperty, Value = LayoutOptions.Fill },
                    new() { Property = Button.CornerRadiusProperty, Value = 6 },
                    new() { Property = Button.PaddingProperty, Value = Thickness.Zero },
                    new() { Property = Button.MarginProperty, Value = new Thickness(6,6) },
                    new() { Property = Button.ShadowProperty, Value = new Shadow() },
                    new() { Property = Button.FontAutoScalingEnabledProperty, Value = false },
                },
            });
            Resources.Add("EqualsLabelStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 28 },
                    new() { Property = Label.TextColorProperty, Value = Color.FromArgb("#EFBB31") },
                    new() { Property = Label.FontFamilyProperty, Value = "LightFont" },
                    new() { Property = Label.LineBreakModeProperty, Value = LineBreakMode.TailTruncation },
                    new() { Property = Label.FontAutoScalingEnabledProperty, Value = false },
                },
            });
            Resources.Add("ResultLabelStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 28 },
                    new() { Property = Label.TextColorProperty, Value = White },
                    new() { Property = Label.FontFamilyProperty, Value = "RegularFont" },
                    new() { Property = Label.LineBreakModeProperty, Value = LineBreakMode.TailTruncation },
                    new() { Property = Label.FontAutoScalingEnabledProperty, Value = false },
                },
            });
            Resources.Add("InputBoxLabelStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 32 },
                    new() { Property = Label.TextColorProperty, Value = White },
                    new() { Property = Label.FontFamilyProperty, Value = "LightFont" },
                    new() { Property = Label.LineBreakModeProperty, Value = LineBreakMode.WordWrap },
                    new() { Property = Label.FontAutoScalingEnabledProperty, Value = false },
                },
            });
        }
    }
}

