using Microsoft.Maui.Controls.Shapes;

namespace EcommerceMAUI.Views
{
    public partial class ProductDetails : ContentPage
    {
        private void InitializeComponent()
        {
            Background = new SolidColorBrush(White);
            Title = "Product Detail";
            Content = new Grid()
            {
                Children =
                {
                    new ScrollView()
                    {
                        Content = new StackLayout()
                        {
                            IsClippedToBounds = true,
                            Children =
                            {
                                new Image()
                                {
                                    Aspect = Aspect.AspectFill,
                                }.Height(200).Bind("ProductDetail.ImageUrl"),
                                new StackLayout()
                                {
                                    Children =
                                    {
                                        new Label()
                                        {
                                            FontAttributes = FontAttributes.Bold,
                                            HorizontalOptions = LayoutOptions.StartAndExpand,
                                            TextColor = Black,
                                        }.FontSize(26).TextCenterVertical().Bind("ProductDetail.Name"),
                                        new StackLayout()
                                        {
                                            HorizontalOptions = LayoutOptions.FillAndExpand,
                                            Orientation = StackOrientation.Horizontal,
                                            Children =
                                            {
                                                new Border()
                                                {
                                                    StrokeShape = new RoundRectangle()
                                                    {
                                                        CornerRadius = new CornerRadius(20)
                                                    },
                                                    HorizontalOptions = LayoutOptions.FillAndExpand,
                                                    Background = new SolidColorBrush(Transparent),
                                                    StrokeThickness = 1,
                                                    Content = new StackLayout()
                                                    {
                                                        HorizontalOptions = LayoutOptions.FillAndExpand,
                                                        Orientation = StackOrientation.Horizontal,
                                                        VerticalOptions = LayoutOptions.CenterAndExpand,
                                                        Children =
                                                        {
                                                            new Label()
                                                            {
                                                                HorizontalOptions = LayoutOptions.StartAndExpand,
                                                                Text = "Size",
                                                                TextColor = Black,
                                                            }.Margins(20,15,35,15).FontSize(14).TextCenterVertical(),
                                                            new Label()
                                                            {
                                                                HorizontalOptions = LayoutOptions.StartAndExpand,
                                                                Text = "XL",
                                                                TextColor = Black,
                                                            }.Margin(24,15).FontSize(14).TextCenterVertical(),
                                                        },
                                                    },
                                                }.Padding(0).Margin(6,0),
                                                new Border()
                                                {
                                                    StrokeShape = new RoundRectangle()
                                                    {
                                                        CornerRadius = new CornerRadius(20)
                                                    },
                                                    HorizontalOptions = LayoutOptions.FillAndExpand,
                                                    Background = new SolidColorBrush(Transparent),
                                                    StrokeThickness = 1,
                                                    Content = new StackLayout()
                                                    {
                                                        Orientation = StackOrientation.Horizontal,
                                                        VerticalOptions = LayoutOptions.CenterAndExpand,
                                                        Children =
                                                        {
                                                            new Label()
                                                            {
                                                                HorizontalOptions = LayoutOptions.StartAndExpand,
                                                                Text = "Color",
                                                                TextColor = Black,
                                                            }.Margin(20,15).FontSize(14).TextCenterVertical(),
                                                            new Border()
                                                            {
                                                                StrokeShape = new RoundRectangle()
                                                                {
                                                                    CornerRadius = new CornerRadius(8)
                                                                },
                                                                HorizontalOptions = LayoutOptions.FillAndExpand,
                                                                StrokeThickness = 1,
                                                            }.Padding(0).Margin(10).Height(26).Width(26).Bind(Border.BackgroundProperty, "ProductDetail.Colors"),
                                                        },
                                                    },
                                                }.Padding(0).Margin(6,0),
                                            },
                                        }.Margin(0,16),
                                        new StackLayout()
                                        {
                                            Children =
                                            {
                                                new Label()
                                                {
                                                    FontAttributes = FontAttributes.Bold,
                                                    HorizontalOptions = LayoutOptions.StartAndExpand,
                                                    Text = "Details",
                                                    TextColor = Black,
                                                }.FontSize(18).TextCenterVertical(),
                                                new Label()
                                                {
                                                    HorizontalOptions = LayoutOptions.StartAndExpand,
                                                    TextColor = Black,
                                                }.FontSize(14).TextCenterVertical().Bind("ProductDetail.Details"),
                                                new Label()
                                                {
                                                    FontAttributes = FontAttributes.Bold,
                                                    HorizontalOptions = LayoutOptions.StartAndExpand,
                                                    Text = "Reviews",
                                                    TextColor = Black,
                                                }.Margins(0,30,0,0).FontSize(18).TextCenterVertical(),
                                                new Label()
                                                {
                                                    FontAttributes = FontAttributes.Bold,
                                                    HorizontalOptions = LayoutOptions.StartAndExpand,
                                                    Text = "Write your review",
                                                    TextColor = Color.FromArgb("#00C569"),
                                                }.Margins(0,5,0,0).FontSize(14).TextCenterVertical(),
                                            },
                                        },
                                        new CollectionView()
                                        {
                                            ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Vertical)
                                            {
                                                ItemSpacing = 12,
                                            },
                                            ItemTemplate = new DataTemplate(() =>
                                            {
                                                return new StackLayout()
                                                {
                                                    Orientation = StackOrientation.Horizontal,
                                                    Children =
                                                    {
                                                        new Border()
                                                        {
                                                            StrokeShape = new RoundRectangle()
                                                            {
                                                                CornerRadius = new CornerRadius(23)
                                                            },
                                                            StrokeThickness = 0,
                                                            Content = new Image()
                                                            {
                                                                Aspect = Aspect.AspectFill,
                                                            }.Height(46).Width(46).Bind("ImageUrl"),
                                                        }.Padding(0).Height(46).Width(46),
                                                        new StackLayout()
                                                        {
                                                            Spacing = 2,
                                                            Children =
                                                            {
                                                                new Label()
                                                                {
                                                                    FontAttributes = FontAttributes.Bold,
                                                                    TextColor = Black,
                                                                }.FontSize(14).Bind("Name"),
                                                                new Label()
                                                                {
                                                                    TextColor = Black,
                                                                }.FontSize(14).TextCenterVertical().Bind("Review"),
                                                            },
                                                        }.Margin(8,0),
                                                    },
                                                };
                                            }),
                                        }.Margin(0,16).Bind("ProductDetail.Reviews"),
                                    },
                                }.Margin(16),
                            },
                        },
                    }.Invoke(sv => sv.Scrolled += ScrollView_Scrolled),
                    new StackLayout()
                    {
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        Orientation = StackOrientation.Horizontal,
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        Children =
                        {
                            new Border()
                            {
                                StrokeShape = new RoundRectangle()
                                {
                                    CornerRadius = new CornerRadius(20,20,20,20)
                                },
                                HorizontalOptions = LayoutOptions.StartAndExpand,
                                Background = new SolidColorBrush(Transparent),
                                StrokeThickness = 0,
                                Content = new Label()
                                {
                                    FontFamily = "icon",
                                    Text = "\xF141",
                                    TextColor = Black,
                                }.FontSize(26).Center(),
                                GestureRecognizers =
                                {
                                    new TapGestureRecognizer().Bind("TapBackCommand"),
                                },
                            }.Height(40).Width(40).Padding(0),
                            new Border()
                            {
                                StrokeShape = new RoundRectangle()
                                {
                                    CornerRadius = new CornerRadius(20,20,20,20)
                                },
                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                Background = new SolidColorBrush(White),
                                StrokeThickness = 1,
                                Content = new Label()
                                {
                                    FontFamily = "icon",
                                    Text = "\xF4D2",
                                }.FontSize(26).Center().Bind(Label.TextColorProperty, "FavStatusColor"),
                                GestureRecognizers =
                                {
                                    new TapGestureRecognizer().BindCommand("TapFavCommand", parameterPath: "FavStatusColor"),
                                },
                            }.Height(40).Width(40).Padding(0),
                        },
                    }.Margin(15).Height(42),
                    new Border()
                    {
                        StrokeShape = new RoundRectangle()
                        {
                            CornerRadius = new CornerRadius(6,6,0,0)
                        },
                        VerticalOptions = LayoutOptions.EndAndExpand,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        Background = new SolidColorBrush(White),
                        StrokeThickness = 1,
                        Content = new StackLayout()
                        {
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new StackLayout()
                                {
                                    Spacing = 0,
                                    VerticalOptions = LayoutOptions.CenterAndExpand,
                                    Children =
                                    {
                                        new Label()
                                        {
                                            Text = "PRICE",
                                            TextColor = Color.FromArgb("#929292"),
                                        }.FontSize(12).CenterHorizontal(),
                                        new Label()
                                        {
                                            TextColor = Color.FromArgb("#00C569"),
                                        }.FontSize(18).CenterHorizontal().Bind("ProductDetail.Price", stringFormat: "{}{0:c}"),
                                    },
                                },
                                new Button()
                                {
                                    Text = "ADD",
                                    BackgroundColor = Color.FromArgb("#00C569"),
                                    TextColor = White,
                                    HorizontalOptions = LayoutOptions.EndAndExpand,
                                    VerticalOptions = LayoutOptions.CenterAndExpand,
                                }.Padding(54,12),
                            },
                        }.Margin(24,0),
                    }.Padding(0).Height(80).Bind(Border.IsVisibleProperty, "IsFooterVisible"),
                }
            };
        }
    }
}

