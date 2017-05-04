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
			mouseState = new MouseState(45,60, 0, ButtonState.Pressed, ButtonState.Released,
											 ButtonState.Released, ButtonState.Released, ButtonState.Released);
			rect = new Rectangle(30, 30, 20, 40);
		}

		[Test()]
		public void TestIfMousePositionIsInRectangle()
		{
			Assert.That(Regions.GeometricFunctions.IsInReagion (mouseState.Position, rect), Is.True);
		}

		[Test()]
		public void TestIfMousePositionXIsOutOfRectangle()
		{
			MouseState auxMouse = new MouseState(100, 60, 0, ButtonState.Pressed, ButtonState.Released,
											 ButtonState.Released, ButtonState.Released, ButtonState.Released);
			Assert.That(Regions.GeometricFunctions.IsInReagion(auxMouse.Position, rect), Is.False);
		}

		[Test()]
		public void TestIfMousePositionYIsOutOfRectangle()
		{
			MouseState auxMouse = new MouseState(45, 100, 0, ButtonState.Pressed, ButtonState.Released,
									 ButtonState.Released, ButtonState.Released, ButtonState.Released);
			Assert.That(Regions.GeometricFunctions.IsInReagion(auxMouse.Position, rect), Is.False);
		}

		[Test()]
		public void TestIfCoordinateWithinLimits()
		{
			Assert.That(Regions.GeometricFunctions.IsBetweenLimits(5, 2, 10), Is.True);
		}

		[Test()]
		public void TestIfCoordinateIsOutOfLimits()
		{
			Assert.That(Regions.GeometricFunctions.IsBetweenLimits(15, 2, 10), Is.False);
		}

		[Test()]
		public void TestIfMouseClickedInRegion() 
		{ 
			MouseState prevState = new MouseState(120,120, 0, ButtonState.Released, ButtonState.Released,
											 ButtonState.Released, ButtonState.Released, ButtonState.Released);
			Assert.That(Regions.Interative.HasMouseClickedRegion(mouseState, prevState, rect), Is.True);
		}
	}
}
