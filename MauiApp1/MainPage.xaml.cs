using CommunityToolkit.Mvvm.Input;

using MauiApp1.ViewModel;
using MauiApp1.Services;
using MauiApp1.Models;

namespace MauiApp1;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}

 