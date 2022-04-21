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
                       fonts.AddFont("fa-brands-400.ttf", "FAB");
                       fonts.AddFont("fa-regular-400.ttf", "FAR");
                       fonts.AddFont("fa-solid-900.ttf", "FAS");
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSans400");
                       fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSans600");
                   });

            builder.Services.AddSingleton<SettingsViewModel>();
            builder.Services.AddSingleton<SettingsPage>();
            return builder.Build();
        }
    }
}