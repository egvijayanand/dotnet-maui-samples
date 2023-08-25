namespace HybridApp

open Microsoft.Extensions.DependencyInjection
open Microsoft.Maui.Accessibility
open Microsoft.Maui.Hosting
open Fabulous.Maui
open VijayAnand.MauiToolkit
open HybridApp.Extensions
open HybridApp.RazorLib.Data

type MauiProgram =
    static member CreateMauiApp() =
        MauiApp
            .CreateBuilder()
            .UseFabulousApp(App.program)
            .ConfigureBlazorWebView()
            .ConfigureFonts(fun fonts ->
                fonts
                    .AddFont("OpenSans-Regular.ttf", "OpenSansRegular")
                    .AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold")
                |> ignore)
            .ConfigureServices(fun services ->
                services
                    .AddSingleton(SemanticScreenReader.Default)
                    .AddSingleton<WeatherForecastService>()
#if DEBUG
                    .AddBlazorWebViewDeveloperTools()
#endif
                |> ignore)
#if DEBUG
            .AddDebugLog()
#endif
            .Build()
