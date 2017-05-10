using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameContent
{
	public class Board
	{
		public Rectangle[] lines { get; set; }
		public Region[] regions { get; set; }
		public int Thickness { get; set; }
		public int Length { get; set;}

		public Board()
		{
			lines = new Rectangle[4];
			regions = new Region[9];
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
			regions[0] = new Region(100, 100, 94, 94);
			regions[1] = new Region(206, 100, 88, 94);
			regions[2] = new Region(306, 100, 94, 94);
			regions[3] = new Region(100, 206, 94, 88);
			regions[4] = new Region(206, 206, 88, 88);
			regions[5] = new Region(306, 206, 94, 88);
			regions[6] = new Region(100, 306, 94, 94);
			regions[7] = new Region(206, 306, 88, 94);
			regions[8] = new Region(306, 306, 94, 94);
		}

		public void Draw(SpriteBatch sb) 
		{
			sb.Draw(GeneralAtributes.LineTexture, lines[0], Color.Black);
			sb.Draw(GeneralAtributes.LineTexture, lines[1], Color.Black);
			sb.Draw(GeneralAtributes.LineTexture, lines[2], Color.Black);
			sb.Draw(GeneralAtributes.LineTexture, lines[3], Color.Black);
		}
	}
}
