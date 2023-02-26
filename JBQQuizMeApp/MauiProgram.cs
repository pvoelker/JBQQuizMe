using CommunityToolkit.Maui;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace JBQQuizMeApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.UseSkiaSharp()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("MorningRainbow.ttf", "MorningRainbow");
			});

        Preferences.Default.Set("bf362ddb-713f-46e6-9c7d-d620f40766c6", "DLXQfyQ113Zmqos7N8/g2w==");
        Preferences.Default.Set("4ad5e9b5-4dca-4c5e-991a-b5bed2c123ec", "BLpDgJ35CMg/nu0UPy9uiCDSPdDdXbbKhoJgK+dPUJI=");
        Preferences.Default.Set("19e32c9e-9e3c-4707-b537-6f8c0cdc1d93", "8Xj1tDnD/WTWhX1g+Y/XIVBo5sHPDoidhz5VZYQ5MoZ8wKUDs2qYOOkUGh6to/DGfSrwxdfYcu42rR4nkAw+yg==");

        return builder.Build();
	}
}
