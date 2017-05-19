using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace GameContent
{
	public class BoardStateManager
	{

		public static int playerState { get; set;} 

		public BoardStateManager()
		{
			BoardStateManager.playerState = 1;
		}

		public static int ClickedRegion(Region[] regions, MouseState current, MouseState prev)
		{
			for (int i = 0; i < regions.Length; i++) {
				if (Regions.Interactive.HasMouseClickedRegion(current, prev, regions[i].rect))
				{
					return i;
				}
			}
			return -1;
		}

		public static void UpdateClickedRegionState(Region[] regions, int idx) {
			if (idx != -1) {
				regions[idx].InteractWithRegionState();
			}
		}

		public static void UpdatePlayerState() {
			playerState = -playerState;
		}
	}
}
