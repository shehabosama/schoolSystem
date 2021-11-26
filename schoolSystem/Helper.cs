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
			Console.WriteLine("--------------------------------------------------------------");
			Console.WriteLine();
		}
	}
}
