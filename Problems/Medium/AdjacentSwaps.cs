using System;

namespace TopCoder
{
	public class AdjacentSwaps
	{

	}
	public class AdjacentSwapsSolution : ISolution
	{
		public bool Enabled { get; } = false;
		public Action[] Theories { get; } = new Action[]
		{
			() => Console.WriteLine("" + "=" + ""), 
		};
	}
}