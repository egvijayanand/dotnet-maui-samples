using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Maui.Controls;

namespace MauiBlazorApp
{
    public class BlazorPage : ContentPage
    {
        public BlazorPage()
        {
            SetDynamicResource(BackgroundColorProperty, "SecondaryColor");

            var blazor = new BlazorWebView()
            {
                HostPage = "wwwroot/index.html"
            };

            blazor.RootComponents.Add(new()
            {
                ComponentType = typeof(Gateway),
                Selector = "#app"
            });

            Content = blazor;
        }
    }
}
