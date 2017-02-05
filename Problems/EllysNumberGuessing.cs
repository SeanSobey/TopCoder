using System.Collections.Generic;
using System.Linq;
using System;

namespace TopCoder
{
	public class EllysNumberGuessing
	{
		public int getNumber(int[] guesses, int[] answers)
		{
			var possibleAnswers = new List<int>();
			for(var index = 0; index < guesses.Length; index++)
			{
				var guess = guesses[index];
				var answer = answers[index];
									
				var possibleAnswer1 = guess - answer;
				var possibleAnswer2 = guess + answer;
				
				if (possibleAnswers.Count == 0)
				{
					if (possibleAnswer1 > 0 && possibleAnswer1 < 1000000000)
						possibleAnswers.Add(possibleAnswer1);
					if (possibleAnswer2 > 0 && possibleAnswer2 < 1000000000)
						possibleAnswers.Add(possibleAnswer2);
					continue;
				}
				if (possibleAnswers.Contains(possibleAnswer1) && possibleAnswers.Contains(possibleAnswer2))
					continue;
				
				if (possibleAnswers.Contains(possibleAnswer1))
					return possibleAnswer1;
				
				if (possibleAnswers.Contains(possibleAnswer2))
					return possibleAnswer2;
				
				return -2;
			}
			
			if (possibleAnswers.Count == 1)
				return possibleAnswers.First();
			
			return -1;
		}
	}
	public class EllysNumberGuessingSolution : ISolution
	{
		public bool Enabled { get; } = false;
		public Action[] Theories { get; } = new Action[]
		{
			() => Console.WriteLine(new EllysNumberGuessing().getNumber(new [] { 500000,600000,700000 }, new [] { 120013,220013,79987 }) + "=" + "379987"), 
		};
	}
}