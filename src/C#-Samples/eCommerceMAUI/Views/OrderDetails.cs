using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class OrderDetails : ContentPage
{
    public OrderDetails()
    {
        InitializeComponent();
        BindingContext = new OrderDetailsViewModel();
    }
}