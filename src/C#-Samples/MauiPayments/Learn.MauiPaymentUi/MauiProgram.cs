using Learn.MauiPaymentUi.Services;
using Learn.MauiPaymentUi.ViewModels;
using Learn.MauiPaymentUi.Views;

namespace Learn.MauiPaymentUi;

public static class MauiProgram
{
    public static void Configure(PrismAppBuilder builder)
    {
        // You may also do this in-line via lambdas without the need of static methods.
        builder
          .ConfigureModuleCatalog(OnConfigureModuleCatalog)
          .RegisterTypes(OnRegisterTypes)
          .OnAppStart($"{nameof(NavigationPage)}/{nameof(MainView)}", ex =>
          {
              // Handle navigation issues
              System.Diagnostics.Debug.WriteLine($"Error Loading MainView - {ex.Message}");
              System.Diagnostics.Debugger.Break();
          });
    }

    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder()
          .UseMauiApp<App>()
          .UsePrism(Configure)
          .ConfigureFonts(fonts =>
          {
              fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
              fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
          });

        return builder.Build();
    }

    private static void OnConfigureModuleCatalog(IModuleCatalog moduleCatalog)
    {
        // Add custom Module to catalog
        //  moduleCatalog.AddModule<MauiAppModule>();
        //  moduleCatalog.AddModule<MauiTestRegionsModule>();
    }

    private static void OnRegisterTypes(IContainerRegistry containerRegistry)
    {
        // Services
        containerRegistry.RegisterSingleton<IStoreService, StoreService>();

        // Navigation
        containerRegistry
          .RegisterForNavigation<MainView>()
          .RegisterForNavigation<PaymentView, PaymentViewModel>()
          .RegisterForNavigation<ReceiptView, ReceiptViewModel>()
          .RegisterInstance(SemanticScreenReader.Default);
    }
}
