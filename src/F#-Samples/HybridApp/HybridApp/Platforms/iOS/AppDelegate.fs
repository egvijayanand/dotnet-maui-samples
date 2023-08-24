namespace HybridApp

open Foundation
open Microsoft.Maui

[<Register(nameof(AppDelegate))>]
type AppDelegate() =
    inherit MauiUIApplicationDelegate()

    override _.CreateMauiApp() = MauiProgram.CreateMauiApp()
