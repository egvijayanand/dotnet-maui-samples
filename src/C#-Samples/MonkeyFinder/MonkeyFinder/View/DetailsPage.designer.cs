namespace MonkeyFinder
{
    public partial class DetailsPage : ContentPage
    {
        private void InitializeComponent()
        {
            SetBinding(TitleProperty, new Binding("Monkey.Name"));
            Content = new ScrollView()
            {
                BackgroundColor = Application.Current.RequestedTheme switch
                {
                    AppTheme.Dark => AppResource<Color>("DarkBackground"),
                    AppTheme.Light or _ => AppResource<Color>("LightBackground"),
                },
                Content = new VerticalStackLayout()
                {
                    Children =
                    {
                        new Grid()
                        {
                            ColumnDefinitions = Columns.Define(Star,Auto,Star),
                            RowDefinitions = Rows.Define(160, Auto),
                            Children =
                            {
                                new BoxView()
                                {
                                    BackgroundColor = AppResource<Color>("Primary"),
                                    HorizontalOptions = LayoutOptions.FillAndExpand,
                                }.ColumnSpan(3).Height(160),
                                new Frame()
                                {
                                    IsClippedToBounds = true,
                                    CornerRadius = 80,
                                    Content = new Image()
                                    {
                                        Aspect = Aspect.AspectFill,
                                    }.Height(160).Width(160).Center().Bind("Monkey.Image"),
                                }.RowSpan(2).Column(1).Margins(0,80,0,0).Height(160).Width(160).Padding(0).CenterHorizontal(),
                            },
                        },
                        new VerticalStackLayout()
                        {
                            Spacing = 10,
                            Children =
                            {
                                new Button()
                                {
                                    Text = "Show on Map",
                                    Style = AppResource<Style>("ButtonOutline"),
                                }.Width(200).Margin(8).CenterHorizontal().Bind(nameof(MonkeyDetailsViewModel.OpenMapCommand)),
                                new Label()
                                {
                                    Style = AppResource<Style>("MediumLabel"),
                                }.Bind("Monkey.Details"),
                                new Label()
                                {
                                    Style = AppResource<Style>("SmallLabel"),
                                }.Bind("Monkey.Location", stringFormat: "Location: {0}"),
                                new Label()
                                {
                                    Style = AppResource<Style>("SmallLabel"),
                                }.Bind("Monkey.Population", stringFormat: "Population: {0}"),
                            },
                        }.Padding(10),
                    }
                }
            };
        }
    }
}

