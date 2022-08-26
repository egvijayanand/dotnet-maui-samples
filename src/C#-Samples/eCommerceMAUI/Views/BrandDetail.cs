using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class BrandDetail : ContentPage
{
    public BrandDetail()
    {
        InitializeComponent();
        BindingContext = new BrandDetailViewModel();
    }
}