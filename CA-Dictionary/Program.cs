using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Dictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			Student student1 = new Student(1, "Milos");
			Student student2 = new Student(2, "Pera");
			Dictionary<int, Student> students = new Dictionary<int, Student>(2);

			students.Add(student1.Index, student1);
			students.Add(student2.Index, student2);

			Student std3 = new Student();
			Student std4 = students[1];

			std3 = std4;

			std3.Name = "Stevan";

			Print(students);

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}

		public static void Print(Dictionary<int, Student> students)
		{
			Console.WriteLine("List of students in dynamic collection: \n");

			foreach (KeyValuePair<int, Student> item in students)
			{
				Student student = item.Value;
				Console.WriteLine("Student: {0}, Index: {1}", student.Name, student.Index);
			}
		}

		public class Student
		{
			public int Index { get; set; }
			public string Name { get; set; }
			public Student() { }
			public Student(int Index, string Name) {
				this.Index = Index;
				this.Name = Name;
			}
		}
	}
}
