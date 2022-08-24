namespace MauiBMICalculator.ViewModels;

public partial class Step2PageViewModel : ObservableObject
{
    private INavigation _navigationService;

    private string _selectedGender;

    [ObservableProperty]
    private string avatarImage;

    [ObservableProperty]
    private float selectedWeight = 0f;

    partial void OnSelectedWeightChanged(float value) =>
        HeightWeightChanged?.Invoke(this, new EventArgs());

    [ObservableProperty]
    private float selectedHeight = 0f;

    partial void OnSelectedHeightChanged(float value) =>
        HeightWeightChanged?.Invoke(this, new EventArgs());

    public event EventHandler HeightWeightChanged;


    public Step2PageViewModel(INavigation navigationService, string selectedGender)
    {
        _navigationService = navigationService;

        _selectedGender = selectedGender;

        AvatarImage = $"{selectedGender.ToLower()}.png";

        SelectedHeight = 130;
        SelectedWeight = 75;
    }


    [RelayCommand]
    private async void CalculateBMI() =>
        await _navigationService.PushAsync(new ResultsPage(_selectedGender, SelectedHeight, SelectedWeight));


}

