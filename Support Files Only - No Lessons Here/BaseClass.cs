using System;
using System.Linq;

public class BaseClass
{
	public BaseClass(int value)
	{
		a = value;
	}

	public BaseClass(int value, string name)
	{
		Name = name;
		a = value;
	}

	private int a;
	public string Name { get; set; }
}
