namespace ChatApp.Views.Templates
{
    public partial class ReceiverChatMessageItemTemplate : ContentView
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
            Resources.Add("MessageColor", Color.FromArgb("#EDEEF7"));
            Resources.Add("MessageShapeStyle", new Style(typeof(BoxView))
            {
                Setters =
                {
                    new() { Property = BoxView.BackgroundColorProperty, Value = (Color)Resources["MessageColor"] },
                    new() { Property = BoxView.CornerRadiusProperty, Value = new CornerRadius(24, 24, 24, 0) },
                },
            });
            Resources.Add("MessageTextStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 12 },
                    new() { Property = Label.FontFamilyProperty, Value = "Metropolis Regular" },
                    new() { Property = Label.TextColorProperty, Value = Black },
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
                    new() { Property = Label.MarginProperty, Value = new Thickness(12, 0, 48, 0) },
                },
            });
            Content = new Grid()
            {
                ColumnDefinitions = Columns.Define(Auto, Star),
                Style = (Style)Resources["MessageContainerStyle"],
                Children =
                {
                    new Label()
                    {
                        Style = (Style)Resources["TimeTextStyle"],
                    }.Bind("Time"),
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
                            }.Padding(12).Bind("Text"),
                        },
                    }.Column(1),
                }
            };
        }
    }
}

