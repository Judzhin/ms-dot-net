/// <author>
/// Judzhin Miles <info@msbios.com>
/// Домашнее задание по первому занятию
/// </author>
using System;

namespace Home
{
	class Program
	{
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// Так как return возвращает значание обработаное в методе после него 
		/// любой код не работоспособен (мёртвый код)
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main (string[] args)
		{
			Console.WriteLine("Первая программа на C#");
			// return;
			Console.ReadLine();
		}
	}
}