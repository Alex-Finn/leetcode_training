// See https://aka.ms/new-console-template for more information
using leetcode_training.Array;
using leetcode_training.Interfaces;

var exercise1 = new RemoveDuplicatesFromSortedArray(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
var exercise2 = new BestTimeToBuyAndSellStockII(new int[] { 7,1,5,3,6,4 });

var exercises = new IExercise[] {exercise1, exercise2};

foreach (var exercise in exercises)
{
	exercise.DoWork();
}

Console.WriteLine("Any key for exit");
Console.ReadKey();