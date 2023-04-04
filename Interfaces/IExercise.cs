namespace LeetCodeTraining.Interfaces
{
	internal interface IExercise
	{
		Type TypeOfClass { get; }
		Action CoreOperation { get; }
		void DoWork();
	}
}