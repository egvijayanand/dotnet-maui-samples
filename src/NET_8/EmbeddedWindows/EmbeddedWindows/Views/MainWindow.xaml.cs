using Microsoft.Maui.Hosting;
using Microsoft.Maui.Platform;
using Microsoft.Maui;
using Microsoft.Maui.Embedding;
using Microsoft.Extensions.DependencyInjection;

namespace EmbeddedWindows
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
                                 .ConfigureFonts(fonts =>
                                 {
                                     fonts.AddFont("OpenSans-Regular.ttf", "OS400");
                                     fonts.AddFont("OpenSans-SemiBold.ttf", "OS600");
                                 })
                                 .Build();
            // While doing .NET MAUI Embedding, this call is required so that the Application object instance gets resolved.
            var _ = mauiApp.Services.GetRequiredService<IApplication>();
            Content = new MauiPage().ToPlatform(new MauiContext(mauiApp.Services));
        }
    }
}
