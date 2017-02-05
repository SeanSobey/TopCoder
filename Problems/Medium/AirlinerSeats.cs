using System;

// Does not work!

public class AirlinerSeats
{
	public string[] mostAisleSeats(int width, int seats)
	{
		var result = new string('.', width).ToCharArray();
		var aisles = width - seats;

		if (aisles <= (seats / 2))
			result[0] = 'S';

		for (int i = 2, count = 1; i < width; i += count % 2, count++)
			result[i] = 'S';
		
		return new [] { new string(result) };
	}
}
public class AirlinerSeatsSolution : ISolution
{
	public bool Enabled { get; } = false;
	public Action[] Theories { get; } = new Action[]
	{
		() => Console.WriteLine(p(new AirlinerSeats().mostAisleSeats(1, 0)) + "=" + "."),
		() => Console.WriteLine(p(new AirlinerSeats().mostAisleSeats(1, 1)) + "=" + "S"),
		() => Console.WriteLine(p(new AirlinerSeats().mostAisleSeats(2, 0)) + "=" + ".."),
		() => Console.WriteLine(p(new AirlinerSeats().mostAisleSeats(2, 1)) + "=" + ".S"),
		() => Console.WriteLine(p(new AirlinerSeats().mostAisleSeats(2, 2)) + "=" + "SS"),
		() => Console.WriteLine(p(new AirlinerSeats().mostAisleSeats(6, 3)) + "=" + "..SS.S"),
		() => Console.WriteLine(p(new AirlinerSeats().mostAisleSeats(6, 4)) + "=" + "S.SS.S"),
	};
	static string p(string[] s)
	{
		if (s.Length == 1)
			return s[0];
		return string.Concat(s[0], s[1]); 
	}
}