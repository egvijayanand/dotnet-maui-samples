using System.Reflection;

namespace HybridWebViewApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            message.ReturnCommand = new Command(SendMessage);
            var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
            versionLabel.Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}";
        }

        private void OnSendClicked(object sender, EventArgs e) => SendMessage();

        private async void OnRawMessageReceived(object sender, HybridWebViewRawMessageReceivedEventArgs e)
        {
            await DisplayAlert("Raw Message Received", e.Message, "OK");
        }

        private void OnMessageChanged(object sender, TextChangedEventArgs e)
        {
            send.IsEnabled = message.Text.Length > 0;
        }

        private void SendMessage()
        {
            hwv.SendRawMessage(message.Text);
            message.Text = string.Empty;
            message.Focus();
        }
    }
}
