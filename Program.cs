using System;
using GetterSetter.Movie;

namespace GetterSetterEntry
{
	class Program
	{
		static void Main(string[]args)
		{
			var avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
			var shrek = new Movie("Shrek", "Adam Adamson", "PG");
			Console.WriteLine(avengers.title);
            Console.WriteLine(shrek.title);

            Console.ReadLine();
		}
	}
}