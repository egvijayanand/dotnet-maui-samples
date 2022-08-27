namespace MyTasks.Views.Templates
{
    public partial class TaskHeaderTemplate : ContentView
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
            Resources.Add("TitleTextStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontFamilyProperty, Value = "PoppinsRegular" },
                    new() { Property = Label.FontSizeProperty, Value = AppResource<double>("FontSize36") },
                    new() { Property = Label.TextColorProperty, Value = AppResource<Color>("BlackColor") },
                    new() { Property = Label.MarginProperty, Value = new Thickness(0, 6, 0, 0) },
                },
            });
            Resources.Add("SubTitleTextStyle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontFamilyProperty, Value = "PoppinsLight" },
                    new() { Property = Label.FontSizeProperty, Value = AppResource<double>("FontSize16") },
                    new() { Property = Label.TextColorProperty, Value = AppResource<Color>("BlackColor") },
                    new() { Property = Label.MarginProperty, Value = new Thickness(0, 0, 0, 36) },
                },
            });
            Content = new Grid()
            {
                BackgroundColor = AppResource<Color>("WhiteColor"),
                ColumnSpacing = 0,
                ColumnDefinitions = Columns.Define(80, Star),
                Children =
                {
                    new Grid()
                    {
                        Children =
                        {
                            new BoxView()
                            {
                                BackgroundColor = Black,
                                Style = (Style)Resources["LineStyle"],
                            },
                        },
                    }.Column(0),
                    new StackLayout()
                    {
                        Children =
                        {
                            new Label()
                            {
                                Text = "My Tasks",
                                Style = (Style)Resources["TitleTextStyle"],
                            },
                            new Label()
                            {
                                Text = "FEBRUARY 8, 2022",
                                Style = (Style)Resources["SubTitleTextStyle"],
                            },
                        },
                    }.Column(1),
                }
            }.Margins(0, 60, 0, 0);
        }
    }
}

