using VijayAnand.MauiToolkit.Services;

namespace PopupDialogs.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private readonly IDialogService _genericDialog;
        private readonly IMauiDialogService _mauiDialog;

        public MainViewModel(IDialogService genericDialog, IMauiDialogService mauiDialog)
            => (_genericDialog, _mauiDialog) = (genericDialog, mauiDialog);

        [RelayCommand]
        private async Task GenericDialog(string arg)
        {
            // DI approach
            // Switch betwen native/custom implementations in the MauiProgram.cs
            // The order in which dependencies are registered determines the instance injected
            // The latest one wins

            switch (arg)
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

        [RelayCommand]
        private async Task MauiDialog(string arg)
        {
            // DI approach
            // Switch betwen native/custom implementations in the MauiProgram.cs
            // The order in which dependencies are registered determines the instance injected
            // The latest one wins

            var rightToLeft = FlowDirection.RightToLeft;

            switch (arg)
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
                    var result = await _mauiDialog.DisplayPromptAsync("Lucky Draw", "Enter your age to participate.", maxLength: 3, inputType: InputType.Numeric, predicate: ValidateUserEntry);

                    if (!string.IsNullOrWhiteSpace(result))
                    {
                        await _mauiDialog.DisplayAlertAsync("Response", result, "OK");
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

        private (bool, string) ValidateUserEntry(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return (false, "Age is required.");
            }

            if (int.TryParse(value, out int age))
            {
                if (age < 0 || age > 120)
                {
                    return (false, "Enter a valid age.");
                }
                else if (age >= 18)
                {
                    return (true, string.Empty);
                }
                else
                {
                    return (false, "You should be atleast 18 years old to participate.");
                }
            }
            else
            {
                return (false, "Enter a valid age.");
            }
        }
    }
}
