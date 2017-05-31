using NUnit.Framework;
using Microsoft.Xna.Framework;

namespace GameContent.Test
{
	[TestFixture]
	public class GameTest
	{

		[TestFixtureSetUp]
		public void GameTestSetUp()
		{
			var gameAttributes = new GeneralAtributes();
		}

		[Test]
		public void TestIfBgIsWhite()
		{
			Assert.That(Color.White, Is.EqualTo(GeneralAtributes.BackgroungColor));
		}
	}
}
