using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace GameContent
{
	public class BoardStateManager
	{
		public BoardStateManager()
		{
		}

		public int ClickedRegion(Region[] regions, MouseState current, MouseState prev)
		{
			for (int i = 0; i < regions.Length; i++) {
				if (Regions.Interactive.HasMouseClickedRegion(current, prev, regions[i].rect))
				{
					return i;
				}
			}
			return -1;
		}

		public void UpdateClickedRegionState(Region[] regions, int idx) {
			if (idx != -1) {
				regions[idx].InteractWithRegionState();
			}
		}
	}
}
