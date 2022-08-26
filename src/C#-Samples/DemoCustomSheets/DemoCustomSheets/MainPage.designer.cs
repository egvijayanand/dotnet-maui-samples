namespace DemoCustomSheets
{
    public partial class MainPage : ContentPage
    {
        private void InitializeComponent()
        {
            Title = "Demo Custom Sheets";
            Content = new Grid()
            {
                Children =
                {
                    new VerticalStackLayout()
                    {
                        Spacing = 16,
                        Children =
                        {
                            new Button()
                            {
                                Text = "Defalut Sheet",
                            }.Invoke(btn => btn.Clicked += Button_Clicked),
                            new Button()
                            {
                                Text = "Question",
                            }.Invoke(btn => btn.Clicked += Button_Clicked_9),
                            new Button()
                            {
                                Text = "Changing height and width",
                            }.Invoke(btn => btn.Clicked += Button_Clicked_1),
                            new Button()
                            {
                                Text = "Close removed",
                            }.Invoke(btn => btn.Clicked += Button_Clicked_2),
                            new Button()
                            {
                                Text = "when back button pressed",
                            }.Invoke(btn => btn.Clicked += Button_Clicked_3),
                            new Button()
                            {
                                Text = "Sheet Background Color",
                            }.Invoke(btn => btn.Clicked += Button_Clicked_7),
                            new Button()
                            {
                                Text = "Remove Round Rectangle",
                            }.Invoke(btn => btn.Clicked += Button_Clicked_5),
                            new Button()
                            {
                                Text = "Sheet Background",
                            }.Invoke(btn => btn.Clicked += Button_Clicked_6),
                            new Button()
                            {
                                Text = "Backgrounck click to close",
                            }.Invoke(btn => btn.Clicked += Button_Clicked_4),
                        },
                    }.Margin(32,0).CenterVertical(),
                    new Sheet()
                    {
                        SheetContent =
                        {
                            new StackLayout()
                            {
                                Children =
                                {
                                    new Label()
                                    {
                                        Text = "Hello Developers",
                                    }.FontSize(NamedSize.Title).CenterHorizontal(),
                                    new Image()
                                    {
                                        Source = "dotnet_bot.png",
                                        VerticalOptions = LayoutOptions.CenterAndExpand,
                                    }.Height(200).CenterHorizontal().CenterVertical().SemanticDesc("Cute dot net bot waving hi to you!"),
                                },
                            },
                        },
                    }.Assign(out DefaultSheet),
                    new Sheet()
                    {
                        SheetContent =
                        {
                            new Label()
                            {
                                HorizontalOptions = LayoutOptions.CenterAndExpand,
                                VerticalOptions = LayoutOptions.CenterAndExpand,
                                Text = "Payment Sucess ! ",
                                FontAttributes = FontAttributes.Italic,
                                TextColor = ForestGreen,
                            }.FontSize(NamedSize.Title),
                        },
                    }.Assign(out CommonSheet),
                    new Sheet()
                    {
                        IsCloseButtonVisible = false,
                        SheetBackgroundColor = Transparent,
                        SheetContent =
                        {
                            new StackLayout()
                            {
                                Children =
                                {
                                    new ScrollView()
                                    {
                                        IsVisible = false,
                                        Content = new CollectionView()
                                        {
                                            ItemTemplate = new DataTemplate(() =>
                                            {
                                                return new Frame()
                                                {
                                                    BackgroundColor = White,
                                                    CornerRadius = 20,
                                                    HasShadow = true,
                                                    Content = new StackLayout()
                                                    {
                                                        Orientation = StackOrientation.Horizontal,
                                                        Children =
                                                        {
                                                            new Frame()
                                                            {
                                                                BorderColor = Blue,
                                                                CornerRadius = 100,
                                                                Content = new ImageButton()
                                                                {
                                                                    Aspect = Aspect.AspectFill,
                                                                }.Height(60).Width(60).Bind(ImageButton.SourceProperty, "Image"),
                                                            }.Padding(0),
                                                            new StackLayout()
                                                            {
                                                                Children =
                                                                {
                                                                    new Label()
                                                                    {
                                                                        FontAttributes = FontAttributes.Bold,
                                                                    }.FontSize(NamedSize.Body).Bind("Name"),
                                                                    new Label().FontSize(NamedSize.Caption).Bind("Location"),
                                                                },
                                                            }.CenterVertical(),
                                                            new ImageButton()
                                                            {
                                                                BackgroundColor = Transparent,
                                                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                                                Source = "maps.jpg",
                                                            }.Height(30).Width(30).Bind(ImageButton.IsVisibleProperty, "ButtonEnabel"),
                                                        },
                                                    },
                                                }.Padding(15).Margin(10,5);
                                            }),
                                        }.Assign(out ApiListViewName),
                                    }.Assign(out Listbutton),
                                    new Button()
                                    {
                                        IsVisible = false,
                                        Text = "Close",
                                    }.Width(100).Height(45).Margin(10).Assign(out MonkeyButton).Invoke(btn => btn.Clicked += SheetClose),
                                    new ActivityIndicator()
                                    {
                                        IsRunning = true,
                                        Color = Blue,
                                    }.CenterVertical().Assign(out incdicate),
                                },
                            },
                        },
                    }.Assign(out CloseRemoved),
                    new Sheet()
                    {
                        SheetContent =
                        {
                            new StackLayout()
                            {
                                Children =
                                {
                                    new Label()
                                    {
                                        Text = "hello",
                                    },
                                    new Image()
                                    {
                                        Source = "dotnet_bot.png",
                                    }.Height(200).CenterHorizontal().SemanticDesc("Cute dot net bot waving hi to you!"),
                                    new Button()
                                    {
                                        Text = "close",
                                    }.Invoke(btn => btn.Clicked += SheetClose),
                                },
                            },
                        },
                        SheetBackground = new LinearGradientBrush()
                        {
                            GradientStops =
                            {
                                new GradientStop()
                                {
                                    Color = Color.FromArgb("#ff6600"),
                                    Offset = 0.0f,
                                },
                                new GradientStop()
                                {
                                    Color = Color.FromArgb("#36D1DC"),
                                    Offset = 0.6f,
                                },
                                new GradientStop()
                                {
                                    Color = Color.FromArgb("#cc5233"),
                                    Offset = 1.0f,
                                },
                            },
                        },
                    }.Assign(out sheetview),
                    new Sheet()
                    {
                        IsCloseButtonVisible = false,
                        SheetHeight = 280,
                        RoundRectangleFill = Gray,
                        ForButtomLayout =
                        {
                            new Button()
                            {
                                Text = "Skip",
                                BackgroundColor = Transparent,
                                TextColor = White,
                                BorderWidth = 0,
                            }.End().Invoke(btn => btn.Clicked += Button_Clicked_8),
                        },
                        SheetContent =
                        {
                            new StackLayout()
                            {
                                Spacing = 16,
                                Children =
                                {
                                    new Label()
                                    {
                                        Text = "Which social media you use most?",
                                    },
                                    new Frame()
                                    {
                                        BorderColor = LightGray,
                                        CornerRadius = 10,
                                        Content = new RadioButton()
                                        {
                                            GroupName = "Question",
                                            Content = "Facebook",
                                        },
                                    }.Height(40).Margins(5,0,5,0).Padding(0),
                                    new Frame()
                                    {
                                        BorderColor = LightGray,
                                        CornerRadius = 10,
                                        Content = new RadioButton()
                                        {
                                            GroupName = "Question",
                                            Content = "Insta",
                                        },
                                    }.Height(40).Margins(5,0,5,0).Padding(0),
                                    new Frame()
                                    {
                                        BorderColor = LightGray,
                                        CornerRadius = 10,
                                        Content = new RadioButton()
                                        {
                                            GroupName = "Question",
                                            Content = "WhatsApp",
                                        },
                                    }.Height(40).Margins(5,0,5,0).Padding(0),
                                    new Button()
                                    {
                                        Text = "Submit",
                                    }.Invoke(btn => btn.Clicked += Button_Clicked_8),
                                },
                            }.Padding(5),
                        },
                    }.Assign(out RadioButtons),
                }
            };
        }

        #region Variables
        private Sheet DefaultSheet;
        private Sheet CommonSheet;
        private Sheet CloseRemoved;
        private ScrollView Listbutton;
        private CollectionView ApiListViewName;
        private Button MonkeyButton;
        private ActivityIndicator incdicate;
        private Sheet sheetview;
        private Sheet RadioButtons;
        #endregion
    }
}

