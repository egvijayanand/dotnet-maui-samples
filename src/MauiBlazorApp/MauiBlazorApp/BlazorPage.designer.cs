using CommunityToolkit.Maui.Markup;
using MauiBlazorApp.Controls;
using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Maui.Controls;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;
using MauiBlazorApp.Extensions;

namespace MauiBlazorApp
{
    public partial class BlazorPage : ContentPage
    {
        enum BodyRow { Top, Bottom }

        public void InitializeComponent()
        {
            SetDynamicResource(ContentPage.BackgroundColorProperty, "SecondaryColor");
            Content = new Grid()
            {
                RowDefinitions = Rows.Define(Auto, Star),
                Children =
                {
                    new StackLayout()
                    {
                        Children =
                        {
                            new TextLabel("The current count is: 0").Start()
                                                                    .CenterVertical()
                                                                    .Assign(out lblCounter),
                            new TextButton("Increment").End()
                                                       .CenterVertical()
                                                       .Invoke(btn => btn.Clicked += Counter_Clicked),
                        },
                    }.Padding(20)
                     .Row(BodyRow.Top),
                    new BlazorWebView()
                    {
                        RootComponents =
                        {
                            new RootComponent().ComponentType(typeof(Gateway))
                                               .Selector("#app"),
                        },
                    }.HostPage("wwwroot/index.html")
                     .Row(BodyRow.Bottom),
                }
            }.Fill();
        }

        #region Variables
        private Label lblCounter;
        #endregion
    }
}