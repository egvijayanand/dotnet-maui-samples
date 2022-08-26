using Microsoft.Maui.Controls.Shapes;

namespace EcommerceMAUI.Views
{
    public partial class Profile : ContentPage
    {
        private void InitializeComponent()
        {
            BackgroundColor = White;
            Shell.SetNavBarIsVisible(this, false);
            profilePage = this;
            Title = "Profile";
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
                                    CornerRadius = new CornerRadius(6)
                                },
                                Background = new SolidColorBrush(Transparent),
                                StrokeThickness = 0,
                                Content = new Image()
                                {
                                    Aspect = Aspect.AspectFit,
                                }.Height(120).Width(120).Bind("ImageUrl"),
                            }.Column(0),
                            new StackLayout()
                            {
                                VerticalOptions = LayoutOptions.CenterAndExpand,
                                Children =
                                {
                                    new Label()
                                    {
                                        FontAttributes = FontAttributes.Bold,
                                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                                        Text = "David Spade",
                                        TextColor = Black,
                                    }.FontSize(26).TextCenterVertical(),
                                    new Label()
                                    {
                                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                                        Text = "iamdavid@gmail.com",
                                        TextColor = Black,
                                    }.FontSize(14).TextCenterVertical(),
                                },
                            }.Margin(20),
                        },
                    }.Margin(15,30),
                    new CollectionView()
                    {
                        ItemsLayout = new GridItemsLayout(1, ItemsLayoutOrientation.Vertical)
                        {
                            HorizontalItemSpacing = 12,
                            VerticalItemSpacing = 12,
                        },
                        ItemTemplate = new DataTemplate(() =>
                        {
                            return new Grid()
                            {
                                ColumnDefinitions = Columns.Define(40,Star,40),
                                GestureRecognizers =
                                {
                                    new TapGestureRecognizer().BindCommand("BindingContext.TapCommand", source: profilePage, parameterPath: Binding.SelfPath),
                                },
                                Children =
                                {
                                    new Border()
                                    {
                                        StrokeShape = new RoundRectangle()
                                        {
                                            CornerRadius = new CornerRadius(6)
                                        },
                                        StrokeThickness = 0,
                                        Background = new LinearGradientBrush()
                                        {
                                            EndPoint = new Point(0,1),
                                            GradientStops =
                                            {
                                                new GradientStop()
                                                {
                                                    Color = LightGreen,
                                                    Offset = 0.1f,
                                                },
                                                new GradientStop()
                                                {
                                                    Color = LightGray,
                                                    Offset = 1.0f,
                                                },
                                            },
                                        },
                                        Content = new Label()
                                        {
                                            FontFamily = "icon",
                                            TextColor = Black,
                                        }.FontSize(22).Center().Bind("Body"),
                                    }.Column(0).Height(40).Width(36),
                                    new Label()
                                    {
                                        FontAttributes = FontAttributes.Bold,
                                        TextColor = Black,
                                    }.FontSize(16).Margin(18,0).Column(1).Start().CenterVertical().TextCenterVertical().Bind("Title"),
                                    new Label()
                                    {
                                        FontFamily = "icon",
                                        FontAttributes = FontAttributes.Bold,
                                        Text = "\xF142",
                                        TextColor = Black,
                                        VerticalOptions = LayoutOptions.CenterAndExpand,
                                    }.Column(2).FontSize(16).End().CenterVertical().TextCenterHorizontal(),
                                },
                            };
                        }),
                    }.Margin(12).Bind("MenuItems"),
                }
            };
        }

        #region Variables
        private Profile profilePage;
        #endregion
    }
}

