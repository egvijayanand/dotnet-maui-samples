namespace MAUIPETS.Views
{
    public partial class DonatePage : ContentPage
    {
        private void InitializeComponent()
        {
            Title = "Please Donate";
            Content = new Grid()
            {
                ColumnDefinitions = Columns.Define(Stars(.05), Stars(.9), Stars(.05)),
                RowDefinitions = Rows.Define(60, 60, 300, 30, 50, 50, 50),
                Children =
                {
                    new Label()
                    {
                        TextColor = Black,
                        TranslationY = 20,
                        FormattedText = new FormattedString()
                        {
                            Spans =
                            {
                                new Span()
                                {
                                    Text = "Save a life ",
                                },
                                new Span()
                                {
                                    FontFamily = "fontello",
                                    Text = "\xF1B0",
                                }.FontSize(32),
                                new Span()
                                {
                                    FontFamily = "fontello",
                                    Text = " ",
                                }.FontSize(32),
                            },
                        },
                    }.Column(1).FontSize(30).TextStart(),
                    new Label()
                    {
                        Text = "Donate today.",
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
                            Source = "dog2.png",
                        }.Height(60).CenterHorizontal().Assign(out Imagedog),
                    }.Row(2).Column(1),
                    new StackLayout()
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            new Button()
                            {
                                BackgroundColor = Color.FromArgb("#FFC300"),
                                BorderColor = DarkOrange,
                                BorderWidth = 3,
                                CornerRadius = 10,
                                FontAttributes = FontAttributes.Bold,
                                Text = "$25",
                                TextColor = White,
                            }.Margin(5).Assign(out donate25).Invoke(btn => btn.Clicked += donate25_Clicked),
                            new Button()
                            {
                                BackgroundColor = Color.FromArgb("#FFC300"),
                                BorderColor = DarkOrange,
                                BorderWidth = 3,
                                CornerRadius = 10,
                                FontAttributes = FontAttributes.Bold,
                                Text = "$50",
                                TextColor = White,
                            }.Margin(5).Assign(out donate50).Invoke(btn => btn.Clicked += donate50_Clicked),
                            new Button()
                            {
                                BackgroundColor = Color.FromArgb("#FFC300"),
                                BorderColor = DarkOrange,
                                BorderWidth = 3,
                                CornerRadius = 10,
                                FontAttributes = FontAttributes.Bold,
                                Text = "$100",
                                TextColor = White,
                            }.Margin(5).Assign(out donate100).Invoke(btn => btn.Clicked += donate100_Clicked),
                        },
                    }.Row(4).Column(1).CenterHorizontal(),
                    new Label()
                    {
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        Text = "Thanks for your support ",
                    }.Row(5).Column(1).Assign(out labelDonate),
                    new Button()
                    {
                        BackgroundColor = Orange,
                        BorderColor = OrangeRed,
                        CornerRadius = 20,
                        FontAttributes = FontAttributes.Bold,
                        Text = "Please Donate",
                        TextColor = White,
                        Shadow = new Shadow()
                        {
                            Brush = Black,
                            Opacity = 0.8f,
                            Offset = new Point(6, 10),
                        },
                    }.Row(6).Column(1).Assign(out Donate).Invoke(btn => btn.Clicked += Donate_Clicked),
                }
            };
        }

        #region Variables
        private Image Imagedog;
        private Button donate25;
        private Button donate50;
        private Button donate100;
        private Label labelDonate;
        private Button Donate;
        #endregion
    }
}

