namespace BeautyShopApp.Views
{
    public partial class HomeView : ContentPage
    {
        private void InitializeComponent()
        {
            ViewModel = new HomeViewModel();
            Resources.Add("PageBackgroundColor", Color.FromArgb("#EBEAEF"));
            Resources.Add("SectionContainerStyle", new Style(typeof(Grid))
            {
                Setters =
                {
                    new() { Property = Grid.MarginProperty, Value = new Thickness(12, 0, 12, 12) },
                },
            });
            Resources.Add("AlignedSectionContainerStyle", new Style(typeof(Grid))
            {
                BasedOn = (Style)Resources["SectionContainerStyle"],
                Setters =
                {
                    new() { Property = Grid.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                },
            });
            Resources.Add("TitleTextStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 16 },
                    new() { Property = Label.FontFamilyProperty, Value = "Fallingsky" },
                    new() { Property = Label.CharacterSpacingProperty, Value = 1.5 },
                    new() { Property = Label.TextColorProperty, Value = Black },
                    new() { Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Label.VerticalOptionsProperty, Value = LayoutOptions.Center },
                },
            });
            Resources.Add("ProfileContainerStyle", new Style(typeof(Frame))
            {
                Setters =
                {
                    new() { Property = MauiFrame.HasShadowProperty, Value = false },
                    new() { Property = MauiFrame.CornerRadiusProperty, Value = 12 },
                    new() { Property = MauiFrame.HorizontalOptionsProperty, Value = LayoutOptions.End },
                    new() { Property = MauiFrame.VerticalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = MauiFrame.HeightRequestProperty, Value = 40 },
                    new() { Property = MauiFrame.WidthRequestProperty, Value = 40 },
                    new() { Property = MauiFrame.PaddingProperty, Value = Thickness.Zero },
                },
            });
            Resources.Add("SearchContainerColor", Color.FromArgb("#F9F9F9"));
            Resources.Add("SearchContainerStyle", new Style(typeof(Frame))
            {
                Setters =
                {
                    new() { Property = MauiFrame.BackgroundColorProperty, Value = (Color)Resources["SearchContainerColor"] },
                    new() { Property = MauiFrame.CornerRadiusProperty, Value = 18 },
                    new() { Property = MauiFrame.HasShadowProperty, Value = false },
                    new() { Property = MauiFrame.PaddingProperty, Value = Thickness.Zero },
                    new() { Property = MauiFrame.MarginProperty, Value = new Thickness(12, 0) },
                },
            });
            Resources.Add("SearchTextStyle", new Style(typeof(BorderlessSearchBar))
            {
                Setters =
                {
                    new() { Property = BorderlessSearchBar.FontSizeProperty, Value = 14 },
                    new() { Property = BorderlessSearchBar.FontFamilyProperty, Value = "Fallingsky" },
                    new() { Property = BorderlessSearchBar.TextColorProperty, Value = Black },
                    new() { Property = BorderlessSearchBar.PlaceholderColorProperty, Value = Black },
                    new() { Property = BorderlessSearchBar.VerticalOptionsProperty, Value = LayoutOptions.Center },
                },
            });
            Resources.Add("FilterContainerStyle", new Style(typeof(Frame))
            {
                Setters =
                {
                    new() { Property = MauiFrame.BackgroundColorProperty, Value = White },
                    new() { Property = MauiFrame.CornerRadiusProperty, Value = 18 },
                    new() { Property = MauiFrame.HasShadowProperty, Value = false },
                    new() { Property = MauiFrame.HorizontalOptionsProperty, Value = LayoutOptions.Start },
                    new() { Property = MauiFrame.HeightRequestProperty, Value = 48 },
                    new() { Property = MauiFrame.WidthRequestProperty, Value = 48 },
                    new() { Property = MauiFrame.PaddingProperty, Value = new Thickness(6) },
                },
            });
            Resources.Add("FilterImageStyle", new Style(typeof(Image))
            {
                Setters =
                {
                    new() { Property = Image.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Image.VerticalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Image.MarginProperty, Value = new Thickness(2) },
                },
            });
            Resources.Add("ResultsItemTemplate", new DataTemplate(() =>
            {
                return new ResultsItemTemplate();
            }));
            Resources.Add("ProductItemTemplate", new DataTemplate(() =>
            {
                return new ProductItemTemplate();
            }));
            Resources.Add("ProductDataTemplateSelector", new ProductDataTemplateSelector()
            {
                ResultsTemplate = (DataTemplate)Resources["ResultsItemTemplate"],
                ProductTemplate = (DataTemplate)Resources["ProductItemTemplate"],
            });
            Content = new Grid()
            {
                BackgroundColor = (Color)Resources["PageBackgroundColor"],
                Children =
                {
                    new Grid()
                    {
                        RowDefinitions = Rows.Define(100, 60, Star),
                        Children =
                        {
                            new Grid()
                            {
                                ColumnDefinitions = Columns.Define(Auto, Star),
                                Style = (Style)Resources["SectionContainerStyle"],
                                Children =
                                {
                                    new Label()
                                    {
                                        Text = "Search Product",
                                        Style = (Style)Resources["TitleTextStyle"],
                                    }.ColumnSpan(2),
                                    new Frame()
                                    {
                                        Style = (Style)Resources["ProfileContainerStyle"],
                                        Content = new Image()
                                        {
                                            Source = "javier.png",
                                        },
                                    }.Column(1),
                                },
                            },
                            new Grid()
                            {
                                ColumnDefinitions = Columns.Define(Star, Auto),
                                Style = (Style)Resources["AlignedSectionContainerStyle"],
                                Children =
                                {
                                    new Frame()
                                    {
                                        Style = (Style)Resources["SearchContainerStyle"],
                                        Content = new BorderlessSearchBar()
                                        {
                                            Placeholder = "Cleansers",
                                            Style = (Style)Resources["SearchTextStyle"],
                                        },
                                    },
                                    new Frame()
                                    {
                                        Style = (Style)Resources["FilterContainerStyle"],
                                        Content = new Image()
                                        {
                                            Source = "slider.png",
                                            Style = (Style)Resources["FilterImageStyle"],
                                        },
                                    }.Column(1),
                                },
                            }.Row(1),
                            new ScrollView()
                            {
                                Style = (Style)Resources["SectionContainerStyle"],
                                Content = new VariableSizedWrapGrid()
                                {
                                    Orientation = StackOrientation.Horizontal,
                                    ItemHeight = 100,
                                    ItemWidth = 160,
                                    MaximumRowsOrColumns = 2,
                                }.CenterHorizontal().ItemsSource(ViewModel.Products).ItemTemplateSelector((ProductDataTemplateSelector)Resources["ProductDataTemplateSelector"]),
                            }.Row(2),
                        },
                    }.Padding(24),
                }
            };

            BindingContext = ViewModel;
        }

        public HomeViewModel ViewModel { get; private set; }
    }
}

