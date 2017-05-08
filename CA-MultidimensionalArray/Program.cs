using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_MultidimensionalArray
{
	class Program
	{
		static void Main(string[] args)
		{
			/*      j 0   1   2   3
			 *  i      
			 *  0   | 1 | 2 | 2 | 3 |
			 *  1   | 7 | 2 | 4 | 1 |
			 *  2   | 8 | 2 | 1 | 5 |       int[i,j]
			 */

			int[,] numbers = new int[,] { { 1, 2, 2, 3 }, { 7, 2, 4, 1 }, { 8, 2, 1, 5} };
			int[] selectedElements;

			int sum = SumUnderMajorDiagonal(numbers, out selectedElements);

			Console.WriteLine("Sum is: " + sum);
			
			Console.WriteLine("Selected elements: {0}", String.Join(",", selectedElements));

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}

		public static int SumUnderMajorDiagonal(int[,] matrix, out int[] selectedElements)
		{
			
			int sum = 0;
			int index = 0;
			selectedElements = new int[matrix.GetLength(0)];

			for ( int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					if (i > j)
					{
						int number = matrix[i, j];
						sum += number;
						selectedElements[index++] = number;
					}
				}
			}
			return sum;
		}
	}
}
