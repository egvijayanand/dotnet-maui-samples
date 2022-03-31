using VijayAnand.MauiToolkit;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace TestApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                   .UseVijayAnandMauiToolkit(ServiceRegistrations.Navigation | ServiceRegistrations.Theme)
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSansRegular.ttf", "OSR");
                   });

            builder.Services.AddSingleton<SettingsViewModel>();
            builder.Services.AddSingleton<SettingsPage>();
            return builder.Build();
        }
    }
}