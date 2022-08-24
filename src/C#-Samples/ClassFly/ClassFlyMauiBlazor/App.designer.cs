using ClassFlyMauiBlazor;

namespace ClassFlyMauiBlazor
{
    public partial class App : Application
    {
        private void InitializeComponent()
        {
            Resources.Add("PageBackgroundColor", Color.FromArgb("#512bdf"));
            Resources.Add("PrimaryTextColor", White);
            Resources.Add(new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.TextColorProperty, Value = AppResource<Color>("PrimaryTextColor") },
                    new() { Property = Label.FontFamilyProperty, Value = "OpenSansRegular" },
                },
            });
            Resources.Add(new Style(typeof(Button))
            {
                Setters =
                {
                    new() { Property = Button.TextColorProperty, Value = AppResource<Color>("PrimaryTextColor") },
                    new() { Property = Button.FontFamilyProperty, Value = "OpenSansRegular" },
                    new() { Property = Button.BackgroundColorProperty, Value = Color.FromArgb("#2b0b98") },
                    new() { Property = Button.PaddingProperty, Value = new Thickness(14,10) },
                },
            });
        }
    }
}

