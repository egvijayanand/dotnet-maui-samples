## .NET MAUI Samples

Completed samples will be uploaded into this repository so that it is accessible to everyone.

Join me on [**Developer Thoughts**](https://egvijayanand.in/), an exclusive blog for .NET MAUI and Blazor, for articles on working with these samples.

_Note: Samples are in the process of migrating to the latest framework version, so there would be a change in the directory structure. Kindly bear with this._

### .NET MAUI 9 Samples

Made available in the `src\NET_9\` directory:

|Solution Title|Description|
|:---:|:---|
|`EmbeddedAndroid`|.NET MAUI Page embedded in a .NET 9 for Android App <br /> Refer to this [.NET MAUI - Native Embedding](https://egvijayanand.in/2024/02/29/dotnet-maui-native-embedding/) article for working with this sample|
|`EmbeddediOS`|.NET MAUI Page embedded in a .NET 9 for iOS App <br /> Refer to this [.NET MAUI - Native Embedding](https://egvijayanand.in/2024/02/29/dotnet-maui-native-embedding/) article for working with this sample|
|`EmbeddedWindows`|.NET MAUI Page embedded in a Native WinUI 3 App <br /> Refer to this [.NET MAUI - Native Embedding](https://egvijayanand.in/2024/02/29/dotnet-maui-native-embedding/) article for working with this sample|
|`MapsApp`|Using .NET MAUI [CommunityToolkit.Maui.Maps](https://www.nuget.org/packages/CommunityToolkit.Maui.Maps) embedded in a Native WinUI 3 App <br /> Refer to this [.NET MAUI Community Toolkit Maps in WinUI 3 App](https://egvijayanand.in/2024/03/07/dotnet-maui-community-toolkit-maps-in-winui-3-app/) article for working with this sample|
|`HybridWebViewApp`|A sample app showcasing the features of the new [HybridWebView](https://learn.microsoft.com/en-us/dotnet/maui/whats-new/dotnet-9?view=net-maui-9.0#hybridwebview) control. <br /> Refer to this [Exploring .NET MAUI 9: HybridWebView](https://egvijayanand.in/2024/10/04/exploring-dotnet-maui-9-hybridwebview-features/) article for working with this sample|
|`WinUIBlazor`|.NET MAUI `BlazorWebView` embedded in a Native WinUI 3 App, making it as a Blazor Hybrid app <br /> Refer to this [.NET MAUI - Blazor Hybrid - WinUI 3](https://egvijayanand.in/2023/03/29/dotnet-maui-blazor-hybrid-winui-3/) article for working with this sample|
|`TitleBarApp`|A sample app showcasing the features of the new [TitleBar](https://learn.microsoft.com/en-us/dotnet/maui/whats-new/dotnet-9?view=net-maui-9.0#titlebar-for-windows) control. <br /> Refer to this [What's New in .NET MAUI 9: Window TitleBar](https://egvijayanand.in/2024/12/04/what-is-new-in-dotnet-maui-9-window-titlebar/) article for working with this sample|
|`RatingApp`|A sample app showcasing the features of the new [RatingView](https://learn.microsoft.com/en-us/dotnet/communitytoolkit/maui/views/ratingview) control. <br /> Refer to this [Exploring the New RatingView Control in .NET MAUI Community Toolkit v11.2](https://egvijayanand.in/2025/03/28/exploring-the-new-ratingview-control-in-dotnet-maui-community-toolkit-v11/?utm_campaign=branding&utm_source=github&utm_medium=samples) article for working with this sample|

### .NET MAUI 8 Samples

Made available in the `src\NET_8\` directory:

|Solution Title|Description|
|:---:|:---|
|`EmbeddedWindows`|.NET MAUI Page embedded in a Native WinUI 3 App <br /> Refer to this [.NET MAUI - Native Embedding](https://egvijayanand.in/2024/02/29/dotnet-maui-native-embedding/) article for working with this sample|
|`MapsApp`|.NET MAUI Maps embedded in a Native WinUI 3 App <br /> Refer to this [.NET MAUI Community Toolkit Maps in WinUI 3 App](https://egvijayanand.in/2024/03/07/dotnet-maui-community-toolkit-maps-in-winui-3-app/) article for working with this sample|
|`ThemedApp`|Sample app for .NET MAUI App Theming <br /> Refer to this [.NET MAUI - App Theming](https://egvijayanand.in/2024/07/03/dotnet-maui-developer-tips-app-theming/) article for further details|
|`DateCalculator`|<ul><li>MVVM Sample</li><li>Xamarin Forms and .NET MAUI in a single solution</li><li>WPF and WinUI projects to illustrate the reuse of ViewModels across UI frameworks</li><li>WinForms project to illustrate the reuse of ViewModels across non-XAML UI framework too</li><li>Shared business logic as a separate library project</li><li>ViewModels implemented with [CommunityToolkit.Mvvm](https://www.nuget.org/packages/CommunityToolkit.Mvvm) (aka Microsoft MVVM Toolkit) NuGet package</li><li>Consult the [MVVM - Made Easy](https://egvijayanand.in/category/mvvm/made-easy/) series of articles for guidance on working with this sample solution.</li></ul>|
|`UnifiedDateCalculator`|<ul><li>Shared class library sample</li><li>UI, ViewModel, Model, and Business logic all from shared project</li><li>Head projects serve as an app container</li><li>Both Xamarin.Forms and .NET MAUI UI definition from a single project - `DateCalculator.UI`</li><li>ViewModels implemented with [CommunityToolkit.Mvvm](https://www.nuget.org/packages/CommunityToolkit.Mvvm) (aka Microsoft MVVM Toolkit) NuGet package</li></ul>|

Made available in the the `src\` directory:

* `TestApp` - .NET MAUI Shell sample
* `MenuApp` - .NET MAUI sample app with multi-level menu definition in both XAML and C# _(Will work only on Desktop form factor)_
* `MauiBlazorApp` - .NET MAUI Blazor sample
  - App Theming
  - State sharing between .NET MAUI and Razor Components
  - Components from shared Razor Class Library (RCL)
* `MauiAppCS` - .NET MAUI C# Markup based Sample
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

### .NET MAUI UI Challenge - C# Version

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

### .NET MAUI - F# Samples

* F# Samples
  - Made available under the [F#-Samples](/src/F%23-Samples/) folder developed with Fabulous
  - FSApp - A F# sample app (with DI option)
  - HybridApp - A F# Blazor Hybrid sample app
