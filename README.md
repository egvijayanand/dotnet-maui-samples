## .NET MAUI Samples

Completed samples will be uploaded into this repository so that it is accessible to everyone.

Join me on [**Developer Thoughts**](https://egvijayanand.in/), an exclusive blog for .NET MAUI and Blazor, for articles on working with these samples.

Available under the `src` directory:

* `TestApp` - .NET MAUI Shell sample
* `DateCalculator`
  - MVVM Sample
  - Xamarin Forms and .NET MAUI in a single solution
  - WPF project to illustrate the reuse of ViewModels across UI frameworks
  - Shared business logic as a separate library project
  - ViewModels implemented with [CommunityToolkit.Mvvm](https://www.nuget.org/packages/CommunityToolkit.Mvvm/8.0.0-preview3) NuGet package
* `MauiBlazorApp` - .NET MAUI Blazor sample
  - App Theming
  - Components from shared Razor Class Library (RCL)
* `MauiAppCS` - .NET MAUI C# Markup based Sample
* `UnifiedDateCalculator`
  - Shared class library sample
  - UI, ViewModel, Model, and Business logic all from shared project
  - Head projects serve as an app container
  - Both Xamarin.Forms and .NET MAUI from a single project - `DateCalculator.UI`
* `EmbeddedAndroid` - .NET MAUI Page embedded in a Native Android App, targeting .NET 6 (`net6.0-android`)
