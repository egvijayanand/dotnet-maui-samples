using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

[assembly: ExportFont("fa-brands-400.ttf", Alias = "FAB")]
[assembly: ExportFont("fa-regular-400.ttf", Alias = "FAR")]
[assembly: ExportFont("fa-solid-900.ttf", Alias = "FAS")]

[assembly: ExportFont("OpenSans-Regular.ttf", Alias = "OpenSans400")]
[assembly: ExportFont("OpenSans-SemiBold.ttf", Alias = "OpenSans600")]
[assembly: ExportFont("OpenSans-Bold.ttf", Alias = "OpenSans700")]

[assembly: ExportFont("Catamaran-Regular.ttf", Alias = "Catamaran400")]
[assembly: ExportFont("Catamaran-SemiBold.ttf", Alias = "Catamaran600")]

[assembly: ExportFont("Roboto-Regular.ttf", Alias = "Roboto400")]
[assembly: ExportFont("Roboto-Bold.ttf", Alias = "Roboto700")]

// For enabling C# 9.0 features

namespace System.Runtime.CompilerServices
{
    public class IsExternalInit { }
}
