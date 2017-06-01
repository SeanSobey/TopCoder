using System;
using System.Collections.Generic;

namespace TopCoder
{
	public class AdditionGame
	{
		public int getMaximumPoints(int A, int B, int C, int N)
		{
			var numbers = new List<int>(3) { A, B, C };
			var points = 0;
			for (int i = 0; i < N; i++)
			{
				numbers.Sort();
				points += numbers[2];
				if (numbers[2] > 0)
					numbers[2]--;
			}
			return points;
		}
	}
	public class AdditionGameSolution : ISolution
	{
		public bool Enabled { get; } = false;
		public Action[] Theories { get; } = new Action[]
		{
			() => Console.WriteLine(new AdditionGame().getMaximumPoints(3, 4, 5, 3) + "=" + 13),
			() => Console.WriteLine(new AdditionGame().getMaximumPoints(1, 1, 1, 8) + "=" + 3),
			() => Console.WriteLine(new AdditionGame().getMaximumPoints(3, 5, 48, 40) + "=" + 1140),
			() => Console.WriteLine(new AdditionGame().getMaximumPoints(36, 36, 36, 13) + "=" + 446),
			() => Console.WriteLine(new AdditionGame().getMaximumPoints(8, 2, 6, 13) + "=" + 57),
		};
	}
}