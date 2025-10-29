#if FileBasedProgram
#:sdk Aspire.AppHost.Sdk@9.5.2
#:package Aspire.Hosting.AppHost@9.5.2

#:project ..\MauiApp1.Api\MauiApp1.Api.csproj
#:project ..\MauiApp1\MauiApp1.csproj
#endif

var builder = DistributedApplication.CreateBuilder(args);

// Configure builder
// Web API
var webapi = builder.AddProject<Projects.MauiApp1_Api>("webapi");

// .NET MAUI
builder.AddProject<Projects.MauiApp1>("mauiapp")
    .WithEnvironment("TargetFramework", "net10.0-windows10.0.19041.0")
    //.WithEnvironment("TargetFramework", "net10.0-android")
    .WithReference(webapi);

var aspire = builder.Build();
aspire.Run();
