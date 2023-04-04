// See https://aka.ms/new-console-template for more information
using LeetCodeTraining.Collections.TopInterviewQuestions.Array;
using LeetCodeTraining.Interfaces;

var exercises = new IExercise[] {
	new RemoveDuplicatesFromSortedArray(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }),
	new BestTimeToBuyAndSellStockII(new int[] { 7, 1, 5, 3, 6, 4 }),
	new RotateArray(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3)
};

foreach(var exercise in exercises)
{
	exercise.DoWork();
}

Console.WriteLine("Any key for exit");
Console.ReadKey();