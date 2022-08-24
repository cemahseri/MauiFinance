using MauiFinance.ViewModels;

namespace MauiFinance.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        BindingContext = new MainViewModel();
    }
}