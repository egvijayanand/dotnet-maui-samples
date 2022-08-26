namespace Learn.MauiPaymentUi.Views
{
    public partial class PaymentView : ContentPage
    {
        private void InitializeComponent()
        {
            SetBinding(TitleProperty, new Binding(nameof(PaymentViewModel.Title)));
            NavigationPage.SetTitleView(this, new Grid()
            {
                Background = AppResource<SolidColorBrush>("PrimaryBrush"),
                Children =
                {
                    new Label()
                    {
                        Text = "Payment",
                        //HorizontalOptions = LayoutOptions.CenterAndExpand,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = AppResource<Color>("White"),
                    }.FontSize(17).Center()
                }
            });
            Content = new ScrollView()
            {
                Content = new Grid()
                {
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    ColumnSpacing = 20,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    RowDefinitions = Rows.Define(Auto, Auto, Auto, Auto, Auto, Auto, Auto),
                    ColumnDefinitions = Columns.Define(Auto, Stars(5), Stars(5)),
                    Children =
                    {
                        new CreditCardView().Row(0).Column(0).ColumnSpan(3),
                        new Frame()
                        {
                            HasShadow = false,
                            BorderColor = AppResource<Color>("LightColor"),
                            Content = new StackLayout()
                            {
                                Orientation = StackOrientation.Horizontal,
                                Spacing = 20,
                                Children =
                                {
                                    new Image().Height(30).Bind(nameof(PaymentViewModel.CardNumber), converter: (IValueConverter)AppResource("CardConverter")),
                                    new Entry()
                                    {
                                        HorizontalOptions = LayoutOptions.FillAndExpand,
                                        Keyboard = Keyboard.Numeric,
                                        //Visual = VisualMarker.Custom,
                                        Behaviors =
                                        {
                                            new FastEntryBehavior()
                                            {
                                                Mask = "####-####-####-####",
                                                MaxLength = 19,
                                            },
                                        },
                                    }.Bind(nameof(PaymentViewModel.CardNumber), BindingMode.TwoWay),
                                },
                            },
                        }.Padding(10).Margins(30,30,30,10).Row(1).Column(0).ColumnSpan(3),
                        new Frame()
                        {
                            HasShadow = false,
                            BorderColor = AppResource<Color>("LightColor"),
                            Content = new StackLayout()
                            {
                                Orientation = StackOrientation.Horizontal,
                                Children =
                                {
                                    new Image()
                                    {
                                        Source = "icon_date.png",
                                    }.Height(25),
                                    new Entry()
                                    {
                                        HorizontalOptions = LayoutOptions.FillAndExpand,
                                        Keyboard = Keyboard.Numeric,
                                        //Visual = VisualMarker.Custom,
                                        Behaviors =
                                        {
                                            new FastEntryBehavior()
                                            {
                                                Mask = "##/##",
                                                MaxLength = 5,
                                            },
                                        },
                                    }.Bind(nameof(PaymentViewModel.CardExpirationDate)),
                                },
                            },
                        }.Padding(10).Margins(30,0,0,0).Row(2).Column(0).ColumnSpan(2),
                        new Frame()
                        {
                            HasShadow = false,
                            BorderColor = AppResource<Color>("LightColor"),
                            Content = new StackLayout()
                            {
                                Orientation = StackOrientation.Horizontal,
                                Children =
                                {
                                    new Image()
                                    {
                                        Source = "icon_cvv.png",
                                    }.Height(25),
                                    new Entry()
                                    {
                                        HorizontalOptions = LayoutOptions.FillAndExpand,
                                        Keyboard = Keyboard.Numeric,
                                        IsPassword = true,
                                        //Visual = VisualMarker.Custom,
                                        Behaviors =
                                        {
                                            new FastEntryBehavior()
                                            {
                                                Mask = "###",
                                                MaxLength = 3,
                                            },
                                        },
                                    }.Bind(nameof(PaymentViewModel.CardCvv)),
                                },
                            },
                        }.Padding(10).Margins(0,0,30,0).Row(2).Column(2),
                        new CheckBox()
                        {
                            Color = LightGray,
                            //Visual = VisualMarker.Material,
                        }.Width(30).Margins(30,0,0,0).Row(3).Column(0).Start(),
                        new Label()
                        {
                            Text = "Remember me",
                            TextColor = AppResource<Color>("PrimaryDark"),
                        }.FontSize(16).Row(3).Column(1).ColumnSpan(2).CenterVertical(),
                        new Button()
                        {
                            Text = "or Pay with Paypal",
                            BackgroundColor = White,
                            BorderColor = AppResource<Color>("LightColor"),
                            TextColor = AppResource<Color>("PrimaryDark"),
                            BorderWidth = 1,
                            CornerRadius = 25,
                        }.Row(4).Column(0).ColumnSpan(3).FontSize(18).Padding(18).Margin(30,0),
                        new BoxView()
                        {
                            HorizontalOptions = LayoutOptions.FillAndExpand,
                            Color = AppResource<Color>("Secondary"),
                            Visual = VisualMarker.Default,
                        }.Height(1).Margin(0,30).Row(5).Column(0).ColumnSpan(3),
                        new Button()
                        {
                            CornerRadius = 26,
                            TextColor = White,
                        }.FontSize(18).Row(6).Column(0).ColumnSpan(3).Padding(18).Margins(30,0,30,30).Bind(Button.TextProperty, nameof(PaymentViewModel.PurchaseText)).Bind(Button.BackgroundColorProperty, nameof(PaymentViewModel.CardNumber), converter: (IValueConverter)AppResource("CardColorConverter")).Bind(nameof(PaymentViewModel.CmdPurchase)),
                    }
                }
            };
        }
    }
}

