using System;

namespace Class
{
	class Program
	{

		const int i = 0;
		// static int a = 2;
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main (string[] args)
		{
			/**
			int x = 2;
			Console.WriteLine (x++ + x);
			x = 2;
			Console.WriteLine (x + x++);
			x = 2;
			Console.WriteLine (++x + x);
			x = 2;
			Console.WriteLine (x + ++x);
			x = 2;
			Console.WriteLine (++x + x++);
			x = 2;
			Console.WriteLine (x++ + ++x);
			*/

			/// Anonimause Initilization
			Customer c1 = new Customer () {
				LastName  = "Some Last Name"
			};

			Console.BackgroundColor = ConsoleColor.DarkGray;
			Console.WriteLine (c1);
			Customer c2 = new Customer ("Judzhin");
			Console.WriteLine (c2);
			Customer c3 = new Customer ("Judzhin", "Miles");
			Console.WriteLine (c3);
			Customer c4 = new Customer ();
			Console.WriteLine (c4);

			// Anonimause Object
			var cs = new {
				ID = 123, Name = "Some User Name"
			};

			Console.WriteLine (cs);

			// structure
			SAnother sa;
			sa.i = 10;
			Console.WriteLine (sa);

			// Show Enum
			Days d = (Days)1;
			Console.WriteLine(d);
			Console.ReadLine ();
		}
	}
}
