﻿using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using CommunityToolkit.Maui.Behaviors;
using Microsoft.Extensions.Logging;

namespace DateCalculator
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            DefaultBindableProperties.RegisterForCommand((EventToCommandBehavior.CommandProperty, EventToCommandBehavior.CommandParameterProperty));
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                   .UseMauiCommunityToolkit()
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("fa-regular-400.ttf", "FAR");
                       fonts.AddFont("fa-solid-900.ttf", "FAS");
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSans400");
                       fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSans600");
                       fonts.AddFont("Catamaran-Regular.ttf", "Catamaran400");
                       fonts.AddFont("Catamaran-SemiBold.ttf", "Catamaran600");
                       //fonts.AddFont("OpenSans-Bold.ttf", "OpenSans700");
                       fonts.AddFont("Roboto-Regular.ttf", "Roboto400");
                       fonts.AddFont("Roboto-Bold.ttf", "Roboto700");
                   });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
