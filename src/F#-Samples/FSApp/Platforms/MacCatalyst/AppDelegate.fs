namespace FSApp

open Foundation
open Microsoft.Maui

[<Register(nameof(AppDelegate))>]
type AppDelegate() =
    inherit MauiUIApplicationDelegate()

    override this.CreateMauiApp() = MauiProgram.CreateMauiApp()
