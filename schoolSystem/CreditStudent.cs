using System;
using System.Collections.Generic;
using System.Text;

namespace schoolSystem
{
	class CreditStudent : Student, StdOperationInerface
	{
		private double expenses;
		private static int countOfStudent;
		private int currentStudingYear;
		private double registrationCost;
		private double transportationCost;
		private double totalCost;
		
		public CreditStudent() { 
			
		}
		public CreditStudent(int studentId, string studentName, string kunya, float gpa, string department, string birthDate, string attendingDate, string graduationDate, int currentStudingYear, string[,] subjects) 
			: base(studentId, studentName, kunya, gpa, department, birthDate, attendingDate, graduationDate, currentStudingYear, subjects)
		{
			countOfStudent++;
			this.currentStudingYear = currentStudingYear;
			registrationCost = 100;
			transportationCost = 400;
			totalCost = registrationCost + transportationCost;

			if (this.currentStudingYear != 1)
			{
				double  annualIncrese=  currentStudingYear * 10;
				double percntageOfIncresing = (registrationCost + transportationCost) * annualIncrese / 100;

				totalCost = registrationCost + transportationCost + percntageOfIncresing;
			}
		}

		public void getStudents(Student[] students)
		{
			for (int i = 0; i < students.Length; i++)
			{
				if (students[i].GetType() == new CreditStudent().GetType())
				{
					Console.WriteLine(
						  "\nStudent Type      : " + "Credit Student"
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
		public double getCostOfStudent() {
			return totalCost;
		}
		public int printCountOfStudent() { 
			return countOfStudent;
		}
		/*	public Student[] addStudent(Student[] std)
			{


				int stdNo = 0;
				Console.WriteLine("How many Student you want to add ?  "  + AutoIndexing);
				 studentSize += Convert.ToInt32(Console.ReadLine());
				std = Array.ConvertAll(Helper.Re2Dimension((Student[])std, std.GetLength(0) + studentSize), o => (Student)o);

				for (int i = AutoIndexing; i <std.GetLength(0); i++)
				{
					Console.WriteLine(AutoIndexing + " " + std.GetLength(0));
					Console.WriteLine("Enter The Studnet Number :" + ++stdNo);
					Console.WriteLine("Student Id Is : " + (AutoIndexing + 1));
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

					std[i] = new CreditStudent(AutoIndexing + 1, studentName, kunya, jpa, department, StudentBirthDate, StudentAttendingDate, graduationDate, currentStudyingYear, temp);
					Console.WriteLine("Student Added succesfully...");
					AutoIndexing++;

				}

				Console.WriteLine(std.Length);
				return std;
			}*/

		public Student[] addStudent(int lastIndex)
		{

			Student[] std;
			int studentSize = 0;
			int stdNo = 0;
			Console.WriteLine("How many Student you want to add ? ");
			try
			{
				studentSize = Convert.ToInt32(Console.ReadLine());
			}
			catch (FormatException ex)
			{
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
				int subjectCount = 0; float jpa = 0.0f;
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

				std[i] = new CreditStudent(lastIndex + 1, studentName, kunya, jpa, department, StudentBirthDate, StudentAttendingDate, graduationDate, currentStudyingYear, temp);
			}
			lastIndex++;
			//Console.WriteLine(std.Length);
			return std;
		}
	}
}
