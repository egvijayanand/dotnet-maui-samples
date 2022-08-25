using Coffeeffee_MAUI.Controls;
using Coffeeffee_MAUI.Styles;
using Microsoft.Maui.Controls.Shapes;

namespace Coffeeffee_MAUI
{
    public partial class DetailPage : ContentPage
    {
        private void InitializeComponent()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            Content = new Grid()
            {
                ColumnDefinitions = Columns.Define(Star,Star,Star),
                RowDefinitions = Rows.Define(120,280,Star,100),
                Children =
                {
                    new Frame()
                    {
                        HasShadow = false,
                        CornerRadius = 40,
                        Content = new Image()
                        {
                            Aspect = Aspect.AspectFill,
                        }.Height(400).Bind("Image"),
                    }.Row(0).RowSpan(2).ColumnSpan(3).Padding(0).Margins(0,-100,0,0),
                    new Button()
                    {
                        BackgroundColor = AppResource<Color>("white"),
                        FontFamily = "Icons",
                        CornerRadius = 8,
                        Text = Icons.IconBack,
                        TextColor = AppResource<Color>("green"),
                    }.ColumnSpan(3).Height(52).Width(52).Margins(32,0,0,0).FontSize(20).Start().CenterVertical().Invoke(btn => btn.Clicked += Back_Clicked),
                    new ScrollView()
                    {
                        Content = new Grid()
                        {
                            ColumnSpacing = 12,
                            RowDefinitions = Rows.Define(48,Auto,Auto,Star),
                            ColumnDefinitions = Columns.Define(120,Star),
                            Children =
                            {
                                new Label()
                                {
                                    Style = AppResource<Style>("product_title_large"),
                                }.ColumnSpan(2).Row(0).Bind("Title"),
                                new Label()
                                {
                                    Style = AppResource<Style>("product_subtitle"),
                                }.ColumnSpan(2).Row(1).Margins(0,0,0,24).Bind("Subtitle"),
                                new Label()
                                {
                                    FontFamily = "JosefinSans-Bold",
                                    TextColor = AppResource<Color>("green"),
                                }.Column(0).Row(2).FontSize(40).Bind("Price", stringFormat: "${0}"),
                                new Stepper().Row(2).Column(1).Width(120).Margins(0,0,0,24).Start(),
                                new Label()
                                {
                                    FontFamily = "JosefinSans-Regular",
                                    LineHeight = 1.2,
                                }.Row(3).ColumnSpan(2).FontSize(16).Bind("Description"),
                            },
                        }.Padding(40,32),
                    }.Row(2).ColumnSpan(3),
                    new BoxView()
                    {
                        BackgroundColor = AppResource<Color>("green"),
                    }.Row(0).ColumnSpan(3).RowSpan(4).Margins(0,0,0,-40).Height(40).Bottom(),
                    new Grid()
                    {
                        Children =
                        {
                            new Path()
                            {
                                Fill = AppResource<Color>("green"),
                                Aspect = Stretch.UniformToFill,
                                Data = (Geometry)new PathGeometryConverter().ConvertFromInvariantString("M615.59,178.35c-86.88,0-129.26-89.18-129.26-89.18S435.14,14,375,14,263.63,89.17,263.63,89.17s-42.2,89.18-129.26,89.18S0,0,0,0V200H750V0S702.61,178.35,615.59,178.35Z"),
                            }.Fill(),
                        },
                    }.Row(3).ColumnSpan(3),
                    new Button()
                    {
                        FontFamily = "Icons",
                        BackgroundColor = AppResource<Color>("green"),
                        TextColor = AppResource<Color>("white"),
                        Text = Icons.IconCoffeeBeans,
                        CornerRadius = 24,
                    }.Row(3).Margins(20,0,0,0).Height(48).Width(48).FontSize(20).Column(0).Center(),
                    new Button()
                    {
                        FontFamily = "Icons",
                        BackgroundColor = AppResource<Color>("white"),
                        TextColor = AppResource<Color>("green"),
                        Text = Icons.IconPaw,
                        CornerRadius = 32,
                    }.Row(3).Height(64).Width(64).FontSize(24).Column(1).Center(),
                    new Button()
                    {
                        FontFamily = "Icons",
                        BackgroundColor = AppResource<Color>("green"),
                        TextColor = AppResource<Color>("white"),
                        Text = Icons.IconBuyMeACoffee,
                        CornerRadius = 24,
                    }.Row(3).Margins(0,0,20,0).Height(48).Width(48).FontSize(20).Column(2).Center(),
                }
            };
        }
    }
}

