using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class AllProduct : ContentPage
{
    public AllProduct()
    {
        InitializeComponent();
        BindingContext = new AllProductViewModel();
    }
}