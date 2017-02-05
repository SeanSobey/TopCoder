using System;

public interface ISolution
{
	bool Enabled { get; }
	Action[] Theories { get; }
}