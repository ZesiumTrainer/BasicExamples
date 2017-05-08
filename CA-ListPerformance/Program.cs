using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ListPerformance
{
	class Program
	{
		static void Main(string[] args)
		{

			/*
			  Your particular list contains strings, which are reference types.
			  The size of a reference will be 4 or 8 bytes, depending on whether you're running on a 32-bit or 64-bit system.
			  This means that the practical limit to the number of strings you could store will be roughly 536 million on 32-bit or 268 million on 64-bit.
			  In practice, you'll most likely run out of allocable memory before you reach those limits, especially if you're running on a 32-bit system.
			 
			  Capacity is always greater than or equal to Count. 
			  If Count exceeds Capacity while adding elements, the capacity is increased by automatically reallocating the internal array before
			  copying the old elements and adding the new elements.
			 
			  On 64-bit platforms, enables arrays that are greater than 2 gigabytes (GB) in total size.

			 */
			int elementsNumber = 15100000; // 23800000
			List<Student> list = new List<Student>(); // probati sa unapred alokacijom prostora
			LinkedList<Student> linkedList = new LinkedList<Student>();
			ArrayList arrayList = new ArrayList();
			ArrayList arrayList2 = new ArrayList(elementsNumber);

			Stopwatch watch = new Stopwatch();

			Console.WriteLine("\n#ADDING#\n");
			/*----------------------------------------------------------------------------------*/
			watch.Start();
			for ( int i = 0; i < elementsNumber; i++)
			{
				list.Add(new Student(i));
			}
			watch.Stop();
			Console.WriteLine("Collection List, is populated for time: {0}", watch.Elapsed);
			watch.Reset();
			/*----------------------------------------------------------------------------------*/
			watch.Start();
			for (int i = 0; i < elementsNumber; i++)
			{
				linkedList.AddLast(new Student(i));
			}
			watch.Stop();
			Console.WriteLine("Collection linkedList, is populated for time: {0}", watch.Elapsed);
			watch.Reset();
			/*----------------------------------------------------------------------------------*/
			watch.Start();
			for (int i = 0; i < elementsNumber; i++)
			{
				arrayList.Add(new Student(i));
			}
			watch.Stop();
			Console.WriteLine("Collection arrayList, is populated for time: {0}", watch.Elapsed);
			watch.Reset();
			/*----------------------------------------------------------------------------------*/
			watch.Start();
			for (int i = 0; i < elementsNumber; i++)
			{
				arrayList2.Add(new Student(i));
			}
			watch.Stop();
			Console.WriteLine("Collection arrayList2, is populated for time: {0}", watch.Elapsed);
			watch.Reset();
			/*----------------------------------------------------------------------------------*/

			Console.WriteLine("\n#SEARCH#\n");

			int searchedIndex = elementsNumber - 5;
			FindElement(searchedIndex, list);
			FindElement(searchedIndex, linkedList);
			FindElement(searchedIndex, arrayList);

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}

		public static void FindElement(int index, List<Student> list)
		{
			Stopwatch watch = new Stopwatch();
			watch.Start();
			Student value = list.ElementAt(index);
			watch.Stop();
			Console.WriteLine("Collection List, value: {0}, elapsed time: {1}", value.Id, watch.Elapsed);
		}
		public static void FindElement(int index, LinkedList<Student> list)
		{
			Stopwatch watch = new Stopwatch();
			watch.Start();
			Student value = list.ElementAt(index);
			watch.Stop();
			Console.WriteLine("Collection LinkedList, value: {0}, elapsed time: {1}", value.Id, watch.Elapsed);
		}
		public static void FindElement(int index, ArrayList list)
		{
			Stopwatch watch = new Stopwatch();
			watch.Start();
			Student value = (Student) list[index];
			watch.Stop();
			Console.WriteLine("Collection ArrayList, value: {0}, elapsed time: {1}", value.Id, watch.Elapsed);
		}

		public class Student
		{
			public int Id { get; set; }
			public Student (int id)
			{
				Id = id;
			}
		}

	}
}
