using System;

namespace TopCoder
{
	public interface ISolution
	{
		bool Enabled { get; }
		Action[] Theories { get; }
	}
}