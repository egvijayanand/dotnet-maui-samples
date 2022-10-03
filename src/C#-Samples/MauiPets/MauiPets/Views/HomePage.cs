using MAUIPETS.Models;
using MAUIPETS.ViewModels;
using MAUIPETS.Views;

namespace MAUIPETS.Views;

public partial class HomePage : ContentPage
{
    public HomePageViewModel viewModel;

    public HomePage(HomePageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ((HomePageViewModel)BindingContext).SelectedPet = null;
    }

    private async void Donate_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DonatePage());
    }


    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        var pet = ((VisualElement)sender).BindingContext as Pet;

        if (pet == null)
            return;
        await Shell.Current.GoToAsync(nameof(PetDetailsView), true, new Dictionary<string, object>
        {
            {"Pet", pet }
        });
    }
}
