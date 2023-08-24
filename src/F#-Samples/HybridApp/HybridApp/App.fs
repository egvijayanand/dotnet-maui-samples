namespace HybridApp

open Fabulous
open Fabulous.Maui
open Fabulous.Maui.Blazor
open Microsoft.Maui.Accessibility
open VijayAnand.MauiToolkit.Services
open HybridApp.RazorLib

open type Fabulous.Maui.View

type FabRootComponent() =
    inherit Microsoft.AspNetCore.Components.WebView.Maui.RootComponent()

module App =
    type Model = { Count: int }

    type Msg = | Clicked

    type CmdMsg = SemanticAnnounce of string

    let semanticAnnounce text =
        Cmd.ofSub(fun _ ->
            let semanticScreenReader = AppService.GetService<ISemanticScreenReader>()
            semanticScreenReader.Announce(text))

    let mapCmd cmdMsg =
        match cmdMsg with
        | SemanticAnnounce text -> semanticAnnounce text

    let init () = { Count = 0 }, []

    let update msg model =
        match msg with
        | Clicked -> { model with Count = model.Count + 1 }, [ SemanticAnnounce $"Current count: {model.Count}" ]

    let view _ =
        Application(
            ContentPage(
                BlazorWebView("wwwroot/index.html", [ new FabRootComponent(Selector = "#app", ComponentType = typeof<Main>) ])
            )
        )

    let program = Program.statefulWithCmdMsg init update view mapCmd
