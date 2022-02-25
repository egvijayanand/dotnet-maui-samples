[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace TestApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSansRegular.ttf", "OpenSansRegular");
                   });

            return builder.Build();
        }
    }
}