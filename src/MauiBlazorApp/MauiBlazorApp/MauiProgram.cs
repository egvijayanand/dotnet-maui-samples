using RazorLib;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace MauiBlazorApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.UseMauiApp<App>()
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSans400");
                       fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSans600");
                   });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif

            builder.Services.AddSingleton<AppState>();
            builder.Services.AddSingleton<BlazorPage>();
            builder.Services.AddSingleton<WebPage>();

            return builder.Build();
        }
    }
}