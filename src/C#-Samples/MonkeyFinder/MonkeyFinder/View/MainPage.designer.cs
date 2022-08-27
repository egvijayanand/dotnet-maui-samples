namespace MonkeyFinder.View
{
    public partial class MainPage : ContentPage
    {
        private void InitializeComponent()
        {
            ios.Page.SetUseSafeArea(this, true);
            Title = "Monkeys";
            Content = new Grid()
            {
                ColumnDefinitions = Columns.Define(Star,Star),
                ColumnSpacing = 5,
                RowDefinitions = Rows.Define(Star,Auto),
                RowSpacing = 0,
                BackgroundColor = Application.Current.RequestedTheme switch
                {
                    AppTheme.Dark => AppResource<Color>("DarkBackground"),
                    AppTheme.Light or _ => AppResource<Color>("LightBackground"),
                },
                Children =
                {
                    new RefreshView()
                    {
                        Content = new CollectionView()
                        {
                            BackgroundColor = Transparent,
                            SelectionMode = SelectionMode.None,
                            ItemTemplate = new DataTemplate(() =>
                            {
                                return new Grid()
                                {
                                    Children =
                                    {
                                        new Frame()
                                        {
                                            Style = AppResource<Style>("CardView"),
                                            GestureRecognizers =
                                            {
                                                new TapGestureRecognizer().BindCommand(nameof(MonkeysViewModel.GoToDetailsCommand), source: new RelativeBindingSource(typeof(MonkeysViewModel).IsSubclassOf(typeof(Element)) ? RelativeBindingSourceMode.FindAncestor : RelativeBindingSourceMode.FindAncestorBindingContext, typeof(MonkeysViewModel)), parameterPath: Binding.SelfPath),
                                            },
                                            Content = new Grid()
                                            {
                                                ColumnDefinitions = Columns.Define(125,Star),
                                                Children =
                                                {
                                                    new Image()
                                                    {
                                                        Aspect = Aspect.AspectFill,
                                                    }.Height(125).Width(125).Bind(nameof(Monkey.Image)),
                                                    new VerticalStackLayout()
                                                    {
                                                        Children =
                                                        {
                                                            new Label()
                                                            {
                                                                Style = AppResource<Style>("LargeLabel"),
                                                            }.Bind(nameof(Monkey.Name)),
                                                            new Label()
                                                            {
                                                                Style = AppResource<Style>("MediumLabel"),
                                                            }.Bind(nameof(Monkey.Location)),
                                                        },
                                                    }.Column(1).Padding(10),
                                                },
                                            }.Padding(0),
                                        }.Height(125),
                                    },
                                }.Padding(10);
                            }),
                        }.Bind(nameof(MonkeysViewModel.Monkeys)),
                    }.ColumnSpan(2).Bind(RefreshView.IsRefreshingProperty, nameof(MonkeysViewModel.IsRefreshing)).Bind(nameof(MonkeysViewModel.GetMonkeysCommand)),
                    new Button()
                    {
                        Style = AppResource<Style>("ButtonOutline"),
                        Text = "Get Monkeys",
                    }.Row(1).Column(0).Margin(8).Bind(Button.IsEnabledProperty, nameof(MonkeysViewModel.IsNotBusy)).Bind(nameof(MonkeysViewModel.GetMonkeysCommand)),
                    new Button()
                    {
                        Style = AppResource<Style>("ButtonOutline"),
                        Text = "Find Closest",
                    }.Row(1).Column(1).Margin(8).Bind(Button.IsEnabledProperty, nameof(MonkeysViewModel.IsNotBusy)).Bind(nameof(MonkeysViewModel.GetClosestMonkeyCommand)),
                    new ActivityIndicator()
                    {
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                    }.RowSpan(2).ColumnSpan(2).Bind(nameof(MonkeysViewModel.IsBusy)).Bind(ActivityIndicator.IsVisibleProperty, nameof(MonkeysViewModel.IsBusy)),
                }
            };
        }
    }
}

