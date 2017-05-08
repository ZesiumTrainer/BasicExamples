using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Inheritance
{
	class Employee : Human
	{
		private DateTime startWorking;
		private String companyName;
		private string employeeId;

		// Default constructor for the derived class.
		public Employee() { }

		// Instance constructor that has four parameters.
		public Employee(string companyName, string employeeId, DateTime startWorking, string firstName, string lastName, int jmbg, DateTime birthday, Gender gender)
			:base(firstName, lastName, jmbg, birthday, gender)
		{
			this.companyName = companyName;
			this.employeeId = employeeId;
			this.startWorking = startWorking;
		}
		public Employee(string companyName, string employeeId, DateTime startWorking, Human human)
			: base(human)
		{
			this.companyName = companyName;
			this.employeeId = employeeId;
			this.startWorking = startWorking;
		}
		public override void Print()
		{
			base.Print();
			Console.WriteLine("Working in: {0}\nEmployee id: {1}\nStart working: {2}", companyName, employeeId, startWorking);
		}
	}
}
