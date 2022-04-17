using Microsoft.AspNetCore.Components.WebView.Maui;
using VijayAnand.MauiBlazor.Markup;
using VijayAnand.MauiToolkit.Markup;
using static MauiBlazorApp.Extensions.GenericExtensions;

#nullable enable

namespace MauiBlazorApp
{
    public partial class BlazorPage : ContentPage
    {
        enum BodyRow { Top, Bottom }

        public void InitializeComponent()
        {
            Content = new Grid()
            {
                RowDefinitions = Rows.Define(Auto, Star),
                Style = AppResource<Style>("ContentArea"),
                Children =
                {
                    new StackLayout()
                    {
                        Children =
                        {
                            new Label()
                            {
                                Style = AppResource<Style>("MauiLabel"),
                                Text = "The current count is: 0"
                            }.Start()
                             .CenterVertical()
                             .Bold()
                             .Assign(out lblCounter),
                            new Button()
                            {
                                Style = AppResource<Style>("PrimaryAction"),
                                Text = "Increment"
                            }.CenterVertical()
                             .Invoke(btn => btn.Clicked += Counter_Clicked),
                        },
                    }.InHorizontal()
                     .Padding(20)
                     .Row(BodyRow.Top),
                    new BlazorWebView().Configure("wwwroot/index.html",
                                                  ("#app", typeof(Gateway), CreateDictionary<string, object?>((nameof(Gateway.Foo), "Bar"))))
                                       .Row(BodyRow.Bottom),
                }
            }.Fill();
        }

        #region Variables
        private Label lblCounter;
        #endregion
    }
}