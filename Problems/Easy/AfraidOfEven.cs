using System;
using System.Linq;

namespace TopCoder
{
	public class AfraidOfEven
	{
		public int[] restoreProgression(int[] seq)
		{
			/// WIP
			return new int[0];
		}
	}

	public class AfraidOfEvenSolution : ISolution
	{
		public bool Enabled { get; } = false;
		public Action[] Theories { get; } = new Action[]
		{
			() => Console.WriteLine(new AfraidOfEven().restoreProgression(new [] {1, 1, 3, 1, 5}) + "=" + "1, 2, 3, 4, 5"),
			() => Console.WriteLine(new AfraidOfEven().restoreProgression(new [] {9, 7, 5, 3, 1}) + "=" + "9, 7, 5, 3, 1"),
			() => Console.WriteLine(new AfraidOfEven().restoreProgression(new [] {999, 999, 999, 999}) + "=" + "999, 999, 999, 999"),
			() => Console.WriteLine(new AfraidOfEven().restoreProgression(new [] {7, 47, 5, 113, 73, 179, 53}) + "=" + "14, 47, 80, 113, 146, 179, 212"),
			() => Console.WriteLine(new AfraidOfEven().restoreProgression(new [] {749, 999, 125, 1}) + "=" + "1498, 999, 500, 1"),
		};
	}
}