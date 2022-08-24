namespace MauiBMICalculator
{
    public partial class App : Application
    {
        private void InitializeComponent()
        {
            Resources.Add("PageBackgroundColor", Color.FromArgb("#FFFFFF"));
            Resources.Add("LightBackgroundColor", Color.FromArgb("#D3D3D3"));
            Resources.Add("DarkTextColor", Color.FromArgb("#00133D"));
            Resources.Add(new Style(typeof(ContentPage))
            {
                ApplyToDerivedTypes = true,
                Setters =
                {
                    new() { Property = NavigationPage.HasNavigationBarProperty, Value = false },
                    new() { Property = ContentPage.BackgroundColorProperty, Value = AppResource<Color>("PageBackgroundColor") },
                },
            });
            Resources.Add("NextButtonStyle", new Style(typeof(ImageButton))
            {
                Setters =
                {
                    new() { Property = ImageButton.HeightRequestProperty, Value = 60 },
                    new() { Property = ImageButton.WidthRequestProperty, Value = 60 },
                    new() { Property = ImageButton.BackgroundColorProperty, Value = Transparent },
                    new() { Property = ImageButton.AspectProperty, Value = "AspectFit" },
                    new() { Property = ImageButton.SourceProperty, Value = "nextbutton.png" },
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
                    new() { Property = Grid.BackgroundColorProperty, Value = Transparent },
                },
            });
            Resources.Add("SectionHeaderStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 24 },
                    new() { Property = Label.TextColorProperty, Value = AppResource<Color>("DarkTextColor") },
                    new() { Property = Label.FontFamilyProperty, Value = "MediumFont" },
                },
            });
            Resources.Add("ScaleHeaderStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 10 },
                    new() { Property = Label.TextColorProperty, Value = AppResource<Color>("DarkTextColor") },
                    new() { Property = Label.FontFamilyProperty, Value = "MediumFont" },
                    new() { Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Label.VerticalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Label.HorizontalTextAlignmentProperty, Value = TextAlignment.Center },
                },
            });
            Resources.Add("ScaleDisplayStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 10 },
                    new() { Property = Label.TextColorProperty, Value = AppResource<Color>("DarkTextColor") },
                    new() { Property = Label.FontFamilyProperty, Value = "RegularFont" },
                    new() { Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Label.VerticalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Label.HorizontalTextAlignmentProperty, Value = TextAlignment.Center },
                },
            });
            Resources.Add("BMIResultStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 96 },
                    new() { Property = Label.TextColorProperty, Value = AppResource<Color>("DarkTextColor") },
                    new() { Property = Label.FontFamilyProperty, Value = "MediumFont" },
                },
            });
        }
    }
}

