using System;
using System.Collections.Generic;
using System.Text;

namespace schoolSystem
{
	class ScholarshipStudent : Student, StdOperationInerface
	{
		private static int scholarshipCountOfStudent = 0;

		public ScholarshipStudent()
		{

		}

		public ScholarshipStudent(int studentId, string studentName, string kunya, float gpa, string department, string birthDate, string attendingDate, string graduationDate, int currentStudingYear, String[,] subjects)
			: base(studentId, studentName, kunya, gpa, department, birthDate, attendingDate, graduationDate, currentStudingYear, subjects)
		{
			scholarshipCountOfStudent++;
			//Console.WriteLine(studentName);
		}

		public int printCountOfStudent()
		{
			return scholarshipCountOfStudent;
		}

		public void getStudents(Student[] students)
		{
			for (int i = 0; i < students.Length; i++)
			{
				if (students[i].GetType() == new ScholarshipStudent().GetType()) { 
					Console.WriteLine(
						  "\nStudent Type      : " + "Scholarship Student"
						 +"\nStudent ID        : " + students[i].getStudentId()
						+ "\nStudent Name      : " + students[i].getStudentName()
						+ "\nStudent B. Date   : " + students[i].getStudentBirthDate()
						+ "\nStudent G. Date   : " + students[i].getStudentGraduationDate()
						+ "\nStudent Department: " + students[i].getStudentDepartment()
						+ "\nStudent GPA       : " + students[i].getStudentGpa());
					Helper.spreateLine(2);
				}
				
			}
			Helper.goBackToMainMenu();
		}
		public Student[] addStudent(int lastIndex)
		{
			Student[] std;
			int studentSize = 0;
			int stdNo = 0;
			Console.WriteLine("How many Student you want to add ? ");
			try {
				studentSize = Convert.ToInt32(Console.ReadLine());
			}
			catch (FormatException ex) {
				Console.WriteLine("Not a valid format. Please try again.");
				addStudent(lastIndex);
			}
			//	std = Array.ConvertAll(Helper.Re2Dimension((Student[])std, std.GetLength(0) + studentSize), o => (Student)o);

			std = new Student[studentSize];
			for (int i = 0; i < studentSize; i++)
			{
				String studentName = "";  
				String kunya = ""; 
				String StudentBirthDate = ""; 
				String StudentAttendingDate = "";
				int currentStudyingYear = 0;
				String department = "";
				int subjectCount=0; float jpa = 0.0f; 
				String graduationDate = "";
				try
				{
				Console.WriteLine("Enter The Studnet Number :" + ++stdNo);
				Console.WriteLine("Student Id Is : " + (lastIndex + 1));
				Console.WriteLine("Enter Student Name");
				 studentName = Console.ReadLine();
				Console.WriteLine("Enter Student Kunya");
				 kunya = Console.ReadLine();
				Console.WriteLine("Enter Student Birth Date");
				 StudentBirthDate = Console.ReadLine();
				Console.WriteLine("Enter Student Attending Date");
				 StudentAttendingDate = Console.ReadLine();
				Console.WriteLine("Enter Student Current Studying Year");
				 currentStudyingYear = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter Student Department");
				 department = Console.ReadLine();
				Console.WriteLine("Enter Stuent Jpa");
				 jpa = (float)Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Enter Student Graduation Date");
				 graduationDate = Console.ReadLine();
				Console.WriteLine("Enter how many subjects it has?");
				subjectCount = Convert.ToInt32(Console.ReadLine());
				}
				catch (FormatException ex)
				{
					Console.WriteLine("Not a valid format. Please try again.");
					addStudent(lastIndex);
					
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error occurred! Please try again.");
					addStudent(lastIndex);
				}

				String[,] temp = new string[subjectCount, 2];
				for (int sbjR = 0; sbjR < subjectCount; sbjR++)
				{
					for (int sbjC = 0; sbjC < 2; sbjC++)
					{
						if (sbjC == 0)
						{
							Console.WriteLine("Enter the student subject");
							temp[sbjR, 0] = Console.ReadLine();
						}
						else
						{
							Console.WriteLine("Enter if it pass or fail");
							temp[sbjR, 1] = Console.ReadLine();
						}
					}
				}

				std[i] = new ScholarshipStudent(lastIndex + 1, studentName, kunya, jpa,department, StudentBirthDate,
					                            StudentAttendingDate, graduationDate, currentStudyingYear, temp);

				lastIndex++;
			}
			
			return std;
		}

		
	}
}
