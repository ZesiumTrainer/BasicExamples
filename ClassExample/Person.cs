using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroExamples.ClassExample
{
    public class Person
    {
        #region Fields
        private string name;
        private string lastName;
        #endregion Fields

        #region Constructors
        public Person ()
        {
            name = "John";
            lastName = "Doe";
        }

        public Person (string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }
        #endregion Constructors

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        #endregion Properties

        #region Methods
        public override string ToString()
        {
            return Name + " " + LastName;
        }
        #endregion Methods
    }
}
