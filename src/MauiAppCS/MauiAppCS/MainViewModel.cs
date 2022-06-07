using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiAppCS
{
    public partial class MainViewModel : ObservableObject
    {
        private int count;
        private readonly ISemanticScreenReader semanticScreenReader;

        public MainViewModel(ISemanticScreenReader semanticScreenReader)
        {
            this.semanticScreenReader = semanticScreenReader;
        }

        [ObservableProperty]
        private string counter = "Current count: 0";

        [RelayCommand]
        private void OnClick()
        {
            count++;
            Counter = $"Current count: {count}";
            semanticScreenReader.Announce(Counter);
        }
    }
}
