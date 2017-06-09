/// <summary>
/// Judzhin Miles <ifno@msbios.com>
/// Решение второго домашнего задания второго занятия
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
			// Byte b = 255;
			// Checked { b++; }

			try {
				byte b = 255;
				checked 
				{ 
					b++; 
				}
			} catch (OverflowException e) {
				String str = String.Format ("Во время работы приложения возникла ошибка: {0}", e.ToString()); 
				Console.WriteLine(str);
			}

			// Advanced
			Console.WriteLine("\nCHECKED output value is: {0}", CheckedMethod());
			Console.WriteLine("\nUNCHECKED output value is: {0}", UncheckedMethod());
		}

		// Using a checked expression.
		static int CheckedMethod()
		{
			byte b = 255;
			int c = 0;
			try
			{
				// The following line raises an exception because it is checked.
				c = checked(b++);
			}
			catch (OverflowException e)
			{
				// The following line displays information about the error.
				Console.WriteLine("CHECKED and CAUGHT:  " + e.ToString());
			}
			// The value of c is still 0.
			return c;
		}

		// Using an unchecked expression.
		static int UncheckedMethod()
		{
			byte b = 255;
			int c = 0;
			try
			{
				// The following calculation is unchecked and will not 
				// raise an exception.
				c = b++;
			}
			catch (System.OverflowException e)
			{
				// The following line will not be executed.
				Console.WriteLine("UNCHECKED and CAUGHT:  " + e.ToString());
			}

			// Because of the undetected overflow, the sum of 255 + 10 is 
			// returned as 255.
			return c;
		}

	}
}

