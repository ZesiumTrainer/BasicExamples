using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Inheritance
{
	enum Gender
	{
		Male,
		Female
	}
	// Human implicitly inherits from the Object class.
	class Human
	{
		//Properties.
		protected string FirstName { get; set; }
		protected string LastName { get; set; }
		protected int JMBG { get; set; }
		protected DateTime Birthday { get; set; }
		protected Gender Gender { get; set; }

		// Default constructor. If a derived class does not invoke a base-
		// class constructor explicitly, the default constructor is called
		// implicitly. 
		public Human() { }

		public Human(string firstName, string lastName, int jmbg, DateTime birthday, Gender gender)
		{
			FirstName = firstName;
			LastName = lastName;
			JMBG = jmbg;
			Birthday = birthday;
			Gender = gender;
		}
		public Human (Human human)
		{
			FirstName = human.FirstName;
			LastName = human.LastName;
			JMBG = human.JMBG;
			Birthday = human.Birthday;
			Gender = human.Gender;
		}
		public virtual void Print()
		{
			Console.WriteLine(this.ToString());
		}
		// Virtual method override of the ToString method that is inherited
		// from System.Object.
		public override string ToString()
		{
			return String.Format("\n#Person#\nFirstname:{0} \nLastName: {1}\nGender: {2} \nDate of birth: {3}", this.FirstName, this.LastName, this.Gender, this.Birthday);
		}
	}
}
