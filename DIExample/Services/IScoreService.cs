using DIExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample.Services
{
	public interface IScoreService
	{
		public List<PlayerScore> GetHighScores();
		public void AddHighScore(PlayerScore score);
	}
}
