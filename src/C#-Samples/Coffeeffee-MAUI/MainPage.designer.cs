using Coffeeffee_MAUI.Controls;
using Coffeeffee_MAUI.Models;
using Coffeeffee_MAUI.Styles;
using Microsoft.Maui.Controls.Shapes;

namespace Coffeeffee_MAUI
{
    public partial class MainPage : ContentPage
    {
        private void InitializeComponent()
        {
            BackgroundColor = AppResource<Color>("green");
            NavigationPage.SetHasNavigationBar(this, false);
            Content = new Grid()
            {
                RowDefinitions = Rows.Define(120,Star,64,100),
                ColumnDefinitions = Columns.Define(Star,Star,Star),
                Children =
                {
                    new Label()
                    {
                        Text = "All Products",
                        FontFamily = "JosefinSansBold",
                        TextColor = Color.FromArgb("#FFFFFF"),
                    }.ColumnSpan(2).FontSize(32).Margins(32,0,0,0).CenterVertical(),
                    new Button()
                    {
                        BackgroundColor = Color.FromArgb("#FFFFFF"),
                        FontFamily = "Icons",
                        CornerRadius = 8,
                        Text = Icons.IconShopping,
                        TextColor = AppResource<Color>("green"),
                    }.Height(52).Width(52).Column(2).Margins(0,0,32,0).FontSize(20).End().CenterVertical(),
                    new Label()
                    {
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        FormattedText = new FormattedString()
                        {
                            Spans =
                            {
                                new Span()
                                {
                                    TextColor = Color.FromArgb("#FFFFFF"),
                                    Text = "Use your voucher code & Get 25% off now. Follow us on Instagram &",
                                    FontFamily = "JosefinSansRegular",
                                    LineHeight = 1.4,
                                },
                                new Span()
                                {
                                    TextColor = Color.FromArgb("#000000"),
                                    Text = " Get your offer voucher code from here !!!",
                                    FontFamily = "JosefinSansRegular",
                                    LineHeight = 1.4,
                                },
                            },
                        },
                    }.Margin(32,0).ColumnSpan(3).Row(2).FontSize(16).CenterHorizontal().CenterVertical().TextCenterHorizontal(),
                    new BoxView()
                    {
                        BackgroundColor = Color.FromArgb("#ffffff"),
                    }.Row(0).ColumnSpan(3).RowSpan(4).Margins(0,0,0,-40).Height(40).Bottom(),
                    new Grid()
                    {
                        Children =
                        {
                            new Path()
                            {
                                Fill = Color.FromArgb("#FFFFFF"),
                                Aspect = Stretch.UniformToFill,
                                Data = (Geometry)new PathGeometryConverter().ConvertFromInvariantString("M615.59,178.35c-86.88,0-129.26-89.18-129.26-89.18S435.14,14,375,14,263.63,89.17,263.63,89.17s-42.2,89.18-129.26,89.18S0,0,0,0V200H750V0S702.61,178.35,615.59,178.35Z"),
                            }.Fill(),
                        },
                    }.Row(3).ColumnSpan(3),
                    new CarouselView()
                    {
                        PeekAreaInsets = new Thickness(32,0,96,0),
                        HorizontalScrollBarVisibility = ScrollBarVisibility.Never,
                        ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Horizontal)
                        {
                            ItemSpacing = 24,
                        },
                        ItemTemplate = new DataTemplate(() =>
                        {
                            return new Frame()
                            {
                                HasShadow = false,
                                IsClippedToBounds = true,
                                CornerRadius = 20,
                                BackgroundColor = AppResource<Color>("white"),
                                Content = new Grid()
                                {
                                    RowSpacing = 16,
                                    RowDefinitions = Rows.Define(Star,48,48,48),
                                    ColumnDefinitions = Columns.Define(Star,Star),
                                    Children =
                                    {
                                        new Image()
                                        {
                                            Aspect = Aspect.AspectFill,
                                            GestureRecognizers =
                                            {
                                                new TapGestureRecognizer().Invoke(x => x.Tapped += Image_Tapped),
                                            },
                                        }.Margins(-24,-24,-24,0).ColumnSpan(2).Bind("Image"),
                                        new Label()
                                        {
                                            Style = AppResource<Style>("product_title"),
                                        }.ColumnSpan(2).Row(1).Bind("Title"),
                                        new Label()
                                        {
                                            FontFamily = "JosefinSansBold",
                                            TextColor = AppResource<Color>("green"),
                                        }.Row(2).FontSize(40).Bind("Price", stringFormat: "${0}"),
                                        new Stepper().Row(2).Column(1).Width(120).Start(),
                                        new Button()
                                        {
                                            Text = "Add To Cart",
                                            BackgroundColor = AppResource<Color>("brown"),
                                            TextColor = AppResource<Color>("white"),
                                            FontFamily = "JosefinSansBold",
                                        }.Row(3).ColumnSpan(2).FontSize(18),
                                    },
                                },
                            }.Padding(20);
                        }),
                    }.Row(1).ColumnSpan(3).Bind(CarouselView.ItemsSourceProperty, Binding.SelfPath),
                    new Button()
                    {
                        FontFamily = "Icons",
                        BackgroundColor = Color.FromArgb("#FFFFFF"),
                        TextColor = AppResource<Color>("green"),
                        Text = Icons.IconCoffeeBeans,
                        CornerRadius = 24,
                    }.Row(3).Margins(20,0,0,0).Height(48).Width(48).FontSize(20).Column(0).Center(),
                    new Button()
                    {
                        FontFamily = "Icons",
                        BackgroundColor = Color.FromArgb("#FFFFFF"),
                        TextColor = AppResource<Color>("green"),
                        Text = Icons.IconPaw,
                        CornerRadius = 32,
                    }.Row(3).Height(64).Width(64).FontSize(24).Column(1).Center(),
                    new Button()
                    {
                        FontFamily = "Icons",
                        BackgroundColor = Color.FromArgb("#FFFFFF"),
                        TextColor = AppResource<Color>("green"),
                        Text = Icons.IconBuyMeACoffee,
                        CornerRadius = 24,
                    }.Row(3).Margins(0,0,20,0).Height(48).Width(48).FontSize(20).Column(2).Center(),
                }
            };
        }
    }
}

