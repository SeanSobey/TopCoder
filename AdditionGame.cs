using System;
using System.Collections.Generic;

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

System.Console.WriteLine(new AdditionGame().getMaximumPoints(3, 4, 5, 3) + "=" + 13);
System.Console.WriteLine(new AdditionGame().getMaximumPoints(1, 1, 1, 8) + "=" + 3);
System.Console.WriteLine(new AdditionGame().getMaximumPoints(3, 5, 48, 40) + "=" + 1140);
System.Console.WriteLine(new AdditionGame().getMaximumPoints(36, 36, 36, 13) + "=" + 446);
System.Console.WriteLine(new AdditionGame().getMaximumPoints(8, 2, 6, 13) + "=" + 57);