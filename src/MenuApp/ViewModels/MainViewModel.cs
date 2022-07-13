using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MenuApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        int count = 0;

        [ObservableProperty]
        private string currentCount = "Current count: 0";

        [RelayCommand]
        private void Count()
        {
            count++;
            CurrentCount = $"Current count: {count}";
        }

        [RelayCommand]
        private void Quit()
        {
            Application.Current?.Quit();
        }
    }
}
