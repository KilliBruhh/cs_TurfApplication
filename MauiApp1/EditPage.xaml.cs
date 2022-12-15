using MauiApp1.ViewModel;

namespace MauiApp1;

public partial class EditPage : ContentPage
{
	public EditPage(EditViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}