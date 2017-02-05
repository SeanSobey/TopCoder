using System;

public class AdvertisingAgency
{
	public int numberOfRejections(int[] requests)
	{
		var billboards = new bool[100];
		var rejections = 0;
		foreach (var request in requests)
		{
			if (billboards[request - 1])
				rejections++;
			else
				billboards[request - 1] = true;
		}
		return rejections;
	}
}
public class AdvertisingAgencySolution : ISolution
{
	public bool Enabled { get; } = false;
	public Action[] Theories { get; } = new Action[]
	{
		() => Console.WriteLine(new AdvertisingAgency().numberOfRejections(new [] {1,2,3}) + "=" + 0),
		() => Console.WriteLine(new AdvertisingAgency().numberOfRejections(new [] {1,1,1}) + "=" + 2),
		() => Console.WriteLine(new AdvertisingAgency().numberOfRejections(new [] {1,2,1,2}) + "=" + 2),
		() => Console.WriteLine(new AdvertisingAgency().numberOfRejections(new [] {100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 }) + "=" + 49),
	};
}