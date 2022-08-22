namespace BeautyShopApp.Views.Templates
{
    public partial class ResultsItemTemplate : ContentView
    {
        private void InitializeComponent()
        {
            VariableSizedWrapGrid.SetRowSpan(this, 1);
            Resources.Add("ResultsTextStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.TextColorProperty, Value = Black },
                    new() { Property = Label.FontFamilyProperty, Value = "Fallingsky Bold" },
                    new() { Property = Label.FontSizeProperty, Value = 28 },
                    new() { Property = Label.MarginProperty, Value = new Thickness(12, 6, 12, 0) },
                },
            });
            Content = new StackLayout()
            {
                Spacing = 0,
                Children =
                {
                    new Label()
                    {
                        Text = "Found",
                        Style = (Style)Resources["ResultsTextStyle"],
                    },
                    new Label()
                    {
                        Text = "10 Results",
                        Style = (Style)Resources["ResultsTextStyle"],
                    }.Margin(12, 0),
                }
            };
        }
    }
}

