namespace MauiScientificCalculator;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
                fonts.AddFont("Cairo-Light.ttf", "RegularFont");
                fonts.AddFont("Cairo-ExtraLight.ttf", "LightFont");
            });

		return builder.Build();
	}
}
