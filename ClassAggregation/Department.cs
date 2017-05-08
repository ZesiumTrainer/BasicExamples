using IntroExamples.ClassExample;
using System;
using System.Collections.Generic;

namespace IntroExamples.ClassAggregation
{
    public class Department
    {
        #region Fields
        private string name;
        private List<Person> teachers;
        #endregion Fields

        #region Constructors
        public Department(string name)
        {
            this.name = name;
            teachers = new List<Person>();
        }
        #endregion Constructors

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Person> Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }
        #endregion Properties
    }
}
