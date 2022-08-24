using ClassFlyXaml.Pages;
using ClassFlyXaml.ViewModels;
using CommunityToolkit.Maui;

namespace ClassFlyXaml;

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
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<ClassListViewModel>();
		builder.Services.AddSingleton<CourseListPage>();

        builder.Services.AddTransient<CourseViewModel>();
        builder.Services.AddTransient<CoursePage>();


        return builder.Build();
	}
}
