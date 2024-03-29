﻿namespace LeetCodeTraining.Extensions
{
	public static class LogExtension
	{
		public static void WithBeforeAndAfterLogging(this Action action, string methodName)
		{
			Console.WriteLine($"\n=== Starting of {methodName} exercise.");
			action.Invoke();
			Console.WriteLine($"=== Finish of {methodName} exercise.\n");
		}
	}
}