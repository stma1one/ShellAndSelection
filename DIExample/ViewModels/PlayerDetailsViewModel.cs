using DIExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DIExample.ViewModels
{
	//[QueryProperty(nameof(PlayerName),"name")]
	//[QueryProperty(nameof(Player),"player")]
	public class PlayerDetailsViewModel : ViewModelBase,IQueryAttributable
	{
		private string playerName;
		private PlayerScore _player;

		// המאפיין שיחזיק את נתוני השחקן שיוצגו במסך
		public PlayerScore Player
		{
			get => _player;
			set
			{
				if (_player != value)
				{
					_player = value;
					OnPropertyChanged();
				}
			}
		}

		public string PlayerName
		{
			get => playerName;
			set
			{
				playerName = value;
				OnPropertyChanged();
			}
		}
		public PlayerDetailsViewModel()
		{
			// הבנאי כרגע ריק, הנתונים יגיעו דרך הניווט
		}
	
		public void ApplyQueryAttributes(IDictionary<string, object> query)
		{
			Player = query["player"] as PlayerScore;
			//אם יש תווים מיוחדים או עברית לא ניתן להמיר ישירות (פרמטר פרימיטיבי)
			//PlayerName = query["name"].ToString();
			//צריך לבצע המרה
			PlayerName = HttpUtility.UrlDecode(query["name"].ToString());
		}
		private async Task RetrunToHomeAsync()
		{
			Shell.Current.GoToAsync("//ScorePage/PlayerDetails/fff");

		}
	}
}
