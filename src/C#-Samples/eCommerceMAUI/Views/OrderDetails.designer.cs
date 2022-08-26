using Microsoft.Maui.Controls.Shapes;

namespace EcommerceMAUI.Views
{
    public partial class OrderDetails : ContentPage
    {
        private void InitializeComponent()
        {
            Shell.SetBackgroundColor(this, Color.FromArgb("#00C569"));
            Shell.SetForegroundColor(this, Black);
            Shell.SetTitleColor(this, White);
            orderDetailsPage = this;
            BackgroundColor = White;
            Title = "OrderDetails";
            Content = new StackLayout()
            {
                Children =
                {
                    new StackLayout()
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            new Border()
                            {
                                StrokeShape = new RoundRectangle()
                                {
                                    CornerRadius = new CornerRadius(20,20,20,20)
                                },
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
                                HorizontalOptions = LayoutOptions.CenterAndExpand,
                                Text = "Track Order",
                                TextColor = Black,
                                VerticalOptions = LayoutOptions.CenterAndExpand,
                            }.FontSize(18).TextCenterHorizontal(),
                        },
                    }.Margin(6,12).Height(42),
                    new CollectionView()
                    {
                        IsGrouped = true,
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        ItemsLayout = new GridItemsLayout(ItemsLayoutOrientation.Vertical)
                        {
                            VerticalItemSpacing = 12,
                        },
                        ItemTemplate = new DataTemplate(() =>
                        {
                            return new StackLayout()
                            {
                                Children =
                                {
                                    new StackLayout()
                                    {
                                        Orientation = StackOrientation.Horizontal,
                                        Children =
                                        {
                                            new StackLayout()
                                            {
                                                HorizontalOptions = LayoutOptions.StartAndExpand,
                                                Children =
                                                {
                                                    new Label()
                                                    {
                                                        HorizontalOptions = LayoutOptions.StartAndExpand,
                                                        TextColor = Black,
                                                    }.FontSize(16).Bind("OrderId"),
                                                    new Label()
                                                    {
                                                        HorizontalOptions = LayoutOptions.StartAndExpand,
                                                        TextColor = Color.FromArgb("#00C569"),
                                                    }.Margin(0,5).FontSize(14).Bind("Price"),
                                                    new Frame()
                                                    {
                                                        BorderColor = Transparent,
                                                        BackgroundColor = Color.FromArgb("#00C569"),
                                                        CornerRadius = 2,
                                                        HasShadow = false,
                                                        IsClippedToBounds = true,
                                                        Content = new Label()
                                                        {
                                                            HorizontalOptions = LayoutOptions.CenterAndExpand,
                                                            TextColor = White,
                                                            VerticalOptions = LayoutOptions.CenterAndExpand,
                                                        }.Margins(12,10,12,10).FontSize(14).TextCenterVertical().Bind("Status"),
                                                        GestureRecognizers =
                                                        {
                                                            new TapGestureRecognizer().BindCommand("BindingContext.TapCommand", source: orderDetailsPage, parameterPath: Binding.SelfPath),
                                                        },
                                                    }.Margin(0,16).Padding(0),
                                                },
                                            },
                                            new Grid()
                                            {
                                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                                ColumnSpacing = 4,
                                                RowSpacing = 4,
                                                RowDefinitions = Rows.Define(50,50),
                                                ColumnDefinitions = Columns.Define(50,50),
                                                Children =
                                                {
                                                    new Border()
                                                    {
                                                        StrokeShape = new RoundRectangle()
                                                        {
                                                            CornerRadius = new CornerRadius(5,5,5,5)
                                                        },
                                                        Stroke = LightGray,
                                                        Background = new SolidColorBrush(Transparent),
                                                        StrokeThickness = 1,
                                                        Content = new Image()
                                                        {
                                                            Aspect = Aspect.AspectFit,
                                                        }.Bind("ImageOneUrl"),
                                                    }.Column(0).Row(0).Padding(4).Bind(Border.IsVisibleProperty, "ImageOneVisibility"),
                                                    new Border()
                                                    {
                                                        StrokeShape = new RoundRectangle()
                                                        {
                                                            CornerRadius = new CornerRadius(5,5,5,5)
                                                        },
                                                        Stroke = LightGray,
                                                        Background = new SolidColorBrush(Transparent),
                                                        StrokeThickness = 1,
                                                        Content = new Image()
                                                        {
                                                            Aspect = Aspect.AspectFit,
                                                        }.Bind(Image.IsVisibleProperty, "ImageTwoVisibility").Bind("ImageTwoUrl"),
                                                    }.Column(1).Row(0).Padding(4).Bind(Border.IsVisibleProperty, "ImageTwoVisibility"),
                                                    new Border()
                                                    {
                                                        StrokeShape = new RoundRectangle()
                                                        {
                                                            CornerRadius = new CornerRadius(5,5,5,5)
                                                        },
                                                        Stroke = LightGray,
                                                        Background = new SolidColorBrush(Transparent),
                                                        StrokeThickness = 1,
                                                        Content = new Image()
                                                        {
                                                            Aspect = Aspect.AspectFit,
                                                        }.Column(0).Row(1).Bind("ImageThreeUrl"),
                                                    }.Column(0).Row(1).Padding(4).Bind(Border.IsVisibleProperty, "ImageThreeVisibility"),
                                                    new Border()
                                                    {
                                                        StrokeShape = new RoundRectangle()
                                                        {
                                                            CornerRadius = new CornerRadius(5,5,5,5)
                                                        },
                                                        Stroke = LightGray,
                                                        Background = new SolidColorBrush(Transparent),
                                                        StrokeThickness = 1,
                                                        Content = new Label()
                                                        {
                                                            HorizontalOptions = LayoutOptions.CenterAndExpand,
                                                            TextColor = Black,
                                                            VerticalOptions = LayoutOptions.CenterAndExpand,
                                                        }.FontSize(14).Bind("RemainingImages", stringFormat: "+{0}"),
                                                    }.Column(1).Row(1).Padding(4).Bind(Border.IsVisibleProperty, "ImageMoreVisibility"),
                                                },
                                            },
                                        },
                                    },
                                },
                            };
                        }),
                        GroupHeaderTemplate = new DataTemplate(() =>
                        {
                            return new Label()
                            {
                                HorizontalOptions = LayoutOptions.StartAndExpand,
                                TextColor = Black,
                            }.FontSize(14).Bind("Date");
                        }),
                    }.Margin(18,0).Bind("TrackData"),
                }
            };
        }

        #region Variables
        private OrderDetails orderDetailsPage;
        #endregion
    }
}

