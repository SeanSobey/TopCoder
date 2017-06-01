using System;
using System.Linq;

namespace TopCoder
{
	public class AimToTen
	{
		public int need(int[] marks)
		{
			var total = (double)marks.Sum();
			var count = (double)marks.Length;
			var i = 0;
			while ((total / count) < 9.5)
			{
				total += 10.0;
				count++;
				i++;
			}
			return i;
		}
	}

	public class AimToTenSolution : ISolution
	{
		public bool Enabled { get; } = true;
		public Action[] Theories { get; } = new Action[]
		{
			() => Console.WriteLine(new AimToTen().need(new []{9, 10, 10, 9}) + "=" + "0"),
			() => Console.WriteLine(new AimToTen().need(new []{8, 9}) + "=" + "4"),
			() => Console.WriteLine(new AimToTen().need(new []{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}) + "=" + "950"),
			() => Console.WriteLine(new AimToTen().need(new []{10, 10, 10, 10}) + "=" + "0"),
		};
	}
}