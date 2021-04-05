﻿using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;

namespace TestApp
{
    public class Startup : IStartup
    {
        public void Configure(IAppHostBuilder appBuilder)
        {
            appBuilder
                .RegisterCompatibilityForms()
                .RegisterCompatibilityRenderers()
                .UseMauiApp<App>();
        }
    }
}