namespace BeautyShopApp.Views.Templates
{
    public partial class ProductItemTemplate : ContentView
    {
        private void InitializeComponent()
        {
            VariableSizedWrapGrid.SetRowSpan(this, 3);
            Resources.Add("ProductContainerStyle", new Style(typeof(Frame))
            {
                Setters =
                {
                    new() { Property = MauiFrame.HeightRequestProperty, Value = 290 },
                    new() { Property = MauiFrame.CornerRadiusProperty, Value = 24 },
                    new() { Property = MauiFrame.HasShadowProperty, Value = false },
                    new() { Property = MauiFrame.PaddingProperty, Value = Thickness.Zero },
                    new() { Property = MauiFrame.HorizontalOptionsProperty, Value = LayoutOptions.Start },
                    new() { Property = MauiFrame.VerticalOptionsProperty, Value = LayoutOptions.Start },
                    new() { Property = MauiFrame.MarginProperty, Value = new Thickness(10) },
                },
            });
            Resources.Add("ProductImageStyle", new Style(typeof(Image))
            {
                Setters =
                {
                    new() { Property = Image.AspectProperty, Value = "AspectFill" },
                },
            });
            Resources.Add("ProductNameTextStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.TextColorProperty, Value = Black },
                    new() { Property = Label.FontSizeProperty, Value = 12 },
                    new() { Property = Label.FontFamilyProperty, Value = "Fallingsky" },
                    new() { Property = Label.FontAttributesProperty, Value = FontAttributes.Bold },
                    new() { Property = Label.MarginProperty, Value = new Thickness(12, 0) },
                },
            });
            Resources.Add("ProductDescriptionTextStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 12 },
                    new() { Property = Label.FontFamilyProperty, Value = "Fallingsky" },
                    new() { Property = Label.MarginProperty, Value = new Thickness(12, 0) },
                },
            });
            Resources.Add("ProductPriceTextStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.TextColorProperty, Value = Black },
                    new() { Property = Label.FontSizeProperty, Value = 16 },
                    new() { Property = Label.FontFamilyProperty, Value = "Fallingsky" },
                    new() { Property = Label.FontAttributesProperty, Value = FontAttributes.Bold },
                    new() { Property = Label.VerticalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Label.MarginProperty, Value = new Thickness(12, 0, 0, 12) },
                },
            });
            Resources.Add("ProductRatingContainerStyle", new Style(typeof(Frame))
            {
                Setters =
                {
                    new() { Property = MauiFrame.HeightRequestProperty, Value = 36 },
                    new() { Property = MauiFrame.WidthRequestProperty, Value = 36 },
                    new() { Property = MauiFrame.CornerRadiusProperty, Value = 24 },
                    new() { Property = MauiFrame.HasShadowProperty, Value = true },
                    new() { Property = MauiFrame.HorizontalOptionsProperty, Value = LayoutOptions.End },
                    new() { Property = MauiFrame.VerticalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = MauiFrame.PaddingProperty, Value = new Thickness(6) },
                    new() { Property = MauiFrame.MarginProperty, Value = new Thickness(0, 0, 12, 12) },
                },
            });
            Content = new Frame()
            {
                Style = (Style)Resources["ProductContainerStyle"],
                Content = new Grid()
                {
                    RowDefinitions = Rows.Define(Star, 36, 48),
                    Children =
                    {
                        new Image()
                        {
                            Style = (Style)Resources["ProductImageStyle"],
                        }.Bind("Image"),
                        new StackLayout()
                        {
                            Children =
                            {
                                new Label()
                                {
                                    Style = (Style)Resources["ProductNameTextStyle"],
                                }.Bind("Name"),
                                new Label()
                                {
                                    Style = (Style)Resources["ProductDescriptionTextStyle"],
                                }.Bind("Description"),
                            },
                        }.Row(1),
                        new Grid()
                        {
                            ColumnDefinitions = Columns.Define(Star, Auto),
                            Children =
                            {
                                new Label()
                                {
                                    Style = (Style)Resources["ProductPriceTextStyle"],
                                }.Bind("Price", stringFormat: "$ {0:F2}"),
                                new Frame()
                                {
                                    BackgroundColor = Black,
                                    Style = (Style)Resources["ProductRatingContainerStyle"],
                                    Content = new Image()
                                    {
                                        Source = "heart.png",
                                    },
                                },
                            },
                        }.Row(2),
                    }
                }
            };
        }
    }
}

