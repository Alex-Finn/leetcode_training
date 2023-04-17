using LeetCodeTraining.Collections.TopInterviewQuestions.Array;
using NUnit.Framework;

namespace LeetCodeTraining.Tests.TopInterviewQuestions.Array
{
	[TestFixture]
	internal class RemoveDuplicatesFromSortedArrayTests
	{
		RemoveDuplicatesFromSortedArray rdfsa;

		[OneTimeSetUp]
		public void SetUp()
		{
			rdfsa = new RemoveDuplicatesFromSortedArray();
		}

		[Test]
		public void Test1()
		{
			var inputData = new[] { 1, 1, 2 };
			var expectedOutput = 2;
			var expectedArray = new[] { 1, 2, int.MaxValue };

			var resultOutput = rdfsa.RemoveDuplicates(inputData);

			Assert.AreEqual(expectedOutput, resultOutput, 0, "Number of unique elements not correct");
			Assert.AreEqual(expectedArray.Length, inputData.Length, 0, "Arrays length not same.");
			Assert.That(() =>
			{
				for(var i = 0; i < expectedOutput; i++)
				{
					if(expectedArray[i] != inputData[i])
					{
						return false;
					}
				}

				return true;
			}, $"Arrays not same.");
		}

		[Test]
		public void Test2()
		{
			var inputData = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
			var expectedOutput = 5;
			var expectedArray = new[] { 0, 1, 2, 3, 4, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue };

			var resultOutput = rdfsa.RemoveDuplicates(inputData);

			Assert.AreEqual(expectedOutput, resultOutput, 0, "Number of unique elements not correct");
			Assert.AreEqual(expectedArray.Length, inputData.Length, 0, "Arrays length not same.");
			Assert.That(() =>
			{
				for(var i = 0; i < expectedOutput; i++)
				{
					if(expectedArray[i] != inputData[i])
					{
						return false;
					}
				}

				return true;
			}, $"Arrays not same.");
		}
	}
}
