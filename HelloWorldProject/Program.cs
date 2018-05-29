using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject {
	class Program {
		static void Main(string[] args) {
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Hello, world!");

			Student student = new Student();

			student.SetFirstName("Frank");
			student.SetLastname("Zappa");
			student.SetStudentID(24601);
			student.SetGPA(3.8);
			student.SetSAT(400);
			student.SetIsFemale(false);
			
			string Fname;
			string Lname;
			int StID;
			double StGPA;
			int StSAT;
			bool StIsFemale;


			Fname = student.GetFirstname();
			Lname = student.GetLastname();
			StID = student.GetStudentID();
			StGPA = student.GetGPA();
			StSAT = student.GetSAT();
			StIsFemale = student.GetIsFemale();

			Console.WriteLine(Fname + " " + Lname + ", Student ID: " + StID + ", GPA: " + StGPA + ", SAT: " + StSAT + ", IsFemale: " + StIsFemale);

			

			//string YourName;
			//string DreamJob;
			//Console.WriteLine("What is your name?");
			//YourName = Console.ReadLine();
			//Console.WriteLine("Hello {0}", YourName);


			//Console.WriteLine("What is your dream job?");
			//Console.ForegroundColor = ConsoleColor.DarkRed;
			//DreamJob = Console.ReadLine();
			//Console.ForegroundColor = ConsoleColor.White;
			//Console.WriteLine("{1} your dream job is to be a {0}", DreamJob, YourName);


		}
	}
}
