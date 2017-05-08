using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_List
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> listOfNumbers = new List<int>();
			LinkedList<int> linkedLists = new LinkedList<int>();

			ArrayList arrayListOfNum = new ArrayList();

			listOfNumbers.Add(1);
			listOfNumbers.Add(2);
			listOfNumbers.Add(3);
			listOfNumbers.Add(4);

			linkedLists.AddFirst(2);
			linkedLists.AddFirst(1);
			linkedLists.AddLast(4);
			LinkedListNode<int> selectedElement = linkedLists.Find(4);
			linkedLists.AddBefore(selectedElement, 3);

			arrayListOfNum.Add(1);
			arrayListOfNum.Add(2);
			arrayListOfNum.Add(3);
			arrayListOfNum.Add(4);

			Print(listOfNumbers);
			Print(linkedLists);
			Print(arrayListOfNum);
			
			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}

		public static void Print(IEnumerable list)
		{

			Console.WriteLine("\nPrinting elements of: \"{0}\" collection type", list.GetType());
			Type type = list.GetType();

			Console.WriteLine("\n{0}", String.Join(",", list.OfType<int>().Select(element => element)));
		}

	}
}
