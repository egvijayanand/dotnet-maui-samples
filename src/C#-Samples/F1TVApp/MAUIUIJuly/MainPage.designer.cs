using MAUIUIJuly.Helpers;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Layouts;

namespace MAUIUIJuly
{
    public partial class MainPage : ContentPage
    {
        private void InitializeComponent()
        {
            BackgroundColor = Color.FromArgb("#15151d");
            Resources.Add(new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.TextColorProperty, Value = White },
                },
            });
            Content = new ScrollView()
            {
                Content = new VerticalStackLayout()
                {
                    Children =
                    {
                        new FlexLayout()
                        {
                            Background = new SolidColorBrush(Color.FromArgb("#e10600")),
                            HorizontalOptions = LayoutOptions.CenterAndExpand,
                            JustifyContent = FlexJustify.SpaceBetween,
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            Children =
                            {
                                new Image()
                                {
                                    Source = new FontImageSource()
                                    {
                                        FontFamily = "IconFontTypes",
                                        Glyph = IconFont.Menu,
                                        Size = 32,
                                        Color = White,
                                    },
                                }.Margins(0,10,0,0).Height(32).Width(32).CenterVertical(),
                                new Label()
                                {
                                    FontAttributes = FontAttributes.Bold,
                                    Text = "F1TV",
                                }.FontSize(22).CenterVertical(),
                                new Image()
                                {
                                    Source = new FontImageSource()
                                    {
                                        FontFamily = "IconFontTypes",
                                        Glyph = IconFont.Magnify,
                                        Size = 32,
                                        Color = White,
                                    },
                                }.Margins(0,10,0,0).Height(32).Width(32).CenterVertical(),
                            },
                        }.Padding(20).Height(60),
                        new Grid()
                        {
                            Children =
                            {
                                new Image()
                                {
                                    Source = "leclerc.jpg",
                                }.Height(220).CenterHorizontal(),
                                new Frame()
                                {
                                    BorderColor = Color.FromArgb("#15151d"),
                                    CornerRadius = 0,
                                    Background = new LinearGradientBrush()
                                    {
                                        EndPoint = new Point(0,1),
                                        GradientStops =
                                        {
                                            new GradientStop()
                                            {
                                                Offset = 0.1f,
                                                Color = Transparent,
                                            },
                                            new GradientStop()
                                            {
                                                Offset = 1.0f,
                                                Color = Color.FromArgb("#15151d"),
                                            },
                                        },
                                    },
                                }.Height(220),
                                new Border()
                                {
                                    Background = new SolidColorBrush(Color.FromArgb("#e10600")),
                                    StrokeThickness = 0,
                                    StrokeShape = new RoundRectangle()
                                    {
                                        CornerRadius = new CornerRadius(0,30,0,0),
                                    },
                                    Content = new Image()
                                    {
                                        Source = new FontImageSource()
                                        {
                                            FontFamily = "IconFontTypes",
                                            Glyph = IconFont.PlayOutline,
                                            Size = 50,
                                            Color = White,
                                        },
                                    }.Height(50).Width(50).CenterVertical(),
                                }.Margin(20,30).Padding(0).Height(70).Width(70).Start().Bottom(),
                                new Label()
                                {
                                    FontAttributes = FontAttributes.Bold,
                                    Text = "2022 British GP - Practice 2",
                                }.Margin(20,0).FontSize(20).Start().Bottom(),
                            },
                        },
                        new HorizontalStackLayout()
                        {
                            Children =
                            {
                                new Image()
                                {
                                    Source = new FontImageSource()
                                    {
                                        FontFamily = "IconFontTypes",
                                        Glyph = IconFont.ClockOutline,
                                        Size = 20,
                                        Color = White,
                                    },
                                }.Margins(0,0,10,0).Height(20).Width(20).CenterVertical(),
                                new Label()
                                {
                                    Text = "01:12:24 | ",
                                },
                                new Label()
                                {
                                    Text = " REPLAY | ",
                                },
                                new Image()
                                {
                                    Source = new FontImageSource()
                                    {
                                        FontFamily = "IconFontTypes",
                                        Glyph = IconFont.Steering,
                                        Size = 20,
                                        Color = White,
                                    },
                                }.Margins(6,0,6,0).Height(20).Width(20).CenterVertical(),
                                new Label()
                                {
                                    Text = " | ",
                                },
                                new Label()
                                {
                                    Text = " F1 | ",
                                },
                                new Label()
                                {
                                    Text = " F1 TV Pro",
                                },
                            },
                        }.Margins(20,10,20,20),
                        new HorizontalStackLayout()
                        {
                            Spacing = 4,
                            Children =
                            {
                                new Line()
                                {
                                    Stroke = White,
                                    X2 = 30,
                                },
                                new Line()
                                {
                                    Stroke = Color.FromArgb("#949398"),
                                    X2 = 30,
                                },
                                new Line()
                                {
                                    Stroke = Color.FromArgb("#949398"),
                                    X2 = 30,
                                },
                                new Line()
                                {
                                    Stroke = Color.FromArgb("#949398"),
                                    X2 = 30,
                                },
                            },
                        }.CenterHorizontal(),
#if !WINDOWS
                        // This FlexLayout causes the below mentioned exception in Windows target platform
                        // Layout cycle detected.  Layout could not complete.
                        new FlexLayout()
                        {
                            JustifyContent = FlexJustify.SpaceBetween,
                            Children =
                            {
                                new HorizontalStackLayout()
                                {
                                    Children =
                                    {
                                        new Label()
                                        {
                                            FontAttributes = FontAttributes.Bold,
                                            Text = "2022 British Grand Prix",
                                        }.FontSize(18).Start(),
                                        new Label()
                                        {
                                            FontAttributes = FontAttributes.Bold,
                                            Text = ">",
                                            TextColor = Color.FromArgb("#e10600"),
                                        }.Margin(10,0).FontSize(18),
                                    },
                                },
                                new Label()
                                {
                                    FontAttributes = FontAttributes.Bold,
                                    HorizontalOptions = LayoutOptions.EndAndExpand,
                                    Text = "View All",
                                }.Margin(0,0).FontSize(18),
                            },
                        }.Margins(20,10,20,0),
#endif
                        new CollectionView()
                        {
                            ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Horizontal),
                            ItemTemplate = new DataTemplate(() =>
                            {
                                return new Border()
                                {
                                    Background = new SolidColorBrush(Color.FromArgb("#1f1f27")),
                                    StrokeThickness = 0,
                                    StrokeShape = new RoundRectangle()
                                    {
                                        CornerRadius = new CornerRadius(0,0,15,15),
                                    },
                                    Content = new Grid()
                                    {
                                        RowDefinitions = Rows.Define(Star,Star),
                                        Children =
                                        {
                                            new Grid()
                                            {
                                                Children =
                                                {
                                                    new Image()
                                                    {
                                                        Source = "leclerc.jpg",
                                                    }.Margin(0).Height(110).CenterHorizontal(),
                                                    new Border()
                                                    {
                                                        Background = new SolidColorBrush(Color.FromArgb("#1f1f27")),
                                                        StrokeThickness = 0,
                                                        StrokeShape = new RoundRectangle()
                                                        {
                                                            CornerRadius = new CornerRadius(0,20,0,0),
                                                        },
                                                        Content = new Image()
                                                        {
                                                            Source = new FontImageSource()
                                                            {
                                                                FontFamily = "IconFontTypes",
                                                                Glyph = IconFont.PlayOutline,
                                                                Size = 38,
                                                                Color = White,
                                                            },
                                                        }.Height(38).Width(38).CenterVertical(),
                                                    }.Margins(-3,0,0,-2).Padding(0).Height(50).Width(50).Start().Bottom(),
                                                },
                                            },
                                            new VerticalStackLayout()
                                            {
                                                Children =
                                                {
                                                    new Label()
                                                    {
                                                        Text = "00:10:22",
                                                    }.Margins(0,0,0,6),
                                                    new Label()
                                                    {
                                                        Text = "PRACTICE 2 HIGHLIGHTS - Great Britain",
                                                    },
                                                    new Label()
                                                    {
                                                        Text = "F1",
                                                        TextColor = Color.FromArgb("#e10600"),
                                                    }.End(),
                                                },
                                            }.Row(1).Margin(10),
                                        },
                                    },
                                }.Margins(10,10,0,0).Height(200).Width(180);
                            }),
                            ItemsSource = new string[]
                            {
                                "test",
                                "test",
                                "test",
                            },
                        },
                        new Grid()
                        {
                            Children =
                            {
                                new Image()
                                {
                                    Source = "redoutline.png",
                                },
                                new VerticalStackLayout()
                                {
                                    Children =
                                    {
                                        new Label()
                                        {
                                            Text = "🇬🇧",
                                        }.FontSize(26),
                                        new Label()
                                        {
                                            FontAttributes = FontAttributes.Bold,
                                            Text = "GREAT BRITAIN",
                                        }.FontSize(22),
                                        new Label()
                                        {
                                            Text = "FORMULA 1 LENOVO BRITISH",
                                        },
                                        new Label()
                                        {
                                            Text = "GRAND PRIX 2022",
                                        },
                                        new Border()
                                        {
                                            Background = new SolidColorBrush(Color.FromArgb("#38393e")),
                                            StrokeThickness = 0,
                                            StrokeShape = new RoundRectangle()
                                            {
                                                CornerRadius = new CornerRadius(15,15,15,15),
                                            },
                                            Content = new Label()
                                            {
                                                Text = "1 JUL - 3 JUL",
                                            }.CenterHorizontal(),
                                        }.Margins(0,20,0,0).Padding(4).Height(30).Width(110).Start().Bottom(),
                                    },
                                }.Margins(20,30,0,0),
                            },
                        }.Margins(0,20,0,0),
                    }
                }
            };
        }
    }
}

