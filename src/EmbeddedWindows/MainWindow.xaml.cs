using CommunityToolkit.Maui.Markup;
using Microsoft.Maui;
using Microsoft.Maui.Embedding;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Platform;
using Microsoft.UI.Xaml;

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
								 .UseMauiEmbedding<Microsoft.Maui.Controls.Application>()
								 .UseMauiCommunityToolkitMarkup()
								 .Build();
			var mauiContext = new MauiContext(mauiApp.Services);
			var mauiPage = new MauiPage();
			Content = mauiPage.ToPlatform(mauiContext);
		}
	}
}
