namespace MauiBMICalculator;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseSkiaSharp()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("DMSans-Regular.ttf", "RegularFont");
				fonts.AddFont("DMSans-Medium.ttf", "MediumFont");
			});

		return builder.Build();
	}
}

