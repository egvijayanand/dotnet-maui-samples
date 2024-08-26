// Note: There's a change in namespace.
using Microsoft.Maui.Controls.Embedding;
//using Microsoft.Maui.Embedding;
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

            var mauiApp = MauiApp.CreateBuilder()
                .UseMauiEmbeddedApp<MyApp>() // Note: The method name too got updated.
                .Build();

            var mauiContext = new MauiContext(mauiApp.Services, this);

            var mauiPage = new MauiPage();
            // Platform-specific extension method
            SetContentView(mauiPage.ToContainerView(mauiContext));
            // Platform-neutral extension method
            //SetContentView(mauiPage.ToPlatform(mauiContext));
        }
    }
}
