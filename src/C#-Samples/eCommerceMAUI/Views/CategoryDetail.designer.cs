using Microsoft.Maui.Controls.Shapes;

namespace EcommerceMAUI.Views
{
    public partial class CategoryDetail : ContentPage
    {
        private void InitializeComponent()
        {
            categoryDetail = this;
            Background = new SolidColorBrush(White);
            Title = "Category Detail";
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
                            new Label()
                            {
                                FontAttributes = FontAttributes.Bold,
                                HorizontalOptions = LayoutOptions.FillAndExpand,
                                TextColor = Black,
                                VerticalOptions = LayoutOptions.CenterAndExpand,
                            }.FontSize(18).TextCenterHorizontal().Bind("PageTitle"),
                            new Border()
                            {
                                StrokeShape = new RoundRectangle()
                                {
                                    CornerRadius = new CornerRadius(20)
                                },
                                Background = new SolidColorBrush(Color.FromArgb("#00C569")),
                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                StrokeThickness = 0,
                                Content = new Label()
                                {
                                    FontFamily = "icon",
                                    Text = "\xF100",
                                    TextColor = White,
                                    VerticalOptions = LayoutOptions.CenterAndExpand,
                                }.FontSize(22).CenterHorizontal().CenterVertical().TextCenterHorizontal(),
                            }.Padding(0).Height(40).Margin(6,0).Width(40),
                        },
                    }.Margin(6,12).Height(42),
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
                                    Text = "Top Brands",
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
                                                    VerticalOptions = LayoutOptions.CenterAndExpand,
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
                                                        new TapGestureRecognizer().BindCommand("BindingContext.FeaturedTapCommand", source: categoryDetail, parameterPath: Binding.SelfPath),
                                                    },
                                                }.Padding(16,8),
                                            },
                                        };
                                    }),
                                }.Margin(0,2).Bind("FeaturedBrandsDataList"),
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
                                                new TapGestureRecognizer().BindCommand("BindingContext.TapCommand", source: categoryDetail, parameterPath: Binding.SelfPath),
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
                                }.Margin(12).Bind("AllProductDataList"),
                            },
                        }.Margin(12,0),
                    },
                }
            };
        }

        #region Variables
        private CategoryDetail categoryDetail;
        #endregion
    }
}

