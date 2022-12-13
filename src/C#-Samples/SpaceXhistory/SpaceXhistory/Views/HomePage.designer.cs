using Microsoft.Maui.Graphics;

namespace SpaceXhistory.Views
{
    public partial class HomePage : ContentPage
    {
        private void InitializeComponent()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            BackgroundColor = Black;
            Content = new ScrollView()
            {
                Orientation = ScrollOrientation.Vertical,
                Content = new Grid()
                {
                    RowDefinitions = Rows.Define(Auto, Auto, Auto, Auto, Auto, Auto, Auto),
                    ColumnDefinitions = Columns.Define(Auto),
                    Children =
                    {
                        new Image()
                        {
                            Source = "logo.png",
                        }.Row(0).Column(0).Margin(0).Width(150).Height(40).Start(),
                        new Label()
                        {
                            Text = "next launch",
                            FontFamily = "Light",
                            TextColor = Color.FromArgb("#adb5bd"),
                        }.Row(1).Column(0).Margins(0,25,0,20),
                        new Grid()
                        {
                            RowDefinitions = Rows.Define(Auto),
                            ColumnDefinitions = Columns.Define(Auto, Auto),
                            Children =
                            {
                                new Image().Row(0).Column(0).Height(120).Width(120).Bind("NextLaunch.links.patch.small", targetNullValue: "https://i.imgur.com/8pgWyf4.png"),
                                new Grid()
                                {
                                    RowDefinitions = Rows.Define(Auto, Auto, Auto, Auto),
                                    ColumnDefinitions = Columns.Define(Auto),
                                    Children =
                                    {
                                        new Label()
                                        {
                                            FontFamily = "Bold",
                                            TextColor = White,
                                        }.Row(0).Column(0).FontSize(30).Margins(0,0,0,10).Bind("NextLaunch.name"),
                                        new Label()
                                        {
                                            FontFamily = "Medium",
                                            TextColor = White,
                                        }.Row(1).Column(0).Margins(0,0,0,5).Bind("NextLaunch.date_local", stringFormat: "{0:ddd, dd MMM yyyy}", targetNullValue: "not informed", fallbackValue: "not informed"),
                                        new Label()
                                        {
                                            FontFamily = "Medium",
                                        }.Row(2).Column(0).Margins(0,0,0,10).Bind("NextLaunch.Status").Bind(Label.TextColorProperty, "NextLaunch.StatusColor"),
                                        new Frame()
                                        {
                                            BackgroundColor = Transparent,
                                            Content = new StackLayout()
                                            {
                                                Orientation = StackOrientation.Horizontal,
                                                Children =
                                                {
                                                    new Image()
                                                    {
                                                        Source = "youtube",
                                                    }.Width(20).Height(10),
                                                    new Label()
                                                    {
                                                        Text = "Watch the launch",
                                                        FontFamily = "Light",
                                                        TextColor = White,
                                                    }.Margins(6,0,0,0).FontSize(12).Center(),
                                                },
                                            },
                                            GestureRecognizers =
                                            {
                                                new TapGestureRecognizer().Invoke(x => x.Tapped += NextLaunchWebcastTap),
                                            },
                                        }.Row(3).Column(0).Padding(6,10).Start(),
                                    },
                                }.Row(0).Column(1).Margins(20,0,0,0).CenterVertical(),
                            },
                        }.Row(2).Column(0),
                        new Label()
                        {
                            FontFamily = "Light",
                            TextColor = Color.FromArgb("#adb5bd"),
                            Text = "latest launch",
                        }.Row(3).Column(0).Margins(0,30,0,20),
                        new Grid()
                        {
                            RowDefinitions = Rows.Define(Auto),
                            ColumnDefinitions = Columns.Define(Auto, Auto),
                            Children =
                            {
                                new Image().Row(0).Column(0).Width(120).Height(120).Bind("LatestLaunch.links.patch.small", targetNullValue: "https://i.imgur.com/8pgWyf4.png"),
                                new Grid()
                                {
                                    RowDefinitions = Rows.Define(Auto, Auto, Auto, Auto),
                                    ColumnDefinitions = Columns.Define(Auto),
                                    Children =
                                    {
                                        new Label()
                                        {
                                            FontFamily = "Bold",
                                            TextColor = White,
                                        }.Row(0).Column(0).Margins(0,0,0,10).FontSize(30).Bind("LatestLaunch.name"),
                                        new Label()
                                        {
                                            FontFamily = "Medium",
                                            TextColor = White,
                                        }.Row(1).Column(0).Margins(0,0,0,5).Bind("LatestLaunch.date_local", stringFormat: "{0:ddd, dd MMM yyyy}", targetNullValue: "not informed", fallbackValue: "not informed"),
                                        new Label()
                                        {
                                            FontFamily = "Medium",
                                        }.Row(2).Column(0).Margins(0,0,0,10).Bind("LatestLaunch.Status").Bind(Label.TextColorProperty, "LatestLaunch.StatusColor"),
                                        new Frame()
                                        {
                                            BackgroundColor = Transparent,
                                            Content = new StackLayout()
                                            {
                                                Orientation = StackOrientation.Horizontal,
                                                Children =
                                                {
                                                    new Image()
                                                    {
                                                        Source = "youtube",
                                                    }.Width(20).Height(10),
                                                    new Label()
                                                    {
                                                        Text = "Watch the launch",
                                                        FontFamily = "Light",
                                                        TextColor = White,
                                                    }.Margins(6,0,0,0).FontSize(12).Center(),
                                                },
                                            },
                                            GestureRecognizers =
                                            {
                                                new TapGestureRecognizer().Invoke(x => x.Tapped += LatestLaunchWebcastTap),
                                            },
                                        }.Row(3).Column(0).Padding(6,10).Start(),
                                    },
                                }.Row(0).Column(1).Margins(20,0,0,0),
                            },
                        }.Row(4).Column(0),
                        new Label()
                        {
                            FontFamily = "Light",
                            TextColor = Color.FromArgb("#adb5bd"),
                            Text = "Tesla Roadster status",
                        }.Row(5).Column(0).Margins(0,30,0,10),
                        new Grid()
                        {
                            RowDefinitions = Rows.Define(Auto),
                            ColumnDefinitions = Columns.Define(Auto, Auto),
                            Children =
                            {
                                new Image()
                                {
                                    Source = "https://farm5.staticflickr.com/4615/40143096241_11128929df_b.jpg",
                                }.Row(0).Column(0).Width(120).Height(120),
                                new Grid()
                                {
                                    RowDefinitions = Rows.Define(Auto, Auto, Auto, Auto, Auto, Auto, Auto, Auto),
                                    Children =
                                    {
                                        new Label()
                                        {
                                            Text = "Earth distance (km)",
                                            FontFamily = "Medium",
                                            TextColor = White,
                                        }.Row(0).Column(0).FontSize(10),
                                        new Label()
                                        {
                                            FontFamily = "Medium",
                                            TextColor = White,
                                        }.Row(1).Column(0).FontSize(16).Bind("RoadsterInfo.earth_distance_km", stringFormat: "{0:0}"),
                                        new Label()
                                        {
                                            FontFamily = "Medium",
                                            TextColor = White,
                                            Text = "Mars distance (km)",
                                        }.Row(2).Column(0).Margins(0,10,0,0).FontSize(10),
                                        new Label()
                                        {
                                            FontFamily = "Medium",
                                            TextColor = White,
                                        }.Row(3).Column(0).FontSize(16).Bind("RoadsterInfo.mars_distance_km", stringFormat: "{0:0}"),
                                        new Label()
                                        {
                                            FontFamily = "Medium",
                                            TextColor = White,
                                            Text = "Speed (km/h)",
                                        }.Row(4).Column(0).FontSize(10).Margins(0,10,0,0),
                                        new Label()
                                        {
                                            FontFamily = "Medium",
                                            TextColor = White,
                                        }.Row(5).Column(0).FontSize(16).Bind("RoadsterInfo.speed_kph", stringFormat: "{0:0}"),
                                        new Frame()
                                        {
                                            BackgroundColor = Transparent,
                                            Content = new StackLayout()
                                            {
                                                Orientation = StackOrientation.Horizontal,
                                                Children =
                                                {
                                                    new Image()
                                                    {
                                                        Source = "youtube",
                                                    }.Width(20).Height(10),
                                                    new Label()
                                                    {
                                                        Text = "Watch the launch",
                                                        FontFamily = "Light",
                                                        TextColor = White,
                                                    }.Margins(6,0,0,0).FontSize(12).Center(),
                                                },
                                            },
                                            GestureRecognizers =
                                            {
                                                new TapGestureRecognizer().Invoke(x => x.Tapped += RoadsterWebcastTap),
                                            },
                                        }.Row(6).Column(0).Padding(6,10).Margins(0,10,0,0).Start(),
                                        new Frame()
                                        {
                                            BackgroundColor = Transparent,
                                            Content = new StackLayout()
                                            {
                                                Orientation = StackOrientation.Horizontal,
                                                Children =
                                                {
                                                    new Image()
                                                    {
                                                        Source = "wiki",
                                                    }.Width(16),
                                                    new Label()
                                                    {
                                                        Text = "Click for more information",
                                                        FontFamily = "Light",
                                                        TextColor = White,
                                                    }.Margins(6,0,0,0).FontSize(12).Center(),
                                                },
                                            },
                                            GestureRecognizers =
                                            {
                                                new TapGestureRecognizer().Invoke(x => x.Tapped += RoadsterWikiTap),
                                            },
                                        }.Row(7).Column(0).Padding(6,10).Margins(0,10,0,0).Start(),
                                    },
                                }.Row(0).Column(1).Margins(20,0,0,0).CenterVertical(),
                            },
                        }.Row(6).Column(0),
                    }
                }.Margin(20)
            };
        }
    }
}

