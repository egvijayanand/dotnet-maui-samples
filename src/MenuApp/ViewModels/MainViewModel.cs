using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using VijayAnand.MauiToolkit.Core.Services;
using VijayAnand.MauiToolkit.Services;

namespace MenuApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        int count = 0;
        readonly IDialogService? dialogService;

        public MainViewModel()
        {
            dialogService = AppService.GetService<IDialogService>();
        }

        [ObservableProperty]
        private string currentCount = "Current count: 0";

        [RelayCommand]
        private void Count()
        {
            count++;
            CurrentCount = $"Current count: {count}";
        }

        [RelayCommand]
        private async Task Quit()
        {
            if (dialogService is not null)
            {
                if (await dialogService.DisplayAlertAsync("Quit!", "Are you sure?", "Yes", "No"))
                {
                    Application.Current?.Quit();
                }
            }
        }
    }
}
