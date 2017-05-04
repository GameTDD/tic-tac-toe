using NUnit.Framework;
using GameContent;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace GameContent.Test
{
	[TestFixture()]
	public class TestRegionState
	{
		Region region;
		MouseState currentState;
		MouseState previousState;

		[TestFixtureSetUp()]
		public void SetUpRegion()
		{ 
			currentState = new MouseState(60, 60, 0, ButtonState.Pressed, ButtonState.Released,
								 ButtonState.Released, ButtonState.Released, ButtonState.Released);
			previousState = new MouseState(44,44, 0, ButtonState.Released, ButtonState.Released,
								 ButtonState.Released, ButtonState.Released, ButtonState.Released);
			region = new Region(45, 45, 30, 30);
		}

		[Test()]
		public void TestIfRegionIsCreatedWith0() 
		{
			Assert.That(region.state, Is.EqualTo(0));
		}
	}
}
