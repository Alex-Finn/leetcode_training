using LeetCodeTraining.Collections.TopInterviewQuestions.Array;
using NUnit.Framework;

namespace LeetCodeTraining.Tests.TopInterviewQuestions.Array
{
	[TestFixture]
	internal class RotateArrayTests
	{
		RotateArray ra;

		[OneTimeSetUp]
		public void SetUp()
		{
			ra = new RotateArray();
		}

		[Test]
		public void Test1()
		{
			var stepsCount = 3;
			var inputArray = new[] { 1, 2, 3, 4, 5, 6, 7 };
			var expectedArray = new[] { 5, 6, 7, 1, 2, 3, 4 };

			ra.Rotate(inputArray, stepsCount);

			Assert.That(() =>
			{
				for (int i = 0; i < inputArray.Length; i++)
				{
					if(expectedArray[i] != inputArray[i])
					{
						return false;
					}
				}

				return true;
			}, $"Arrays not same");
		}

		[Test]
		public void Test2()
		{
			var stepsCount = 2;
			var inputArray = new[] { -1, -100, 3, 99 };
			var expectedArray = new[] { 3, 99, -1, -100 };

			ra.Rotate(inputArray, stepsCount);

			Assert.That(() =>
			{
				for (int i = 0; i < inputArray.Length; i++)
				{
					if(expectedArray[i] != inputArray[i])
					{
						return false;
					}
				}

				return true;
			}, $"Arrays not same");
		}
	}
}
