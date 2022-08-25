using Coffeeffee_MAUI;

namespace Coffeeffee_MAUI
{
    public partial class AppShell : Shell
    {
        private void InitializeComponent()
        {
            FlyoutBehavior = FlyoutBehavior.Disabled;
            Items.Add(new ShellContent()
            {
                Title = "Home",
                ContentTemplate = new DataTemplate(typeof(MainPage)),
                Route = "MainPage",
            });
        }
    }
}

