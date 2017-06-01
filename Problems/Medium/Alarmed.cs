using System;

namespace TopCoder
{
	public class Alarmed
	{
		public double noise(int[] x, int[] y, int[] threshold)
		{
			/// WIP
			return 0d;
		}
	}
	public class AlarmedSolution : ISolution
	{
		public bool Enabled { get; } = false;
		public Action[] Theories { get; } = new Action[]
		{
			() => Console.WriteLine(new Alarmed().noise(new []{50}, new []{2}, new []{87}) + "=" + 347.99999999999994d),
			() => Console.WriteLine(new Alarmed().noise(new []{1,99}, new []{50,50}, new []{1,1}) + "=" + 2400.9999999999995d),
			() => Console.WriteLine(new Alarmed().noise(new []{3,11,2,62,91}, new []{90,10,75,25,50}, new []{5,4,3,2,1}) + "=" + 1537.9999999999998d),
			() => Console.WriteLine(new Alarmed().noise(new []{1,99}, new []{50,50}, new []{1,2}) + "=" + 3295.5717878751793d),
		};
	}
}