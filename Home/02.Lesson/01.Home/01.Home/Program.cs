/// <summary>
/// Judzhin Miles <info@msbios.com>
/// Решение первой задачи второго занятия
/// </summary>
using System;

namespace Home
{
	class Programm
	{
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main (string[] args)
		{

			Boolean endapp = false;

			do {

				Console.Write ("Введите радиус окружности от 0 до 255: ");

				Int32 r = 0;

				try {
					r = Int32.Parse (Console.ReadLine ());
				} catch (FormatException e) {
					Console.Write ("\nФормат вводимый Вами не допустим, попробуйте ещё раз! {0}", e.ToString ());
					Console.Clear ();
				}

				if (0 > r || 255 < r) {
					Console.Write ("Ваше значение {0} не в зоне допустимого, повторите заного.", r);
					Console.ReadLine ();
					Console.Clear ();
					continue;
				}

				// 2PiR
				Console.WriteLine ("Длина окружности = {0}", (int)(2 * Math.PI * r));
				// 2PiR^2
				Console.WriteLine ("Площадь круга = {0}", (int)(Math.PI * Math.Pow (r, 2)));

				Console.Write ("Желаете повторить? [Y]: ");
				String answer = Console.ReadLine ();

				if ("Y" != answer.ToUpper ()) {
					endapp = !endapp;
				}

				Console.Clear ();

			} while (!endapp);
		}
	}
}