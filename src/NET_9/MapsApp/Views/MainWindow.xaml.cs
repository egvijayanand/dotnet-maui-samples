using Microsoft.Maui.Hosting;
using Microsoft.Maui;
// Note: There's a change in namespace.
using Microsoft.Maui.Controls.Embedding;
//using Microsoft.Maui.Embedding;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Platform;
using MapsApp.Extensions;

namespace MapsApp.Views
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            var mauiApp = MauiApp.CreateBuilder()
                                 .UseMauiEmbeddedApp<MyApp>() // Note: The method name too got updated.
                                 .UseMauiToolkitMaps("<BING_MAPS_API_KEY_HERE>") // To generate a Bing Maps API Key, visit https://www.bingmapsportal.com/
                                 .Build();

            // From .NET MAUI 9 Preview 7 onwards, the below method call is no longer required
            // as the .NET MAUI Embedding process is revamped.
            // While doing .NET MAUI Embedding, this call is required so that
            // the Application object instance gets resolved.
            //var _ = mauiApp.Services.GetRequiredService<IApplication>();

            var mauiContext = new MauiContext(mauiApp.Services);

            // Platform-neutral - Windowless API
            Content = new HomePage().ToPlatform(mauiContext);
            // Updated Window-aware API
            //Content = new HomePage().ToPlatformEmbedded(mauiContext);
        }
    }
}
