using DIExample.Views;

namespace DIExample
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();
			RegisterPages();
		}
		private void RegisterPages()
		{
			Routing.RegisterRoute("PlayerDetails", typeof(PlayerDetailsPage));
			
		}


	}
}
