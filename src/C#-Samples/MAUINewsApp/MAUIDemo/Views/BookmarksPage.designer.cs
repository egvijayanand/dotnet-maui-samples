namespace MAUIDemo.Views
{
    public partial class BookmarksPage : ContentPage
    {
        private void InitializeComponent()
        {
            Title = "Bookmarks";
            Content = new CollectionView()
            {
                ItemTemplate = new DataTemplate(() =>
                {
                    return new Border()
                    {
                        StrokeThickness = 0.5,
                        Content = new ContentView()
                        {
                            GestureRecognizers =
                            {
                                new TapGestureRecognizer().BindCommand(nameof(BookmarksViewModel.TappedCommand), source: new RelativeBindingSource(typeof(BookmarksViewModel).IsSubclassOf(typeof(Element)) ? RelativeBindingSourceMode.FindAncestor : RelativeBindingSourceMode.FindAncestorBindingContext, typeof(BookmarksViewModel)), parameterPath: Binding.SelfPath),
                            },
                            Content = new Grid()
                            {
                                ColumnSpacing = 16,
                                ColumnDefinitions = Columns.Define(120, Star),
                                RowDefinitions = Rows.Define(60, 40, 20),
                                Children =
                                {
                                    new Frame()
                                    {
                                        BorderColor = Transparent,
                                        IsClippedToBounds = true,
                                        Content = new Image()
                                        {
                                            Aspect = Aspect.AspectFill,
                                        }.Bind("ImageURL"),
                                    }.Padding(0)
                                     .Column(0)
                                     .RowSpan(3),
                                    new Label()
                                    {
                                        MaxLines = 2,
                                        FontFamily = "PoppinsSemibold",
                                    }.Row(0)
                                     .Column(1)
                                     .FontSize(20)
                                     .Bind("Title"),
                                    new Label()
                                    {
                                        TextColor = AppResource<Color>("Gray400"),
                                        MaxLines = 2,
                                    }.Row(1)
                                     .Column(1)
                                     .Bind("Subtitle"),
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
                                    }.Row(2)
                                     .Column(1),
                                },
                            },
                        }.Padding(16),
                    };
                }),
                Footer = new BoxView()
                {
                    Color = White,
                }.Height(100),
            }.Bind("Articles");
        }
    }
}
