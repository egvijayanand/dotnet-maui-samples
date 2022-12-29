using VijayAnand.MauiToolkit.Core;

namespace PopupDialogs
{
    public partial class MainPage : ContentPage
    {
        readonly IDialogService _dialogService;

        public MainPage(IDialogService dialogService)
        {
            InitializeComponent();
            _dialogService = dialogService;
        }

        private async void OnClicked(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                // DI approach
                // Switch betwen native/custom implementations in the MauiProgram.cs
                // The order in which dependencies are registered determines the instance injected
                // The latest one wins

                switch (btn.AutomationId)
                {
                    case "Alert1":
                        await _dialogService.DisplayAlertAsync("Greeting", "Hello from .NET MAUI!!!", "OK");
                        break;
                    case "Alert2":
                        var response = await _dialogService.DisplayAlertAsync("Confirm", "Would you like to proceed?", "Yes", "No");
                        var message = response is true ? "Glad that you opted in." : "Sorry to miss you, hope to see you soon.";
                        await _dialogService.DisplayAlertAsync("Response", message, "OK");
                        break;
                    case "Prompt":
                        var result = await _dialogService.DisplayPromptAsync("Subscribe", "Enter your email to send notifications.", maxLength: 100, inputType: InputType.Email);
                        
                        if (!string.IsNullOrWhiteSpace(result))
                        {
                            await _dialogService.DisplayAlertAsync("Response", result, "OK");
                        }
                        break;
                    case "ActionSheet":
                        var action = await _dialogService.DisplayActionSheetAsync("Unsaved Changes ...", "What would you like to do?", "Cancel", "Discard", "Save", "Save", "Upload", "Share", "Discard");
                        await _dialogService.DisplayAlertAsync("Response", action, "OK");
                        break;
                    default:
                        // Static approach for custom implementation
                        // Static approach for native dialogs soon in an upcoming preview
                        await PopupDialog.Instance.DisplayAlertAsync("Static Invocation", "Welcome to .NET MAUI!!!", "OK");
                        break;
                }
            }
        }
    }
}
