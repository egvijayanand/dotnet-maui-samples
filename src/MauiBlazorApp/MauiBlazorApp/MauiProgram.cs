﻿using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using RazorLib;

namespace MauiBlazorApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.RegisterBlazorMauiWebView()
                   .UseMauiApp<App>()
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                   });

            builder.Services.AddBlazorWebView();

            builder.Services.AddSingleton<AppState>();
            builder.Services.AddSingleton<BlazorPage>();
            builder.Services.AddSingleton<WebPage>();

            return builder.Build();
        }
    }
}