using	System;

namespace	DemoCode
{
/*	public	class	Name
	{
		public static void	PrintFullName()
		{
			var	fullName = "wataru watanabe";
			var	tokens = fullName.Split(' ');
			var	firstName = tokens[0];
			Console.WriteLine(fullName);
			Console.WriteLine(firstName);
		}
	}*/

	public	class	FullName
	{
		public	FullName(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}

		public string FirstName{get;}
		public string LastName{get;}
	}
}
