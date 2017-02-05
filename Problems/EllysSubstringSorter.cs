using System;
using System.Collections.Generic;
using System.Linq;

namespace TopCoder
{
	public class EllysSubstringSorter
	{
		public string getMin(string S, int L)
		{
			var strings = new List<string>();
			for(var i = 0; i < S.Length - L; i++)
			{
				var start = S.Substring(0, i);
				var sorted = S.Substring(i, L);
				var end = S.Substring(i + L);
				
				var sortedChars = sorted.ToCharArray();
				Array.Sort(sortedChars);
				strings.Add(start + new string(sortedChars) + end);
			}
			strings.Sort();
			return strings.First();
		}
	}
	public class EllysSubstringSorterSolution : ISolution
	{
		public bool Enabled { get; } = false;
		public Action[] Theories { get; } = new Action[]
		{
			() => Console.WriteLine(new EllysSubstringSorter().getMin("TOPCODER", 4) + "=" + "COPTODER"), 
		};
	}
}