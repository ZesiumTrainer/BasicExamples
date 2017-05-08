using IntroExamples.ClassAggregation;
using IntroExamples.ClassExample;
using System;
using System.Collections.Generic;

namespace IntroExamples.ClassComposition
{
    public class School
    {
        #region Fields
        private List<Department> departments = new List<Department>(0);
        private string schoolName;
        private int studentsCount;
        #endregion Fields

        #region Constructors
        public School (string schoolName, int studentsCount = 0)
        {
            this.schoolName = schoolName;
            this.studentsCount = studentsCount;
            initDepratmentList();
        }
        #endregion Constructors

        #region Properties
        public List<Department> Departments { get { return departments; } }

        public string SchoolName
        {
            get { return schoolName; }
            set { schoolName = value; }
        }

        public int StudentsCount
        {
            get { return studentsCount; }
            set { studentsCount = value; }
        }
        #endregion Properties

        #region Methods
        private void initDepratmentList ()
        {
            Department dep1 = new Department("Mobile");
            Department dep2 = new Department("Web");

            departments.Add(dep1);
            departments.Add(dep2);
        }
        #endregion Methods
    }
}
