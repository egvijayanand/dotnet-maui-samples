using CommunityToolkit.Maui.Maps.Handlers;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Hosting;
using System.Reflection;

namespace MapsApp.Extensions;

public static class AppBuilderExtensions
{
    public static MauiAppBuilder UseMauiToolkitMaps(this MauiAppBuilder builder, string key)
    {
        SetMapsKey(key);
        builder.ConfigureMauiHandlers(handlers => handlers.AddHandler<Map, MapHandlerWindows>());
        return builder;

        static void SetMapsKey(string key)
        {
            var mapsKey = typeof(MapHandlerWindows).GetField("MapsKey", BindingFlags.NonPublic | BindingFlags.Static);
            mapsKey?.SetValue(null, key);
        }
    }
}
