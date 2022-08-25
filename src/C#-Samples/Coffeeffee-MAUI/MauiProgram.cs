namespace Coffeeffee_MAUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("icomoon.ttf", "Icons");
                fonts.AddFont("JosefinSans-Bold.ttf", "JosefinSansBold");
                fonts.AddFont("JosefinSans-Regular.ttf", "JosefinSansRegular");
            });

		return builder.Build();
	}
}

