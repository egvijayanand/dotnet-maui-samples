using VijayAnand.MauiToolkit.Markup;

namespace MenuApp
{
    public partial class MenuPageCS : ContentPage
    {
        public MenuPageCS()
        {
            InitializeComponent();
        }

        public MainViewModel ViewModel { get; private set; }

        private void InitializeComponent()
        {
            ViewModel = new MainViewModel();
            Title = "Menu Page";
            MenuBarItems.Add(new MenuBarItem().Title("File")
                                              .Assign(out fileMenu)
                                              .AddMenuItem(new MenuFlyoutItem().Title("Quit")
                                                                               .BindCommand(nameof(MainViewModel.QuitCommand))));
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
                         .Bind(nameof(MainViewModel.CurrentCount)),
                        new Button()
                        {
                            Style = AppResource<Style>("PrimaryAction"),
                            Text = "Click me",
                        }.CenterHorizontal()
                         .BindCommand(nameof(MainViewModel.CountCommand))
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

            BindingContext = ViewModel;
            fileMenu.BindingContext = BindingContext;
        }

        #region Variables
        private MenuBarItem fileMenu;
        #endregion
    }
}
