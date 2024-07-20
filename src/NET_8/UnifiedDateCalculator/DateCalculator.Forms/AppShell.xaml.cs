using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DateCalculator.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        // UnComment the below method to handle Shell Menu item click event
        // And ensure appropriate page definitions are available for it work as expected
        //private async void OnMenuItemClicked(object sender, EventArgs e)
        //{
        //    await Current.GoToAsync("//login");
        //}
    }
}
