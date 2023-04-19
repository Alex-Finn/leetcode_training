using LeetCodeTraining.Extensions;
using LeetCodeTraining.Interfaces;

namespace LeetCodeTraining.Abstractions
{
	internal abstract class Exercise : IExercise
	{
		public Type TypeOfClass { get; }
		public abstract Action? CoreOperation { get; }

		public Exercise()
		{
			TypeOfClass = GetType();
		}

		public void DoWork()
		{
			CoreOperation.WithBeforeAndAfterLogging(TypeOfClass.Name);
		}
	}
}