using System;

public class Abacus
{
	/*
	Does not work!
	*/


	/*
	{"ooo---oooooo", "---ooooooooo", "---ooooooooo", "---ooooooooo", "oo---ooooooo", "---ooooooooo"}
	5
	Returns: {"ooo---oooooo", "---ooooooooo", "---ooooooooo", "---ooooooooo", "o---oooooooo", "ooooo---oooo" }
	*/
	public string[] add(string[] original, int val)
	{
		var result = new string[original.Length];
		for (var i = 0; i < original.Length; i++)
		{
			var divisor = (int)Math.Pow(10, original.Length - i - 1);
			result[i] = addToThread(original[i], val / divisor);
		}

		/*
		100000
		10000
		1000
		100
		10
		1
		*/

		return result;
	}

	string addToThread(string original, int number)
	{
		return new string('o', number) + original.Substring(0, original.Length - number);
	}
}