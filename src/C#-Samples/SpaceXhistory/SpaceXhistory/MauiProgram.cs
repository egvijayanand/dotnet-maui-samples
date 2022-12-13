using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace SpaceXhistory;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
                fonts.AddFont("GemunuLibre-Bold.ttf", "Bold");
                fonts.AddFont("GemunuLibre-ExtraBold.ttf", "ExtraBold");
                fonts.AddFont("GemunuLibre-ExtraLight.ttf", "ExtraLight");
                fonts.AddFont("GemunuLibre-Light.ttf", "Light");
                fonts.AddFont("GemunuLibre-Medium.ttf", "Medium");
                fonts.AddFont("GemunuLibre-Regular.ttf", "Regular");
                fonts.AddFont("GemunuLibre-SemiBold.ttf", "SemiBold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

