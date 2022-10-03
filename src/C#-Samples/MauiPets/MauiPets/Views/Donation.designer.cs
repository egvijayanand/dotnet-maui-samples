namespace MAUIPETS.Views
{
    public partial class Donation : ContentPage
    {
        private void InitializeComponent()
        {
            Title = "Thanks for donating";
            Shell.SetTabBarIsVisible(this, false);
            Content = new Grid()
            {
                ColumnDefinitions = Columns.Define(Stars(.05), Stars(.9), Stars(.05)),
                RowDefinitions = Rows.Define(40, 70, 250, 30, 50, 50, 50),
                Children =
                {
                    new StackLayout()
                    {
                        Orientation = StackOrientation.Horizontal,
                        TranslationY = 20,
                        Children =
                        {
                            new Label()
                            {
                                Text = "High five! ",
                                TextColor = Black,
                            }.FontSize(30).Start().Bottom(),
                            new Label()
                            {
                                FontFamily = "fontello",
                                Text = " ",
                                TextColor = Black,
                            }.FontSize(30),
                            new Label()
                            {
                                FontFamily = "fontello",
                                Text = "\xF1B0",
                                TextColor = Black,
                            }.FontSize(30),
                        },
                    }.Column(1),
                    new Label()
                    {
                        Text = "Well Done",
                        TextColor = Black,
                        TranslationY = 10,
                    }.Row(1).Column(1).FontSize(30).Start().Top(),
                    new Frame()
                    {
                        BackgroundColor = Color.FromArgb("#9EFADC"),
                        BorderColor = Color.FromArgb("#89E2FA"),
                        CornerRadius = 20,
                        HasShadow = true,
                        Shadow = new Shadow()
                        {
                            Brush = Black,
                            Opacity = 0.8f,
                            Offset = new Point(6, 10),
                        },
                        Content = new Image()
                        {
                            Source = "dog3.png",
                        }.Height(100).CenterHorizontal().Bottom(),
                    }.Row(2).Column(1).Margins(10,50,10,10),
                    new Label()
                    {
                        FontAttributes = FontAttributes.Italic,
                        Text = "You just donate!!!",
                        TextColor = Black,
                    }.Row(4).Column(1).FontSize(NamedSize.Title).CenterHorizontal(),
                    new Label()
                    {
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        Text = "Thanks for your support, our dear pets can sleep tight!",
                    }.Row(5).Column(1).FontSize(20),
                }
            };
        }
    }
}

