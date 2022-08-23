namespace ChatApp.Views.Templates
{
    public partial class RecentChatItemTemplate : ContentView
    {
        private void InitializeComponent()
        {
            Resources.Add("RecentImageContainerStyle", new Style(typeof(Grid))
            {
                Setters =
                {
                    new() { Property = Grid.VerticalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Grid.HeightRequestProperty, Value = 72 },
                    new() { Property = Grid.WidthRequestProperty, Value = 72 },
                },
            });
            Resources.Add("RecentEllipseStyle", new Style(typeof(Ellipse))
            {
                Setters =
                {
                    new() { Property = Ellipse.HeightRequestProperty, Value = 72 },
                    new() { Property = Ellipse.WidthRequestProperty, Value = 72 },
                },
            });
            Resources.Add("RecentImageStyle", new Style(typeof(Image))
            {
                Setters =
                {
                    new() { Property = Image.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Image.VerticalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Image.HeightRequestProperty, Value = 48 },
                    new() { Property = Image.MarginProperty, Value = new Thickness(10) },
                },
            });
            Resources.Add("NameTextStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.TextColorProperty, Value = Black },
                    new() { Property = Label.FontSizeProperty, Value = 16 },
                    new() { Property = Label.FontFamilyProperty, Value = "Metropolis Regular" },
                    new() { Property = Label.FontAttributesProperty, Value = FontAttributes.Bold },
                    new() { Property = Label.MarginProperty, Value = new Thickness(12, 0) },
                },
            });
            Resources.Add("MessageTextStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.TextColorProperty, Value = Black },
                    new() { Property = Label.FontSizeProperty, Value = 14 },
                    new() { Property = Label.FontFamilyProperty, Value = "Metropolis Regular" },
                    new() { Property = Label.LineBreakModeProperty, Value = LineBreakMode.TailTruncation },
                    new() { Property = Label.MaxLinesProperty, Value = 1 },
                    new() { Property = Label.MarginProperty, Value = new Thickness(12, 12, 12, 0) },
                },
            });
            Resources.Add("TimeColor", Color.FromArgb("#B2ACBE"));
            Resources.Add("TimeTextStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.TextColorProperty, Value = (Color)Resources["TimeColor"] },
                    new() { Property = Label.FontFamilyProperty, Value = "Metropolis Regular" },
                    new() { Property = Label.FontSizeProperty, Value = 11 },
                },
            });
            Content = new Grid()
            {
                ColumnDefinitions = Columns.Define(Auto, Star),
                RowSpacing = 0,
                GestureRecognizers =
                {
                    new TapGestureRecognizer().BindCommand(nameof(HomeViewModel.DetailCommand), source: new RelativeBindingSource(typeof(HomeViewModel).IsSubclassOf(typeof(Element)) ? RelativeBindingSourceMode.FindAncestor : RelativeBindingSourceMode.FindAncestorBindingContext, typeof(HomeViewModel)), parameterPath: Binding.SelfPath),
                },
                Children =
                {
                    new Grid()
                    {
                        Style = (Style)Resources["RecentImageContainerStyle"],
                        Children =
                        {
                            new Ellipse()
                            {
                                Style = (Style)Resources["RecentEllipseStyle"],
                            }.Bind(Ellipse.FillProperty, "Sender.Color"),
                            new Image()
                            {
                                Style = (Style)Resources["RecentImageStyle"],
                            }.Bind("Sender.Image"),
                        },
                    },
                    new Grid()
                    {
                        ColumnDefinitions = Columns.Define(Star, Auto),
                        Children =
                        {
                            new StackLayout()
                            {
                                Children =
                                {
                                    new Label()
                                    {
                                        Style = (Style)Resources["NameTextStyle"],
                                    }.Bind("Sender.Name"),
                                    new Label()
                                    {
                                        Style = (Style)Resources["MessageTextStyle"],
                                    }.Bind("Text"),
                                },
                            },
                            new Label()
                            {
                                Style = (Style)Resources["TimeTextStyle"],
                            }.Column(1).Bind("Time"),
                        },
                    }.Column(1),
                }
            }.Margin(12, 24);
        }
    }
}

