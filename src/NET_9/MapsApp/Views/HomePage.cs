using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Devices.Sensors;
using Microsoft.Maui.Maps;

namespace MapsApp.Views;

public class HomePage : ContentPage
{
    public HomePage()
    {
        Content = new Map(new MapSpan(new Location(47.643543, -122.130821), 0.01, 0.01));
    }
}
