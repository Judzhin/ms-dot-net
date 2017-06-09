using System;

namespace Lesson
{
	public class Rectangle : Shape
	{

		int _a,_b;

		/// <summary>
		/// Initializes a new instance of the <see cref="Lesson.Rectangle"/> class.
		/// </summary>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		public Rectangle(int a, int b)
		{
			_a = a;
			_b = b;
		}

		// public void Square()
		public override void Square()
		{
			Console.WriteLine ("Площадь прямоугольника {0}", _a * _b);
		}
	}
}

