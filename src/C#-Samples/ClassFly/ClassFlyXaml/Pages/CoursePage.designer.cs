using ClassFlyXaml.Converters;
using Microsoft.Maui.Controls.Shapes;

namespace ClassFlyXaml.Pages
{
    public partial class CoursePage : ContentPage
    {
        private void InitializeComponent()
        {
            Title = "CoursePage";
            Shell.SetBackgroundColor(this, White);
            Shell.SetForegroundColor(this, Black);
            Shell.SetNavBarIsVisible(this, true);
            Resources.Add("IndexToBackgroundColorConverter", new IndexToObjectConverter()
            {
                EvenObject = AppResource<Color>("EvenRowColor"),
                OddObject = AppResource<Color>("OddRowColor"),
            });
            Shell.SetTitleView(this, new Grid()
            {
                ColumnDefinitions = Columns.Define(Star,30),
                Children =
                {
                    new Label()
                    {
                        Style = AppResource<Style>("CourseHeaderText"),
                    }.CenterVertical().Bind("Course.Name"),
                    new Image()
                    {
                        Source = "menu",
                    }.Column(1).Height(28).Width(28).Center(),
                }
            }.Margins(0,0,20,0));
            Content = new Grid()
            {
                RowDefinitions = Rows.Define(Stars(.25), Stars(.75)),
                Children =
                {
                    new Image()
                    {
                        Aspect = Aspect.AspectFill,
                        Source = "piano_large.jpg",
                    }.Margins(0,0,0,-20).FillHorizontal().Top(),
                    new Border()
                    {
                        Background = AppResource<LinearGradientBrush>("WhiteFadeGradient"),
                        Stroke = Color.FromArgb("#CCCCCC"),
                        StrokeThickness = 0,
                    }.Row(0).Margin(-2).Height(30).FillHorizontal().Top(),
                    new Border()
                    {
                        Background = new SolidColorBrush(White),
                        Stroke = Color.FromArgb("#CCCCCC"),
                        StrokeShape = new RoundRectangle()
                        {
                            CornerRadius = new CornerRadius(20,20,0,0)
                        },
                        StrokeThickness = 1,
                        Shadow = new Shadow()
                        {
                            Brush = Black,
                            Opacity = 0.2f,
                            Radius = 20,
                            Offset = new Point(-20,-20),
                        },
                        Content = new Grid()
                        {
                            RowDefinitions = Rows.Define(60,Star),
                            Children =
                            {
                                new Image()
                                {
                                    Aspect = Aspect.Fill,
                                    Source = "highlight_heading.png",
                                }.Height(20).Width(200).Start().CenterVertical(),
                                new Label()
                                {
                                    Style = AppResource<Style>("CourseHeaderText"),
                                    Text = "Select Mentor",
                                }.Row(0).CenterVertical(),
                                new Rectangle()
                                {
                                    Fill = AppResource<Color>("Gray100"),
                                }.Height(2).CenterHorizontal().Bottom(),
                                new CollectionView()
                                {
                                    ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Vertical)
                                    {
                                        ItemSpacing = 10,
                                    },
                                    ItemTemplate = new DataTemplate(() =>
                                    {
                                        return new Grid()
                                        {
                                            ColumnDefinitions = Columns.Define(60,5,Star,20),
                                            ColumnSpacing = 15,
                                            Children =
                                            {
                                                new RoundRectangle()
                                                {
                                                    CornerRadius = 10,
                                                }.Column(0).Height(50).Width(50).CenterHorizontal().Bottom().Bind(RoundRectangle.FillProperty, Binding.SelfPath, converter: (IValueConverter)Resources["IndexToBackgroundColorConverter"], converterParameter: MentorsCollectionView),
                                                new Image()
                                                {
                                                    Clip = new RoundRectangleGeometry()
                                                    {
                                                        CornerRadius = 10,
                                                        Rect = new Rect(5,0,50,60),
                                                    },
                                                }.Height(60).Width(60).CenterHorizontal().Bottom().Bind("Image"),
                                                new Rectangle()
                                                {
                                                    Fill = AppResource<Color>("Gray100"),
                                                }.Column(1).Height(30).Width(2).Center(),
                                                new VerticalStackLayout()
                                                {
                                                    Children =
                                                    {
                                                        new Label()
                                                        {
                                                            Style = AppResource<Style>("CourseHeaderText"),
                                                        }.Bind("Name"),
                                                        new Label()
                                                        {
                                                            Style = AppResource<Style>("CourseSmallText"),
                                                        }.Bind("FollowerCount", stringFormat: "{0} Followers"),
                                                    },
                                                }.Column(2),
                                                new Image()
                                                {
                                                    Source = "right.png",
                                                }.Column(3).Center(),
                                            },
                                        };
                                    }),
                                }.Row(1).Margins(0,20,0,0).Bind("Course.Mentors").Assign(out MentorsCollectionView),
                            },
                        },
                    }.Row(1).Margin(-2).Padding(16,16),
                }
            };
        }

        #region Variables
        private CollectionView MentorsCollectionView;
        #endregion
    }
}

