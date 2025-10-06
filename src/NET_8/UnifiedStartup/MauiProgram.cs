using Microsoft.Extensions.Logging;
using VijayAnand.MauiToolkit;

namespace UnifiedStartup
{
    public static partial class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            // Integrated App Hosting Builder Method
            // For more details, consult this article:
            // https://egvijayanand.in/2025/09/29/integrated-app-hosting-builder-method-for-dotnet-maui-explained/
            //builder.UseMauiApp<App, Window, MainPage>()
            // To use Shell as an initial page
            builder.UseMauiApp<App, Window, AppShell>()
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                       fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
                   });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
