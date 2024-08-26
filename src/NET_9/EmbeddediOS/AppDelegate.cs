// Note: There's a change in namespace.
using Microsoft.Maui.Controls.Embedding;
//using Microsoft.Maui.Embedding;
using Microsoft.Maui.Platform;

namespace EmbeddediOS;

[Register(nameof(AppDelegate))]
public class AppDelegate : UIApplicationDelegate
{
    public override UIWindow? Window { get; set; }

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        var mauiApp = MauiApp.CreateBuilder()
            .UseMauiEmbeddedApp<MyApp>() // Note: The method name too got updated.
            .Build();

        var mauiContext = new MauiContext(mauiApp.Services);
        var mauiPage = new MauiPage();
        // Platform-specific extension method
        var viewController = mauiPage.ToUIViewController(mauiContext);

        // Create a new window instance based on the screen size
        Window = new UIWindow(UIScreen.MainScreen.Bounds)
        {
            RootViewController = viewController
        };

        // Here MauiView is a type defined using .NET MAUI construct
        // Platform-neutral Windowless API
        //var nativeView = new MauiView().ToPlatform(mauiContext);
        // Window-aware API - platformWindow can be passed as a method parameter
        //var nativeView = new MauiView().ToPlatformEmbedded(mauiContext);

        // Make the window visible
        Window.MakeKeyAndVisible();

        return true;
    }
}
