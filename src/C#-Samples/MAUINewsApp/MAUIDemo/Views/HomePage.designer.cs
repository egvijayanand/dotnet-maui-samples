namespace MAUIDemo.Views
{
    public partial class HomePage : ContentPage
    {
        private void InitializeComponent()
        {
            Title = "Home";
            Resources.Add("HeaderStack", new Style(typeof(StackLayout))
            {
                Setters =
                {
                    new() { Property = StackLayout.MarginProperty, Value = new Thickness(20,16,20,14) },
                    new() { Property = StackLayout.OrientationProperty, Value = "Horizontal" },
                    new() { Property = StackLayout.PaddingProperty, Value = new Thickness(20,0) },
                },
            });
            Resources.Add("SectionHeading", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontFamilyProperty, Value = "NotoSerifBold" },
                    new() { Property = Label.FontSizeProperty, Value = 20 },
                    new() { Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.StartAndExpand },
                },
            });
            Resources.Add("ShowAll", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.End },
                    new() { Property = Label.FontSizeProperty, Value = 16 },
                    new() { Property = Label.TextColorProperty, Value = AppResource<Color>("Primary") },
                    new() { Property = Label.VerticalOptionsProperty, Value = LayoutOptions.End },
                },
            });
            Resources.Add(new Style(typeof(BoxView))
            {
                Setters =
                {
                    new() { Property = BoxView.HeightRequestProperty, Value = 1 },
                    new() { Property = BoxView.ColorProperty, Value = Color.FromArgb("#eee") },
                    new() { Property = BoxView.MarginProperty, Value = new Thickness(0,10,0,0) },
                },
            });
            Resources.Add("ArticleTemplate", new DataTemplate(() =>
            {
                return new StackLayout()
                {
                    Orientation = StackOrientation.Vertical,
                    GestureRecognizers =
                    {
                        new TapGestureRecognizer().BindCommand(nameof(HomeViewModel.TappedCommand), source: new RelativeBindingSource(typeof(HomeViewModel).IsSubclassOf(typeof(Element)) ? RelativeBindingSourceMode.FindAncestor : RelativeBindingSourceMode.FindAncestorBindingContext, typeof(HomeViewModel)), parameterPath: Binding.SelfPath),
                    },
                    Children =
                    {
                        new Frame()
                        {
                            IsClippedToBounds = true,
                            BorderColor = Transparent,
                            Content = new Image()
                            {
                                Aspect = Aspect.AspectFill,
                            }.Height(180)
                             .Width(300)
                             .Bind("ImageURL"),
                        }.Padding(0),
                        new Label()
                        {
                            FontFamily = "PoppinsSemibold",
                            MaxLines = 2,
                        }.Margins(0,4,0,0)
                         .FontSize(18)
                         .Bind("Title"),
                        new StackLayout()
                        {
                            Orientation = StackOrientation.Horizontal,
                            Spacing = 4,
                            Children =
                            {
                                new Label()
                                {
                                    TextColor = AppResource<Color>("Primary"),
                                }.Bind("Category"),
                                new Label()
                                {
                                    Text = "\xB7",
                                    FontAttributes = FontAttributes.Bold,
                                    TextColor = AppResource<Color>("Gray200"),
                                },
                                new Label()
                                {
                                    TextColor = AppResource<Color>("Gray200"),
                                }.Bind("Time"),
                            },
                        },
                    },
                }.Margins(20, 0, 0, 0)
                 .Width(300)
                 .Height(260);
            }));
            Content = new ScrollView()
            {
                Content = new VerticalStackLayout()
                {
                    Children =
                    {
                        new StackLayout()
                        {
                            Style = (Style)Resources["HeaderStack"],
                            Children =
                            {
                                new Label()
                                {
                                    Text = "Popular tags",
                                    Style = (Style)Resources["SectionHeading"],
                                },
                                new Label()
                                {
                                    Text = "Show All",
                                    Style = (Style)Resources["ShowAll"],
                                },
                            },
                        },
                        new ScrollView()
                        {
                            Orientation = ScrollOrientation.Horizontal,
                            HorizontalScrollBarVisibility = ScrollBarVisibility.Never,
                            Content = new StackLayout()
                            {
                                Orientation = StackOrientation.Horizontal,
                                /*Wrap = FlexWrap.Wrap,*/
                            }.Margin(20,0)
                             .ItemsSource(ViewModel.Tags)
                             .ItemTemplate(new DataTemplate(() =>
                            {
                                return new Frame()
                                {
                                    BackgroundColor = Application.Current.PlatformAppTheme switch { AppTheme.Dark => Color.FromArgb("#003D7A"), _ => Color.FromArgb("#F2F2F2") },
                                    BorderColor = Transparent,
                                    CornerRadius = 4,
                                    Content = new Label()
                                    {
                                        FontFamily = "Poppins",
                                    }.CenterVertical().Bind(),
                                }.Padding(8,2).Margins(0,0,4,10);
                            })),
                        },
                        new BoxView(),
                        new StackLayout()
                        {
                            Style = (Style)Resources["HeaderStack"],
                            Children =
                            {
                                new Label()
                                {
                                    Text = "Latest news",
                                    Style = (Style)Resources["SectionHeading"],
                                },
                                new Label()
                                {
                                    Text = "Show All",
                                    Style = (Style)Resources["ShowAll"],
                                },
                            },
                        },
                        new ScrollView()
                        {
                            Orientation = ScrollOrientation.Horizontal,
                            HorizontalScrollBarVisibility = ScrollBarVisibility.Never,
                            Content = new StackLayout()
                            {
                                Orientation = StackOrientation.Horizontal,
                                Spacing = 10,
                            }.ItemTemplate((DataTemplate)Resources["ArticleTemplate"])
                             .ItemsSource(ViewModel.LatestArticles),
                        },
                        new BoxView(),
                        new StackLayout()
                        {
                            Style = (Style)Resources["HeaderStack"],
                            Children =
                            {
                                new Label()
                                {
                                    Text = "Recommended for you",
                                    Style = (Style)Resources["SectionHeading"],
                                },
                                new Label()
                                {
                                    Text = "Show All",
                                    Style = (Style)Resources["ShowAll"],
                                },
                            },
                        },
                        new ScrollView()
                        {
                            Orientation = ScrollOrientation.Horizontal,
                            HorizontalScrollBarVisibility = ScrollBarVisibility.Never,
                            Content = new StackLayout()
                            {
                                Orientation = StackOrientation.Horizontal,
                                Spacing = 10,
                            }.ItemTemplate((DataTemplate)Resources["ArticleTemplate"])
                             .ItemsSource(ViewModel.LatestArticles),
                        },
                        new BoxView(),
                        new StackLayout()
                        {
                            Style = (Style)Resources["HeaderStack"],
                            Children =
                            {
                                new Label()
                                {
                                    Text = "Popular articles",
                                    Style = (Style)Resources["SectionHeading"],
                                },
                                new Label()
                                {
                                    Text = "Show All",
                                    Style = (Style)Resources["ShowAll"],
                                },
                            },
                        },
                        new ScrollView()
                        {
                            Orientation = ScrollOrientation.Horizontal,
                            HorizontalScrollBarVisibility = ScrollBarVisibility.Never,
                            Content = new StackLayout()
                            {
                                Orientation = StackOrientation.Horizontal,
                                Spacing = 10,
                            }.ItemTemplate((DataTemplate)Resources["ArticleTemplate"])
                             .ItemsSource(ViewModel.LatestArticles),
                        },
                    }
                }
            };
        }
    }
}
