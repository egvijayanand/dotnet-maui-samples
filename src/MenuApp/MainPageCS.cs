using VijayAnand.MauiToolkit.Markup;

namespace MenuApp
{
    public partial class MainPageCS : ContentPage
    {
        int count = 0;

        public MainPageCS()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Title = "Main Page (C#)";

            MenuBarItems.Add(new MenuBarItem().Title("File")
                                              .AddMenuItem(new MenuFlyoutItem().Title("Quit")
                                                                               .Invoke(item => item.Clicked += OnQuitClicked)));
            MenuBarItems.Add(new MenuBarItem().Title("Locations")
                                              .AddMenuGroup(new MenuFlyoutSubItem().Title("Change Location")
                                                                                   .AddSubMenuItem(new MenuFlyoutItem().Title("New York, USA"))
                                                                                   .AddSubMenuItem(new MenuFlyoutItem().Title("London, UK"))
                                                                                   .AddSubMenuItem(new MenuFlyoutItem().Title("Cape Town, RSA"))
                                                                                   .AddSubMenuItem(new MenuFlyoutItem().Title("Beijing, PRC"))
                                                                                   .AddSubMenuGroup(new MenuFlyoutSubItem().Title("India")
                                                                                                                           .AddSubMenuItem(new MenuFlyoutItem().Title("Chennai, TN"))
                                                                                                                           .AddSubMenuItem(new MenuFlyoutItem().Title("Kolkata, WB"))
                                                                                                                           .AddSubMenuItem(new MenuFlyoutItem().Title("Mumbai, MH"))
                                                                                                                           .AddSubMenuItem(new MenuFlyoutItem().Title("New Delhi, NCR"))))
                                              .AddMenuItem(new MenuFlyoutItem().Title("Add a Location")));
            MenuBarItems.Add(new MenuBarItem().Title("View")
                                              .AddMenuItem(new MenuFlyoutItem().Title("Refresh"))
                                              .AddMenuItem(new MenuFlyoutItem().Title("Toggle Light/Dark Mode")));
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
                        }.FontSize(32).CenterHorizontal().SemanticHeading(SemanticHeadingLevel.Level1),
                        new Label()
                        {
                            Style = AppResource<Style>("MauiLabel"),
                            Text = "Welcome to .NET Multi-platform App UI",
                        }.FontSize(18).CenterHorizontal().SemanticDesc("Welcome to dot net Multi platform App U I").SemanticHeading(SemanticHeadingLevel.Level1),
                        new Label()
                        {
                            FontAttributes = FontAttributes.Bold,
                            Style = AppResource<Style>("MauiLabel"),
                            Text = "Current count: 0",
                        }.FontSize(18).CenterHorizontal().Assign(out CounterLabel),
                        new Button()
                        {
                            Style = AppResource<Style>("PrimaryAction"),
                            Text = "Click me",
                        }.CenterHorizontal().Invoke(btn => btn.Clicked += OnCounterClicked).SemanticHint("Counts the number of times you click"),
                        new Image()
                        {
                            Source = "dotnet_bot.png",
                        }.Height(310).Width(250).CenterHorizontal().SemanticDesc("Cute dot net bot waving hi to you!"),
                    }
                }.Padding(30)
            };
        }

        #region Event Handlers
        private async void OnQuitClicked(object? sender, EventArgs e)
        {
            if (await DisplayAlert("Quit", "Are you sure?", "Yes", "No"))
            {
                Application.Current?.Quit();
            }
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = $"Current count: {count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
        #endregion

        #region UI Fields
        private Label CounterLabel;
        #endregion
    }
}
