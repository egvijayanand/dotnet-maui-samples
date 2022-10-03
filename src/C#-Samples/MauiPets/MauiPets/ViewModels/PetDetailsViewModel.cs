namespace MAUIPETS.ViewModels;

[QueryProperty(nameof(Pet), "Pet")]
public partial class PetDetailsViewModel : BaseViewModel
{
    public PetDetailsViewModel()
    {
    }

    [ObservableProperty]
    Pet pet;

}


