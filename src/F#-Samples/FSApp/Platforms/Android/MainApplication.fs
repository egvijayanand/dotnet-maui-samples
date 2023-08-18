namespace FSApp

open Android.App
open Microsoft.Maui

[<Application>]
type MainApplication(handle, ownership) =
    inherit MauiApplication(handle, ownership)

    do FSApp.Resource.UpdateIdValues()

    override _.CreateMauiApp() = MauiProgram.CreateMauiApp()
