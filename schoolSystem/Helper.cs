using System;
using System.Collections.Generic;
using System.Text;

namespace schoolSystem
{
	class Helper
	{
		public static Object[] Re2Dimension(Object[] OldArray, int arr1stDimLength)
		{
			// declare a larger array
			Object[] NewArray = new object[arr1stDimLength];
			// determine if we are shrinking or enlarging
			const int FirstDimension = 0;
			int xMax = 0;
			// determine if we are shrinking or enlarging columns
			if (OldArray.GetUpperBound(FirstDimension) < (arr1stDimLength - 1))
				xMax = OldArray.GetUpperBound(FirstDimension) + 1;
			else
				xMax = arr1stDimLength;

			for (int x = 0; x < xMax; x++)
			{
				NewArray[x] = OldArray[x];
			}
			return NewArray;
		}
		public static void spreateLine()
		{
			Console.WriteLine();
			Console.WriteLine("=======================================================================");
			Console.WriteLine();
		}

		public static void programOptions()
		{
			Console.WriteLine("1 - Print All Students currently exist in the school");
			Console.WriteLine("2 - Write the number of student and to get his degrees");
			Console.WriteLine("3 - print all the students that have scholarship");
			Console.WriteLine("4 - get Top ten Student's degrees");
			Console.WriteLine("5 - Add Student");
			Console.WriteLine("6 - Add Teacher");
			Console.WriteLine("7 - Print the salary one of teachers");
			Console.WriteLine("8 - Print Counr of student currently exist in the school");
		}
		public static void goBackToMainMenu() {
			spreateLine();
			Console.WriteLine("Press Enter To Go To The Main Menu");
			Console.ReadLine();
			Helper.programOptions();
			spreateLine();
			Program.programOptionsImplementation(Console.ReadLine());
		}
	}
}
