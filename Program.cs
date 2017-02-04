using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var result = new ABBADiv1().canObtain("AAABBAABB", "BAABAAABAABAABBBAAAAAABBAABBBBBBBABB");
			//var result = new ABoardGame().whoWins(new string[] {".....A", "......", "..A...", "...B..", "......", "......"});
			//var result = new EllysNumberGuessing().getNumber(new [] { 500000,600000,700000 }, new [] { 120013,220013,79987 });
			//var result = new EllysSubstringSorter().getMin("TOPCODER", 4);
			//var result1 = new ATaleOfThreeCities().connect(new []{0,0,0}, new []{0,1,2}, new []{2,3}, new []{1,1}, new []{1,5}, new []{3,28});
			var result2 = new ATaleOfThreeCities().connect(new []{-2,-1,0,1,2}, new []{0,0,0,0,0}, new []{-2,-1,0,1,2}, new []{1,1,1,1,1}, new []{-2,-1,0,1,2}, new []{2,2,2,2,2});
        }
    }
}