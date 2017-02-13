using System;

namespace TopCoder
{
	public class AdditionCycles
	{
		public int cycleLength(int n)
		{
			return cycleLength(n, n, 1);
		}

		int cycleLength(int original, int n, int count)
		{
			var nText = n.ToString("D2");

			var nSum = int.Parse(nText[0].ToString()) + int.Parse(nText[1].ToString());
			var nSumText = nSum.ToString("D2");

			var combined = int.Parse($"{nText[1]}{nSumText[1]}");

			if (combined == original)
				return count;
			return cycleLength(original, combined, count + 1);
		}
	}
	public class AdditionCyclesSolution : ISolution
	{
		public bool Enabled { get; } = false;
		public Action[] Theories { get; } = new Action[]
		{
			() => Console.WriteLine(new AdditionCycles().cycleLength(26) + "=" + "4"), 
		};
	}
}