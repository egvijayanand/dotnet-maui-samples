using System.Reflection;

namespace TitleBarApp.Views
{
    public partial class MainPage : ContentPage
    {
        private int _count = 0;

        public MainPage()
        {
            InitializeComponent();

            var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
            versionLabel.Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}";
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            // Revert to default
            Window.TitleBar = new TitleBar();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            _count++;
            counterLabel.Text = $"Current count: {_count}";

            SemanticScreenReader.Announce(counterLabel.Text);
        }
    }
}
