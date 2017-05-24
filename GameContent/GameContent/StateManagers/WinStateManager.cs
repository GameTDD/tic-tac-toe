using System;
using Microsoft.Xna.Framework;

namespace GameContent
{
	public class WinStateManager
	{
		public static int PlayerWon(Region[] regions) {
			if (regions[0].state == 1 && regions[1].state == 1 && regions[2].state == 1)
			{
				return 1;
			}
			else return 0;
		}
	}
}
