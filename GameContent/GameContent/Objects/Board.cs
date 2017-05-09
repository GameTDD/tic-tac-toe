using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameContent
{
	public class Board
	{
		public Rectangle[] lines { get; set; }
		public int Thickness { get; set; }
		public int Length { get; set;}

		public Board()
		{
			lines = new Rectangle[4];
			Thickness = 10;
			Length = 300;
			SetLinesData();
		}

		private void SetLinesData() 
		{
			lines[0] = new Rectangle(195, 100, Thickness, Length);
			lines[1] = new Rectangle(295, 100, Thickness, Length);
			lines[2] = new Rectangle(100, 195, Length, Thickness);
			lines[3] = new Rectangle(100, 295, Length, Thickness);
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
