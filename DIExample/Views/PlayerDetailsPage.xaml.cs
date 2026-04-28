using DIExample.ViewModels;

namespace DIExample.Views;

public partial class PlayerDetailsPage : ContentPage
{
	public PlayerDetailsPage(PlayerDetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}