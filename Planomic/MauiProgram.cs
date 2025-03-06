using Planomic.Data;
using Microsoft.Extensions.DependencyInjection;
using Planomic;
using Planomic.Services;
using Planomic.Views;


public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>()
               .ConfigureFonts(fonts =>
               {
                   fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                   fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
               });

        builder.Services.AddDbContext<AppDbContext>();

        builder.Services.AddSingleton<DatabaseService>();
        builder.Services.AddSingleton<ProjectsPage>();

        return builder.Build();
    }
}
