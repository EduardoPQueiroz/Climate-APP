using ClimateApp.Services;
using ClimateApp.ViewModels;

namespace ClimateApp.Views;

public partial class WeatherPage : ContentPage
{
	public WeatherPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}