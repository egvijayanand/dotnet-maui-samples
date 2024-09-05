using Microsoft.Maui.Platform;
// Note: There's a change in namespace.
using Microsoft.Maui.Controls.Embedding;
//using Microsoft.Maui.Embedding;
using WinUIBlazor.Views;
using WinUIBlazor.Data;

namespace WinUIBlazor
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Microsoft.UI.Xaml.Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            var builder = MauiApp.CreateBuilder()
                .UseMauiEmbeddedApp<MyApp>(); // Note: The method name too got updated.

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddSingleton<WeatherForecastService>();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif

            var mauiApp = builder.Build();
            var mauiContext = new MauiContext(mauiApp.Services);

            // Platform-neutral - Windowless API
            Content = new HomePage().ToPlatform(mauiContext);
            // Updated Window inclusive API
            //Content = new HomePage().ToPlatformEmbedded(mauiContext);
        }
    }
}
