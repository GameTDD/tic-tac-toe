using System;
using Microsoft.Xna.Framework;

namespace GameContent
{
	public class WinStateManager
	{
		public static int PlayerWon(Region[] regions) {

			int row1 = CheckRowColWinner(new Region[] {regions[0], regions[1], regions[2] });
			int row2 = CheckRowColWinner(new Region[] { regions[3], regions[4], regions[5] });
			int row3 = CheckRowColWinner(new Region[] { regions[6], regions[7], regions[8] });

			int col1 = CheckRowColWinner(new Region[] { regions[0], regions[3], regions[6] });
			int col2 = CheckRowColWinner(new Region[] { regions[1], regions[4], regions[7] });
			int col3 = CheckRowColWinner(new Region[] { regions[2], regions[5], regions[8] });

			int dia1 = CheckRowColWinner(new Region[] { regions[0], regions[4], regions[8] });
			int dia2 = CheckRowColWinner(new Region[] { regions[2], regions[4], regions[6] });

			return DetermineWinner(DetermineWinner(row1, row2, row3), DetermineWinner(col1, col2, col3), 
			                       DetermineWinner(dia1, dia2, 0));
		}

		private static int CheckRowColWinner(Region[] regions)
		{
			if (regions[0].state == regions[1].state && regions[1].state == regions[2].state 
			    && regions[0].state != 0) 
			{
				return regions[0].state;
			}
			return 0;
		}

		private static int DetermineWinner(int a, int b, int c) 
		{
			if (a != 0)
			{
				return a;
			}
			else if (b != 0)
			{
				return b;
			}
			return c;
		}
	}
}
