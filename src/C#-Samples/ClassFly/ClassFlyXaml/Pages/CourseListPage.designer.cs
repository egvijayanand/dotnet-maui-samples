using ClassFlyXaml;
using ClassFlyXaml.Converters;
using ClassFlyXaml.ViewModels;
using CommunityToolkit.Maui.Behaviors;

namespace ClassFlyXaml.Pages
{
    public partial class CourseListPage : ContentPage
    {
        private void InitializeComponent()
        {
            ViewModel = new ClassListViewModel();
            BackgroundColor = White;
            Shell.SetBackgroundColor(this, White);
            Shell.SetForegroundColor(this, Black);
            Shell.SetNavBarIsVisible(this, true);
            Resources.Add("IndexToBackgroundImageConverter", new IndexToObjectConverter()
            {
                EvenObject = "highlight_green.png",
                OddObject = "highlight_yellow.png",
            });
            Shell.SetTitleView(this, new Grid()
            {
                ColumnDefinitions = Columns.Define(Star, 30),
                Children =
                {
                    new Label()
                    {
                        Style = AppResource<Style>("CourseHeaderText"),
                        Text = "Choose a course",
                    }.CenterVertical(),
                    new Image()
                    {
                        Source = "menu",
                    }.Column(1).Height(28).Width(28).Center(),
                }
            }.Margins(0, 0, 20, 0));
            Content = new Grid()
            {
                RowDefinitions = Rows.Define(Auto, Auto, Star, Auto),
                Children =
                {
                    new Border()
                    {
                        Stroke = Color.FromArgb("#CCCCCC"),
                        StrokeShape = new RoundRectangle()
                        {
                            CornerRadius = new CornerRadius(20)
                        },
                        StrokeThickness = 1,
                        Content = new SearchBar()
                        {
                            Placeholder = "Search courses",
                        }.Assign(out CourseSearchBar).AddBehavior(new EventToCommandBehavior()
                        {
                            EventName = "TextChanged",
                        }.BindCommand(nameof(ClassListViewModel.SearchTermCommand), parameterPath: nameof(CourseSearchBar.Text), parameterSource: CourseSearchBar)),
                    }.Row(1).Margins(10,0,10,0),
                    new CollectionView()
                    {
                        SelectionMode = SelectionMode.Single,
                        ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Vertical)
                        {
                            ItemSpacing = 10,
                        },
                        ItemTemplate = new DataTemplate(() =>
                        {
                            return new Border()
                            {
                                Background = new SolidColorBrush(White),
                                Stroke = Color.FromArgb("#CCCCCC"),
                                StrokeShape = new RoundRectangle()
                                {
                                    CornerRadius = new CornerRadius(20)
                                },
                                StrokeThickness = 1,
                                Shadow = new Shadow()
                                {
                                    Brush = AppResource<Color>("Gray500"),
                                    Opacity = .15f,
                                    Radius = 10,
                                    Offset = new Point(5,5),
                                },
                                GestureRecognizers =
                                {
                                    new TapGestureRecognizer().BindCommand(nameof(ClassListViewModel.GoToCourseDetailsCommand), source: new RelativeBindingSource(typeof(ClassListViewModel).IsSubclassOf(typeof(Element)) ? RelativeBindingSourceMode.FindAncestor : RelativeBindingSourceMode.FindAncestorBindingContext, typeof(ClassListViewModel)), parameterPath: Binding.SelfPath),
                                },
                                Content = new Grid()
                                {
                                    ColumnDefinitions = Columns.Define(Auto,Star),
                                    ColumnSpacing = 20,
                                    InputTransparent = true,
                                    IsClippedToBounds = false,
                                    Children =
                                    {
                                        new Image().Height(80).Width(80).Bind(converter: (IValueConverter)Resources["IndexToBackgroundImageConverter"], converterParameter: CourseCollectionView),
                                        new Image().Height(80).Width(80).Bind("Image"),
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
                                                    Text = "in class",
                                                },
                                                new Label()
                                                {
                                                    Style = AppResource<Style>("CourseSmallText"),
                                                }.Bind("MemberCount", stringFormat: "{0} Members"),
                                            },
                                        }.Column(1),
                                    },
                                },
                            }.Padding(16,8);
                        }),
                        EmptyView = new ContentView()
                        {
                            Content = new Label()
                            {
                                Style = AppResource<Style>("CourseHeaderText"),
                                Text = "No courses match that search term...",
                            }.Center(),
                        },
                    }.Row(2).Margin(10).Bind(nameof(ClassListViewModel.Courses)).Bind(CollectionView.SelectedItemProperty, nameof(ClassListViewModel.SelectedCourse)).Assign(out CourseCollectionView),
                    new Border()
                    {
                        Background = AppResource<LinearGradientBrush>("TabBarGradient"),
                        Stroke = Color.FromArgb("#CCCCCC"),
                        StrokeShape = new RoundRectangle()
                        {
                            CornerRadius = new CornerRadius(20,20,0,0)
                        },
                        StrokeThickness = 0,
                        Content = new Grid()
                        {
                            ColumnDefinitions = Columns.Define(Star,Star,Star,Star),
                            IsClippedToBounds = false,
                            Children =
                            {
                                new ImageButton()
                                {
                                    Source = "home_active.png",
                                }.Column(0).Center(),
                                new ImageButton()
                                {
                                    Source = "pin_inactive.png",
                                }.Column(1).Center(),
                                new ImageButton()
                                {
                                    Source = "bell_inactive.png",
                                }.Column(2).Center(),
                                new ImageButton()
                                {
                                    Source = "user_inactive.png",
                                }.Column(3).Center(),
                            },
                        }.Height(30),
                    }.Row(3).Margin(-2).Padding(20),
                }
            };

            BindingContext = ViewModel;
        }

        public ClassListViewModel ViewModel { get; private set; }

        #region Variables
        private SearchBar CourseSearchBar;
        private CollectionView CourseCollectionView;
        #endregion
    }
}

