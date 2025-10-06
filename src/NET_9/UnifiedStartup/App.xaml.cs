using System.Reflection;

namespace UnifiedStartup
{
    public partial class App : Application
    {
        public App() => InitializeComponent();

        public static string MauiVersion
        {
            get
            {
                var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()!.InformationalVersion;
                return $".NET MAUI ver. {version[..version.IndexOf('+')]}";
            }
        }
    }
}
