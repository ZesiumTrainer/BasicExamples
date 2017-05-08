using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Array1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numberList = new int[] { 3, 4, 2, 5, 6, 2, 34, 5, 6 };
			int[] sortedList;

			sortedList = Sort(numberList);
			Print(sortedList);
			Console.WriteLine(" Press any key to exit.");
			Console.ReadKey();
		}

		public static int[] Sort(int[] list)
		{
			for (int i = 0; i < list.Length - 1; i++)
			{
				for (int j = i + 1; j < list.Length; j++)
				{
					if (list[i] > list[j])
					{
						int shift = list[i];
						list[i] = list[j];
						list[j] = shift;
					}
				}
			}

			return list;
		} 

		public static void Print(int[] sortedList)
		{
			Console.Write("Sorted numbers: ");
			foreach (int i in sortedList)
			{
				Console.Write(i + ",");
			}
		}
	}
}
