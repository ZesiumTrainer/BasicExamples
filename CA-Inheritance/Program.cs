using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			Human human1 = new Human("Stive", "Stivenson",123456789, new DateTime(1988,3,17), Gender.Male);

			Human human2 = new Human("Klara", "Klarenson", 44444444, new DateTime(1984, 7, 23), Gender.Female);

			Employee employee1 = new Employee("SchneiderElectric", "NO_1", DateTime.Now, human2);

			Execute(human1);
			Execute(employee1);

			// Keep the console open in debug mode.
			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}

		public static void Execute (Human item)
		{
			item.Print();
		}


	}
}
