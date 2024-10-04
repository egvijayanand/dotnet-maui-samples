using System.Reflection;

namespace HybridWebViewApp.Views;

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
        => await DisplayAlert("Raw Message Received", e.Message, "OK");

    private void OnMessageChanged(object sender, TextChangedEventArgs e)
        => send.IsEnabled = message.Text.Length > 0;

    private async void OnAddClicked(object sender, EventArgs e)
    {
        if (int.TryParse(operand1.Text, out var num1)
            && int.TryParse(operand2.Text, out var num2))
        {
            var result = await hwv.InvokeJavaScriptAsync<int>(
                "addNumbers", // Method name
                IntContext.Default.Int32, // Return type
                [num1, num2], // Input parameter values
                [IntContext.Default.Int32, IntContext.Default.Int32]); // Input parameter types
            await DisplayAlert("Result", $"{result}", "OK");

            operand1.Text = string.Empty;
            operand2.Text = string.Empty;
            operand1.Focus();
        }
        else
        {
            await DisplayAlert("Error", "Invalid input.", "OK");
        }
    }

    private void SendMessage()
    {
        hwv.SendRawMessage(message.Text);
        message.Text = string.Empty;
        message.Focus();
    }
}
