namespace EcommerceMAUI
{
    public partial class MainPage : ContentPage
    {
        private void InitializeComponent()
        {
            Content = new ScrollView()
            {
                Content = new VerticalStackLayout()
                {
                    Spacing = 25,
                    Children =
                    {
                        new Image()
                        {
                            Source = "dotnet_bot.png",
                        }.Height(200).CenterHorizontal().SemanticDesc("Cute dot net bot waving hi to you!"),
                        new Label()
                        {
                            Text = "Hello, World!",
                        }.FontSize(32).CenterHorizontal().SemanticHeading(SemanticHeadingLevel.Level1),
                        new Label()
                        {
                            Text = "Welcome to .NET Multi-platform App UI",
                        }.FontSize(18).CenterHorizontal().SemanticHeading(SemanticHeadingLevel.Level2).SemanticDesc("Welcome to dot net Multi platform App U I"),
                        new Button()
                        {
                            Text = "Click me",
                        }.CenterHorizontal().Assign(out CounterBtn).Invoke(btn => btn.Clicked += OnCounterClicked).SemanticHint("Counts the number of times you click"),
                    }
                }.Padding(30,0).CenterVertical()
            };
        }

        #region Variables
        private Button CounterBtn;
        #endregion
    }
}

