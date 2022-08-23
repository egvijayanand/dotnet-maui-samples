namespace ChatApp.Views
{
    public partial class HomeView : ContentPage
    {
        private void InitializeComponent()
        {
            ViewModel = new HomeViewModel();
            Resources.Add("TitleTextStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 26 },
                    new() { Property = Label.TextColorProperty, Value = White },
                    new() { Property = Label.FontFamilyProperty, Value = "Metropolis Medium" },
                    new() { Property = Label.FontAttributesProperty, Value = FontAttributes.Bold },
                    new() { Property = Label.WidthRequestProperty, Value = 160 },
                    new() { Property = Label.MarginProperty, Value = new Thickness(36, 48, 0, 0) },
                },
            });
            Resources.Add("SuggestedContainerStyle", new Style(typeof(Grid))
            {
                Setters =
                {
                    new() { Property = Grid.MarginProperty, Value = new Thickness(36, 24, 0, 24) },
                },
            });
            Resources.Add("SearchContainerStyle", new Style(typeof(Grid))
            {
                Setters =
                {
                    new() { Property = Grid.HeightRequestProperty, Value = 52 },
                    new() { Property = Grid.WidthRequestProperty, Value = 52 },
                    new() { Property = Grid.MarginProperty, Value = new Thickness(0, 0, 12, 0) },
                },
            });
            Resources.Add("SearchBackgroundColor", Color.FromArgb("#868ACB"));
            Resources.Add("RecentChatCollectionStyle", new Style(typeof(CollectionView))
            {
                Setters =
                {
                    new() { Property = CollectionView.MarginProperty, Value = new Thickness(12, 24, 12, 0) },
                },
            });
            Resources.Add("RecentChatAdornerStyle", new Style(typeof(BoxView))
            {
                Setters =
                {
                    new() { Property = BoxView.ColorProperty, Value = White },
                    new() { Property = BoxView.CornerRadiusProperty, Value = new CornerRadius(18, 18, 0, 0) },
                },
            });
            Content = new Grid()
            {
                BackgroundColor = AppResource<Color>("PrimaryColor"),
                RowDefinitions = Rows.Define(220, Star),
                Children =
                {
                    new Grid()
                    {
                        RowDefinitions = Rows.Define(Auto, Star),
                        Children =
                        {
                            new Label()
                            {
                                Text = "Chat with your friends",
                                Style = (Style)Resources["TitleTextStyle"],
                            },
                            new Grid()
                            {
                                ColumnDefinitions = Columns.Define(Auto, Star),
                                Style = (Style)Resources["SuggestedContainerStyle"],
                                Children =
                                {
                                    new Grid()
                                    {
                                        Style = (Style)Resources["SearchContainerStyle"],
                                        Children =
                                        {
                                            new Ellipse()
                                            {
                                                Fill = (Color)Resources["SearchBackgroundColor"],
                                            },
                                            new Image()
                                            {
                                                Source = "search.png",
                                            },
                                        },
                                    },
                                    new ScrollView()
                                    {
                                        Content = new StackLayout()
                                        {
                                            Orientation = StackOrientation.Horizontal,
                                        }.ItemsSource(ViewModel.Users).ItemTemplate(new DataTemplate(() =>
                                        {
                                            return new SuggestedItemTemplate();
                                        })),
                                    }.Column(1),
                                },
                            }.Row(1),
                        },
                    },
                    new Grid()
                    {
                        Children =
                        {
                            new BoxView()
                            {
                                Style = (Style)Resources["RecentChatAdornerStyle"],
                            },
                            new CollectionView()
                            {
                                Style = (Style)Resources["RecentChatCollectionStyle"],
                                ItemTemplate = new DataTemplate(() =>
                                {
                                    return new RecentChatItemTemplate();
                                }),
                            }.Bind(nameof(HomeViewModel.RecentChat)),
                        },
                    }.Row(1),
                }
            };

            BindingContext = ViewModel;
        }

        public HomeViewModel ViewModel { get; private set; }
    }
}

