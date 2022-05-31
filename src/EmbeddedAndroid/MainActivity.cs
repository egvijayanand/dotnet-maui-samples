using Android.App;
using Android.OS;
using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Embedding;
using Microsoft.Maui.Platform;

namespace EmbeddedAndroid
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.activity_main);

            var builder = MauiApp.CreateBuilder();
            builder.UseMauiEmbedding<App>()
                   .UseMauiCommunityToolkitMarkup();
            var mauiApp = builder.Build();
            var mauiContext = new MauiContext(mauiApp.Services, this);
            var mauiPage = new MauiPage();
            // Platform-specific extension method
            SetContentView(mauiPage.ToContainerView(mauiContext));
            // Platform-independent extension method
            //SetContentView(mauiPage.ToPlatform(mauiContext));
        }
    }
}
