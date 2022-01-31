using Microsoft.AspNetCore.Components.WebView.Maui;
using RazorLib;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace MauiBlazorApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.RegisterBlazorMauiWebView()
                   .UseMauiApp<App>()
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSansRegular.ttf", "OpenSansRegular");
                   });

            builder.Services.AddBlazorWebView();

            builder.Services.AddSingleton<AppState>();
            builder.Services.AddSingleton<BlazorPage>();
            builder.Services.AddSingleton<WebPage>();

            return builder.Build();
        }
    }
}