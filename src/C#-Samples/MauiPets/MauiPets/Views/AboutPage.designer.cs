namespace MAUIPETS.Views
{
    public partial class AboutPage : ContentPage
    {
        private void InitializeComponent()
        {
            ViewModel = new AboutViewModel();
            SetBinding(TitleProperty, new Binding(nameof(AboutViewModel.Title)));
            BackgroundColor = AppResource<Color>("Secondary");
            Content = new VerticalStackLayout()
            {
                Children =
                {
                    new Grid()
                    {
                        Children =
                        {
                            new Grid()
                            {
                                ColumnDefinitions = Columns.Define(Stars(0.2), Auto, Stars(0.2)),
                                RowDefinitions = Rows.Define(200, 300, 150),
                                Children =
                                {
                                    new Image()
                                    {
                                        Source = "dotnet_bot.png",
                                    }.Row(0).Column(1).Width(80),
                                    new Frame()
                                    {
                                        BackgroundColor = Black,
                                        BorderColor = OrangeRed,
                                        CornerRadius = 20,
                                        HasShadow = true,
                                        Shadow = new Shadow()
                                        {
                                            Brush = Black,
                                            Opacity = 0.9f,
                                            Offset = new Point(20, 20),
                                        },
                                        Content = new StackLayout()
                                        {
                                            Children =
                                            {
                                                new Label()
                                                {
                                                    FontAttributes = FontAttributes.Bold,
                                                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                                                    Text = "MAUIPETS",
                                                    TextColor = White,
                                                }.FontSize(40),
                                                new Label()
                                                {
                                                    FontAttributes = FontAttributes.Bold,
                                                    Text = "By Luis Bryan Oroxón Ramírez ",
                                                    TextColor = White,
                                                },
                                                new Label()
                                                {
                                                    TextColor = White,
                                                    FormattedText = new FormattedString()
                                                    {
                                                        Spans =
                                                        {
                                                            new Span()
                                                            {
                                                                FontFamily = "fontello",
                                                                Text = "\xF309",
                                                                TextColor = Color.FromArgb("#1dcaff"),
                                                            }.FontSize(20),
                                                            new Span()
                                                            {
                                                                FontAttributes = FontAttributes.Bold,
                                                                Text = " @BryanOroxon",
                                                                TextColor = White,
                                                            }.FontSize(16),
                                                        },
                                                    },
                                                }.FontSize(40),
                                                new Label()
                                                {
                                                    TextColor = White,
                                                    FormattedText = new FormattedString()
                                                    {
                                                        Spans =
                                                        {
                                                            new Span()
                                                            {
                                                                FontFamily = "fontello",
                                                                Text = "\xF318",
                                                                TextColor = Color.FromArgb("#00a0dc"),
                                                            }.FontSize(20),
                                                            new Span()
                                                            {
                                                                FontAttributes = FontAttributes.Bold,
                                                                Text = " www.linkedin.com/in/bryan-oroxon",
                                                                TextColor = White,
                                                            }.FontSize(16),
                                                        },
                                                    },
                                                }.FontSize(40),
                                                new Label()
                                                {
                                                    FontAttributes = FontAttributes.Bold,
                                                    Text = "",
                                                    TextColor = Color.FromArgb("#1dcaff"),
                                                }.FontSize(NamedSize.Medium).Assign(out LabelName),
                                                new Label()
                                                {
                                                    FontAttributes = FontAttributes.Bold,
                                                    Text = " 0 ",
                                                    TextColor = Color.FromArgb("#00a0dc"),
                                                }.Assign(out LabelVersion),
                                                new Label()
                                                {
                                                    Text = "This App was made for .NET MAUI CHALLENGE",
                                                    TextColor = White,
                                                },
                                            },
                                        }.CenterVertical(),
                                    }.Row(1).Column(1).Margins(15,5,15,5),
                                    new Button()
                                    {
                                        BackgroundColor = Orange,
                                        CornerRadius = 20,
                                        FontAttributes = FontAttributes.Bold,
                                        Text = "To learn more about .NET MAUI, press here",
                                        TextColor = White,
                                        Shadow = new Shadow()
                                        {
                                            Brush = Black,
                                            Opacity = 0.8f,
                                            Offset = new Point(6, 10),
                                        },
                                    }.Row(2).Column(1).Margin(15).FontSize(NamedSize.Medium).Height(60).Bind(nameof(AboutViewModel.OpenWebCommand)),
                                },
                            },
                        },
                    },
                }
            };

            BindingContext = ViewModel;
        }

        public AboutViewModel ViewModel { get; private set; }

        #region Variables
        private Label LabelName;
        private Label LabelVersion;
        #endregion
    }
}

