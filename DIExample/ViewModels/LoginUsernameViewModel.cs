using System.Windows.Input;

namespace DIExample.ViewModels
{
	public class LoginUsernameViewModel : ViewModelBase
	{
		private string _username;
		private string _password;

		public string Username
		{
			get => _username;
			set
			{
				_username = value; OnPropertyChanged();
			}
		}

		public string Password
		{
			get => _password;
			set
			{
				_password = value; OnPropertyChanged();
			}
		}

		public ICommand LoginCommand
		{
			get;
		}

		public LoginUsernameViewModel()
		{
			LoginCommand = new Command(async () => await OnLogin());
		}

		private async Task OnLogin()
		{
			if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
			{
				// שימוש ב-Shell.Current במקום MainPage
				await Shell.Current.DisplayAlert("שגיאה", "יש להזין שם משתמש וסיסמה", "אישור");
				return;
			}

			// כאן תלמד את התלמידים להוסיף לוגיקת אימות וניווט ב-Shell
			await Shell.Current.DisplayAlert("התחברות", $"ברוך הבא, {Username}!", "אישור");
		}
	}
}