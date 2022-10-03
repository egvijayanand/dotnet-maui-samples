namespace MAUIPETS.Views
{
    public partial class PetDetailsView : ContentPage
    {
        private void InitializeComponent()
        {
            SetBinding(TitleProperty, new Binding("Pet.Name"));
            Shell.SetTabBarIsVisible(this, false);
            Content = new ScrollView()
            {
                Content = new Grid()
                {
                    ColumnDefinitions = Columns.Define(Star, Star, Star),
                    RowDefinitions = Rows.Define(Auto, Auto, Auto),
                    Children =
                    {
                        new Image()
                        {
                            Aspect = Aspect.Fill,
                        }.Row(0).Column(0).ColumnSpan(3).Height(400).Bind("Pet.Image"),
                        new Frame()
                        {
                            BackgroundColor = Color.FromArgb("#f9f9f9"),
                            CornerRadius = 40,
                            HasShadow = true,
                            Content = new Grid()
                            {
                                HorizontalOptions = LayoutOptions.FillAndExpand,
                                RowDefinitions = Rows.Define(Auto, Auto),
                                RowSpacing = 5,
                                Children =
                                {
                                    new Label()
                                    {
                                        FontFamily = "Bold",
                                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                                        VerticalOptions = LayoutOptions.CenterAndExpand,
                                    }.Row(0).FontSize(40).Bind("Pet.Name"),
                                    new Label()
                                    {
                                        FormattedText = new FormattedString()
                                        {
                                            Spans =
                                            {
                                                new Span()
                                                {
                                                    FontFamily = "fontello",
                                                    Text = ".",
                                                    TextColor = Color.FromArgb("#1dcaff"),
                                                }.FontSize(20),
                                                new Span()
                                                {
                                                    FontAttributes = FontAttributes.Bold,
                                                    Text = " Location: ",
                                                    TextColor = Orange,
                                                }.FontSize(20),
                                                new Span()
                                                {
                                                    TextColor = Black,
                                                }.FontSize(NamedSize.Large).Bind("Pet.Location"),
                                            },
                                        },
                                    }.Row(1).Column(0).Margins(5,-10,5,5).TextCenterHorizontal(),
                                },
                            }.Padding(20,5).FillHorizontal().CenterVertical(),
                        }.Row(1).Column(0).ColumnSpan(3).Margins(20,-50,20,10).Height(100),
                        new Frame()
                        {
                            BackgroundColor = Color.FromArgb("#b99aff"),
                            TranslationX = 0,
                            TranslationY = 0,
                        }.Row(2).Column(0).ColumnSpan(3),
                        new Frame()
                        {
                            BackgroundColor = Color.FromArgb("#9b6dff"),
                            TranslationX = 4,
                            TranslationY = 4,
                        }.Row(2).Column(0).ColumnSpan(3),
                        new Frame()
                        {
                            BackgroundColor = Color.FromArgb("#7c40ff"),
                            TranslationX = 8,
                            TranslationY = 8,
                        }.Row(2).Column(0).ColumnSpan(3),
                        new Frame()
                        {
                            BackgroundColor = Color.FromArgb("#6d2aff"),
                            TranslationX = 12,
                            TranslationY = 12,
                        }.Row(2).Column(0).ColumnSpan(3),
                        new Frame()
                        {
                            BackgroundColor = Color.FromArgb("#651fff"),
                            TranslationX = 16,
                            TranslationY = 16,
                        }.Row(2).Column(0).ColumnSpan(3),
                        new Grid()
                        {
                            ColumnDefinitions = Columns.Define(Star, Star, Star),
                            ColumnSpacing = 10,
                            RowDefinitions = Rows.Define(Auto, Auto, Auto, Auto, Auto, Auto),
                            Children =
                            {
                                new Label()
                                {
                                    FormattedText = new FormattedString()
                                    {
                                        Spans =
                                        {
                                            new Span()
                                            {
                                                FontFamily = "fontello",
                                                Text = "\xF1B0",
                                                TextColor = Color.FromArgb("#1dcaff"),
                                            }.FontSize(20),
                                            new Span()
                                            {
                                                FontAttributes = FontAttributes.Bold,
                                                Text = " Pet",
                                                TextColor = Orange,
                                            }.FontSize(16),
                                        },
                                    },
                                }.Row(0).Column(0),
                                new Label()
                                {
                                    LineBreakMode = LineBreakMode.NoWrap,
                                    TextColor = White,
                                    TranslationX = 10,
                                }.Row(1).Column(0).FontSize(NamedSize.Large).Bind("Pet.Type"),
                                new Label()
                                {
                                    FormattedText = new FormattedString()
                                    {
                                        Spans =
                                        {
                                            new Span()
                                            {
                                                FontFamily = "fontello",
                                                Text = "\xF1B0",
                                                TextColor = Color.FromArgb("#1dcaff"),
                                            }.FontSize(20),
                                            new Span()
                                            {
                                                FontAttributes = FontAttributes.Bold,
                                                Text = " Breed",
                                                TextColor = Orange,
                                            }.FontSize(16),
                                        },
                                    },
                                }.Row(0).Column(1),
                                new Label()
                                {
                                    LineBreakMode = LineBreakMode.WordWrap,
                                    TextColor = White,
                                    TranslationX = 20,
                                }.Row(1).Column(1).FontSize(NamedSize.Large).Bind("Pet.Breed"),
                                new Label()
                                {
                                    FormattedText = new FormattedString()
                                    {
                                        Spans =
                                        {
                                            new Span()
                                            {
                                                FontFamily = "fontello",
                                                Text = "7",
                                                TextColor = Color.FromArgb("#1dcaff"),
                                            }.FontSize(20),
                                            new Span()
                                            {
                                                FontFamily = "fontello",
                                                Text = ";",
                                                TextColor = Color.FromArgb("#1dcaff"),
                                            }.FontSize(20),
                                            new Span()
                                            {
                                                FontAttributes = FontAttributes.Bold,
                                                Text = " Gender",
                                                TextColor = Orange,
                                            }.FontSize(16),
                                        },
                                    },
                                }.Row(0).Column(2),
                                new Label()
                                {
                                    LineBreakMode = LineBreakMode.WordWrap,
                                    TextColor = White,
                                    TranslationX = 20,
                                }.Row(1).Column(2).FontSize(NamedSize.Large).Bind("Pet.Gender"),
                                new Label()
                                {
                                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                                    VerticalOptions = LayoutOptions.CenterAndExpand,
                                    FormattedText = new FormattedString()
                                    {
                                        Spans =
                                        {
                                            new Span()
                                            {
                                                FontFamily = "fontello",
                                                Text = "/",
                                                TextColor = Color.FromArgb("#1dcaff"),
                                            }.FontSize(20),
                                            new Span()
                                            {
                                                FontAttributes = FontAttributes.Bold,
                                                Text = " Social: ",
                                                TextColor = Orange,
                                            }.FontSize(16),
                                            new Span()
                                            {
                                                FontAttributes = FontAttributes.Bold,
                                                TextColor = White,
                                            }.FontSize(16).Bind("Pet.Social"),
                                        },
                                    },
                                }.Row(2).Column(0).ColumnSpan(3).Margin(10).TextCenterHorizontal(),
                                new Label()
                                {
                                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                                    VerticalOptions = LayoutOptions.CenterAndExpand,
                                    FormattedText = new FormattedString()
                                    {
                                        Spans =
                                        {
                                            new Span()
                                            {
                                                FontFamily = "fontello",
                                                Text = "-",
                                                TextColor = Color.FromArgb("#1dcaff"),
                                            }.FontSize(20),
                                            new Span()
                                            {
                                                FontAttributes = FontAttributes.Bold,
                                                Text = " Health: ",
                                                TextColor = Orange,
                                            }.FontSize(16),
                                            new Span()
                                            {
                                                FontAttributes = FontAttributes.Bold,
                                                TextColor = White,
                                            }.FontSize(16).Bind("Pet.Health"),
                                        },
                                    },
                                }.Row(3).Column(0).ColumnSpan(3).Margin(10).TextCenterHorizontal(),
                                new Label()
                                {
                                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                                    VerticalOptions = LayoutOptions.CenterAndExpand,
                                    FormattedText = new FormattedString()
                                    {
                                        Spans =
                                        {
                                            new Span()
                                            {
                                                FontFamily = "fontello",
                                                Text = "1",
                                                TextColor = Color.FromArgb("#1dcaff"),
                                            }.FontSize(20),
                                            new Span()
                                            {
                                                FontAttributes = FontAttributes.Bold,
                                                Text = " Meet: ",
                                                TextColor = Orange,
                                            }.FontSize(16),
                                            new Span()
                                            {
                                                FontAttributes = FontAttributes.Italic,
                                                TextColor = White,
                                            }.FontSize(16).Bind("Pet.Meet"),
                                        },
                                    },
                                }.Row(4).Column(0).ColumnSpan(3).Margin(10),
                            },
                        }.Row(2).Column(0).ColumnSpan(3).Margins(30,30,10,15),
                    }
                }
            };
        }
    }
}

