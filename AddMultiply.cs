using System.Collections.Generic;

public class AddMultiply
{
	public int[] makeExpression(int y)
	{
		var elements = new List<int>(1998);
		for	(var element = -1000; element < 0; element++)
			elements.Add(element);
		for	(var element = 2; element <= 1000; element++)
			elements.Add(element);
		
		foreach	(var x0 in elements)
		{
			foreach	(var x1 in elements)
			{
				foreach	(var x2 in elements)
				{
					if ((x0 * x1) + x2 == y)
					return new [] { x0, x1, x2 };
				}
			}
		}
		return new int[0];
	}
}