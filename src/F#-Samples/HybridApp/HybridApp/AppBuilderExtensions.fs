namespace HybridApp.Extensions

open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Logging
open Microsoft.Maui.Hosting
open System.Runtime.CompilerServices

[<Extension>]
type AppBuilderExtensions =
    [<Extension>]
    static member inline ConfigureBlazorWebView(builder: MauiAppBuilder) =
        builder.Services.AddMauiBlazorWebView() |> ignore
        builder
    [<Extension>]
    static member inline AddDebugLog(builder: MauiAppBuilder) =
        builder.Logging.AddDebug() |> ignore
        builder
