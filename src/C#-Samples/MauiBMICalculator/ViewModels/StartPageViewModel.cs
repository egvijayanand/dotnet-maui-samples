namespace MauiBMICalculator.ViewModels;

public partial class StartPageViewModel : ObservableObject
{
    private INavigation _navigationService;
    private Page _pageService;

    private string selectedGender = string.Empty;

    [ObservableProperty]
    private bool isMaleSelected = false;

    [ObservableProperty]
    private bool isFemaleSelected = false;

    public StartPageViewModel(INavigation navigationService, Page pageService)
    {
        _navigationService = navigationService;
        _pageService = pageService;
    }

    [RelayCommand]
    private async void SelectGender(string gender)
    {
        selectedGender = gender;

        IsMaleSelected = false;
        IsFemaleSelected = false;

        if (gender == "Male")
            IsMaleSelected = true;
        else
            IsFemaleSelected = true;
    }

    [RelayCommand]
    private async void GotoStep2()
    {
        if (string.IsNullOrEmpty(selectedGender))
        {
            //Display a message and do nothing
            await _pageService.DisplayAlert("GENDER SELECTION", "Please choose your gender before proceeding further.", "Got it!");

            return;
        }

        await _navigationService.PushAsync(new Step2Page(selectedGender));
    }


}

