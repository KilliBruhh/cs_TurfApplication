using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;
using MauiApp1.ViewModel;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;
	// public TurfInfo TurfInfo { get; set; }
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}

 