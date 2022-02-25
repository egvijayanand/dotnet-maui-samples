using MauiBlazorApp.Controls;
using Microsoft.AspNetCore.Components.WebView.Maui;
using VijayAnand.MauiBlazor.Markup;

using static MauiBlazorApp.Extensions.GenericExtensions;

#nullable enable

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
                    new HStack()
                    {
                        Children =
                        {
                            new TextLabel("The current count is: 0").Start()
                                                                    .CenterVertical()
                                                                    .Bold()
                                                                    .Assign(out lblCounter),
                            new TextButton("Increment").CenterVertical()
                                                       .Invoke(btn => btn.Clicked += Counter_Clicked),
                        },
                    }.Padding(20)
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