using BlazorApp.Services;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;

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
