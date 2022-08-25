using Coffeeffee_MAUI.Models;

namespace Coffeeffee_MAUI;

public partial class DetailPage : ContentPage
{
    public DetailPage(Coffee coffee)
    {
        InitializeComponent();

        BindingContext = coffee;
    }

    async void Back_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}