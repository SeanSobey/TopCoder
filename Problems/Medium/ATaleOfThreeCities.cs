using System;

namespace TopCoder
{
	public class ATaleOfThreeCities
	{
		public double connect(int[] ax, int[] ay, int[] bx, int[] by, int[] cx, int[] cy)
		{
			var shortestAB = double.MaxValue;
			for(var a = 0; a < ax.Length; a++)
				for(var b = 0; b < bx.Length; b++)
					shortestAB = Math.Min(shortestAB, distance(ax[a], bx[b], ay[a], by[b]));
				
			var shortestBC = double.MaxValue;
			for(var b = 0; b < bx.Length; b++)
				for(var c = 0; c < cx.Length; c++)
					shortestBC = Math.Min(shortestBC, distance(bx[b], cx[c], by[b], cy[c]));
			
			var shortestAC = double.MaxValue;
			for(var a = 0; a < ax.Length; a++)
				for(var c = 0; c < cx.Length; c++)
					shortestAC = Math.Min(shortestAC, distance(ax[a], cx[c], ay[a], cy[c]));
			
			var max = Math.Max(shortestAB, Math.Max(shortestBC, shortestAC));

			if (max == shortestAB)
				return shortestBC + shortestAC;
			if (max == shortestBC)
				return shortestAB + shortestAC;
				
			return shortestAB + shortestBC;
		}
		
		double distance(int x1, int x2, int y1, int y2)
		{
			return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
		}
	}
	public class ATaleOfThreeCitiesSolution : ISolution
	{
		public bool Enabled { get; } = false;
		public Action[] Theories { get; } = new Action[]
		{
			() => Console.WriteLine(new ATaleOfThreeCities().connect(new []{0,0,0}, new []{0,1,2}, new []{2,3}, new []{1,1}, new []{1,5}, new []{3,28}) + "=" + "3,41421356237309"), 
			() => Console.WriteLine(new ATaleOfThreeCities().connect(new []{-2,-1,0,1,2}, new []{0,0,0,0,0}, new []{-2,-1,0,1,2}, new []{1,1,1,1,1}, new []{-2,-1,0,1,2}, new []{2,2,2,2,2}) + "=" + "2"), 
		};
	}
}