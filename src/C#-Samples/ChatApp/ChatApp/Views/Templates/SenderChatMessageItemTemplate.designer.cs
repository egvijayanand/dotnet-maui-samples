namespace ChatApp.Views.Templates
{
    public partial class SenderChatMessageItemTemplate : ContentView
    {
        private void InitializeComponent()
        {
            Resources.Add("MessageContainerStyle", new Style(typeof(Grid))
            {
                Setters =
                {
                    new() { Property = Grid.MarginProperty, Value = new Thickness(8) },
                },
            });
            Resources.Add("SenderContainerStyle", new Style(typeof(Grid))
            {
                Setters =
                {
                    new() { Property = Grid.HeightRequestProperty, Value = 42 },
                    new() { Property = Grid.WidthRequestProperty, Value = 42 },
                    new() { Property = Grid.VerticalOptionsProperty, Value = LayoutOptions.End },
                },
            });
            Resources.Add("SenderEllipseStyle", new Style(typeof(Ellipse))
            {
                Setters =
                {
                    new() { Property = Ellipse.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Ellipse.VerticalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Ellipse.HeightRequestProperty, Value = 30 },
                    new() { Property = Ellipse.WidthRequestProperty, Value = 30 },
                },
            });
            Resources.Add("SenderImageStyle", new Style(typeof(Image))
            {
                Setters =
                {
                    new() { Property = Image.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Image.VerticalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Image.MarginProperty, Value = new Thickness(12) },
                },
            });
            Resources.Add("MessageColor", Color.FromArgb("#F7F7F8"));
            Resources.Add("MessageShapeStyle", new Style(typeof(BoxView))
            {
                Setters =
                {
                    new() { Property = BoxView.BackgroundColorProperty, Value = (Color)Resources["MessageColor"] },
                    new() { Property = BoxView.CornerRadiusProperty, Value = new CornerRadius(24, 24, 0, 24) },
                },
            });
            Resources.Add("MessageTextStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 12 },
                    new() { Property = Label.FontFamilyProperty, Value = "Metropolis Regular" },
                    new() { Property = Label.TextColorProperty, Value = Black },
                    new() { Property = Label.VerticalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Label.PaddingProperty, Value = new Thickness(12, 0) },
                },
            });
            Resources.Add("TimeTextStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 10 },
                    new() { Property = Label.FontFamilyProperty, Value = "Metropolis Regular" },
                    new() { Property = Label.TextColorProperty, Value = Gray },
                    new() { Property = Label.VerticalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Label.MarginProperty, Value = new Thickness(48, 0, 12, 0) },
                },
            });
            Content = new Grid()
            {
                ColumnDefinitions = Columns.Define(Auto, Star, Auto),
                Style = (Style)Resources["MessageContainerStyle"],
                Children =
                {
                    new Grid()
                    {
                        Style = (Style)Resources["SenderContainerStyle"],
                        Children =
                        {
                            new Ellipse()
                            {
                                Style = (Style)Resources["SenderEllipseStyle"],
                            }.Bind(Ellipse.FillProperty, "Sender.Color", converter: (IValueConverter)Resources["ColorToBrushConverter"]),
                            new Image()
                            {
                                Style = (Style)Resources["SenderImageStyle"],
                            }.Bind("Sender.Image"),
                        },
                    },
                    new Grid()
                    {
                        Children =
                        {
                            new BoxView()
                            {
                                Style = (Style)Resources["MessageShapeStyle"],
                            },
                            new Label()
                            {
                                Style = (Style)Resources["MessageTextStyle"],
                            }.Bind("Text"),
                        },
                    }.Column(1),
                    new Label()
                    {
                        Style = (Style)Resources["TimeTextStyle"],
                    }.Column(2).Bind("Time"),
                }
            };
        }
    }
}

