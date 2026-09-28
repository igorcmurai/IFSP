// TP02 - CBTPRDM
// Igor Cerqueira Murai - CB3033295
// Gustavo Cerqueira Murai - CB3033261

using Microsoft.Extensions.Logging;

namespace TarefasApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont(
                    "OpenSans-Regular.ttf",
                    "OpenSansRegular");

                fonts.AddFont(
                    "OpenSans-Semibold.ttf",
                    "OpenSansSemibold");
            });

#if WINDOWS

        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(
            "Material3Entry",
            (handler, view) =>
            {
                handler.PlatformView.BorderThickness =
                    new Microsoft.UI.Xaml.Thickness(0);

                handler.PlatformView.BorderBrush = null;
                handler.PlatformView.Background = null;

                handler.PlatformView.Padding =
                    new Microsoft.UI.Xaml.Thickness(0);
            });


        Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping(
            "Material3Editor",
            (handler, view) =>
            {
                handler.PlatformView.BorderThickness =
                    new Microsoft.UI.Xaml.Thickness(0);

                handler.PlatformView.BorderBrush = null;
                handler.PlatformView.Background = null;

                handler.PlatformView.Padding =
                    new Microsoft.UI.Xaml.Thickness(0);
            });


        Microsoft.Maui.Handlers.PickerHandler.Mapper.AppendToMapping(
            "Material3Picker",
            (handler, view) =>
            {
                handler.PlatformView.BorderThickness =
                    new Microsoft.UI.Xaml.Thickness(0);

                handler.PlatformView.BorderBrush = null;
                handler.PlatformView.Background = null;

                handler.PlatformView.Padding =
                    new Microsoft.UI.Xaml.Thickness(0);
            });


        Microsoft.Maui.Handlers.DatePickerHandler.Mapper.AppendToMapping(
            "Material3DatePicker",
            (handler, view) =>
            {
                handler.PlatformView.BorderThickness =
                    new Microsoft.UI.Xaml.Thickness(0);

                handler.PlatformView.BorderBrush = null;
                handler.PlatformView.Background = null;

                handler.PlatformView.Padding =
                    new Microsoft.UI.Xaml.Thickness(0);
            });

#endif

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}