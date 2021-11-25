using System;

namespace schoolSystem
{
	class Program
	{
		public static Student[] arr;
		public static Student std;
		public static ScholarshipStudent stdShcollerShip;
		static void Main(string[] args)
		{
			init();
			//Console.WriteLine(obj.GetType()==obj2.GetType());
			//for (int i = 0; i < arr.Length; i++)
			//		Console.WriteLine(arr[i].GetType() == new ScholarshipStudent().GetType());


			//ScholarshipStudent st = (ScholarshipStudent)arr[3];
			//Console.WriteLine(arr[0].printCountOfStudent()- st.printCountOfStudent());
			//Console.WriteLine(st.printCountOfStudent());
			//Student stt = new Student();
			//stt.getTopTenStudents(arr);
			//Student.addEmployee(arr);
	
		}

		public static void init() {

			
		

			arr =new Student[12] {
				new Student(1, "mohmed", "sdfsd", 1.2f, "cs", "11-10-1997", "20-2-2021", "2-6-2020", 1, new String[,]{
					{ "introduction to cs","pass"},
					{ "operating system", "pass" } }) ,

				new Student(2, "eslam", "sdfsd", 2.2f, "cs", "11-10-1997", "20-2-2021", "2-6-2020", 1, new String[,]{
					{ "introduction to cs","pass"},
					{ "operating system", "pass" } }),

				new Student(3, "shaker", "sdfsd", 3.2f, "cs", "11-10-1997", "20-2-2021", "2-6-2020", 1, new String[,]{
					{ "introduction to cs","pass"},
					 { "operating system", "pass" } }),

				new ScholarshipStudent(4, "shehab", "sdfsd", 12.2f, "cs", "11-10-1997", "20-2-2021", "2-6-2020", 1, new String[,]{
					{ "introduction to cs","pass"},
					{ "operating system", "pass" } }),

				new ScholarshipStudent(5, "osama", "sdfsd", 4.2f, "cs", "11-10-1997", "20-2-2021", "2-6-2020", 1, new String[,]{
					{ "introduction to cs","pass"},
					{ "operating system", "pass" } }),

			new ScholarshipStudent(6, "tamer", "sdfsd", 5.2f, "cs", "11-10-1997", "20-2-2021", "2-6-2020", 1, new String[,]{
					{ "introduction to cs","pass"},
					{ "operating system", "pass" } }),

			new ScholarshipStudent(7, "maged", "sdfsd", 6.2f, "cs", "11-10-1997", "20-2-2021", "2-6-2020", 1, new String[,]{
					{ "introduction to cs","pass"},
					{ "operating system", "pass" } }),

			new ScholarshipStudent(8, "smir", "sdfsd", 7.2f, "cs", "11-10-1997", "20-2-2021", "2-6-2020", 1, new String[,]{
					{ "introduction to cs","pass"},
					 { "operating system", "pass" } }),

			new ScholarshipStudent(9, "hisham", "sdfsd", 8.2f, "cs", "11-10-1997", "20-2-2021", "2-6-2020", 1, new String[,]{
					{ "introduction to cs","pass"},
					 { "operating system", "pass" } }),

			new ScholarshipStudent(10, "salama", "sdfsd", 9.2f, "cs", "11-10-1997", "20-2-2021", "2-6-2020", 1, new String[,]{
					{ "introduction to cs","pass"},
					 { "operating system", "pass" } }),

			new ScholarshipStudent(11, "samy", "sdfsd", 10.2f, "cs", "11-10-1997", "20-2-2021", "2-6-2020", 1, new String[,]{
					{ "introduction to cs","pass"},
					 { "operating system", "pass" } }),

			new ScholarshipStudent(12, "fathi", "sdfsd", 11.2f, "cs", "11-10-1997", "20-2-2021", "2-6-2020", 1, new String[,]{
					{ "introduction to cs","pass"},
					 { "operating system", "pass" },
					 { "information system", "pass" }})
					};
			stdShcollerShip = (ScholarshipStudent)arr[3];
			std = arr[0];
			std.addIntialStudent(arr);
			programOptions();
			programOptionsImplementation(Console.ReadLine());
		}

		private static void programOptions()
		{
			Console.WriteLine("1 - Print All Students currently exist in the school");
			Console.WriteLine("2 - Write the number of student and to get his degrees");
			Console.WriteLine("3 - print all the students that have scholarship");
			Console.WriteLine("4 - get Top ten Student's degrees");
			Console.WriteLine("5 - Add Student");
			Console.WriteLine("6 - Add Teacher");
			Console.WriteLine("7 - Print the salary one of teachers");
			Console.WriteLine("8 - Print Counr of student currently exist in the school");

		}
		private static void programOptionsImplementation(String option) {
			switch (option)
			{
				case "1":
					//Print All Students currently exist in the school
					std.getStudents();
					break;
				case "2":
					// Write the number of student and to get his degrees
					Console.WriteLine("Please Enter Th number of students : ");
					std.getStudentSubjectsAndStatus(Convert.ToInt32(Console.ReadLine()));
					break;
				case "3":
					// print all the students that have scholarship
					Console.WriteLine("The count of Normal Student is : " + stdShcollerShip.printCountOfStudent());
					break;
				case "4":
					// get Top ten Student's degrees
					std.getTopTenStudents();
					break;
				case "5":
					// Add Student
					std.addStudent(arr);
					break;
				case "6":
					// Add Teacher
					break;
				case "7":
					// Print the salary one of teachers
					break;
				case "8":
					// Print the salary one of teachers
					Console.WriteLine("The count of Normal Student is : "+(arr[0].printCountOfStudent() - stdShcollerShip.printCountOfStudent()));
					break;
				default:
					Console.Clear();
					Console.WriteLine("*****************Please Select one of these numbers**************\n\n");
					programOptions();
					programOptionsImplementation(Console.ReadLine());
					break;
			}
		}
	}
}
