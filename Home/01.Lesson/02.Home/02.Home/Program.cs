/// <summary>
/// Judzhin Miles <info@msbios.com>
/// Второе домашнее задание по первому занятию
/// </summary>
using System;

namespace Home
{
	class Program
	{
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			Addational ad = new Addational();
			ad.Main ();
		}
	}

	class Addational
	{
		/// <summary>
		/// Точка входа в приложение определяется по критерию Namespace.Static(Main)
		/// в данном случаи у нас происходит дублирование которое достаточно убрать модификатор 
		/// что данный метод не является статическим
		/// </summary>
		/* static */ public void Main()
		{
			Console.WriteLine("Дополнительная программа на C#");
			Console.ReadLine();
		}
	}

}