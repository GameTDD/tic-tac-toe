﻿using NUnit.Framework;

namespace GameContent.Test
{
	[TestFixture]
	public class WinTest
	{
		Region[] regions;

		[TestFixtureSetUp]
		public void TestSetup()
		{
			regions = new Region[9];
			regions[0] = new Region(100, 100, 94, 94, null);
			regions[1] = new Region(206, 100, 88, 94, null);
			regions[2] = new Region(306, 100, 94, 94, null);
			regions[3] = new Region(100, 206, 94, 88, null);
			regions[4] = new Region(206, 206, 88, 88, null);
			regions[5] = new Region(306, 206, 94, 88, null);
			regions[6] = new Region(100, 306, 94, 94, null);
			regions[7] = new Region(206, 306, 88, 94, null);
			regions[8] = new Region(306, 306, 94, 94, null);
		}

		[Test]
		public void TestIfAllRegions0ReturnsFalseForWin()
		{
			Assert.That(WinStateManager.PlayerWon(regions), Is.EqualTo(0));
		}

		[Test]
		public void TestIfRowOneWinsP1()
		{
			regions[0].state = 1;
			regions[1].state = 1;
			regions[2].state = 1;
			Assert.That(WinStateManager.PlayerWon(regions), Is.EqualTo(1));
		}

		[Test]
		public void TestIfRowTwoWinsP2()
		{
			TestSetup();
			regions[3].state = -1;
			regions[4].state = -1;
			regions[5].state = -1;
			Assert.That(WinStateManager.PlayerWon(regions), Is.EqualTo(-1));
		}

		[Test]
		public void TestIfColOneWinsP1()
		{
			TestSetup();
			regions[0].state = 1;
			regions[3].state = 1;
			regions[6].state = 1;
			Assert.That(WinStateManager.PlayerWon(regions), Is.EqualTo(1));
		}

		[Test]
		public void TestIfColTwoWinsP2()
		{
			TestSetup();
			regions[1].state = -1;
			regions[4].state = -1;
			regions[7].state = -1;
			Assert.That(WinStateManager.PlayerWon(regions), Is.EqualTo(-1));
		}

		[Test]
		public void TestIfDiaOneWinsP1()
		{
			TestSetup();
			regions[0].state = 1;
			regions[4].state = 1;
			regions[8].state = 1;
			Assert.That(WinStateManager.PlayerWon(regions), Is.EqualTo(1));
		}

		[Test]
		public void TestIfDiaTwoWinsP2()
		{
			TestSetup();
			regions[2].state = -1;
			regions[4].state = -1;
			regions[6].state = -1;
			Assert.That(WinStateManager.PlayerWon(regions), Is.EqualTo(-1));
		}

		[Test]
		public void TestIfP1WinsOnGlobalVar()
		{
			TestSetup();
			regions[0].state = 1;
			regions[4].state = 1;
			regions[8].state = 1;
			WinStateManager.Update(regions);
			Assert.That(WinStateManager.PlayerWhoWon, Is.EqualTo(1));
		}

		[Test]
		public void TestIfNooneWins()
		{
			TestSetup();
			Assert.That(WinStateManager.PlayerWhoWon, Is.EqualTo(0));
		}

		[Test]
		public void TestIfNoWinnerIsEMptyStr()
		{
			Assert.That(WinStateManager.PlayerStr, Is.EqualTo(""));
		}

		[Test]
		public void TestIfP1WinsStr()
		{
            TestSetup();
			regions[0].state = 1;
			regions[4].state = 1;
			regions[8].state = 1;
			WinStateManager.Update(regions);
			Assert.That(WinStateManager.PlayerStr, Is.EqualTo("Player 1 Wins"));
		}

		[Test]
		public void TestIfP2WinsStr()
		{
			TestSetup();
			regions[0].state = -1;
			regions[4].state = -1;
			regions[8].state = -1;
			WinStateManager.Update(regions);
			Assert.That(WinStateManager.PlayerStr, Is.EqualTo("Player 2 Wins"));
		}
	}
}
