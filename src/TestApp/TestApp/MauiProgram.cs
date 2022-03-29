using Microsoft.Maui.Essentials.Implementations;
using TestApp.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace TestApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSansRegular.ttf", "OSR");
                   });

            builder.Services.AddSingleton<IPreferences, PreferencesImplementation>();
            builder.Services.AddSingleton<IThemeService, ThemeService>();
            return builder.Build();
        }
    }
}