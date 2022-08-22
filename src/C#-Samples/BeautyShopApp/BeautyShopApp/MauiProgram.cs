using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace BeautyShopApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCompatibility()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("fallingsky.otf", "Fallingsky");
				fonts.AddFont("fallingskybd.otf", "Fallingskybd");
				fonts.AddFont("fallingskylight.otf", "Fallingsky Light");
			});

		return builder.Build();
	}
}
