using Microsoft.AspNetCore.Components.WebView.Maui;
using VijayAnand.MauiBlazor.Markup;

namespace WinUIBlazor.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            Content = new Grid()
            {
                Children =
                {
                    new BlazorWebView().Configure(typeof(Main), "/counter")
                }
            };
        }
    }
}
