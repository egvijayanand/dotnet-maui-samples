using Microsoft.Maui.Hosting;
using Microsoft.Maui;
using Microsoft.Maui.Embedding;
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
                                 .UseMauiEmbedding<MyApp>()
                                 .UseMauiToolkitMaps("<BING_MAPS_API_KEY_HERE>") // To generate a Bing Maps API Key, visit https://www.bingmapsportal.com/
                                 .Build();
            // While doing .NET MAUI Embedding, this call is required so that the Application object instance gets resolved.
            var _ = mauiApp.Services.GetRequiredService<IApplication>();
            Content = new HomePage().ToPlatform(new MauiContext(mauiApp.Services));
        }
    }
}
