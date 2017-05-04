using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace GameContent
{
	public class Region
	{
		public Rectangle rect { get; set; }
		public int state { get; set; }

		public Region(int x, int y, int width, int height)
		{
			rect = new Rectangle(x, y, width, height);
			state = 0;
		}
	}
}
