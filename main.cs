using	System;
using	DemoCode;

class	Program
{
	static	void	Main(string[] args)
	{
		PrintGreetings();
		var fullname = new FullName("John","smith");
		Console.WriteLine(fullname.LastName);
	}
}

