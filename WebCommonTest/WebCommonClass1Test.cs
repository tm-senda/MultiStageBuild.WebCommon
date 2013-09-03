using System;
using NUnit.Framework;

namespace MultiStageBuild.WebCommon
{
	[TestFixture]
	public class WebCommonClass1Test
	{
		[Test]
		public void TestMethod1()
		{
			Assert.IsTrue(new WebCommonClass1().Method1());
		}
	}
}
