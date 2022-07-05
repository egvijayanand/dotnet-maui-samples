namespace MenuApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // XAML-based conventional UI definition
            MainPage = new NavigationPage(new MainPage());

            // C# Markup UI definition
            //MainPage = new NavigationPage(new MainPageCS());
        }
    }
}
