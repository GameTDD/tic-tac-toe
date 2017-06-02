using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.FSharp.Core;

namespace GameContent
{
	public class Region
	{
		public Rectangle rect { get; set; }
		public int state { get; set; }
		public Vector2 StringPosition { get; set; }

		public SpriteFont font { get; set;}

		public Region(int x, int y, int width, int height, SpriteFont font)
		{
			rect = new Rectangle(x, y, width, height);
			this.font = font;
			state = 0;
			StringPosition = new Vector2(rect.Left + 30, rect.Top + 30);
		}

		public void InteractWithRegionState() 
		{
			if (!IsActive()) 
			{
				state = BoardStateManager.playerState;
				BoardStateManager.UpdatePlayerState();
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

		public string GetSymbol() 
		{
			return Regions.State.GetStateString(state);
		}


		public void Draw(SpriteBatch sb)
		{
			sb.DrawString(font, GetSymbol(), StringPosition, Color.Black);
		}
	}
}
