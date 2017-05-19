using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace GameContent
{
	public class Board
	{
		public Rectangle[] lines { get; set; }
		public Region[] regions { get; set; }
		SpriteFont font;
		MouseState current, previous;
		public int Thickness { get; set; }
		public int Length { get; set;}

		public Board(SpriteFont font)
		{
			lines = new Rectangle[4];
			regions = new Region[9];
			current = previous = Mouse.GetState();
			this.font = font;
			Thickness = 10;
			Length = 300;
			SetLinesData();
			SetRegionsData();
		}

		private void SetLinesData() 
		{
			lines[0] = new Rectangle(195, 100, Thickness, Length);
			lines[1] = new Rectangle(295, 100, Thickness, Length);
			lines[2] = new Rectangle(100, 195, Length, Thickness);
			lines[3] = new Rectangle(100, 295, Length, Thickness);
		}

		private void SetRegionsData()
		{
			regions[0] = new Region(100, 100, 94, 94, font);
			regions[1] = new Region(206, 100, 88, 94, font);
			regions[2] = new Region(306, 100, 94, 94, font);
			regions[3] = new Region(100, 206, 94, 88, font);
			regions[4] = new Region(206, 206, 88, 88, font);
			regions[5] = new Region(306, 206, 94, 88, font);
			regions[6] = new Region(100, 306, 94, 94, font);
			regions[7] = new Region(206, 306, 88, 94, font);
			regions[8] = new Region(306, 306, 94, 94, font);
		}

		public void Update(GameTime time) {
			UpdateMouse();
			UpdateCLicks();
		}

		private void UpdateMouse() {
			previous = current;
			current = Mouse.GetState();
		}

		private void UpdateCLicks()
		{
			int idx = BoardStateManager.ClickedRegion(regions, current, previous);
			BoardStateManager.UpdateClickedRegionState(regions, idx);
		}

		public void Draw(SpriteBatch sb) 
		{
			sb.Draw(GeneralAtributes.LineTexture, lines[0], Color.Black);
			sb.Draw(GeneralAtributes.LineTexture, lines[1], Color.Black);
			sb.Draw(GeneralAtributes.LineTexture, lines[2], Color.Black);
			sb.Draw(GeneralAtributes.LineTexture, lines[3], Color.Black);
			DrawRegions(sb);
		}

		public void DrawRegions(SpriteBatch sb) 
		{
			regions[0].Draw(sb);
			regions[1].Draw(sb); 
			regions[2].Draw(sb); 
			regions[3].Draw(sb); 
			regions[4].Draw(sb); 
			regions[5].Draw(sb); 
			regions[6].Draw(sb); 
			regions[7].Draw(sb); 
			regions[8].Draw(sb);
		}
	}
}
