using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AbstractClass
{
	class Program
	{
		public static void Main()
		{
			Dog bulldog = new Dog(3.21);
			Cat cat = new Cat(1.01);

			PrintItem(bulldog);
			PrintItem((FourLeggedAnimal)cat);

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
		public static void PrintItem(FourLeggedAnimal animal)
		{
			Console.WriteLine("\nDescribe: {0}", animal.Describe());
			animal.PrintWeight();
			Console.WriteLine("Type: {0}", animal.TypeOfAnimal());
		}
	}
}
