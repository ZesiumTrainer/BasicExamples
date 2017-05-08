using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_HashSet
{
	class Program
	{
		static void Main(string[] args)
		{
			int instanceNumber = 151000;
			HashSet<Student> students = new HashSet<Student>();

			Student stud1 = new Student(99999999);
			Student stud2 = new Student(99999999);

			students.Add(stud1);

			for (int i = 0; i < instanceNumber; i++)
			{
				students.Add(new Student(i));
			}
			students.Add(stud1);
			
			Find(stud1, students);
			Find(stud2, students);
			
			//Print(students);
			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();

		}

		public static void Print(HashSet<Student> students)
		{
			Console.WriteLine("Elements are: {0}", String.Join(",", students));
		}

		public static void Find(Student student, HashSet<Student> students)
		{
			Stopwatch watch = new Stopwatch();
			watch.Start();

			if (students.Contains(student))
			{
				watch.Stop();
				Console.WriteLine("Object is found! Time elapsed: {0}", watch.Elapsed);
			} else
			{
				watch.Stop();
				Console.WriteLine("Object was not found! Time elapsed: {0}", watch.Elapsed);
			}

		}
		public class Student
		{
			public int Id { get; set; }
			public Student(int id)
			{
				Id = id;
			}

			public override string ToString()
			{
				return Id.ToString();
			}
		}
	}
}
