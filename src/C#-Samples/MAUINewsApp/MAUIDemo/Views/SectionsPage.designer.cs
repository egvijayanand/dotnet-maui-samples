namespace MAUIDemo.Views
{
    public partial class SectionsPage : ContentPage
    {
        private void InitializeComponent()
        {
            Title = "Sections";
            Content = new ScrollView()
            {
                Content = new VerticalStackLayout()
                {
                    Children =
                    {
                        new Label()
                        {
                            Text = "Choose a Topic to Explore",
                            FontFamily = "NotoSerifBold",
                        }.Margins(0,10,20,10)
                         .FontSize(28),
                        new Grid()
                        {
                            ColumnDefinitions = Columns.Define(Star, Star)
                            /*Direction = FlexDirection.Row,
                            Wrap = FlexWrap.Wrap,
                            JustifyContent = FlexJustify.SpaceEvenly,
                            AlignItems = FlexAlignItems.Stretch,*/
                        }.Assign(out sections)
                         .Margin(-10,0)
                         .ItemsSource(ViewModel.Sections)
                         .ItemTemplate(new DataTemplate(() =>
                        {
                            return new Frame()
                            {
                                BackgroundColor = AppResource<Color>("Tertiary"),
                                BorderColor = Transparent,
                                Content = new VerticalStackLayout()
                                {
                                    Spacing = 10,
                                    Children =
                                    {
                                        new Label()
                                        {
                                            FontFamily = "Material",
                                            TextColor = AppResource<Color>("Gray600"),
                                        }.FontSize(34)
                                         .CenterHorizontal()
                                         .Bind("MaterialIcon"),
                                        new Label()
                                        {
                                            FontFamily = "PoppinsSemibold",
                                            TextColor = AppResource<Color>("Gray600"),
                                        }.FontSize(16)
                                         .CenterHorizontal()
                                         .Bind("Name"),
                                    },
                                }.Padding(20,6).CenterVertical(),
                            }.Bind(Grid.RowProperty, nameof(Category.RowIndex))
                             .Bind(Grid.ColumnProperty, nameof(Category.ColIndex))
                             .FlexBasis((FlexBasis)160)
                             .FlexGrow(0.75f)
                             .FlexShrink(0.5f)
                             .Margin(5,10);
                        })),
                    }
                }.Padding(16)
            };
        }

        #region Variables
        private Grid sections;
        #endregion
    }
}

