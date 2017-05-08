using IntroExamples.ClassExample;
using System;

namespace IntroExamples.ImplicitConversion
{
    public class Student : Person
    {
        #region Fields
        private double gpa;
        #endregion Fields

        #region Constructor
        public Student(string name, string lastName, double gpa)
            : base (name, lastName)
        {
            this.gpa = gpa;
        }
        #endregion Constructors

        #region Properties 
        public double GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }
        #endregion Properties

        #region Methods
        public override string ToString()
        {
            return base.ToString() + "\t" + GPA;
        }
        #endregion Methods
    }
}
