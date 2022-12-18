using MauiApp1.Models;
using MauiApp1.Services;

namespace MauiApp1;

public partial class App : Application
{
    /*
	 Erros waar ik de oplossing niet van vind :))

	static TurfService TurfService;

    public static TurfService TurfService
	{
		get
		{
			if (TurfService == null)
			{
				TurfService = new TurfService(
					Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "turfDB.db3"));
			}
			return TurfService;
		}
	}
	*/

    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
