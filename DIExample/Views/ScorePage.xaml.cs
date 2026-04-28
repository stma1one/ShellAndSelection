using DIExample.ViewModels;

namespace DIExample.Views;

public partial class ScorePage : ContentPage
{
	public ScorePage(ScorePageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	
}