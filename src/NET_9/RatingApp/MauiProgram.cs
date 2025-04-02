using Microsoft.Extensions.Logging;

namespace RatingApp;

public static partial class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>()
               .UseMauiCommunityToolkit()
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

#if BCL
    // To resolve the warning when BCL is included in the TFMs.
    public static MauiAppBuilder UseMauiCommunityToolkit(this MauiAppBuilder bindable) => bindable;
#endif
}
