using Microsoft.Maui.Graphics;

namespace SpaceXhistory.Views
{
    public partial class UpcomingLaunchesPage : ContentPage
    {
        private void InitializeComponent()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            BackgroundColor = Black;
            Content = new ListView()
            {
                BackgroundColor = Black,
                HasUnevenRows = true,
                SeparatorVisibility = SeparatorVisibility.None,
                Header = new Grid()
                {
                    RowDefinitions = Rows.Define(Auto, Auto),
                    ColumnDefinitions = Columns.Define(Auto),
                    Children =
                    {
                        new Image()
                        {
                            Source = "logo.png",
                        }.Row(0).Column(0).Margin(0).Width(150).Height(40).Start(),
                        new Label()
                        {
                            Text = "next launchs",
                            FontFamily = "Light",
                            TextColor = Color.FromArgb("#adb5bd"),
                        }.Row(1).Column(0).Margins(0,20,0,0),
                    },
                },
                ItemTemplate = new DataTemplate(() =>
                {
                    return new ViewCell()
                    {
                        View = new Grid()
                        {
                            RowDefinitions = Rows.Define(Auto),
                            ColumnDefinitions = Columns.Define(Auto, Auto),
                            Children =
                            {
                                new Image().Row(0).Column(0).Height(120).Width(120).Bind("links.patch.small", targetNullValue: "https://i.imgur.com/8pgWyf4.png"),
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
                                        }.Row(0).Column(0).FontSize(30).Margins(0,0,0,10).Bind("name"),
                                        new Label()
                                        {
                                            FontFamily = "Medium",
                                            TextColor = White,
                                        }.Row(1).Column(0).Margins(0,0,0,5).Bind("date_local", stringFormat: "{0:ddd, dd MMM yyyy}", targetNullValue: "not informed", fallbackValue: "not informed"),
                                        new Label()
                                        {
                                            FontFamily = "Medium",
                                        }.Row(2).Column(0).Margins(0,0,0,10).Bind("Status").Bind(Label.TextColorProperty, "StatusColor"),
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
                                        }.Row(3).Column(0).Padding(6,10).Start(),
                                    },
                                }.Row(0).Column(1).Margins(20,0,0,0).CenterVertical(),
                            },
                        }.Margins(0,20,0,0),
                    };
                }),
            }.Bind("NextLaunchs").Margin(20).Invoke(lv => lv.ItemTapped += ListView_ItemTapped);
        }
    }
}

