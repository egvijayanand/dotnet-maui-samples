#if ANDROID
using Android.Views;
#endif
using Microsoft.Maui.LifecycleEvents;

namespace MauiFinance;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
#if ANDROID
        builder = builder.ConfigureLifecycleEvents(lifecycleBuilder =>
        {
            lifecycleBuilder.AddAndroid(android => android.OnCreate((activity, _) =>
            {
                activity.Window!.SetFlags(WindowManagerFlags.LayoutNoLimits, WindowManagerFlags.LayoutNoLimits);
                activity.Window.ClearFlags(WindowManagerFlags.TranslucentStatus);
                activity.Window.SetStatusBarColor(Android.Graphics.Color.Transparent);

                // To make it fullscreen
                activity.Window.AddFlags(WindowManagerFlags.Fullscreen);
                activity.Window.ClearFlags(WindowManagerFlags.ForceNotFullscreen);
            }));
        });
#endif
        
        return builder.Build();
	}
}
