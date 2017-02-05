using System;

namespace TopCoder
{
	public class AkariDaisukiDiv1
	{
		public int countF(string Waai, string Akari, string Daisuki, string S, string F, int k)
		{
			var text = S;//getText(Waai, Akari, Daisuki, S, k, 1);
			for (int i = 0; i < k; i++)
				text = Waai + text + Akari + text + Daisuki;

			var result = 0;
			for (int i = 0; i < text.Length - F.Length; i++)
				if (string.Equals(text.Substring(i, F.Length), F, StringComparison.OrdinalIgnoreCase))
					result++;
			return result % 1_000_000_007;
		}
	}
	public class AkariDaisukiDiv1Solution : ISolution
	{
		public bool Enabled { get; } = true;
		public Action[] Theories { get; } = new Action[]
		{
			//() => Console.WriteLine(new AkariDaisukiDiv1().countF("a", "b", "c", "x", "axb", 2) + "=" + 2), 
			//() => Console.WriteLine(new AkariDaisukiDiv1().countF("a", "b", "c", "x", "abcdefghij", 1) + "=" + 0), 
			//() => Console.WriteLine(new AkariDaisukiDiv1().countF("a", "a", "a", "b", "aba", 2) + "=" + 4), 
			() => Console.WriteLine(new AkariDaisukiDiv1().countF("a", "b", "c", "d", "baadbdcbadbdccccbaaaadbdcbadbdccbaadbdcba", 58) + "=" + 191690599), 
			() => Console.WriteLine(new AkariDaisukiDiv1().countF("a", "x", "y", "b", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab", 49) + "=" + 1), 
		};
	}
}