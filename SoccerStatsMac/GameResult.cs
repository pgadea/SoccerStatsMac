using System;
namespace SoccerStatsMac
{
	public class GameResult
	{
		public DateTime GameDate { get; set; }
		public string TeamName { get; set; }
		public HomeOrAway HomeOrAway { get; set; }
		public int Goals { get; set; }
		public int GoalAttempts { get; set; }
		public int ShotsOnGoal { get; set; }
		public int ShotsOffGoal { get; set; }
		public double PossessionPercent { get; set; }
		public double ConversionRate 
		{ 
			get
			{
				return (double)Goals / (double)GoalAttempts;
			}
		}

	}

	public enum HomeOrAway
	{
		Home,
		Away
	}
}

			