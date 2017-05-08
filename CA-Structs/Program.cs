using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Structs
{
	class Program
	{
		public class TheClass
		{
			public int x;
		}

		public struct TheStruct
		{
			public int x;
		}

		public static void Change(TheStruct s)
		{
			s.x = 5;
		}
		public static void Change(TheClass c)
		{
			c.x = 5;
		}

		public static void Main()
		{
			TheStruct structObject = new TheStruct();
			TheClass classObject = new TheClass();
			structObject.x = 1;
			classObject.x = 1;
			Change(structObject);
			Change(classObject);
			Console.WriteLine("structObject.x = {0}", structObject.x);
			Console.WriteLine("classObject.x = {0}", classObject.x);

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();

		}
	}
	
}
