namespace MAUIPETS.Views
{
    public partial class HomePage : ContentPage
    {
        private void InitializeComponent()
        {
            SetBinding(TitleProperty, new Binding(nameof(HomePageViewModel.Title)));
            Content = new RefreshView()
            {
                Content = new ScrollView()
                {
                    Content = new Grid()
                    {
                        ColumnDefinitions = Columns.Define(Stars(0.5), Auto, Stars(0.5)),
                        RowDefinitions = Rows.Define(10, 50, 550, 90, Auto, 50),
                        Children =
                        {
                            new Label()
                            {
                                FontAttributes = FontAttributes.Bold,
                                Text = "Paws and Purrs",
                                TextColor = Black,
                            }.Row(1)
                             .ColumnSpan(3)
                             .FontSize(30)
                             .CenterHorizontal()
                             .Bottom(),
                            new CollectionView()
                            {
                                BackgroundColor = White,
                                SelectionMode = SelectionMode.Single,
                                ItemsLayout = new GridItemsLayout(2, ItemsLayoutOrientation.Vertical),
                                ItemTemplate = new DataTemplate(() =>
                                {
                                    return new StackLayout()
                                    {
                                        Children =
                                        {
                                            new Frame()
                                            {
                                                BorderColor = OrangeRed,
                                                CornerRadius = 15,
                                                HasShadow = true,
                                                VerticalOptions = LayoutOptions.CenterAndExpand,
                                                Shadow = new Shadow()
                                                {
                                                    Brush = Black,
                                                    Opacity = 0.8f,
                                                    Offset = new Point(6, 10),
                                                },
                                                Content = new StackLayout()
                                                {
                                                    Children =
                                                    {
                                                        new Label()
                                                        {
                                                            FontAttributes = FontAttributes.Bold,
                                                        }.FontSize(NamedSize.Large)
                                                         .Center()
                                                         .Bind(nameof(Pet.Name)),
                                                        new Image()
                                                        {
                                                            Aspect = Aspect.AspectFit,
                                                        }.Height(200)
                                                         .Width(200)
                                                         .CenterHorizontal()
                                                         .Bind(nameof(Pet.Image)),
                                                        new Label().CenterHorizontal()
                                                                   .Bind(nameof(Pet.Gender)),
                                                        new Label()
                                                        {
                                                            FontAttributes = FontAttributes.Italic,
                                                            LineBreakMode = LineBreakMode.WordWrap,
                                                            MaxLines = 5,
                                                        }.CenterHorizontal()
                                                         .TextCenterHorizontal()
                                                         .Bind(nameof(Pet.Breed)),
                                                    },
                                                },
                                            }.Margin(10)
                                             .Height(320)
                                             .CenterHorizontal()
                                             .CenterVertical(),
                                        },
                                    }/*.BindTapGesture(nameof(HomePageViewModel.GoToDetailsCommand), new RelativeBindingSource(RelativeBindingSourceMode.FindAncestorBindingContext, typeof(HomePageViewModel)))*/;
                                }),
                            }.Row(2)
                             .Column(0)
                             .ColumnSpan(3)
                             .Bind(nameof(HomePageViewModel.Pets))
                             .Bind(CollectionView.SelectedItemProperty, nameof(HomePageViewModel.SelectedPet))
                             .Bind(CollectionView.SelectionChangedCommandProperty, nameof(HomePageViewModel.GoToDetailsCommand))
                             .Assign(out PetsList),
                            new Border()
                            {
                                BackgroundColor = Color.FromArgb("#3D5AFE"),
                                Stroke = Color.FromArgb("#6600FF"),
                                StrokeShape = new RoundRectangle()
                                {
                                    CornerRadius = new CornerRadius(0, 50, 40, 15)
                                },
                                StrokeThickness = 10,
                                TranslationY = -20,
                                Shadow = new Shadow()
                                {
                                    Brush = Black,
                                    Opacity = 0.8f,
                                    Offset = new Point(6, 10),
                                },
                            }.Row(4)
                             .RowSpan(4)
                             .Column(0)
                             .ColumnSpan(3)
                             .Margin(10)
                             .Height(120),
                            new Button()
                            {
                                BackgroundColor = Orange,
                                CornerRadius = 25,
                                FontAttributes = FontAttributes.Bold,
                                Text = "Save a Life. Donate a Shelter Pet!",
                                TranslationY = 5,
                            }.Row(4)
                             .Column(1)
                             .FontSize(NamedSize.Large)
                             .Height(60)
                             .Invoke(btn => btn.Clicked += Donate_Clicked),
                            new Image()
                            {
                                HorizontalOptions = LayoutOptions.CenterAndExpand,
                                Source = "dog1.png",
                                TranslationY = 5,
                            }.Row(3)
                             .Column(1)
                             .Height(50)
                             .Width(50),
                        },
                    },
                }
            }.Bind(nameof(HomePageViewModel.GetPetsCommand))
             .Bind(RefreshView.IsRefreshingProperty, nameof(HomePageViewModel.IsRefreshing));
        }

        #region Variables
        private CollectionView PetsList;
        #endregion
    }
}

