using MauiApp1.ViewModel;

namespace MauiApp1;

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

		// Signleton => Global Static creates it once
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainViewModel>();

		// will be Created and destroyed everytime it gets loaded and unloaded
		builder.Services.AddTransient<DetailPage>();
		builder.Services.AddTransient<DetailViewModel>();

		builder.Services.AddTransient<EditPage>();
		builder.Services.AddTransient<EditViewModel>();

		return builder.Build();
	}
}
