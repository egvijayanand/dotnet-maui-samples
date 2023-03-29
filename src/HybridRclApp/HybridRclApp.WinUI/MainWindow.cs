// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

using Microsoft.AspNetCore.Components.WebView.Maui;
using VijayAnand.MauiBlazor.Markup;
using Microsoft.Maui.Platform;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using static Microsoft.Maui.Dispatching.Dispatcher;

namespace HybridRclApp.WinUI
{
	/// <summary>
	/// An empty window that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainWindow : Window
	{
		public MainWindow()
		{
			var services = new ServiceCollection();
			services.AddSingleton(GetForCurrentThread()!);
			services.AddMauiBlazorWebView();
			services.AddSingleton<WeatherForecastService>();
#if DEBUG
			services.AddBlazorWebViewDeveloperTools();
#endif

			Content = new Grid()
			{
				Children =
				{
					new BlazorWebView().Configure("wwwroot/index.html", "/counter", ("#app", typeof(Main), null))
									   .ToPlatform(new MauiContext(services.BuildServiceProvider()))
				}
			};
		}
	}
}
