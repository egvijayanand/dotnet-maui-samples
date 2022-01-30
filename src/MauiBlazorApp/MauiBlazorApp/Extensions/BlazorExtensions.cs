using Microsoft.AspNetCore.Components.WebView.Maui;

namespace MauiBlazorApp.Extensions
{
    public static class BlazorExtensions
    {
        public static TBlazorWebView HostPage<TBlazorWebView>(this TBlazorWebView blazorWV, string hostPage)
            where TBlazorWebView : BlazorWebView
        {
            blazorWV.HostPage = hostPage;
            return blazorWV;
        }

        public static TRootComponent ComponentType<TRootComponent>(this TRootComponent component, Type type)
            where TRootComponent : RootComponent
        {
            component.ComponentType = type;
            return component;
        }

        public static TRootComponent Selector<TRootComponent>(this TRootComponent component, string selector)
            where TRootComponent : RootComponent
        {
            component.Selector = selector;
            return component;
        }

        public static TRootComponent Parameters<TRootComponent>(this TRootComponent component, params (string key, object? value)[] parameters)
            where TRootComponent : RootComponent
        {
            var dict = new Dictionary<string, object?>();

            foreach (var (key, value) in parameters)
            {
                dict.Add(key, value);
            }

            component.Parameters = dict;
            return component;
        }
    }
}
