using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.FSharp.Core;

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

		public void InteractWithRegionState(MouseState current, MouseState previous) 
		{
			if (Regions.Interactive.HasMouseClickedRegion(current, previous, rect) && !IsActive()) 
			{
				state = 1;
			}
		}

		public bool IsActive() 
		{
			if (state == 1 || state == -1) 
			{
				return true;
			}
			return false;
		}
	}
}
