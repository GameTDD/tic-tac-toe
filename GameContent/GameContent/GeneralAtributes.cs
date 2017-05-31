using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameContent
{
	public class GeneralAtributes
	{
		public static Color BackgroungColor { get; set; }
		public static Texture2D LineTexture { get; set; }

		public GeneralAtributes()
		{
			BackgroungColor = Color.White;
		}

		public void GenerateTextures(GraphicsDevice graphics)
		{
			LineTexture = new Texture2D(graphics, 1, 1, false, SurfaceFormat.Color);
			Color[] data = { Color.Black };
			LineTexture.SetData<Color>(data);
		}
	}
}
