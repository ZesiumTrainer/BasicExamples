using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CA_AbstractClass
{
	class Dog : FourLeggedAnimal
	{
		public Dog(double weigh)
		{
			base.weigh = weigh;
		}
		public override AnimalType TypeOfAnimal()
		{
			return AnimalType.Dog;
		}

		public override string Describe()
		{
			string result = base.Describe();
			result += " In fact, it's a dog!";

			return result;
		}


		//public override void Calculate()
		//{

		//}
	}
}
