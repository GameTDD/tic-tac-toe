using NUnit.Framework;
using System;
using GameContent;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameContent.Test
{
	[TestFixture()]
	public class GameTest
	{

		[TestFixtureSetUp()]
		public void GameTestSetUp()
		{
			GeneralAtributes gameAttributes = new GeneralAtributes();
		}

		[Test()]
		public void TestIfBgIsWhite()
		{
			Assert.That(Color.White, Is.EqualTo(GeneralAtributes.BackgroungColor));
		}

		[Test()]
		public void TestIfBoardIsWithCorrectSize() 
		{ 
			
		}
	}
}
