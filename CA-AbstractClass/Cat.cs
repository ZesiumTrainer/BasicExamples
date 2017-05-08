using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AbstractClass
{
	class Cat : FourLeggedAnimal
	{
		public Cat(double weigh)
		{
			base.weigh = weigh;
		}
		public override string Describe()
		{
			string result = base.Describe();
			result += " In fact, it's a cat!";
			return result;
		}

		public override AnimalType TypeOfAnimal()
		{
			return AnimalType.Cat;
		}
	}

}
