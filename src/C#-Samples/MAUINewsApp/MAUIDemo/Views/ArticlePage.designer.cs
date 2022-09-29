namespace MAUIDemo.Views
{
    public partial class ArticlePage : ContentPage
    {
        private void InitializeComponent()
        {
            Title = "";
            Content = new ScrollView()
            {
                Content = new VerticalStackLayout()
                {
                    Spacing = 10,
                    Children =
                    {
                        new Image()
                        {
                            Aspect = Aspect.AspectFill,
                        }.Height(300)
                         .Bind(nameof(ArticleViewModel.ImageURL)),
                        new Label()
                        {
                            FontFamily = "NotoSerifBold",
                        }.FontSize(26)
                         .Margin(20,10)
                         .Bind(nameof(ArticleViewModel.Title)),
                        new StackLayout()
                        {
                            Orientation = StackOrientation.Horizontal,
                            Spacing = 10,
                            Children =
                            {
                                new Frame()
                                {
                                    CornerRadius = 16,
                                    BackgroundColor = AppResource<Color>("Gray200"),
                                    BorderColor = Transparent,
                                    Content = new Label()
                                    {
                                        Text = MaterialDesignIcons.AccountCircle,
                                        FontFamily = "Material",
                                        TextColor = White,
                                    }.FontSize(28)
                                     .Center(),
                                }.Width(32)
                                 .Height(32)
                                 .Padding(0),
                                new Label()
                                {
                                    TextColor = AppResource<Color>("Gray400"),
                                }.CenterVertical()
                                 .Bind(nameof(ArticleViewModel.Time)),
                            },
                        }.Margin(20,0),
                        new Label().Margin(20,0)
                                   .FontSize(16)
                                   .Bind(nameof(ArticleViewModel.Body)),
                    }
                }
            };
        }
    }
}

