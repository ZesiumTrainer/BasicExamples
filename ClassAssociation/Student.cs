using IntroExamples.ClassExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroExamples.ClassAssociation
{
    public class Student : Person
    {
        #region Fields
        private List<Person> associatedTeachers;
        #endregion Fields

        #region Constructors
        public Student () : base()
        {
            associatedTeachers = new List<Person>(0);
        }

        public Student (string name, string lastName) : base (name, lastName)
        {
            associatedTeachers = new List<Person>(0);
        }
        #endregion Constructors

        #region Properties
        public List<Person> AssociatedTeachers { get { return associatedTeachers; } }
        #endregion Properties

        #region Methods
        public void AddNewAssociatedTeacher(Person newTeacher)
        {
            if(!this.associatedTeachers.Contains(newTeacher))
            {
                this.associatedTeachers.Add(newTeacher);
            }
            else
            {
                Console.WriteLine("Student {0} is already associated with teacher {1}", 
                    this.ToString(), newTeacher.ToString());
            }
        }
        #endregion Methods
    }
}
