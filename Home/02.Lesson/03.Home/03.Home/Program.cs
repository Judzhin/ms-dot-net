/// <summary>
/// Judzhin Miles <info@msbios.com>
/// </summary>
using System;

namespace TypeApplication
{
	class Program
	{
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		static void Main()
		{
			// Int i = 1;
			// byte b = 2 * I;
			int i = 1;
			byte b = Convert.ToByte(2 * i);
			Console.WriteLine ("Результат опреации умножения байта: {0}", b);
		}
	}
}