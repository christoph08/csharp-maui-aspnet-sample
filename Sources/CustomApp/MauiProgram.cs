﻿using CustomApp.Models.Pages;
using Microsoft.Extensions.Logging;

namespace CustomApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            // Create builder
            var builder = MauiApp.CreateBuilder();

            // Configure application
            builder.UseMauiApp<App>();

            // Configure fonts
            builder.ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                }
            );

            // Configure services
            builder.Services.AddSingleton<UsersPageModel>();
            builder.Services.AddSingleton<UserPageModel>();
            builder.Services.AddSingleton<IssuesPageModel>();
            builder.Services.AddSingleton<IssuePageModel>();

#if DEBUG
            // Configure debugger
            builder.Logging.AddDebug();
#endif

            // Build application
            return builder.Build();
        }
    }
}
