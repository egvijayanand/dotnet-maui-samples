using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class Profile : ContentPage
{
    public Profile()
    {
        InitializeComponent();
        BindingContext = new ProfileViewModel();
    }
}