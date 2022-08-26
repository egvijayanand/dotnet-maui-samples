using EcommerceMAUI.Views;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Devices;

namespace EcommerceMAUI.Views
{
    public partial class BrandDetail : ContentPage
    {
        private void InitializeComponent()
        {
            brandListPage = this;
            Shell.SetBackgroundColor(this, Color.FromArgb("#00C569"));
            Shell.SetForegroundColor(this, Application.Current.RequestedTheme switch
            {
                AppTheme.Dark => AppResource<Color>("White"),
                AppTheme.Light or _ => AppResource<Color>("Black"),
            });
            Shell.SetTitleColor(this, White);
            BackgroundColor = White;
            Title = "Brand Detail";
            Content = new StackLayout()
            {
                Spacing = 0,
                Children =
                {
                    new CollectionView()
                    {
                        Background = new SolidColorBrush(Color.FromArgb("#00C569")),
                        ItemsLayout = new GridItemsLayout(ItemsLayoutOrientation.Horizontal)
                        {
                            HorizontalItemSpacing = 6,
                        },
                        ItemTemplate = new DataTemplate(() =>
                        {
                            return new Grid()
                            {
                                GestureRecognizers =
                                {
                                    new TapGestureRecognizer().BindCommand("BindingContext.TapCommandMenu", source: brandListPage, parameterPath: Binding.SelfPath),
                                },
                                Children =
                                {
                                    new StackLayout()
                                    {
                                        Children =
                                        {
                                            new Label()
                                            {
                                                FontAttributes = FontAttributes.Bold,
                                                TextColor = White,
                                            }.FontSize(18).Margin(6).Center().TextCenterVertical().Bind("Name"),
                                            new Border()
                                            {
                                                Background = new SolidColorBrush(White),
                                                Stroke = White,
                                                StrokeShape = new RoundRectangle()
                                                {
                                                    CornerRadius = new CornerRadius(0)
                                                },
                                            }.Height(4).Bind(Border.IsVisibleProperty, "IsSelected"),
                                        },
                                    },
                                },
                            }.Margins(6,0,0,12);
                        }),
                    }.Bind("TabPageList"),
                    new CollectionView()
                    {
                        VerticalOptions = LayoutOptions.FillAndExpand,
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
                                    new TapGestureRecognizer().BindCommand("BindingContext.TapCommand", source: brandListPage, parameterPath: Binding.SelfPath),
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
                }
            };
        }

        #region Variables
        private BrandDetail brandListPage;
        #endregion
    }
}

