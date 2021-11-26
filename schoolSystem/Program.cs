using System;

namespace schoolSystem
{
	class Program
	{
		public static Student[] students;
		public static Teacher[] teachers;
		public static Student stdRef;
		public static ScholarshipStudent stdShcollerShipRef;
		public static FullTimeTeacher fTeacherRef;
		public static PartTimeTeacher pTeacherRef;
		public static Teacher teacher;
		static void Main(string[] args)
		{
			//FullTimeTeacher f = new FullTimeTeacher();
			//PartTimeTeacher p = new PartTimeTeacher();
		
			init();
			//Console.WriteLine(obj.GetType()==obj2.GetType());
			//for (int i = 0; i < arr.Length; i++)
			//Console.WriteLine(arr[i].GetType() == new ScholarshipStudent().GetType());
			//ScholarshipStudent st = (ScholarshipStudent)arr[3];
			//Console.WriteLine(arr[0].printCountOfStudent()- st.printCountOfStudent());
			//Console.WriteLine(st.printCountOfStudent());
			//Student stt = new Student();S
			//stt.getTopTenStudents(arr);
			//Student.addEmployee(arr);
	
		}

		public static void init() {
			students =new Student[12] {
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
			teachers = new Teacher[2] { new PartTimeTeacher(1, "tamer", "salama", new String[]{ "cs" ,"Is" , "Os"},20) ,
										new FullTimeTeacher(1, "tamer", "salama", 343, new String[]{ "cs" ,"Is" , "Os"},20)};



			stdShcollerShipRef = (ScholarshipStudent)students[3];
			stdRef = students[0];
			teacher = teachers[1];
			pTeacherRef = (PartTimeTeacher)teachers[0];
			stdRef.addIntialStudent(students);
			teacher.addIntialTeachers(teachers);
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
					stdRef.getStudents();
					break;
				case "2":
					// Write the number of student and to get his degrees
					Console.WriteLine("Please Enter Th number of students : ");
					stdRef.getStudentSubjectsAndStatus(Convert.ToInt32(Console.ReadLine()));
					break;
				case "3":
					// print all the students that have scholarship
					Console.WriteLine("The count of Normal Student is : " + stdShcollerShipRef.printCountOfStudent());
					break;
				case "4":
					// get Top ten Student's degrees
					stdRef.getTopTenStudents();
					break;
				case "5":
					// Add Student
					stdRef.addStudent(students);
					break;
				case "6":
					// Add Teacher
					Console.WriteLine("What Type of Teacher you want to add ? ");
					Console.WriteLine("1 -Basic Teacher ");
					Console.WriteLine("2 -PartTime Teacher ");
					int type = Convert.ToInt32(Console.ReadLine());
					teacher.addTeacher(teachers,type);
					break;
				case "7":
					// Print the salary one of teachers
					break;
				case "8":
					// Print the salary one of teachers
					Console.WriteLine("The count of Normal Student is : "+(students[0].printCountOfStudent() - stdShcollerShipRef.printCountOfStudent()));
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
