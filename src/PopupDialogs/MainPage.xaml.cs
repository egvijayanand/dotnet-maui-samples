using VijayAnand.MauiToolkit.Core;
using VijayAnand.MauiToolkit.Services;

namespace PopupDialogs
{
    public partial class MainPage : ContentPage
    {
        readonly IDialogService _genericDialog;
        readonly IMauiDialogService _mauiDialog;

        public MainPage(IDialogService genericDialog, IMauiDialogService mauiDialog)
        {
            InitializeComponent();
            _genericDialog = genericDialog;
            _mauiDialog = mauiDialog;
        }

        private async void OnBtnClicked(object sender, EventArgs e)
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
                        await _genericDialog.DisplayAlertAsync("Greeting", "Hello from .NET MAUI!!!", "OK");
                        break;
                    case "Alert2":
                        var response = await _genericDialog.DisplayAlertAsync("Confirm", "Would you like to proceed?", "Yes", "No");
                        var message = response is true ? "Glad that you opted in." : "Sorry to miss you, hope to see you soon.";
                        await _genericDialog.DisplayAlertAsync("Response", message, "OK");
                        break;
                    case "Prompt":
                        var result = await _genericDialog.DisplayPromptAsync("Subscribe", "Enter your email to send notifications.", maxLength: 100, inputType: InputType.Email);

                        if (!string.IsNullOrWhiteSpace(result))
                        {
                            await _genericDialog.DisplayAlertAsync("Response", result, "OK");
                        }
                        break;
                    case "ActionSheet":
                        var action = await _genericDialog.DisplayActionSheetAsync("Unsaved Changes ...", "What would you like to do?", "Cancel", "Discard", "Save", "Save", "Upload", "Share");
                        await _genericDialog.DisplayAlertAsync("Response", action, "OK");
                        break;
                    default:
                        // Static approach for custom implementation
                        // Static approach for native dialogs soon in an upcoming preview
                        await PopupDialog.Instance.DisplayAlertAsync("Static Invocation", "Welcome to .NET MAUI!!!", "OK");
                        break;
                }
            }
        }

        private async void OnMauiBtnClicked(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                // DI approach
                // Switch betwen native/custom implementations in the MauiProgram.cs
                // The order in which dependencies are registered determines the instance injected
                // The latest one wins

                var rightToLeft = FlowDirection.RightToLeft;

                switch (btn.AutomationId)
                {
                    case "Alert1":
                        await _mauiDialog.DisplayAlertAsync("Greeting", "Hello from .NET MAUI!!!", "OK", rightToLeft);
                        break;
                    case "Alert2":
                        var response = await _mauiDialog.DisplayAlertAsync("Confirm", "Would you like to proceed?", "Yes", "No", rightToLeft);
                        var message = response is true ? "Glad that you opted in." : "Sorry to miss you, hope to see you soon.";
                        await _mauiDialog.DisplayAlertAsync("Response", message, "OK", rightToLeft);
                        break;
                    case "Prompt":
                        var result = await _mauiDialog.DisplayPromptAsync("Subscribe", "Enter your email to send notifications.", rightToLeft, maxLength: 100, keyboard: Keyboard.Email);

                        if (!string.IsNullOrWhiteSpace(result))
                        {
                            await _mauiDialog.DisplayAlertAsync("Response", result, "OK", rightToLeft);
                        }
                        break;
                    case "ActionSheet":
                        var action = await _mauiDialog.DisplayActionSheetAsync("Unsaved Changes ..."/*, "What would you like to do?"*/, "Cancel", "Discard", rightToLeft, "Save", "Upload", "Share");
                        await _mauiDialog.DisplayAlertAsync("Response", action, "OK", rightToLeft);
                        break;
                    default:
                        // Static approach for custom implementation
                        // Static approach for native dialogs soon in an upcoming preview
                        await MauiPopupDialog.Instance.DisplayAlertAsync("Static Invocation", "Welcome to .NET MAUI!!!", "OK", rightToLeft);
                        break;
                }
            }
        }
    }
}
