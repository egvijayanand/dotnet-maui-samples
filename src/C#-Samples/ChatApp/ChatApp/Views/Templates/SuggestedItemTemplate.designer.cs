namespace ChatApp.Views.Templates
{
    public partial class SuggestedItemTemplate : ContentView
    {
        private void InitializeComponent()
        {
            Resources.Add("SuggestedContainerStyle", new Style(typeof(Grid))
            {
                Setters =
                {
                    new() { Property = Grid.HeightRequestProperty, Value = 52 },
                    new() { Property = Grid.WidthRequestProperty, Value = 52 },
                    new() { Property = Grid.MarginProperty, Value = new Thickness(0, 0, 12, 0) },
                },
            });
            Resources.Add("SuggestedImageStyle", new Style(typeof(Image))
            {
                Setters =
                {
                    new() { Property = Image.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Image.VerticalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Image.MarginProperty, Value = new Thickness(8) },
                },
            });
            Content = new Grid()
            {
                Style = (Style)Resources["SuggestedContainerStyle"],
                Children =
                {
                    new Ellipse().Bind(Ellipse.FillProperty, "Color"),
                    new Image()
                    {
                        Style = (Style)Resources["SuggestedImageStyle"],
                    }.Bind("Image"),
                }
            };
        }
    }
}

