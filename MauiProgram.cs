#if ANDROID
using Android.Views;
using Microsoft.Maui.LifecycleEvents;
#endif

namespace MauiFinance;

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
            });
#if ANDROID
        builder = builder.ConfigureLifecycleEvents(lifecycleBuilder =>
        {
            lifecycleBuilder.AddAndroid(android => android.OnCreate((activity, _) =>
            {
                // To extend outside of the screen. This will also allow us to use fullscreen indicator's (that white/black horizontal line at the bottom of the screen) space aswell
                // Otherwise, that indicator will have black background
                activity.Window!.SetFlags(WindowManagerFlags.LayoutNoLimits, WindowManagerFlags.LayoutNoLimits);

                // To enter in fullscreen mode.
                activity.Window.AddFlags(WindowManagerFlags.Fullscreen);
                activity.Window.ClearFlags(WindowManagerFlags.ForceNotFullscreen);
            }));
        });
#endif
        
        return builder.Build();
	}
}