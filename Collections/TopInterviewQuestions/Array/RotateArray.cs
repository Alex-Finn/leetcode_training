using LeetCodeTraining.Abstractions;

namespace LeetCodeTraining.Collections.TopInterviewQuestions.Array
{
	/*
https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/646/
Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.



Example 1:

Input: nums = [1,2,3,4,5,6,7], k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]
Example 2:

Input: nums = [-1,-100,3,99], k = 2
Output: [3,99,-1,-100]
Explanation: 
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100]


Constraints:

1 <= nums.length <= 105
-231 <= nums[i] <= 231 - 1
0 <= k <= 105


Follow up:

Try to come up with as many solutions as you can. There are at least three different ways to solve this problem.
Could you do it in-place with O(1) extra space?




*/
	internal class RotateArray : Exercise
	{
		public override Action? CoreOperation { get; }

		internal RotateArray() : base() { }

		public RotateArray(int[] inputArray, int k) : this()
		{
			CoreOperation = () =>
			{
				Console.WriteLine($"Input array: [{string.Join(", ", inputArray)}]. Number of steps: {k}");
				Rotate(inputArray, k);
				Console.WriteLine($"Result array: [{string.Join(", ", inputArray)}]");
			};
		}

		public void Rotate(int[] nums, int k)
		{
			k %= nums.Length;

			var numsLength = nums.Length;
			var transformsLeft = nums.Length;
			var currentPosition = 0;
			var valuePreserved = false;
			var currentValue = 0;
			var loopIndex = 0;

			while(transformsLeft > 0)
			{
				var nextPosition1 = (currentPosition + k) % numsLength;
				var nextPosition2 = (nextPosition1 + k) % numsLength;

				if(currentPosition == nextPosition2)
				{
					(nums[currentPosition], nums[nextPosition1]) = (nums[nextPosition1], nums[currentPosition]);
					transformsLeft -= 2;

					if(transformsLeft < 1) return;

					if(currentPosition + 1 != nextPosition1)
					{
						currentPosition += 1;
					}
					else
					{
						currentPosition += 2;
					}
					valuePreserved = false;
				}
				else
				{
					var preserveValue = nums[nextPosition1];
					nums[nextPosition1] = valuePreserved ? currentValue : nums[currentPosition];

					transformsLeft--;
					if(transformsLeft < 1) return;

					currentPosition = (currentPosition + k) % numsLength;

					if(currentPosition == loopIndex)
					{
						currentPosition = (++loopIndex) % nums.Length;
						currentValue = nums[currentPosition];
					}
					else
					{
						currentValue = preserveValue;
						valuePreserved = true;
					}
				}
			}
		}
	}
}