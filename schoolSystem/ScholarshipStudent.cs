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
			
			int stdNo = 0;
			Console.WriteLine("How many Student you want to add ? ");
			int studentSize = Convert.ToInt32(Console.ReadLine());
			//	std = Array.ConvertAll(Helper.Re2Dimension((Student[])std, std.GetLength(0) + studentSize), o => (Student)o);

			std = new Student[studentSize];
			for (int i = 0; i < studentSize; i++)
			{
				Console.WriteLine("Enter The Studnet Number :" + ++stdNo);
				Console.WriteLine("Student Id Is : " + (lastIndex + 1));
				Console.WriteLine("Enter Student Name");
				String studentName = Console.ReadLine();
				Console.WriteLine("Enter Student Kunya");
				String kunya = Console.ReadLine();
				Console.WriteLine("Enter Student Birth Date");
				String StudentBirthDate = Console.ReadLine();
				Console.WriteLine("Enter Student Attending Date");
				String StudentAttendingDate = Console.ReadLine();
				Console.WriteLine("Enter Student Current Studying Year");
				int currentStudyingYear = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter Student Department");
				String department = Console.ReadLine();
				Console.WriteLine("Enter Stuent Jpa");
				float jpa = (float)Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Enter Student Graduation Date");
				String graduationDate = Console.ReadLine();
				Console.WriteLine("Enter how many subjects it has?");
				int subjectCount = Convert.ToInt32(Console.ReadLine());
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
				Console.WriteLine("Student Added succesfully...");

				lastIndex++;
			}
			
			return std;
		}

		
	}
}
