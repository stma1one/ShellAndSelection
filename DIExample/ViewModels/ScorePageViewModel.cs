using DIExample.Models;
using DIExample.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DIExample.ViewModels
{
	public class ScorePageViewModel:ViewModelBase
	{
		//תלויות
		private IScoreService _dataService;
		private List<PlayerScore> PlayerScores;
		private string scoresDisplayText;
		private PlayerScore selectedPlayer;

		public ICommand AddPlayerCommand
		{
			get; private set;
		}
		public ICommand ClearSelectionCommand{
			get; private set;
		}
		public PlayerScore SelectedPlayer
		{
			get => selectedPlayer;
			set
			{
				if (selectedPlayer != value)
				{
					selectedPlayer = value;
					OnPropertyChanged();
					UpdateDisplayText();
					//בכל שינוי בשדה - רענן האם הפעולה יכולה להתבצע
					(ClearSelectionCommand as Command)?.ChangeCanExecute();
				}
			}
		}

		private void UpdateDisplayText()
		{
			if(SelectedPlayer!=null)
			ScoresDisplayText = $"{SelectedPlayer.Name}-{SelectedPlayer.Score}";
			else
				ScoresDisplayText = string.Join("\n", PlayerScores.Select(s => $"{s.Name} - {s.Score}"));

		}

		public string ScoresDisplayText
		{
			get
			{
				return scoresDisplayText;
			}
			set
			{
				if (scoresDisplayText != value)
				{
					scoresDisplayText = value;
					OnPropertyChanged();

				}
			}
		}

		public ObservableCollection<PlayerScore> Players
		{
			get; set;
		}

		public ScorePageViewModel(IScoreService service) {
			_dataService = service ;
			//נביא את המידע מהשרת
			PlayerScores = _dataService.GetHighScores();
			//נאכלס את אוסף הנתונים
			Players = new ObservableCollection<PlayerScore>(PlayerScores);
			//פעולות
			AddPlayerCommand = new Command(() => Players.Add(new PlayerScore() { Name = "Tal", Score = 400 }));
			ClearSelectionCommand = new Command(() => SelectedPlayer = null,()=>SelectedPlayer!=null);	
	
			ScoresDisplayText = string.Join("\n", PlayerScores.Select(s => $"{s.Name} - {s.Score}"));


		}
	}
}
