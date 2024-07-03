using System.Reflection;

namespace ThemedApp.Views
{
    public partial class MainPage : ContentPage
    {
        private int _count = 0;

        public MainPage()
        {
            InitializeComponent();
            var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
            VersionLabel.Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}";
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            _count++;
            CounterLabel.Text = $"Current count: {_count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
    }
}
