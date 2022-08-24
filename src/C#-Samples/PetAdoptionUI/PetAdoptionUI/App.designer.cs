namespace PetAdoptionUI
{
    public partial class App : Application
    {
        private void InitializeComponent()
        {
            Resources.Add("PrimaryColor", Color.FromArgb("#512bdf"));
            Resources.Add("SecondaryColor", White);
            Resources.Add(new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.TextColorProperty, Value = AppResource<Color>("PrimaryColor") },
                    new() { Property = Label.FontFamilyProperty, Value = "OpenSansRegular" },
                },
            });
            Resources.Add(new Style(typeof(Button))
            {
                Setters =
                {
                    new() { Property = Button.TextColorProperty, Value = AppResource<Color>("SecondaryColor") },
                    new() { Property = Button.FontFamilyProperty, Value = "OpenSansRegular" },
                    new() { Property = Button.BackgroundColorProperty, Value = AppResource<Color>("PrimaryColor") },
                    new() { Property = Button.PaddingProperty, Value = new Thickness(14,10) },
                },
            });
        }
    }
}

