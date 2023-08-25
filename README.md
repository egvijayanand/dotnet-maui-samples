## .NET MAUI Samples

Completed samples will be uploaded into this repository so that it is accessible to everyone.

Join me on [**Developer Thoughts**](https://egvijayanand.in/), an exclusive blog for .NET MAUI and Blazor, for articles on working with these samples.

Available under the `src` directory:

* `TestApp` - .NET MAUI Shell sample
* `MenuApp` - .NET MAUI sample app with multi-level menu definition in both XAML and C# _(Will work only on Desktop form factor)_
* `DateCalculator`
  - MVVM Sample
  - Xamarin Forms and .NET MAUI in a single solution
  - WPF project to illustrate the reuse of ViewModels across UI frameworks
  - Shared business logic as a separate library project
  - ViewModels implemented with [CommunityToolkit.Mvvm](https://www.nuget.org/packages/CommunityToolkit.Mvvm/8.0.0-preview3) NuGet package
* `MauiBlazorApp` - .NET MAUI Blazor sample
  - App Theming
  - State sharing between .NET MAUI and Razor Components
  - Components from shared Razor Class Library (RCL)
* `MauiAppCS` - .NET MAUI C# Markup based Sample
* `UnifiedDateCalculator`
  - Shared class library sample
  - UI, ViewModel, Model, and Business logic all from shared project
  - Head projects serve as an app container
  - Both Xamarin.Forms and .NET MAUI from a single project - `DateCalculator.UI`
* `EmbeddedAndroid` - .NET MAUI Page embedded in a Native Android App, targeting .NET 6 (`net6.0-android`)
* `MediaElement` - Sample project in both .NET 6 and 7. Now made available in Preview bits as part of the .NET MAUI CommunityToolkit - And it'll be a separate NuGet package titled `CommunityToolkit.Maui.MediaElement`
* `MauiHotReload` - Sample project to demonstrate **C# Hot Reload** feature supported via [MetadataUpdateHandler](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.metadata.metadataupdatehandlerattribute?view=net-6.0) (refer to HotReloadService.cs). Core logic is abstracted into a base page named `MauiPage`, inherit the content pages from it and implement the UI logic in the override of the abstract `Build()` method. Source is available in the `src\MauiHotReload` folder.
* `WindowsUnpackagedApp` - Sample project to demonstrate running Windows targeted WinUI 3 project as Unpackaged app type.
* `PopupDialogs` - Sample project to demonstrate the custom dialogs implemented with [VijayAnand.MauiToolkit.Pro](https://www.nuget.org/packages/VijayAnand.MauiToolkit.Pro) NuGet package.
* `HybridRclApp` - `BlazorWebView` hybrid sample
  - A hybrid solution demonstrating the capabilities of `BlazorWebView` control
  - Loaded with `.NET MAUI`, `Windows Forms`, `WPF`, and `WinUI 3` projects in a single solution
  - Razor components abstracted in a shared Razor Class Library (RCL)
  - While working with the **WinUI 3** **Unpackaged** model, the below project property needs to be uncommented in the project file otherwise it'll result in the mentioned error message. _And for the **Packaged** model, this can stay as commented or update its value as MSIX (the default value)_:

```xml
<WindowsPackageType>None</WindowsPackageType>
```

**Error message:**
Unable to load DLL 'Microsoft.ui.xaml.dll' or one of its dependencies: The specified module could not be found. (0x8007007E)

* C# Samples - C# version of the [.NET MAUI UI Challenge](https://aka.ms/maui/UIChallenge) - [Awesome UIs](https://github.com/jsuarezruiz/dotnet-maui-showcase) without any XAML usage - Stay tuned for more samples ...
  - Made available under the [C#-Samples](/src/C%23-Samples/) folder
  - Design credit to their respective owners
  - [BeautyShop App](https://github.com/jsuarezruiz/netmaui-beautyshop-app-challenge) 
  - [Chat App](https://github.com/jsuarezruiz/netmaui-chat-app-challenge)
  - [Pet Adoption UI](https://github.com/LeomarisReyes/PetAdoptionUI)
  - [MAUI Finance](https://github.com/cemahseri/MauiFinance)
  - [BMI Calculator](https://github.com/naweed/MauiBMICalculator)
  - [Class Fly](https://github.com/kphillpotts/MAUI-UI-July) - Designed as part of MAUI UI July
  - [F1 TV](https://github.com/andreas-nesheim/MAUIUIJuly) - Designed as part of MAUI UI July
  - [Coffeeffee MAUI](https://github.com/zdanovs/Coffeeffee-MAUI)
  - [MAUI Focus](https://github.com/pedroldk/maui-focus)
  - [Scientific Calculator](https://github.com/naweed/MauiScientificCalculator)
  - [Medicine Tracker](https://github.com/thaveeshakannangara/MAUIBeautifulUIChallenge)
  - [eCommerce MAUI](https://github.com/exendahal/EcommerceMAUI)
  - [MAUI Payments with Prism](https://github.com/DamianSuess/Learn.MauiPaymentUi)
  - [Bottom Sheets](https://github.com/PremSaiVarada/DemoCustomSheets)
  - [MyTasks](https://github.com/jsuarezruiz/netmaui-mytasks-app-challenge)
  - [MonkeyFinder](https://github.com/dotnet-presentations/dotnet-maui-workshop) - Designed as part of .NET MAUI - Workshop by James Montemagno
  - [News App](https://github.com/henduck/MAUINewsApp)
    * There's some issue in making use of FlexLayout as a BindableLayout in C# Markup hence replaced it with StackLayout and Grid on two of the pages
  - [MAUI Pets](https://github.com/BryanOroxon/MAUIPETS)
  - [SpaceX History](https://github.com/EduardoReisDev/SpaceXhistory)

* F# Samples
  - Made available under the [F#-Samples](/src/F%23-Samples/) folder developed with Fabulous
  - FSApp - A F# sample app (with DI option)
  - HybridApp - A F# Blazor Hybrid sample app
