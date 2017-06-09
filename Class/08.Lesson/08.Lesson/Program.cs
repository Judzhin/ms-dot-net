/// <summary>
/// Program.
/// </summary>
using System;

namespace Lesson
{
	class Program
	{
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main (string[] args)
		{
			Shape[] shapes = new Shape[10];

			Random r = new Random ();

			for (int i = 0; i < 10; i++) {

				if (i % 2 == 0) {
					shapes [i] = new Triagle (r.Next(1,100), r.Next(100,200));
				} else {
					shapes [i] = new Rectangle (r.Next(1,100), r.Next(100,200));
				}
			}

			// Triagle tr = new Triagle ();
			// tr.Square ();

			foreach (Shape s in shapes) 
			{
				s.Square ();
			}

			(shapes [0] as Triagle).Square ();

			Console.ReadLine ();
		}
	}
}
