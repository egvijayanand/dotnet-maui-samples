using VijayAnand.MauiToolkit.Services;

namespace PopupDialogs
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = AppService.GetService<MainPage>();
        }
    }
}
