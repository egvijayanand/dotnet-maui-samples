namespace ChatApp.Views
{
    public partial class DetailView : ContentPage
    {
        private void InitializeComponent()
        {
            ViewModel = new DetailViewModel();
            Resources.Add("SenderMessageItemTemplate", new DataTemplate(() =>
            {
                return new SenderChatMessageItemTemplate();
            }));
            Resources.Add("ReceiverMessageItemTemplate", new DataTemplate(() =>
            {
                return new ReceiverChatMessageItemTemplate();
            }));
            Resources.Add("MessageDataTemplateSelector", new MessageDataTemplateSelector()
            {
                SenderMessageTemplate = (DataTemplate)Resources["SenderMessageItemTemplate"],
                ReceiverMessageTemplate = (DataTemplate)Resources["ReceiverMessageItemTemplate"],
            });
            Resources.Add("NavigationButtonContainerStyle", new Style(typeof(Grid))
            {
                Setters =
                {
                    new() { Property = Grid.MarginProperty, Value = new Thickness(24, 12) },
                    new() { Property = Grid.VerticalOptionsProperty, Value = LayoutOptions.Start },
                },
            });
            Resources.Add("NavigationButtonColor", Color.FromArgb("#A2A4D6"));
            Resources.Add("NavigationButtonStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.TextColorProperty, Value = (Color)Resources["NavigationButtonColor"] },
                    new() { Property = Label.FontSizeProperty, Value = 12 },
                    new() { Property = Label.FontFamilyProperty, Value = "Metropolis Regular" },
                },
            });
            Resources.Add("UsernameTextStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 26 },
                    new() { Property = Label.TextColorProperty, Value = White },
                    new() { Property = Label.FontFamilyProperty, Value = "Metropolis Medium" },
                    new() { Property = Label.FontAttributesProperty, Value = FontAttributes.Bold },
                    new() { Property = Label.WidthRequestProperty, Value = 150 },
                    new() { Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.Start },
                    new() { Property = Label.MarginProperty, Value = new Thickness(24, 36) },
                },
            });
            Resources.Add("ButtonsContainerStyle", new Style(typeof(StackLayout))
            {
                Setters =
                {
                    new() { Property = StackLayout.HeightRequestProperty, Value = 120 },
                    new() { Property = StackLayout.OrientationProperty, Value = "Horizontal" },
                    new() { Property = StackLayout.MarginProperty, Value = new Thickness(24, 12) },
                },
            });
            Resources.Add("CircularButtonEllipseColor", Color.FromArgb("#868BCB"));
            Resources.Add("CircularButtonEllipseStyle", new Style(typeof(BoxView))
            {
                Setters =
                {
                    new() { Property = BoxView.CornerRadiusProperty, Value = 40 },
                    new() { Property = BoxView.HeightRequestProperty, Value = 40 },
                    new() { Property = BoxView.WidthRequestProperty, Value = 40 },
                    new() { Property = BoxView.VerticalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = BoxView.MarginProperty, Value = new Thickness(6, 0, 0, 0) },
                },
            });
            Resources.Add("CircularButtonImageStyle", new Style(typeof(Image))
            {
                Setters =
                {
                    new() { Property = Image.HeightRequestProperty, Value = 40 },
                    new() { Property = Image.AspectProperty, Value = "AspectFit" },
                    new() { Property = Image.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Image.VerticalOptionsProperty, Value = LayoutOptions.Center },
                },
            });
            Resources.Add("ChatAdornerStyle", new Style(typeof(BoxView))
            {
                Setters =
                {
                    new() { Property = BoxView.ColorProperty, Value = White },
                    new() { Property = BoxView.CornerRadiusProperty, Value = new CornerRadius(24, 24, 0, 0) },
                },
            });
            Resources.Add("ChatCollectionStyle", new Style(typeof(CollectionView))
            {
                Setters =
                {
                    new() { Property = CollectionView.MarginProperty, Value = new Thickness(18, 32, 18, 0) },
                },
            });
            Resources.Add("ChatEntryBackgroundColor", Color.FromArgb("#F7F7F8"));
            Resources.Add("ChatEntryContainerStyle", new Style(typeof(Frame))
            {
                Setters =
                {
                    new() { Property = MauiFrame.BackgroundColorProperty, Value = (Color)Resources["ChatEntryBackgroundColor"] },
                    new() { Property = MauiFrame.HeightRequestProperty, Value = 72 },
                    new() { Property = MauiFrame.CornerRadiusProperty, Value = 32 },
                    new() { Property = MauiFrame.HasShadowProperty, Value = false },
                    new() { Property = MauiFrame.PaddingProperty, Value = new Thickness(4) },
                    new() { Property = MauiFrame.MarginProperty, Value = new Thickness(12) },
                },
            });
            Resources.Add("ChatEntryStyle", new Style(typeof(BorderlessEntry))
            {
                Setters =
                {
                    new() { Property = BorderlessEntry.FontSizeProperty, Value = 12 },
                    new() { Property = BorderlessEntry.VerticalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = BorderlessEntry.MarginProperty, Value = new Thickness(6, 0) },
                },
            });
            Resources.Add("SearchButtonContainerStyle", new Style(typeof(Grid))
            {
                Setters =
                {
                    new() { Property = Grid.HorizontalOptionsProperty, Value = LayoutOptions.End },
                    new() { Property = Grid.WidthRequestProperty, Value = 40 },
                },
            });
            Resources.Add("SearchButtonEllipseStyle", new Style(typeof(BoxView))
            {
                Setters =
                {
                    new() { Property = BoxView.ColorProperty, Value = AppResource<Color>("PrimaryColor") },
                    new() { Property = BoxView.CornerRadiusProperty, Value = 32 },
                    new() { Property = BoxView.HeightRequestProperty, Value = 32 },
                    new() { Property = BoxView.WidthRequestProperty, Value = 32 },
                    new() { Property = BoxView.VerticalOptionsProperty, Value = LayoutOptions.Center },
                },
            });
            Resources.Add("SearchButtonImageStyle", new Style(typeof(Image))
            {
                Setters =
                {
                    new() { Property = Image.HeightRequestProperty, Value = 40 },
                    new() { Property = Image.AspectProperty, Value = "AspectFit" },
                    new() { Property = Image.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Image.VerticalOptionsProperty, Value = LayoutOptions.Center },
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
                        RowDefinitions = Rows.Define(Auto, 150),
                        Children =
                        {
                            new Grid()
                            {
                                ColumnDefinitions = Columns.Define(Auto, Star),
                                Style = (Style)Resources["NavigationButtonContainerStyle"],
                                Children =
                                {
                                    new Label()
                                    {
                                        Text = "Back",
                                        Style = (Style)Resources["NavigationButtonStyle"],
                                        GestureRecognizers =
                                        {
                                            new TapGestureRecognizer().Bind(nameof(DetailViewModel.BackCommand)),
                                        },
                                    },
                                    new Label()
                                    {
                                        Text = "Search",
                                        Style = (Style)Resources["NavigationButtonStyle"],
                                    }.Column(1).End(),
                                },
                            },
                            new Grid()
                            {
                                ColumnDefinitions = Columns.Define(Star, Auto),
                                Children =
                                {
                                    new Label()
                                    {
                                        Style = (Style)Resources["UsernameTextStyle"],
                                    }.Bind("User.Name"),
                                    new StackLayout()
                                    {
                                        Style = (Style)Resources["ButtonsContainerStyle"],
                                        Children =
                                        {
                                            new Grid()
                                            {
                                                Children =
                                                {
                                                    new BoxView()
                                                    {
                                                        Color = (Color)Resources["CircularButtonEllipseColor"],
                                                        Style = (Style)Resources["CircularButtonEllipseStyle"],
                                                    },
                                                    new Image()
                                                    {
                                                        Source = "call.png",
                                                        Style = (Style)Resources["CircularButtonImageStyle"],
                                                    },
                                                },
                                            },
                                            new Grid()
                                            {
                                                Children =
                                                {
                                                    new BoxView()
                                                    {
                                                        Color = (Color)Resources["CircularButtonEllipseColor"],
                                                        Style = (Style)Resources["CircularButtonEllipseStyle"],
                                                    },
                                                    new Image()
                                                    {
                                                        Source = "record.png",
                                                        Style = (Style)Resources["CircularButtonImageStyle"],
                                                    },
                                                },
                                            },
                                        },
                                    }.Column(1),
                                },
                            }.Row(1),
                        },
                    }.Row(0),
                    new Grid()
                    {
                        Children =
                        {
                            new BoxView()
                            {
                                Style = (Style)Resources["ChatAdornerStyle"],
                            },
                            new Grid()
                            {
                                RowDefinitions = Rows.Define(Star, Auto),
                                Children =
                                {
                                    new Grid()
                                    {
                                        Children =
                                        {
                                            new CollectionView()
                                            {
                                                ItemTemplate = (MessageDataTemplateSelector)Resources["MessageDataTemplateSelector"],
                                                Style = (Style)Resources["ChatCollectionStyle"],
                                            }.Bind(nameof(DetailViewModel.Messages)),
                                        },
                                    },
                                    new Frame()
                                    {
                                        Style = (Style)Resources["ChatEntryContainerStyle"],
                                        Content = new Grid()
                                        {
                                            ColumnDefinitions = Columns.Define(Star, Auto),
                                            Children =
                                            {
                                                new BorderlessEntry()
                                                {
                                                    Placeholder = "Type your message...",
                                                    Style = (Style)Resources["ChatEntryStyle"],
                                                },
                                                new Grid()
                                                {
                                                    Style = (Style)Resources["SearchButtonContainerStyle"],
                                                    Children =
                                                    {
                                                        new Ellipse()
                                                        {
                                                            Fill = AppResource<Color>("PrimaryBrush"),
                                                            Style = (Style)Resources["SearchButtonEllipseStyle"],
                                                        },
                                                        new Image()
                                                        {
                                                            Source = "send.png",
                                                            Style = (Style)Resources["SearchButtonImageStyle"],
                                                        },
                                                    },
                                                }.Column(1),
                                            },
                                        },
                                    }.Row(1),
                                },
                            },
                        },
                    }.Row(1),
                }
            };

            BindingContext = ViewModel;
        }

        public DetailViewModel ViewModel { get; private set; }
    }
}

