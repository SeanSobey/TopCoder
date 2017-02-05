using System;

public class Solution : ISolution
{
	public bool Enabled { get; } = false;
	public Action[] Theories { get; } = new Action[]
	{
		() => Console.WriteLine("" + "=" + ""), 
	};
}