using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AbstractClass
{
	enum AnimalType
	{
		Cat,
		Dog,
		Mouse,
		Cow,
		Horse
	}
	abstract class FourLeggedAnimal
	{
		protected double weigh;

		public virtual string Describe()
		{
			return "This animal has four legs.";
		}

		public abstract AnimalType TypeOfAnimal();

		public void PrintWeight ()
		{
			Console.WriteLine("Weigh is: " + weigh);
		}
	}
}
