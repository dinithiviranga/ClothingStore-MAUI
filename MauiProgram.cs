using DDClothingStoreMAUI.View;
using DDClothingStoreMAUI.ViewModel;
using Microsoft.Extensions.Logging;

namespace DDClothingStoreMAUI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("materialdesignicons-webfont.ttf", "MaterialFontFamily");
            });

        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<HomePage>();
        builder.Services.AddTransient<ItemListPage>();
        builder.Services.AddTransient<ItemDetailPage>();
        builder.Services.AddTransient<HomePageViewModel>();
        builder.Services.AddTransient<ItemDetailViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}