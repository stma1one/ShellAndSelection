using DIExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample.ViewModels
{
	public class PlayerDetailsViewModel : ViewModelBase
	{
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

		public PlayerDetailsViewModel()
		{
			// הבנאי כרגע ריק, הנתונים יגיעו דרך הניווט
		}
	}
}
