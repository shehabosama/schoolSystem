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
		public static void spreateLine(int typeOfDesign)
		{
			if (typeOfDesign == 1)
			{
				Console.WriteLine();
				Console.WriteLine("=======================================================================");
				Console.WriteLine();
			}
			else if (typeOfDesign == 2) {
				Console.WriteLine();
				Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				Console.WriteLine();
			}
			else if (typeOfDesign == 3)
			{
				Console.WriteLine();
				Console.WriteLine("````````````````````````````````````````````````````````````````````````");
				Console.WriteLine();
			}
			else if (typeOfDesign == 4)
			{
				Console.WriteLine();
				Console.WriteLine("#########################################################################");
				Console.WriteLine();
			}
		}

		public static void programOptions()
		{
			Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~Select Number of operation~~~~~~~~~~~~~~~~~~~~~~~~~~ \n\n");
			Console.WriteLine("1 - Print All Students currently exist in the school");
			Console.WriteLine("2 - Print Credit Student currently exist in the school");
			Console.WriteLine("3 - Print Schollership Student currently exist in the school");
			Console.WriteLine("4 - Write the number of student and to get his degrees");
			Console.WriteLine("5 - Print Count of scholarship student currently exist in the school");
			Console.WriteLine("6 - Print Count of Credit students currently exist in the school");
			Console.WriteLine("7 - get Top ten Student's degrees");
			Console.WriteLine("8 - Add Student");
			Console.WriteLine("9 - Add Teacher");
			Console.WriteLine("10- Print the salary one of teachers");
			Console.WriteLine("11 - Print All Teachers");
			

		}
		public static void goBackToMainMenu() {
			spreateLine(1);
			Console.WriteLine("Press Enter To Go To The Main Menu");
			Console.ReadLine();
			Helper.programOptions();
			spreateLine(1);
			Program.programOptionsImplementation(Console.ReadLine());
		}
	}
}
