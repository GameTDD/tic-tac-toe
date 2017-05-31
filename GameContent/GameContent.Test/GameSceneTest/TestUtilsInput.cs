using NUnit.Framework;
using Microsoft.Xna.Framework.Input;

namespace GameContent.Test
{
	[TestFixture]
	public class TestUtilsInput
	{
		MouseState mouseButtonState;
		MouseState mousePreviousButtonState;

		[TestFixtureSetUp]
		public void TestSetup()
		{
			mouseButtonState = new MouseState(0,0, 0, ButtonState.Pressed, ButtonState.Released,
			                                 ButtonState.Released, ButtonState.Released, ButtonState.Released);
			mousePreviousButtonState = new MouseState(0,0, 0, ButtonState.Released, ButtonState.Released,
											 ButtonState.Released, ButtonState.Released, ButtonState.Released);	
		}

		[Test]
		public void TesterShouldReturnTrueWhenIsBool()
		{
			var auxPreviousButtonState = new MouseState(0,0, 0, ButtonState.Pressed, ButtonState.Released,
											 ButtonState.Released, ButtonState.Released, ButtonState.Released);	
			Assert.That(Handlers.Input.IsMousePressed(mouseButtonState, auxPreviousButtonState), Is.True);
		}

		[Test]
		public void TestOnlyCurrentStateIsPressed()
		{
			Assert.That(Handlers.Input.IsMouseClick(mouseButtonState, mousePreviousButtonState), Is.True);
		}
	}
}

