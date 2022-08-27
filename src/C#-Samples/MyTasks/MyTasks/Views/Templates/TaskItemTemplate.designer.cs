using Task = MyTasks.Models.Task;

namespace MyTasks.Views.Templates
{
    public partial class TaskItemTemplate : ContentView
    {
        private void InitializeComponent()
        {
            Resources.Add("LineStyle", new Style(typeof(BoxView))
            {
                Setters =
                {
                    new() { Property = BoxView.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = BoxView.VerticalOptionsProperty, Value = LayoutOptions.Fill },
                    new() { Property = BoxView.WidthRequestProperty, Value = 1 },
                },
            });
            Resources.Add("PointStyle", new Style(typeof(BoxView))
            {
                Setters =
                {
                    new() { Property = BoxView.CornerRadiusProperty, Value = 12 },
                    new() { Property = BoxView.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = BoxView.VerticalOptionsProperty, Value = LayoutOptions.Start },
                    new() { Property = BoxView.HeightRequestProperty, Value = 16 },
                    new() { Property = BoxView.WidthRequestProperty, Value = 16 },
                    new() { Property = BoxView.MarginProperty, Value = new Thickness(0, 6, 0, 0) },
                },
            });
            Resources.Add("NameTextStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontFamilyProperty, Value = "PoppinsRegular" },
                    new() { Property = Label.FontSizeProperty, Value = AppResource<double>("FontSize18") },
                    new() { Property = Label.TextColorProperty, Value = AppResource<Color>("BlackColor") },
                },
            });
            Resources.Add("CategoryTextStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = AppResource<double>("FontSize14") },
                    new() { Property = Label.FontFamilyProperty, Value = "PoppinsLight" },
                    new() { Property = Label.TextColorProperty, Value = AppResource<Color>("BlackColor") },
                },
            });
            Resources.Add("TimeTextStyle", new Style(typeof(Label))
            {
                BasedOn = (Style)Resources["CategoryTextStyle"],
                Setters =
                {
                    new() { Property = Label.FontFamilyProperty, Value = "PoppinsLight" },
                    new() { Property = Label.MarginProperty, Value = new Thickness(12, 0) },
                },
            });
            Resources.Add("PhotoLayoutStyle", new Style(typeof(Grid))
            {
                Setters =
                {
                    new() { Property = Grid.MarginProperty, Value = new Thickness(0, 0, 6, 0) },
                },
            });
            Resources.Add("PhotoStyle", new Style(typeof(Image))
            {
                Setters =
                {
                    new() { Property = Image.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Image.HeightRequestProperty, Value = 40 },
                },
            });
            Content = new Grid()
            {
                BackgroundColor = AppResource<Color>("WhiteColor"),
                ColumnSpacing = 0,
                RowSpacing = 0,
                ColumnDefinitions = Columns.Define(80, Star, Auto),
                RowDefinitions = Rows.Define(Auto, Auto, Star, 12),
                Children =
                {
                    new BoxView()
                    {
                        BackgroundColor = Black,
                        Style = (Style)Resources["LineStyle"],
                    }.Column(0).Row(0).RowSpan(4),
                    new BoxView()
                    {
                        Style = (Style)Resources["PointStyle"],
                    }.Column(0).Row(0).Bind(nameof(Task.Color)),
                    new Label()
                    {
                        Style = (Style)Resources["NameTextStyle"],
                    }.Column(1).Row(0).Bind(nameof(Task.Name)),
                    new Label()
                    {
                        Style = (Style)Resources["CategoryTextStyle"],
                    }.Column(1).Row(1).Bind(nameof(Task.Category)),
                    new Label()
                    {
                        Style = (Style)Resources["TimeTextStyle"],
                    }.Column(2).Row(0).Bind(nameof(Task.Time)),
                    new StackLayout()
                    {
                        Orientation = StackOrientation.Horizontal,
                    }.Column(1).Row(2).Margin(0, 6).Assign(out peopleStack).ItemTemplate(new DataTemplate(() =>
                    {
                        return new Grid()
                        {
                            Style = (Style)Resources["PhotoLayoutStyle"],
                            Children =
                            {
                                new Image()
                                {
                                    Aspect = Aspect.AspectFit,
                                    Style = (Style)Resources["PhotoStyle"],
                                    Clip = new EllipseGeometry()
                                    {
                                        Center = new Point(20, 20),
                                        RadiusX = 20,
                                        RadiusY = 20,
                                    },
                                }.Bind(nameof(Person.Photo)),
                            },
                        };
                    })),
                }
            };
        }

        #region Variables
        private StackLayout peopleStack;
        #endregion
    }
}

