using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample.Models
{
	public class PlayerScore:ObservableObject
	{
		private string profileImage;
		private string? _name;
		private int _score;
		public string? Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (_name != value)
				{
					_name = value; OnPropertyChanged();
				}
			}
		}
		public int Score
		{ get
			{ return _score; } 
			set
			{ if(_score != value)
				{ _score = value; OnPropertyChanged();
				} 
			}
		}

		public string ProfileImage
		{
			get => profileImage;
			set
			{
				if (profileImage != value)
				{
					profileImage = value;
					OnPropertyChanged();
				}
			}
		}
	}
}
