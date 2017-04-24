using NUnit.Framework;
using System;
using GameContent;

namespace GameContent.Test
{
	[TestFixture()]
	public class Test
	{
		private Tester tester;

		[TestFixtureSetUp()]
		public void TestSetup()
		{
			tester = new Tester();
		}

		[Test()]
		public void TesterShouldReturnTrueWhenIsBool()
		{
			Assert.That(true, Is.EqualTo(tester.isBool()));
		}
	}
}
