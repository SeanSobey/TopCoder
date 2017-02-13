using System;

namespace TopCoder
{
	public class ABBADiv1
	{
		public string canObtain(string initial, string target)
		{
			if (initial.Length == target.Length)
				return "Impossible";
			
			var string1 = initial + "A";

			var chars = (initial + "B").ToCharArray();
			Array.Reverse(chars);
			var string2 = new string(chars);
			
			if ((string1.Length == target.Length && string1 == target) 
			|| (string2.Length == target.Length && string2 == target))
				return "Possible";
			
			if (canObtain(string1, target) == "Possible")
				return "Possible";
			
			return canObtain(string2, target);
		}
	}
	public class ABBADiv1Solution : ISolution
	{
		public bool Enabled { get; } = false;
		public Action[] Theories { get; } = new Action[]
		{ 
			() => Console.WriteLine(new ABBADiv1().canObtain("AAABBAABB", "BAABAAABAABAABBBAAAAAABBAABBBBBBBABB") + "=" + "Possible"),
		};
	}
}