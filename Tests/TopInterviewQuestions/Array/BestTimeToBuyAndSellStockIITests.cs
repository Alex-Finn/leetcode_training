using LeetCodeTraining.Collections.TopInterviewQuestions.Array;
using NUnit.Framework;

namespace LeetCodeTraining.Tests.TopInterviewQuestions.Array
{
	[TestFixture]
	internal class BestTimeToBuyAndSellStockIITests
	{
		BestTimeToBuyAndSellStockII bttbassii;

		[OneTimeSetUp]
		public void Initialize()
		{
			bttbassii = new BestTimeToBuyAndSellStockII();
		}

		[Test]
		public void Test1()
		{			
			var inputData = new int[] { 7, 1, 5, 3, 6, 4 };
			var expected = 7;

			Assert.AreEqual(expected, bttbassii.MaxProfit(inputData), 0, "Algorithm is incorrect.");
		}

		[Test]
		public void Test2()
		{			
			var inputData = new int[] { 1, 2, 3, 4, 5 };
			var expected = 4;

			Assert.AreEqual(expected, bttbassii.MaxProfit(inputData), 0, "Algorithm is incorrect.");
		}

		[Test]
		public void Test3()
		{			
			var inputData = new int[] { 7, 6, 4, 3, 1 };
			var expected = 0;

			Assert.AreEqual(expected, bttbassii.MaxProfit(inputData), 0, "Algorithm is incorrect.");
		}
	}
}
