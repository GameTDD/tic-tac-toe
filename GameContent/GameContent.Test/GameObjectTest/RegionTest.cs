using NUnit.Framework;
using System;
using GameContent;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace GameContent.Test
{
	[TestFixture()]
	public class RegionTest
	{
		Region region;

		[TestFixtureSetUp()]
		public void SetUpRegion()
		{
			region = new Region(45, 40, 30, 30, null);
		}

		[Test()]
		public void TestIfV2PosIs30x30FromRegionOrigin()
		{
			Assert.That(region.StringPosition, Is.EqualTo(new Vector2(75, 70)));
		}
	}
}
