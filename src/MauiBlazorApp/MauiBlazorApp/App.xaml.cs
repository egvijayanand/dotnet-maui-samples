using VijayAnand.MauiToolkit.Services;

namespace MauiBlazorApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // C# definition
            MainPage = AppService.GetService<BlazorPage>();

            // XAML definition
            //MainPage = AppService.GetService<WebPage>();
        }
    }
}
