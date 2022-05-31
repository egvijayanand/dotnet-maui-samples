using CommunityToolkit.Maui.Markup;
using static Microsoft.Maui.Graphics.Colors;

namespace EmbeddedAndroid
{
    public class MauiPage : ContentPage
    {
        public MauiPage()
        {
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "Welcome to .NET MAUI!!!"
                    }.TextColor(Purple)
                }
            }.Center();
        }
    }
}
