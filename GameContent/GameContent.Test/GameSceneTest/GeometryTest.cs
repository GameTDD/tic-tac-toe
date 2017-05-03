using NUnit.Framework;
using Microsoft.FSharp.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace GameContent.Test
{
	[TestFixture()]
	public class GeometryTest
	{
		MouseState mouseState;
		Rectangle rect;

		[TestFixtureSetUp()]
		public void GeometryTestSetUp()
		{
			mouseState = new MouseState(50,60, 0, ButtonState.Pressed, ButtonState.Released,
											 ButtonState.Released, ButtonState.Released, ButtonState.Released);
			rect = new Rectangle(30, 30, 40, 40);
		}

		[Test()]
		public void TestIfXisInRectangle()
		{
			Assert.That(Regions.GeometricFunctions.IsInReagion (mouseState.X, rect), Is.True);
		}
	}
}
