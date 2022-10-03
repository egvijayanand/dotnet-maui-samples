using MAUIPETS.Services;
using MAUIPETS.ViewModels;
using MAUIPETS.Views;

namespace MAUIPETS;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("fontello.ttf", "Fontello");
            });
        builder.Services.AddSingleton<PetService>();
        builder.Services.AddTransient<HomePageViewModel>();
        builder.Services.AddTransient<HomePage>();
        builder.Services.AddTransient<PetDetailsViewModel>();
        builder.Services.AddTransient<PetDetailsView>();

        return builder.Build();
    }
}
