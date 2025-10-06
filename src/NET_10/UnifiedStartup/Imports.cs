global using UnifiedStartup;
global using UnifiedStartup.Views;

// Static
global using static Microsoft.Maui.Graphics.Colors;

// Implicit Namespace option
// To enable, uncomment the below two lines.
//[assembly: System.Runtime.Versioning.RequiresPreviewFeatures]
//[assembly: Microsoft.Maui.Controls.Xaml.Internals.AllowImplicitXmlnsDeclaration]
// Alternatively, this can be done in the project file also.
// Set the EnablePreviewFeatures node and assign its value to true.
// And then define this constant: MauiAllowImplicitXmlnsDeclaration

// CLR Namespaces
[assembly: XmlnsDefinition("http://schemas.microsoft.com/dotnet/maui/global", "UnifiedStartup")]
[assembly: XmlnsDefinition("http://schemas.microsoft.com/dotnet/maui/global", "UnifiedStartup.Views")]
