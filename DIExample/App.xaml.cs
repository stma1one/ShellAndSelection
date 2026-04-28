using DIExample.Views;

namespace DIExample
{
	public partial class App : Application
	{
		Page startPage;
		public App(ScorePage p)
		{
			InitializeComponent();
			startPage = p;
		}

		protected override Window CreateWindow(IActivationState? activationState)
		{
			return new Window(startPage);
		}
	}
}