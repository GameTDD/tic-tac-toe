using NUnit.Framework;
using GameContent;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameContent.Test
{
	[TestFixture()]
	public class BoardTest
	{
		Board gameBoard;

		[TestFixtureSetUp()]
		public void BoardTestSetUp()
		{
			gameBoard = new Board();
		}

		[Test()]
		public void TestIfBoardHasOnly4Lines() 
		{
			Assert.That(gameBoard.lines.Length, Is.EqualTo(4));
			Assert.That(gameBoard.lines.Length, Is.GreaterThan(3));
			Assert.That(gameBoard.lines.Length, Is.LessThan(5));
		}

		[Test()]
		public void TestThicknessAndLenght() 
		{
			Assert.That(gameBoard.Thickness, Is.EqualTo(10));
			Assert.That(gameBoard.Length, Is.EqualTo(300));
		}

		[Test()]
		public void TestIfRectanglesPositionAreCorrect() 
		{
			Assert.That(gameBoard.lines[0].Location, Is.EqualTo(new Point(195, 100)));
			Assert.That(gameBoard.lines[1].Location, Is.EqualTo(new Point(295, 100)));
			Assert.That(gameBoard.lines[2].Location, Is.EqualTo(new Point(100, 195)));
			Assert.That(gameBoard.lines[3].Location, Is.EqualTo(new Point(100, 295)));
		}

		[Test()]
		public void TestIfRectanglesSizeAreCorrect()
		{
			Assert.That(gameBoard.lines[0].Size, Is.EqualTo(new Point(10, 300)));
			Assert.That(gameBoard.lines[1].Size, Is.EqualTo(new Point(10, 300)));
			Assert.That(gameBoard.lines[2].Size, Is.EqualTo(new Point(300, 10)));
			Assert.That(gameBoard.lines[3].Size, Is.EqualTo(new Point(300, 10)));
		}

		[Test()]
		public void TestIfBoardHas9Regions()
		{
			Assert.That(gameBoard.regions.Length, Is.EqualTo(9));
		}

		[Test()]
		public void TestIfCenterRegionOverlapsLines()
		{
			Assert.That(HasOverlap(gameBoard.regions[4].rect, gameBoard.lines), Is.False);
		}

		public bool HasOverlap(Rectangle rect, Rectangle[] lines) {
			for (int i = 0; i < 4; i++) {
				if (rect.Intersects(lines[i])) {
					return true;
				}
			}
			return false;
		}
	}
}
