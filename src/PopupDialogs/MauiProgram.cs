using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace PopupDialogs
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                   .UseMauiCommunityToolkit()
                   .UseVijayAnandMauiToolkit() // Has DI based implementation of native .NET MAUI dialogs
                   .UseVijayAnandMauiToolkitPro() // Registers the Popup-based dialogs
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                       fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
                   })
                   .ConfigureServices(services =>
                   {
                       services.AddSingleton<MainViewModel>();
                       services.AddSingleton<MainPage>();
                   });
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
