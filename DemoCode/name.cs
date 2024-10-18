using	System;

namespace	DemoCode
{
	public	class	Name
	{
		public static void	PrintFullName()
		{
			var	fullName = "wataru watanabe";
			var	tokens = fullName.Split(' ');
			var	lastName = tokens[0];
			Console.WriteLine(fullName);
			Console.WriteLine(lastName);
		}
	}
}
