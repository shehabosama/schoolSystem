using System;

namespace schoolSystem
{
	class Program
	{
		public static Student[] students;
		public static Teacher[] teachers;
		public static Student stdRef;
		public static ScholarshipStudent stdShcollerShipRef;
		public static CreditStudent stdCreditStudentRef;
		public static Teacher teacher;
		static void Main(string[] args)
		{
			//FullTimeTeacher f = new FullTimeTeacher();
			//PartTimeTeacher p = new PartTimeTeacher();

			//Console.WriteLine(new ScholarshipStudent().GetType().ToString());
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
				new CreditStudent(1, "mohmed", "sdfsd", 1.2f, "cs", "11-10-1997", "20-2-2021", "2-6-2020", 1, new String[,]{
					{ "introduction to cs","pass"},
					{ "operating system", "pass" } }) ,

				new CreditStudent(2, "eslam", "sdfsd", 2.2f, "cs", "11-10-1997", "20-2-2021", "2-6-2020", 1, new String[,]{
					{ "introduction to cs","pass"},
					{ "operating system", "pass" } }),

				new CreditStudent(3, "shaker", "sdfsd", 3.2f, "cs", "11-10-1997", "20-2-2021", "2-6-2020", 1, new String[,]{
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
										new FullTimeTeacher(2, "tamer", "salama", 343, new String[]{ "cs" ,"Is" , "Os"},20)};



			stdShcollerShipRef = (ScholarshipStudent)students[3];
			stdCreditStudentRef = (CreditStudent)students[0];
			stdRef = students[0];
			teacher = teachers[1];
			stdRef.addIntialStudent(students);
			teacher.initialTeachers(teachers);
			Helper.programOptions();
			Helper.spreateLine(1);
			programOptionsImplementation(Console.ReadLine());
		}

	
		public static void programOptionsImplementation(String option) {
			switch (option)
			{
				case "1":
					//Print All Students currently exist in the school
					stdRef.getStudents(3);
					break;
				case "2":
					// Print Credit Student currently exist in the school
					stdRef.getStudents(1);
					break;
				case "3":
					//  Print Schollership Student currently exist in the school
					stdRef.getStudents(2);
					break;
				case "4":
					// Write the number of student and to get his degrees
					Console.WriteLine("Please Enter Th number of students : ");
					try
					{
						stdRef.getStudentSubjectsAndStatus(Convert.ToInt32(Console.ReadLine()));

					}
					catch (FormatException ex)
					{
						Console.WriteLine("Invalid Format Please Try again.");
						programOptionsImplementation(option);
					}
					catch (Exception ex)
					{
						Console.WriteLine("Error occure Please Try again.");
						programOptionsImplementation(option);
					}
					break;
				case "5":
					// Print Count of scholarship student currently exist in the school
					Console.WriteLine("The count of Schollership Students is : " + stdShcollerShipRef.printCountOfStudent());
					Helper.goBackToMainMenu();
					break;
				case "6":
					// Print Count of Credit students currently exist in the school
					//Console.WriteLine("The count of Normal Student is : "+(students[0].printCountOfStudent() - stdShcollerShipRef.printCountOfStudent()));
					Console.WriteLine("The count of Credit Student is : " + stdCreditStudentRef.printCountOfStudent());
					Helper.goBackToMainMenu();
					break;
				case "7":
					// get Top ten Student's degrees
					stdRef.getTopTenStudents();
					break;
				case "8":
					// Add Student
					Console.WriteLine("What Type of Student you want to add ? ");
					Console.WriteLine("1 -Credit Student ");
					Console.WriteLine("2 -Schollership Student ");
					try
					{
						int Studenttype = Convert.ToInt32(Console.ReadLine());
						stdRef.addStudent(students, Studenttype);
					}
					catch (FormatException ex)
					{
						Console.WriteLine("Invalid Format Please Try again.");
						programOptionsImplementation(option);
					}
					catch (Exception ex)
					{
						Console.WriteLine("Error occure Please Try again.");
						programOptionsImplementation(option);
					}
					break;
				case "9":
					// Add Teacher
					Console.WriteLine("What Type of Teacher you want to add ? ");
					Console.WriteLine("1 -Full Time Teacher ");
					Console.WriteLine("2 -Part Time Teacher ");
					try {
						int Teachertype = Convert.ToInt32(Console.ReadLine());
						teacher.addTeacher(teachers, Teachertype);
					} catch (FormatException ex) {
						Console.WriteLine("Invalid Format Please Try again.");
						programOptionsImplementation(option);
					}
					catch (Exception ex)
					{
						Console.WriteLine("Error occure Please Try again.");
						programOptionsImplementation(option);
					}

					break;
				case "10":
					// Print the salary one of teachers
					Console.WriteLine("Please Enter Teacher Id : ");
					try
					{
						int teacherId = Convert.ToInt32(Console.ReadLine());
						teacher.getSpecificTeacherSalary(teacherId);
					}
					catch (FormatException ex)
					{
						Console.WriteLine("Invalid Format Please Try again.");
						programOptionsImplementation(option);
					}
					catch (Exception ex)
					{
						Console.WriteLine("Error occure Please Try again.");
						programOptionsImplementation(option);
					}
					break;
				case "11":
					// get teachers
					teacher.getTeachers();
					break;
				default:
					Console.Clear();
					Console.WriteLine("*****************Please Select one of these numbers**************\n\n");
					Helper.programOptions();
					programOptionsImplementation(Console.ReadLine());
					break;
			}
		}
	}
}
