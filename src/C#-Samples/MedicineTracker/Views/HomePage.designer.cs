namespace UIMock
{
    public partial class HomePage : ContentPage
    {
        private void InitializeComponent()
        {
            Title = "HomePage";
            NavigationPage.SetHasNavigationBar(this, false);
            BackgroundColor = Color.FromArgb("#fafafa");
            Content = new Grid()
            {
                RowDefinitions = Rows.Define(Auto, Auto, Auto, Auto, Auto),
                Children =
                {
                    new StackLayout()
                    {
                        Children =
                        {
                            new Grid()
                            {
                                ColumnDefinitions = Columns.Define(Star,Auto,Auto),
                                Children =
                                {
                                    new Image()
                                    {
                                        Source = "menu64.png",
                                        BackgroundColor = Transparent,
                                    }.Column(0).Height(25).Width(25).Start(),
                                    new StackLayout()
                                    {
                                        Children =
                                        {
                                            new Grid()
                                            {
                                                Children =
                                                {
                                                    new Image()
                                                    {
                                                        Source = "bell48.png",
                                                        BackgroundColor = Transparent,
                                                    }.Row(0).Column(0).Height(35).Margins(0,0,0,0).Width(35).End().Top(),
                                                    new Ellipse()
                                                    {
                                                        Fill = Red,
                                                        Stroke = Transparent,
                                                        StrokeThickness = 0,
                                                    }.Row(0).Column(0).Width(12).Height(12).End().Top(),
                                                },
                                            },
                                        },
                                    }.Column(1),
                                    new Frame()
                                    {
                                        BorderColor = Transparent,
                                        CornerRadius = 20,
                                        IsClippedToBounds = true,
                                        Content = new Image()
                                        {
                                            Source = "me.jpg",
                                            BackgroundColor = Transparent,
                                            Aspect = DeviceInfo.Platform.ToString() switch
                                            {
                                                nameof(DevicePlatform.iOS) => Aspect.AspectFit,
                                                nameof(DevicePlatform.Android) => Aspect.AspectFill,
                                            },
                                        }.CenterHorizontal(),
                                    }.Column(2).Padding(0).Width(40).Height(40),
                                },
                            },
                        },
                    }.Row(0).Margins(30,10,30,10),
                    new VerticalStackLayout()
                    {
                        Children =
                        {
                            new Label()
                            {
                                Text = "Hello,",
                                TextColor = Gray,
                            }.FontSize(18).Start(),
                            new Label()
                            {
                                Text = "Elina Johnson",
                                TextColor = Black,
                                FontAttributes = FontAttributes.Bold,
                                FontFamily = "LatoBold",
                            }.FontSize(24).Start(),
                        },
                    }.Row(1).Margins(30,30,30,10),
                    new StackLayout()
                    {
                        Children =
                        {
                            new Grid()
                            {
                                RowSpacing = 10,
                                ColumnSpacing = DeviceInfo.Platform.ToString() switch
                                {
                                    nameof(DevicePlatform.iOS) => 30d,
                                    nameof(DevicePlatform.Android) => 10d,
                                },
                                RowDefinitions = Rows.Define(80,80),
                                ColumnDefinitions = Columns.Define(Stars(0.5),Stars(0.5)),
                                Children =
                                {
                                    new Frame()
                                    {
                                        BackgroundColor = Color.FromArgb("#f7d5d2"),
                                        BorderColor = Transparent,
                                        CornerRadius = 20,
                                        VerticalOptions = LayoutOptions.CenterAndExpand,
                                        Content = new VerticalStackLayout()
                                        {
                                            Spacing = 5,
                                            Children =
                                            {
                                                new Frame()
                                                {
                                                    BackgroundColor = White,
                                                    CornerRadius = 22,
                                                    BorderColor = Transparent,
                                                    Content = new Label()
                                                    {
                                                        Text = "\xF043",
                                                        FontFamily = "FontAwesomeSolid",
                                                        TextColor = Color.FromArgb("#e8bc65"),
                                                    }.FontSize(22).Center(),
                                                }.Height(45).Width(45).Padding(0),
                                                new Label()
                                                {
                                                    Text = "80-82",
                                                    TextColor = Black,
                                                    FontFamily = "LatoBold",
                                                }.FontSize(24),
                                                new Label()
                                                {
                                                    Text = "Glocose",
                                                    TextColor = Gray,
                                                },
                                            },
                                        }.CenterHorizontal(),
                                    }.Row(0).RowSpan(2).Column(0).Height(160),
                                    new Frame()
                                    {
                                        BackgroundColor = Color.FromArgb("#fbe6b8"),
                                        BorderColor = Transparent,
                                        CornerRadius = 20,
                                        Content = new Grid()
                                        {
                                            ColumnSpacing = 10,
                                            RowDefinitions = Rows.Define(Auto,Auto),
                                            ColumnDefinitions = Columns.Define(Auto,Auto),
                                            Children =
                                            {
                                                new Frame()
                                                {
                                                    BackgroundColor = White,
                                                    CornerRadius = 20,
                                                    BorderColor = Transparent,
                                                }.Row(0).RowSpan(2).Column(0).Height(40).Width(40),
                                                new Label()
                                                {
                                                    Text = "\xF004",
                                                    FontFamily = "FontAwesomeSolid",
                                                    TextColor = Color.FromArgb("#e8bc65"),
                                                }.Row(0).RowSpan(2).Column(0).FontSize(22).Center(),
                                                new Label()
                                                {
                                                    Text = "08",
                                                    TextColor = Black,
                                                    FontFamily = "LatoBold",
                                                }.Row(0).Column(1).FontSize(24),
                                                new Label()
                                                {
                                                    Text = "Pills per day",
                                                    TextColor = Gray,
                                                }.Row(1).Column(1),
                                            },
                                        }.Center(),
                                    }.Row(0).Column(1).Padding(0),
                                    new Frame()
                                    {
                                        BackgroundColor = Color.FromArgb("#e9eafd"),
                                        BorderColor = Transparent,
                                        CornerRadius = 20,
                                        Content = new Grid()
                                        {
                                            ColumnSpacing = 10,
                                            RowDefinitions = Rows.Define(Auto,Auto),
                                            ColumnDefinitions = Columns.Define(Auto,Auto),
                                            Children =
                                            {
                                                new Frame()
                                                {
                                                    BackgroundColor = White,
                                                    CornerRadius = 20,
                                                    BorderColor = Transparent,
                                                }.Row(0).RowSpan(2).Column(0).Height(40).Width(40),
                                                new Label()
                                                {
                                                    Text = "\xF46B",
                                                    FontFamily = "FontAwesomeSolid",
                                                    TextColor = Color.FromArgb("#e8bc65"),
                                                }.Row(0).RowSpan(2).Column(0).FontSize(22).Center(),
                                                new Label()
                                                {
                                                    Text = "87 bp",
                                                    TextColor = Black,
                                                    FontFamily = "LatoBold",
                                                }.Row(0).Column(1).FontSize(24),
                                                new Label()
                                                {
                                                    Text = "Heart rate",
                                                    TextColor = Gray,
                                                }.Row(1).Column(1),
                                            },
                                        }.Center(),
                                    }.Row(1).Column(1).Padding(0),
                                },
                            },
                        },
                    }.Row(2).Margins(30,10,30,10),
                    new StackLayout()
                    {
                        Children =
                        {
                            new Grid()
                            {
                                ColumnDefinitions = Columns.Define(Star,Auto),
                                Children =
                                {
                                    new Label()
                                    {
                                        Text = "Upcoming Doses",
                                        TextColor = Black,
                                        FontAttributes = FontAttributes.None,
                                        FontFamily = "LatoBold",
                                    }.Row(0).Column(0).FontSize(18).Start().CenterVertical(),
                                    new Label()
                                    {
                                        Text = "See all",
                                        TextColor = Blue,
                                    }.Row(0).Column(1).FontSize(12).End().CenterVertical(),
                                },
                            },
                        },
                    }.Row(3).Margins(30,10,30,10),
                    new CollectionView()
                    {
                        SelectionMode = SelectionMode.Single,
                        ItemSizingStrategy = ItemSizingStrategy.MeasureAllItems,
                        HorizontalScrollBarVisibility = ScrollBarVisibility.Always,
                        BackgroundColor = Transparent,
                        ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Vertical)
                        {
                            ItemSpacing = 10,
                        },
                        ItemTemplate = new DataTemplate(() =>
                        {
                            return new Frame()
                            {
                                HasShadow = false,
                                BackgroundColor = White,
                                BorderColor = Color.FromArgb("#f0ebeb"),
                                CornerRadius = 20,
                                IsClippedToBounds = true,
                                Content = new Grid()
                                {
                                    RowSpacing = 5,
                                    ColumnSpacing = 10,
                                    RowDefinitions = Rows.Define(Auto,Auto,Auto),
                                    ColumnDefinitions = Columns.Define(5,Star,Auto),
                                    Children =
                                    {
                                        new BoxView()
                                        {
                                            Color = Color.FromArgb("#7d87f1"),
                                            VerticalOptions = LayoutOptions.FillAndExpand,
                                        }.Row(0).RowSpan(3).Column(0).Width(3),
                                        new Label()
                                        {
                                            FontAttributes = FontAttributes.Bold,
                                            FontFamily = "LatoBold",
                                        }.Row(0).Column(1).FontSize(15).CenterVertical().TextStart().Bind("Medicine"),
                                        new Label()
                                        {
                                            FontAttributes = FontAttributes.Bold,
                                            FontFamily = "LatoBold",
                                        }.Row(1).Column(1).FontSize(15).Margins(0,0,0,10).CenterVertical().TextStart().Bind("Dose"),
                                        new Button()
                                        {
                                            Text = "Mark Taken",
                                            BackgroundColor = Color.FromArgb("#e8bc65"),
                                            Padding = DeviceInfo.Platform.ToString() switch
                                            {
                                                nameof(DevicePlatform.iOS) => new Thickness(10,10,10,10),
                                                nameof(DevicePlatform.Android) => new Thickness(10,5,10,5),
                                            },
                                        }.Row(0).RowSpan(2).Column(2).Height(30),
                                        new Label()
                                        {
                                            FontAttributes = FontAttributes.Bold,
                                            FontFamily = "LatoRegular",
                                            TextColor = Gray,
                                        }.Row(2).Column(1).FontSize(12).CenterVertical().TextStart().Bind("Time"),
                                        new HorizontalStackLayout()
                                        {
                                            Children =
                                            {
                                                new Label()
                                                {
                                                    Text = "\xF017",
                                                    FontFamily = "FontAwesomeSolid",
                                                    TextColor = Gray,
                                                }.FontSize(16).Margins(0,0,3,0),
                                                new Label()
                                                {
                                                    Text = "2hr",
                                                    FontAttributes = FontAttributes.Bold,
                                                    FontFamily = "LatoRegular",
                                                    TextColor = Gray,
                                                }.FontSize(12),
                                            },
                                        }.Row(2).Column(2).Center(),
                                    },
                                },
                            }.Padding(15).Margin(2);
                        }),
                    }.Row(4).Margins(20,20,20,0).Top().Bind("ReminderList"),
                }
            };
        }
    }
}

