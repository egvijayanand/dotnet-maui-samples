namespace FSApp

open Microsoft.Extensions.DependencyInjection
open Microsoft.Maui.Accessibility
open Microsoft.Maui.Hosting
open Fabulous.Maui
open VijayAnand.MauiToolkit
open FSApp.Extensions

type MauiProgram =
    static member CreateMauiApp() =
        MauiApp
            .CreateBuilder()
            .UseFabulousApp(App.program)
            .ConfigureFonts(fun fonts ->
                fonts
                    .AddFont("OpenSans-Regular.ttf", "OpenSansRegular")
                    .AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold")
                |> ignore)
            .ConfigureServices(fun services ->
                services
                    .AddSingleton(SemanticScreenReader.Default)
                |> ignore)
#if DEBUG
            .AddDebugLog()
#endif
            .Build()
