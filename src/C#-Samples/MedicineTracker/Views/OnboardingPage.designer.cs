namespace UIMock
{
    public partial class OnboardingPage : ContentPage
    {
        private void InitializeComponent()
        {
            Title = "OnboardingPage";
            NavigationPage.SetHasNavigationBar(this, false);
            BackgroundColor = Color.FromArgb("#7d87f1");
            Content = new Grid()
            {
                RowDefinitions = Rows.Define(Auto, Auto, Star),
                Children =
                {
                    new VerticalStackLayout()
                    {
                        Children =
                        {
                            new Label()
                            {
                                Text = "Ensure to keep",
                                TextColor = White,
                                FontAttributes = FontAttributes.Bold,
                                FontFamily = "LatoRegular",
                            }.FontSize(28).Margins(0,0,0,10).Start().CenterVertical(),
                            new Label()
                            {
                                Text = "track of your",
                                TextColor = White,
                                FontAttributes = FontAttributes.Bold,
                                FontFamily = "LatoRegular",
                            }.FontSize(28).Margins(0,0,0,10).Start().CenterVertical(),
                            new Label()
                            {
                                Text = "medicine",
                                TextColor = White,
                                FontAttributes = FontAttributes.Bold,
                                FontFamily = "LatoRegular",
                            }.FontSize(28).Margins(0,0,0,10).Start().CenterVertical(),
                        },
                    }.Row(0),
                    new IndicatorView()
                    {
                        IndicatorColor = DimGray,
                        IndicatorsShape = IndicatorShape.Circle,
                        IndicatorSize = 8,
                        SelectedIndicatorColor = LightGray,
                    }.Row(1).Margins(4,10,0,0).Start().Bottom().Assign(out indicatorView),
                    new CarouselView()
                    {
                        IndicatorView = indicatorView,
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        VerticalOptions = LayoutOptions.EndAndExpand,
                        HorizontalScrollBarVisibility = ScrollBarVisibility.Never,
                        HeightRequest = DeviceInfo.Idiom.ToString() switch
                        {
                            nameof(DeviceIdiom.Phone) => 320d,
                            nameof(DeviceIdiom.Tablet) => 320d,
                        },
                        ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Horizontal)
                        {
                            SnapPointsType = SnapPointsType.MandatorySingle,
                        },
                        ItemTemplate = new DataTemplate(() =>
                        {
                            return new Image()
                            {
                                HorizontalOptions = LayoutOptions.FillAndExpand,
                                VerticalOptions = LayoutOptions.FillAndExpand,
                                Aspect = DeviceInfo.Idiom.ToString() switch
                                {
                                    nameof(DeviceIdiom.Phone) => Aspect.AspectFit,
                                    nameof(DeviceIdiom.Tablet) => Aspect.AspectFill,
                                },
                            }.Bind();
                        }),
                    }.Row(2).Margins(0,10,5,90).Bind(CarouselView.ItemsSourceProperty, "OnboardingList").Bind(CarouselView.PositionProperty, "Position", BindingMode.TwoWay).Assign(out OnboardingCarousel),
                    new Grid()
                    {
                        RowSpacing = 0,
                        ColumnSpacing = 0,
                        GestureRecognizers =
                        {
                            new TapGestureRecognizer().Bind("ICommandNavToLoginPage"),
                        },
                        Children =
                        {
                            new Frame()
                            {
                                BackgroundColor = White,
                                Opacity = 0.3f,
                                CornerRadius = 45,
                                GestureRecognizers =
                                {
                                    new TapGestureRecognizer().Bind("ICommandNavToLoginPage"),
                                },
                            }.Row(0).Margin(0).Padding(5).Width(90).Height(90).Center(),
                            new Frame()
                            {
                                BackgroundColor = White,
                                Opacity = 1f,
                                CornerRadius = 30,
                                Content = new Label()
                                {
                                    Text = "\xF176",
                                    FontFamily = "FontAwesomeSolid",
                                    TextColor = Color.FromArgb("#e8bc65"),
                                    Rotation = 28,
                                    FontAttributes = FontAttributes.Bold,
                                }.FontSize(30).Center(),
                                GestureRecognizers =
                                {
                                    new TapGestureRecognizer().Bind("ICommandNavToLoginPage"),
                                },
                            }.Row(0).Margin(0).Padding(0).Width(60).Height(60).Center(),
                        },
                    }.Row(2).Padding(0).Margins(0,0,0,40).Bottom(),
                }
            }.Paddings(30, 40, 20, 20);
        }

        #region Variables
        private IndicatorView indicatorView;
        private CarouselView OnboardingCarousel;
        #endregion
    }
}

