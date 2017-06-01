using System;
using System.Reflection;
using System.Linq;

namespace TopCoder
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var solutions = Assembly.GetEntryAssembly().DefinedTypes
				.Where(typeInfo => typeInfo.ImplementedInterfaces.Contains(typeof(ISolution)))
				.Select(typeInfo => Activator.CreateInstance(typeInfo.AsType()) as ISolution);

			foreach (var solution in solutions)
			{
				Console.WriteLine($"Solution: {solution.ToString()}, Enabled: {solution.Enabled}, Theories: {solution.Theories?.Count() ?? 0}");
				Console.WriteLine("===========================================================");
				if (solution.Enabled)
				foreach (var theory in solution.Theories)
					theory();
				Console.WriteLine("");
			}
		}
	}
}