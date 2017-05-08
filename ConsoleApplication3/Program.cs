using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
	class Program
	{
		interface ISampleInterface
		{
			String Name { get; set; } //property
			void SampleMethod();
		}

		class ImplementationClass : ISampleInterface
		{
			public string SomeString { get; set; }

			public string Name
			{
				get
				{
					throw new NotImplementedException();
				}

				set
				{
					throw new NotImplementedException();
				}
			}

			// Explicit interface member implementation: 
			public void SampleMethod()
			{
				// Method implementation.
			}

			static void Main()
			{
				// Declare an interface instance.
				ISampleInterface obj = new ImplementationClass();

				// Call the member.
				obj.SampleMethod();

				Console.WriteLine("Press any key to exit.");
				Console.ReadKey();
			}
		}
	}
}
