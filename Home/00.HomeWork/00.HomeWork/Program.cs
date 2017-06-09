/// <summary>
/// Program.
/// </summary>
using System;

namespace HomeWork
{
	class Program
	{
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main (string[] args)
		{
			#region HomeWork01
			// Client c1 = new Client ("Judzhin", "Miles", "100", 20);
			// Console.WriteLine ("Class {0}", c1);
			// Client c2 = new Client ("Judzhin", "Miles", "200", 30);
			// Console.WriteLine ("Class {0}", c2);
			// Client c3 = new Client ("Judzhin", "Miles", "200", 30);
			// Console.WriteLine ("Class {0}", c3);
			#endregion

			#region HomeWork02
			// Commodity cm01 = new Commodity("PC");
			// cm01.Cost = 5200.00;
			// cm01.Count = -10;
			// Console.WriteLine(cm01);
			//
			// Commodity cm02 = new Commodity("Modile", 15999.00);
			// Console.WriteLine(cm02);
			//
			// Commodity cm03 = new Commodity("Tablet", 8999.50, 100);
			// Console.WriteLine(cm03);
			//
			// Commodity cm04 = new Commodity() { Name = "Notebook", Cost = 10299.50, Count = 100};
			// Console.WriteLine(cm04);
			#endregion

			Order o1 = new Order (new Client ("Eugen", "Shykor"));

			o1.add (new Commodity ("PC", 10025.00, 4));
			o1.add (new Commodity ("Notebook", 9899.00, 7));
			o1.add (new Commodity ("BlackBerry", 4666.20, 2));

			Order o2 = new Order (new Client ("Ivan", "Ivanov"));

			o2.add (new Commodity ("PC", 10025.00, 6));
			o2.add (new Commodity ("Notebook", 9899.00, 2));
			o2.add (new Commodity ("BlackBerry", 4666.20, 1));

			Console.WriteLine (o1);
			Console.WriteLine (o2);
			Console.ReadLine ();
		}
	}
}
