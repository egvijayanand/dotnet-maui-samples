namespace MauiAppCS
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel viewModel)
        {
            Build();
            BindingContext = viewModel;
        }

        private void Build()
        {
            Content = new ScrollView()
            {
                Content = new StackLayout()
                {
                    Spacing = 25,
                    Children =
                    {
                        new Label()
                        {
                            Style = AppResource<Style>("MauiLabel"),
                            Text = "Hello, World!",
                        }.FontSize(32)
                         .CenterHorizontal()
                         .SemanticHeading(SemanticHeadingLevel.Level1),
                        new Label()
                        {
                            Style = AppResource<Style>("MauiLabel"),
                            Text = "Welcome to .NET Multi-platform App UI",
                        }.FontSize(18)
                         .CenterHorizontal()
                         .SemanticDesc("Welcome to dot net Multi platform App U I")
                         .SemanticHeading(SemanticHeadingLevel.Level1),
                        new Label()
                        {
                            FontAttributes = FontAttributes.Bold,
                            Style = AppResource<Style>("MauiLabel"),
                        }.FontSize(18)
                         .CenterHorizontal()
                         .Bind(nameof(MainViewModel.Counter)),
                        new Button()
                        {
                            Style = AppResource<Style>("PrimaryAction"),
                            Text = "Click Me",
                        }.CenterHorizontal()
                         .BindCommand(nameof(MainViewModel.ClickCommand))
                         .SemanticHint("Counts the number of times you click"),
                        new Image()
                        {
                            Source = "dotnet_bot.png",
                        }.Height(310)
                         .Width(250)
                         .CenterHorizontal()
                         .SemanticDesc("Cute dot net bot waving hi to you!"),
                    }
                }.Padding(30)
            };
        }
    }
}
