using System.Reflection;

namespace MenuApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            /*DefaultBindableProperties.RegisterForCommand(
                (MenuFlyoutItem.CommandProperty, MenuFlyoutItem.CommandParameterProperty)
            );*/

            // XAML-based conventional UI definition
            MainPage = new NavigationPage(GetXamlResource<Page>("MainPage.xaml", GetType().Assembly));

            // C# Markup UI definition
            //MainPage = new NavigationPage(new MainPageCS());

            // For simulating the issue
            // https://github.com/CommunityToolkit/Maui.Markup/issues/82
            //MainPage = new NavigationPage(new MenuPageCS());
        }
    }
}
