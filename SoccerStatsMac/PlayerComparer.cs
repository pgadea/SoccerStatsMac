using System;
using System.Collections.Generic;

namespace SoccerStatsMac
{
	public class PlayerComparer : IComparer<Player>
	{
		public int Compare(Player x, Player y)
		{
			return x.PointsPerGame.CompareTo(y.PointsPerGame) * -1;
		}
	}
}
