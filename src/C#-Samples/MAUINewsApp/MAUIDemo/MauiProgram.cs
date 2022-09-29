namespace MAUIDemo;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>()
               .RegisterAppServices()
               .RegisterViewModels()
               .ConfigureFonts(fonts =>
               {
                   fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                   fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                   fonts.AddFont("NotoSerif-Bold.ttf", "NotoSerifBold");
                   fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");
                   fonts.AddFont("Poppins-SemiBold.ttf", "PoppinsSemibold");
                   fonts.AddFont("Poppins-Regular.ttf", "Poppins");
                   fonts.AddFont("MaterialIconsOutlined-Regular.otf", "Material");
               });

        return builder.Build();
    }

    public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<INewsService, MockNewsService>();

        return builder;
    }

    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddTransient<HomeViewModel>();
        builder.Services.AddTransient<SectionsViewModel>();
        builder.Services.AddTransient<ArticleViewModel>();
        builder.Services.AddTransient<BookmarksViewModel>();

        builder.Services.AddTransient<HomePage>();
        builder.Services.AddTransient<SectionsPage>();
        builder.Services.AddTransient<ArticlePage>();
        builder.Services.AddTransient<BookmarksPage>();

        return builder;
    }
}
