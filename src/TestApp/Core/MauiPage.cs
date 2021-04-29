using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace TestApp.Core
{
    public class MauiPage : ContentPage, IPage
    {
        public IView View { get => Content; set => Content = (View)value; }
    }
}
