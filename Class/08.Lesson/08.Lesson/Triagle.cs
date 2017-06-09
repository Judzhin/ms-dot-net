using System;

namespace Lesson
{
	public class Triagle : Shape
	{
		/// <summary>
		/// A.
		/// </summary>
		int _a,_b;

		/// <summary>
		/// Initializes a new instance of the <see cref="Lesson.Triagle"/> class.
		/// </summary>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		public Triagle(int a, int b)
		{
			_a = a; 
			_b = b;
		}

		/// <summary>
		/// Square this instance.
		/// </summary>
		// public new void Square() 
		public override void Square() 
		{
			Console.WriteLine ("Площадь триугольника, {0}", _a*_b / 2 );
		}
	}
}

