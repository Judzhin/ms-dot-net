/// <summary>
/// Program.
/// </summary>
using System;

/// <summary>
/// Program.
/// </summary>
namespace Lesson
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
			// int[] IntArr;
			// arr = new int["10"];
			// IntArr = new int[10];
			// IntArr = new int[] {1,2,3,4,5,6};
			int[] IntArr = { 1, 2, 3, 4, 5, 6 };
			// int[] A = {1,2,3}; => int[] A = new int[3]{1,2,3}

			for (var i = 0; i < IntArr.Length; i++ )
			{
				Console.WriteLine("IntArr[{0}]={1}", i, IntArr[i]);
			}

			foreach (int i in IntArr) 
			{
				// i = i;
				Console.WriteLine("IntArr[]={0}", i);
			}

			int[] SomeIntArr = (int[])IntArr.Clone();

			Array.Sort(SomeIntArr);

			foreach (int i in SomeIntArr) 
			{
				Console.WriteLine("IntArr[]={0}", i);
			}

			Console.ReadLine();

			// int[,] IntArr2D;
			int[,] IntArr2D = new int[2,2]{{1,2},{3,4}};
			int[,,] IntArr3D;

			//IntArr2D = new int[2,2];
			//IntArr2D[0][0] = 0;
		}
	}
}
