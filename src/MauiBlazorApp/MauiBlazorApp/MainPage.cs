using MauiBlazorApp.Extensions;

namespace MauiBlazorApp
{
    public partial class MainPage : ContentPage
    {
        int count;
        Label counter;

        public MainPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Content = new ScrollView()
            {
                Content = new Grid()
                {
                    RowSpacing = 25,
                    RowDefinitions = Rows.Define(Auto, Auto, Auto, Auto, Star),
                    Children =
                    {
                        new Label() { Text = "Hello, World!" }.Row(0)
                                                              .FontSize(32)
                                                              .CenterHorizontal()
                                                              .SemanticHeading(SemanticHeadingLevel.Level1),
                        new Label() { Text = "Welcome to .NET Multi-platform App UI" }.Row(1)
                                                                                      .FontSize(18)
                                                                                      .CenterHorizontal()
                                                                                      .SemanticHeading(SemanticHeadingLevel.Level1)
                                                                                      .SemanticDesc("Welcome to dot net Multi platform App U I"),
                        new Label() { Text = "Current count: 0" }.Row(2)
                                                                 .Bold()
                                                                 .FontSize(18)
                                                                 .CenterHorizontal()
                                                                 .Assign(out counter),
                        new Button() { Text = "Click me" }.Row(3)
                                                          .Bold()
                                                          .CenterHorizontal()
                                                          .Invoke(btn => btn.Clicked += OnCounterClicked)
                                                          .SemanticHint("Counts the number of times you click"),
                        new Image() { Source = "dotnet_bot.png" }.Row(4)
                                                                 .Size(250, 310)
                                                                 .CenterHorizontal()
                                                                 .SemanticDesc("Cute dot net bot waving hi to you!"),
                    }
                }.Padding(Device.RuntimePlatform switch { Device.iOS => new Thickness(30, 60, 30, 30), _ => new Thickness(30) })
            };
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            counter.Text = $"Current count: {count}";

            SemanticScreenReader.Announce(counter.Text);
        }
    }
}
