namespace leetcode_training.Array
{
	/*
	https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/727/
	Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.The relative order of the elements should be kept the same.
	Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums.More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result.It does not matter what you leave beyond the first k elements.
	Return k after placing the final result in the first k slots of nums.

	Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.

	Constraints:

	1 <= nums.length <= 3 * 104
	-100 <= nums[i] <= 100
	nums is sorted in non-decreasing order.
	*/
	internal class RemoveDuplicatesFromSortedArray
	{
        int[] inputArray;

        public RemoveDuplicatesFromSortedArray(int[] inputArray)
        {
			this.inputArray = inputArray;
		}

		private int RemoveDuplicates(int[] nums)
		{
			var uniqueCounter = 1;
			var currentValue = nums[0];
			var lastUniquePosition = 0;

			for (int i = 1; i < nums.Length; i++)
			{
				if (nums[i] == currentValue) continue;
				currentValue = nums[i];
				nums[++lastUniquePosition] = nums[i];
				uniqueCounter++;
			}

			return uniqueCounter;
		}

		public void DoWork()
		{
			Console.WriteLine("Input array: [" + string.Join(", ", inputArray) + "]");
			var uniqueNumbers = RemoveDuplicates(inputArray);
			Console.WriteLine("unique numbers: " + uniqueNumbers);
			Console.WriteLine("Result array: [" + string.Join(", ", inputArray) + "]");
		}
	}
}