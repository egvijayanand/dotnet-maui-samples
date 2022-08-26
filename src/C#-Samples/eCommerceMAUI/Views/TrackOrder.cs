using EcommerceMAUI.ViewModel;
using static EcommerceMAUI.Model.TrackOrderModel;

namespace EcommerceMAUI.Views;

public partial class TrackOrder : ContentPage
{
    public TrackOrder(Track data)
    {
        InitializeComponent();
        BindingContext = new TrackOrderViewModel(data);
    }
}