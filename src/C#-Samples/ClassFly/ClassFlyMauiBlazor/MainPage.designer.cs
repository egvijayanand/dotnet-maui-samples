using ClassFlyMauiBlazor;
using Microsoft.AspNetCore.Components.WebView.Maui;

namespace ClassFlyMauiBlazor
{
    public partial class MainPage : ContentPage
    {
        private void InitializeComponent()
        {
            SetDynamicResource(BackgroundColorProperty, "PageBackgroundColor");
            Content = new BlazorWebView()
            {
                HostPage = "wwwroot/index.html",
                RootComponents =
                {
                    new RootComponent()
                    {
                        Selector = "#app",
                        ComponentType = typeof(Main),
                    },
                },
            };
        }
    }
}

