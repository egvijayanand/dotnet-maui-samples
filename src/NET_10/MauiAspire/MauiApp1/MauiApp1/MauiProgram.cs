using MauiApp1.Services;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using VijayAnand.MauiToolkit.Core.Services;

namespace MauiApp1
{
    public static partial class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App, MainWindow, MainPage>()
                   .AddServiceDefaults() // Aspire service defaults
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                       fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
                   })
                   .ConfigureServices(services =>
                   {
                       services.AddSingleton<MainViewModel>();
                       services.AddSingleton<WeatherDataStore>();
                       // BaseAddress should point to the named endpoint registered in the Aspire project.
                       // It'll be auto resolved using Aspire's service discovery.
                       services.AddHttpClient("webapi", client => client.BaseAddress = new("https+http://webapi"));
                   });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
