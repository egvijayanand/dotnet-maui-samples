using DateCalculator.UI.Services;
using Xamarin.Forms;

namespace DateCalculator.Forms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            BindableProperties.Register();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
