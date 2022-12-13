using android = Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using SpaceXhistory.Views;
using Microsoft.Maui.Graphics;

namespace SpaceXhistory.Views
{
    public partial class BottomTabPage : TabbedPage
    {
        private void InitializeComponent()
        {
            android.TabbedPage.SetToolbarPlacement(this, android.ToolbarPlacement.Bottom);
            BarBackgroundColor = Black;
            Children.Add(new NavigationPage(new HomePage())
            {
                Title = "Home",
                IconImageSource = "base",
            });
            Children.Add(new NavigationPage(new UpcomingLaunchesPage())
            {
                Title = "next launchs",
                IconImageSource = "ship",
            });
            Children.Add(new NavigationPage(new PastLaunchesPage())
            {
                Title = "latest launchs",
                IconImageSource = "cap",
            });
        }
    }
}

