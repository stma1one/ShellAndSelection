using DIExample.ViewModels;

namespace DIExample.Views;

public partial class LoginContactPage : ContentPage
{
	public LoginContactPage(LoginContactViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;	
	}
}