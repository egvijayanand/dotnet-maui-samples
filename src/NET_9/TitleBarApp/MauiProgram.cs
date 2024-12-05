using Microsoft.Extensions.Logging;

namespace TitleBarApp
{
    public static partial class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                   .UseMauiCommunityToolkitMarkup()
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSans-Regular.ttf", "OS400");
                       fonts.AddFont("OpenSans-SemiBold.ttf", "OS600");
                       fonts.AddFont("fa-solid-900.ttf", "FAS");
                   });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
