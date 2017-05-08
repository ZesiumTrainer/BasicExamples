using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
	class Program
	{

		static void Main()
		{
			// Instantiate the delegate.
			Del handler = DelegateMethod;

			MethodWithCallback(1, 1, handler);

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}

		public delegate void Del(string message);

		// Create a method for a delegate.
		public static void DelegateMethod(string message)
		{
			System.Console.WriteLine(message);
		}

		public static void MethodWithCallback(int param1, int param2, Del callback)
		{
			callback("The number is: " + (param1 + param2).ToString());
		}


	}
}
