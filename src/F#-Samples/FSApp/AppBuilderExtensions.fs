namespace FSApp.Extensions

open Microsoft.Extensions.Logging
open Microsoft.Maui.Hosting
open System.Runtime.CompilerServices

[<Extension>]
type AppBuilderExtensions =
    [<Extension>]
    static member inline AddDebugLog(builder: MauiAppBuilder) =
        builder.Logging.AddDebug() |> ignore
        builder
