using DIExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample.Services
{
	public class TheRealService : IScoreService
	{
		List<PlayerScore> scores;

		public TheRealService() { 
			scores = new List<PlayerScore>() { new PlayerScore() { Name = "Tal", Score = 100 } };
		}
		public void AddHighScore(PlayerScore score)
		{
			scores.Add(score);
		}

		public List<PlayerScore> GetHighScores()
		{
			return scores.Select(x => new PlayerScore() {Score= x.Score, Name=x.Name }).ToList();
		}
	}
}
