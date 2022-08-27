namespace MyTasks.Views
{
    public partial class MyTasksView : ContentPage
    {
        private void InitializeComponent()
        {
            BackgroundColor = AppResource<Color>("WhiteColor");
            Title = "Timeline";
            Resources.Add("ProfileStyle", new Style(typeof(Image))
            {
                Setters =
                {
                    new() { Property = Image.HeightRequestProperty, Value = 80 },
                    new() { Property = Image.MarginProperty, Value = new Thickness(12, 0) },
                },
            });
            Resources.Add("NameTextStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontFamilyProperty, Value = "PoppinsRegular" },
                    new() { Property = Label.FontSizeProperty, Value = AppResource<double>("FontSize28") },
                    new() { Property = Label.TextColorProperty, Value = AppResource<Color>("WhiteColor") },
                },
            });
            Resources.Add("JobTextStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontFamilyProperty, Value = "PoppinsLight" },
                    new() { Property = Label.FontSizeProperty, Value = AppResource<double>("FontSize18") },
                    new() { Property = Label.TextColorProperty, Value = AppResource<Color>("WhiteColor") },
                },
            });
            Resources.Add("LineStyle", new Style(typeof(BoxView))
            {
                Setters =
                {
                    new() { Property = BoxView.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = BoxView.VerticalOptionsProperty, Value = LayoutOptions.Fill },
                    new() { Property = BoxView.WidthRequestProperty, Value = 1 },
                },
            });
            Content = new Grid()
            {
                RowSpacing = 0,
                RowDefinitions = Rows.Define(250, 100, Star),
                Children =
                {
                    new Grid()
                    {
                        ColumnDefinitions = Columns.Define(80,Star),
                        Children =
                        {
                            new BoxView()
                            {
                                BackgroundColor = Black,
                                Style = (Style)Resources["LineStyle"],
                            }.Column(0),
                            new ListView()
                            {
                                SelectionMode = ListViewSelectionMode.None,
                                HasUnevenRows = true,
                                SeparatorVisibility = SeparatorVisibility.None,
                                Header = new TaskHeaderTemplate(),
                                ItemTemplate = new DataTemplate(() =>
                                {
                                    return new TaskItemViewCell();
                                }),
                            }.Column(0).ColumnSpan(2).Bind(nameof(MyTasksViewModel.Tasks)),
                        },
                    }.Row(1).RowSpan(2),
                    new Grid()
                    {
                        ColumnDefinitions = Columns.Define(80, Star),
                        Children =
                        {
                            new BoxView()
                            {
                                BackgroundColor = Black,
                                Style = (Style)Resources["LineStyle"],
                            }.Column(0),
                            new Image()
                            {
                                Aspect = Aspect.AspectFill,
                                Source = "birdsfly.png",
                                Clip = new PathGeometry()
                                {
                                    Figures = (PathFigureCollection)new PathFigureCollectionConverter().ConvertFromInvariantString("m 0 0 l 400 0 l 0 300 l -400 -50"),
                                },
                            }.Column(0).ColumnSpan(2),
                            new Grid()
                            {
                                ColumnDefinitions = Columns.Define(Auto, Star),
                                RowDefinitions = Rows.Define(Auto, Auto),
                                Children =
                                {
                                    new Image()
                                    {
                                        Source = "face1.jpg",
                                        Aspect = Aspect.AspectFit,
                                        Style = (Style)Resources["ProfileStyle"],
                                        Clip = new EllipseGeometry()
                                        {
                                            Center = new Point(40, 40),
                                            RadiusX = 40,
                                            RadiusY = 40,
                                        },
                                    }.Column(0).Row(0).RowSpan(2),
                                    new Label()
                                    {
                                        Text = "Ryan Barnes",
                                        Style = (Style)Resources["NameTextStyle"],
                                    }.Column(1).Row(0),
                                    new Label()
                                    {
                                        Text = "Product Designer",
                                        Style = (Style)Resources["JobTextStyle"],
                                    }.Column(1).Row(1),
                                },
                            }.Column(0).ColumnSpan(2).Height(120).Margin(12, 48).Bottom(),
                        },
                    }.Row(0).RowSpan(2).Margins(0, 0, 0, 40),
                    new Grid()
                    {
                        Children =
                        {
                            new FilterMenu().Center().Bind(FilterMenu.SelectedCommandProperty, nameof(MyTasksViewModel.ItemSelectedCommand)),
                        },
                    }.Row(1).Margins(0, 0, -24, 0).End(),
                }
            };
        }
    }
}

