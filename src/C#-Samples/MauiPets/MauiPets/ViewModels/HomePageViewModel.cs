using MAUIPETS.Services;
using System.Diagnostics;

namespace MAUIPETS.ViewModels;

public partial class HomePageViewModel : BaseViewModel
{
    public ObservableCollection<Pet> Pets { get; } = new();
    PetService petService;
    public HomePageViewModel(PetService petService)
    {
        Title = "Choose your next big friend";
        this.petService = petService;
        
    }

    [ObservableProperty]
    bool isRefreshing=true;

    [ObservableProperty]
    Pet selectedPet;

    [RelayCommand]
    async Task GetPetsAsync()
    {
        if (IsBusy)
            return;

        try
        {
            IsBusy = true;
            Console.WriteLine("Buscando Mascotas");

            var pets = await petService.GetPets();

            if (Pets.Count != 0)
                Pets.Clear();

            foreach (var pet in pets)
                Pets.Add(pet);

        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to get Pets: {ex.Message}");
            Console.WriteLine("No encontramos Mascotas");
            await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
        }
        finally
        {
            IsBusy = false;
            IsRefreshing = false;
        }

    }

    [RelayCommand]
    async Task GoToDetails()
    {
        if (selectedPet == null)
            return;

        var data = new Dictionary<string, object>
            {
                {"Pet", selectedPet }
            };

        await Shell.Current.GoToAsync(nameof(PetDetailsView), true, data);
    }
}