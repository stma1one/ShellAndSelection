using DIExample.ViewModels;

namespace DIExample.Views;

public partial class LoginUsernamePage : ContentPage
{
	public LoginUsernamePage(LoginUsernameViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}