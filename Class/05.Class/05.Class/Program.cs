/// <summary>
/// Program.
/// </summary>
using System;

/// <summary>
/// Program.
/// </summary>
namespace Class
{
	/// <summary>
	/// Program.
	/// </summary>
	class Program
	{
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main (string[] args)
		{

			do {
				Console.Clear();
				Console.WriteLine("Enter");

				switch (Int32.Parse (Console.ReadLine ())) {
				case 1:
					Console.WriteLine("1");
					break;
				case 2:
					Console.WriteLine("2");
					break;
				case 3:
					if (true) {
						break;
					}
					break;
				}
			} while (true);


		}
	}
}
