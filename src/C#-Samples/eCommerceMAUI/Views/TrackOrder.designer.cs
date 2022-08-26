using Microsoft.Maui.Controls.Shapes;

namespace EcommerceMAUI.Views
{
    public partial class TrackOrder : ContentPage
    {
        private void InitializeComponent()
        {
            Shell.SetBackgroundColor(this, Color.FromArgb("#00C569"));
            Shell.SetForegroundColor(this, Black);
            Shell.SetTitleColor(this, White);
            BackgroundColor = White;
            SetBinding(TitleProperty, new Binding("PageTitle"));
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
                                TextColor = Black,
                                VerticalOptions = LayoutOptions.CenterAndExpand,
                            }.FontSize(18).TextCenterHorizontal().Bind("PageTitle"),
                        },
                    }.Margin(6,12).Height(42),
                    new CollectionView()
                    {
                        ItemTemplate = new DataTemplate(() =>
                        {
                            return new StackLayout()
                            {
                                HorizontalOptions = LayoutOptions.CenterAndExpand,
                                Orientation = StackOrientation.Horizontal,
                                Spacing = 0,
                                Children =
                                {
                                    new StackLayout()
                                    {
                                        Children =
                                        {
                                            new Label()
                                            {
                                                FontAttributes = FontAttributes.Bold,
                                                TextColor = Gray,
                                            }.FontSize(18).Bind("DateMonth"),
                                            new Label()
                                            {
                                                FontAttributes = FontAttributes.Bold,
                                                TextColor = Gray,
                                            }.FontSize(14).Bind("Time"),
                                        },
                                    },
                                    new StackLayout()
                                    {
                                        Spacing = 0,
                                        Children =
                                        {
                                            new Border()
                                            {
                                                StrokeShape = new RoundRectangle()
                                                {
                                                    CornerRadius = new CornerRadius(16)
                                                },
                                                Stroke = Black,
                                                Background = new SolidColorBrush(Transparent),
                                                StrokeThickness = 1,
                                                Content = new Border()
                                                {
                                                    StrokeShape = new RoundRectangle()
                                                    {
                                                        CornerRadius = new CornerRadius(16)
                                                    },
                                                    StrokeThickness = 1,
                                                }.Padding(4).Height(16).Width(16).Bind(Border.StrokeProperty, "StatusColor").Bind(Border.BackgroundProperty, "StatusColor"),
                                            }.Padding(4),
                                            new Border()
                                            {
                                                StrokeShape = new RoundRectangle()
                                                {
                                                    CornerRadius = new CornerRadius(16)
                                                },
                                                HorizontalOptions = LayoutOptions.CenterAndExpand,
                                                VerticalOptions = LayoutOptions.FillAndExpand,
                                                StrokeThickness = 1,
                                            }.Width(2).Height(80).Bind(Border.IsVisibleProperty, "IsLineVisible").Bind(Border.StrokeProperty, "StatusColor").Bind(Border.BackgroundProperty, "StatusColor"),
                                        },
                                    }.Margins(30,0,20,0),
                                    new StackLayout()
                                    {
                                        Children =
                                        {
                                            new Label()
                                            {
                                                FontAttributes = FontAttributes.Bold,
                                                TextColor = Black,
                                            }.FontSize(16).Bind("Name"),
                                            new Label()
                                            {
                                                FontAttributes = FontAttributes.None,
                                                TextColor = Black,
                                            }.FontSize(12).Bind("Location"),
                                        },
                                    }.Margin(20,0),
                                },
                            };
                        }),
                    }.Margin(20).Bind("TrackStatusData"),
                }
            };
        }
    }
}

