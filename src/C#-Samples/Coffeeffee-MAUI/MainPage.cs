using Coffeeffee_MAUI.Models;

namespace Coffeeffee_MAUI;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        BindingContext = new List<Coffee>
            {
                new Coffee { Title="XamaCoffee", Price=3.99, Quantity = 1, Image="xamacoffee.jpg",
                    Subtitle="This is the best coffee on Hawaii!",
                    Description="Coffee brewn on the foothills of Maui. It's nutty aftertaste comes from Depechie's cat, that ate it first. Apparently. Gerald Versluis hops by in a bunny suit."
                },
                new Coffee { Title="XamaCoffee Deluxe", Price=5.99, Quantity = 1 , Image="xamacoffee.jpg", Subtitle="This is the bestest coffee on Hawaii!"},
                new Coffee { Title="XamaCoffee Super Deluxe", Price=10.99, Quantity = 1, Image="xamacoffee.jpg", Subtitle="This is the bestestest coffee on Hawaii!" },
            };
    }

    async void Image_Tapped(System.Object sender, System.EventArgs e)
    {
        var model = (sender as Image).BindingContext as Coffee;
        await Navigation.PushAsync(new DetailPage(model));
    }
}