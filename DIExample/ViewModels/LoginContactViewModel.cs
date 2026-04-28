using System.Windows.Input;

namespace DIExample.ViewModels
{
	public class LoginContactViewModel : ViewModelBase
	{
		private string _phone;
		private string _email;

		public string Phone
		{
			get => _phone;
			set
			{
				_phone = value; OnPropertyChanged();
			}
		}

		public string Email
		{
			get => _email;
			set
			{
				_email = value; OnPropertyChanged();
			}
		}

		public ICommand LoginCommand
		{
			get;
		}

		public LoginContactViewModel()
		{
			LoginCommand = new Command(OnLogin);
		}

		private async void OnLogin()
		{
			// לוגיקת בדיקה בסיסית
			if (string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(Email))
			{
				await Shell.Current.DisplayAlert("שגיאה", "יש למלא את כל השדות", "אישור");
				return;
			}

			await Shell.Current.DisplayAlert("התחברות", $"קוד אימות נשלח ל-{Email}", "אישור");
		}
	}
}