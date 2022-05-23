global using VijayAnand.Toolkit.Markup;
global using static VijayAnand.Toolkit.Markup.Utility;

// Based on constants defined in the project file
// Can also be defined using TargetFrameworkVersion like NETSTANDARD2_0, NETSTANDARD2_0_OR_GREATER,
// NET6_0, NET6_0_OR_GREATER, but requires certain changes to the project file while referencing it.
#if FORMS
// Xamarin.Forms specific using statements
global using Xamarin.CommunityToolkit.Behaviors;
global using Xamarin.CommunityToolkit.Converters;

global using AppTheme = Xamarin.Forms.OSAppTheme;
#endif

#if MAUI
// .NET MAUI specific using statements
global using CommunityToolkit.Maui.Behaviors;
global using CommunityToolkit.Maui.Converters;
#endif
