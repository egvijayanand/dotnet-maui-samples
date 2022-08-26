using Microsoft.Maui.Controls.Shapes;

namespace EcommerceMAUI.Views
{
    public partial class HomePage : ContentPage
    {
        private void InitializeComponent()
        {
            homePage = this;
            Title = "HomePage";
            BackgroundColor = White;
            Shell.SetNavBarIsVisible(this, false);
            Content = new StackLayout()
            {
                Spacing = 0,
                Children =
                {
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
                                    CornerRadius = new CornerRadius(22)
                                },
                                HorizontalOptions = LayoutOptions.FillAndExpand,
                                Background = new SolidColorBrush(LightGray),
                                StrokeThickness = 0,
                                Content = new StackLayout()
                                {
                                    Orientation = StackOrientation.Horizontal,
                                    VerticalOptions = LayoutOptions.CenterAndExpand,
                                    Children =
                                    {
                                        new Label()
                                        {
                                            FontFamily = "icon",
                                            Text = "\xF349",
                                            TextColor = Black,
                                            VerticalOptions = LayoutOptions.CenterAndExpand,
                                        }.FontSize(22).CenterHorizontal().CenterVertical().TextCenterHorizontal(),
                                        new Entry()
                                        {
                                            HorizontalOptions = LayoutOptions.FillAndExpand,
                                            Placeholder = "Search Here",
                                        }.Margin(8,0),
                                    },
                                }.Margin(12,2),
                            }.Padding(0).Margin(0),
                            new Border()
                            {
                                StrokeShape = new RoundRectangle()
                                {
                                    CornerRadius = new CornerRadius(20)
                                },
                                Background = new SolidColorBrush(Color.FromArgb("#00C569")),
                                StrokeThickness = 0,
                                Content = new Label()
                                {
                                    FontFamily = "icon",
                                    Text = "\xF100",
                                    TextColor = White,
                                    VerticalOptions = LayoutOptions.CenterAndExpand,
                                }.FontSize(22).CenterHorizontal().CenterVertical().TextCenterHorizontal(),
                            }.Padding(0).Height(40).Margin(6,0).Width(40).End(),
                        },
                    }.Margin(0),
                    new ScrollView()
                    {
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        Content = new StackLayout()
                        {
                            Spacing = 0,
                            Children =
                            {
                                new Label()
                                {
                                    FontAttributes = FontAttributes.Bold,
                                    Text = "Categories",
                                    TextColor = Black,
                                    VerticalOptions = LayoutOptions.EndAndExpand,
                                }.Margin(0,12).FontSize(16).Start().Bottom().TextStart(),
                                new CollectionView()
                                {
                                    SelectionMode = SelectionMode.Single,
                                    VerticalScrollBarVisibility = ScrollBarVisibility.Never,
                                    ItemsLayout = new GridItemsLayout(5, ItemsLayoutOrientation.Vertical)
                                    {
                                        HorizontalItemSpacing = 12,
                                        VerticalItemSpacing = 0,
                                    },
                                    ItemTemplate = new DataTemplate(() =>
                                    {
                                        return new StackLayout()
                                        {
                                            Spacing = 0,
                                            GestureRecognizers =
                                            {
                                                new TapGestureRecognizer().BindCommand("BindingContext.CategoryTapCommand", source: homePage, parameterPath: Binding.SelfPath),
                                            },
                                            Children =
                                            {
                                                new Border()
                                                {
                                                    Background = new SolidColorBrush(White),
                                                    Stroke = Gray,
                                                    StrokeShape = new RoundRectangle()
                                                    {
                                                        CornerRadius = new CornerRadius(30)
                                                    },
                                                    Content = new Label()
                                                    {
                                                        FontFamily = "icon",
                                                        TextColor = Black,
                                                        VerticalOptions = LayoutOptions.CenterAndExpand,
                                                    }.FontSize(32).CenterHorizontal().CenterVertical().TextCenterHorizontal().Bind("Icon"),
                                                }.Margin(0,4).Padding(12).Height(60).Width(60).Center(),
                                                new Label()
                                                {
                                                    TextColor = Black,
                                                    VerticalOptions = LayoutOptions.EndAndExpand,
                                                }.FontSize(14).CenterHorizontal().Bottom().TextCenterHorizontal().Bind("CategoryName"),
                                            },
                                        };
                                    }),
                                }.Margin(0,6).Bind("CategoriesDataList"),
                                new StackLayout()
                                {
                                    Orientation = StackOrientation.Horizontal,
                                    Spacing = 0,
                                    Children =
                                    {
                                        new Label()
                                        {
                                            FontAttributes = FontAttributes.Bold,
                                            Text = "Best Selling",
                                            TextColor = Black,
                                        }.FontSize(16).Start().CenterVertical().TextStart(),
                                        new Button()
                                        {
                                            BackgroundColor = Transparent,
                                            Text = "View All",
                                            TextColor = Black,
                                            HorizontalOptions = LayoutOptions.EndAndExpand,
                                        }.FontSize(16).End().CenterVertical().Bind("RecommendedTapCommand"),
                                    },
                                }.Margin(0,12),
                                new CollectionView()
                                {
                                    ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Horizontal)
                                    {
                                        ItemSpacing = 12,
                                    },
                                    ItemTemplate = new DataTemplate(() =>
                                    {
                                        return new StackLayout()
                                        {
                                            Background = new SolidColorBrush(White),
                                            HorizontalOptions = LayoutOptions.FillAndExpand,
                                            GestureRecognizers =
                                            {
                                                new TapGestureRecognizer().BindCommand("BindingContext.TapCommand", source: homePage, parameterPath: Binding.SelfPath),
                                            },
                                            Children =
                                            {
                                                new Border()
                                                {
                                                    StrokeShape = new RoundRectangle()
                                                    {
                                                        CornerRadius = new CornerRadius(6,0,0,6)
                                                    },
                                                    Background = new SolidColorBrush(Transparent),
                                                    StrokeThickness = 1,
                                                    Content = new Image()
                                                    {
                                                        Aspect = Aspect.AspectFit,
                                                    }.Height(240).Width(165).Bind("ImageUrl"),
                                                }.Padding(0),
                                                new StackLayout()
                                                {
                                                    Children =
                                                    {
                                                        new Label()
                                                        {
                                                            TextColor = Black,
                                                        }.FontSize(16).CenterHorizontal().Top().Bind("Name"),
                                                        new Label()
                                                        {
                                                            TextColor = Color.FromArgb("#929292"),
                                                        }.FontSize(12).CenterHorizontal().Top().Bind("BrandName"),
                                                        new Label()
                                                        {
                                                            TextColor = Color.FromArgb("#00C569"),
                                                        }.FontSize(16).CenterHorizontal().Top().Bind("Price"),
                                                    },
                                                }.Margins(0,8,0,0),
                                            },
                                        }.Margin(0);
                                    }),
                                }.Margin(0,12).Bind("BestSellingDataList"),
                                new Label()
                                {
                                    FontAttributes = FontAttributes.Bold,
                                    Text = "Featured Brands",
                                    TextColor = Black,
                                    VerticalOptions = LayoutOptions.EndAndExpand,
                                }.Margin(0,12).FontSize(16).Start().Bottom().TextStart(),
                                new CollectionView()
                                {
                                    ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Horizontal)
                                    {
                                        ItemSpacing = 12,
                                    },
                                    ItemTemplate = new DataTemplate(() =>
                                    {
                                        return new StackLayout()
                                        {
                                            Children =
                                            {
                                                new Border()
                                                {
                                                    Background = new SolidColorBrush(White),
                                                    StrokeShape = new RoundRectangle()
                                                    {
                                                        CornerRadius = new CornerRadius(6)
                                                    },
                                                    Stroke = Wheat,
                                                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                                                    VerticalOptions = LayoutOptions.FillAndExpand,
                                                    Content = new StackLayout()
                                                    {
                                                        Orientation = StackOrientation.Horizontal,
                                                        Children =
                                                        {
                                                            new Frame()
                                                            {
                                                                CornerRadius = 20,
                                                                HasShadow = false,
                                                                Opacity = 10f,
                                                                Content = new Image()
                                                                {
                                                                    Aspect = Aspect.AspectFit,
                                                                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                                                                    VerticalOptions = LayoutOptions.CenterAndExpand,
                                                                }.Height(40).Width(40).Bind("ImageUrl"),
                                                            }.Padding(0).Height(40).Width(40),
                                                            new StackLayout()
                                                            {
                                                                Children =
                                                                {
                                                                    new Label()
                                                                    {
                                                                        FontAttributes = FontAttributes.Bold,
                                                                        TextColor = Black,
                                                                    }.FontSize(16).CenterHorizontal().Bind("BrandName"),
                                                                    new Label()
                                                                    {
                                                                        TextColor = Color.FromArgb("#929292"),
                                                                    }.FontSize(12).CenterHorizontal().Bind("Details"),
                                                                },
                                                            }.Margin(6,0),
                                                        },
                                                    },
                                                    GestureRecognizers =
                                                    {
                                                        new TapGestureRecognizer().BindCommand("BindingContext.BrandTapCommand", source: homePage, parameterPath: Binding.SelfPath),
                                                    },
                                                }.Padding(16,8),
                                            },
                                        };
                                    }),
                                }.Margin(0,10).Bind("FeaturedBrandsDataList"),
                                new StackLayout()
                                {
                                    Orientation = StackOrientation.Horizontal,
                                    Spacing = 0,
                                    Children =
                                    {
                                        new Label()
                                        {
                                            FontAttributes = FontAttributes.Bold,
                                            Text = "Recommended",
                                            TextColor = Black,
                                        }.FontSize(16).Start().CenterVertical().TextStart(),
                                        new Button()
                                        {
                                            BackgroundColor = Transparent,
                                            Text = "View All",
                                            TextColor = Black,
                                            HorizontalOptions = LayoutOptions.EndAndExpand,
                                        }.FontSize(16).End().CenterVertical().Bind("RecommendedTapCommand"),
                                    },
                                }.Margin(0,12),
                                new CollectionView()
                                {
                                    ItemsLayout = new GridItemsLayout(2, ItemsLayoutOrientation.Vertical)
                                    {
                                        HorizontalItemSpacing = 12,
                                        VerticalItemSpacing = 12,
                                    },
                                    ItemTemplate = new DataTemplate(() =>
                                    {
                                        return new StackLayout()
                                        {
                                            Background = new SolidColorBrush(White),
                                            HorizontalOptions = LayoutOptions.FillAndExpand,
                                            GestureRecognizers =
                                            {
                                                new TapGestureRecognizer().BindCommand("BindingContext.TapCommand", source: homePage, parameterPath: Binding.SelfPath),
                                            },
                                            Children =
                                            {
                                                new Border()
                                                {
                                                    StrokeShape = new RoundRectangle()
                                                    {
                                                        CornerRadius = new CornerRadius(6,0,0,6)
                                                    },
                                                    Background = new SolidColorBrush(Transparent),
                                                    StrokeThickness = 1,
                                                    Content = new Image()
                                                    {
                                                        Aspect = Aspect.AspectFit,
                                                    }.Height(240).Width(165).Bind("ImageUrl"),
                                                },
                                                new StackLayout()
                                                {
                                                    Children =
                                                    {
                                                        new Label()
                                                        {
                                                            TextColor = Black,
                                                        }.FontSize(16).CenterHorizontal().Top().Bind("Name"),
                                                        new Label()
                                                        {
                                                            TextColor = Color.FromArgb("#929292"),
                                                        }.FontSize(12).CenterHorizontal().Top().Bind("BrandName"),
                                                        new Label()
                                                        {
                                                            TextColor = Color.FromArgb("#00C569"),
                                                        }.FontSize(16).CenterHorizontal().Top().Bind("Price"),
                                                    },
                                                }.Margins(0,8,0,0),
                                            },
                                        }.Margin(0);
                                    }),
                                }.Margin(12).Bind("BestSellingDataList"),
                            },
                        },
                    },
                }
            }.Margin(8,12);
        }

        #region Variables
        private HomePage homePage;
        #endregion
    }
}

