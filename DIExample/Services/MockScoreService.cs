using DIExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample.Services
{
	public class MockScoreService :IScoreService
	{
		List<PlayerScore> players;

		public MockScoreService()
		{
			players = new List<PlayerScore>
		{
			new PlayerScore { Name = "רון", Score = 150 },
			new PlayerScore { Name = "מיכל", Score = 120 },
			new PlayerScore { Name = "דני", Score = 90 }
		};
		}
		public void AddHighScore(PlayerScore score)
		{
			players.Add(score);
		}

		public List<PlayerScore> GetHighScores()
		{
			return players.Select(p=>new PlayerScore { Name = p.Name, Score = p.Score }).ToList();
			
		}
	
	}
}
