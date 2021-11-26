using System;
using System.Collections.Generic;
using System.Text;

namespace schoolSystem
{
	class Student : StdOperationInerface
	{
		private int studentId;
		private String studentName;
		private String kunya;
		private float gpa;
		private String department;
		private String birthDate;
		private String attendingDate;
		private String graduationDate;
		private int currentStudingYear;
		private static int countOfStudents = 0;
		private String[,] subjects;
		private Student[] students , topTenStudents;
		private static int AutoIndexing;
		public void setSubjects(String[,] subjects) { this.subjects = subjects; }
		public String[,] getSubjects() { return subjects; }

		public Student(int studentId, string studentName, string kunya, float gpa, string department,
			String birthDate, String attendingDate, String graduationDate, int currentStudingYear, String[,] subjects)
		{
			this.studentId = studentId;
			this.studentName = studentName;
			this.kunya = kunya;
			this.gpa = gpa;
			this.department = department;
			this.birthDate = birthDate;
			this.attendingDate = attendingDate;
			this.graduationDate = graduationDate;
			this.currentStudingYear = currentStudingYear;
			this.subjects = subjects;
			countOfStudents++;
		}

		public Student()
		{
			countOfStudents++;
		}

		public void setStudentId(int studentId)
		{
			this.studentId = studentId;
		}
		public int getStudentId()
		{
			return studentId;
		}
		public String getStudentName() {
			return studentName;
		}
		public void setStudentName(String studentName)
		{
			this.studentName = studentName;
		}
		
		
		public void setStudentKunya(String kunya) {
			this.kunya = kunya;
		}
		public String getStudentkunya()
		{
			return kunya;
		}

		public void setStudentGpa(float studentGpa)
		{
			this.gpa = studentGpa;
		}

		public float getStudentGpa()
		{
			return gpa;
		}

		public void setStudentDepartment(String studentDepartment) {
			this.department = studentDepartment;
		}
		public String getStudentDepartment() {
			return department;
		}

		public void setStudentBirthDate(String studentBirthDate) {
			this.birthDate = studentBirthDate;
		}
		public String getStudentBirthDate() {
			return birthDate;
		}
		public void setStudentAttendingDate(String studentAttendingDate) {
			this.attendingDate = studentAttendingDate;
		}
		public String getStudentAttendingDate() {
			return attendingDate;
		}

		public void setStudentGraduationDate(String studentGraduationDate)
		{
			this.graduationDate = studentGraduationDate ;
		}
		public String getStudentGraduationDate()
		{
			return graduationDate;
		}
		public void setStudentCurrentStudyingYear(int studentCurrentStudyingYear)
		{
			this.currentStudingYear = studentCurrentStudyingYear;
		}
		public int getStudentCurrentStudyingYear ()
		{
			return currentStudingYear;
		}

		public int getCountOfStudent() {
			return countOfStudents;
		}

		public  void getStudents()
		{
			for (int i = 0; i < students.Length; i++) { 
				Console.WriteLine(students[i].getStudentName());
			}
		}
		
		public  void getTopTenStudents()
		{
			topTenStudents = sortTopTenStudent(students);
			
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(topTenStudents[i].getStudentName());
			}
		}
		
		public void getStudentSubjectsAndStatus(int studentNumber)
		{
			for (int i = 0; i < students.GetLength(0); i++)
			{

				if (students[i].getStudentId() == studentNumber)
				{
					Console.WriteLine("Student Name : " + students[i].getStudentName());
					for (int sbjR = 0; sbjR < students[i].getSubjects().GetLength(0); sbjR++)
					{
						
						if (students[i].getSubjects()[sbjR, 1].Equals("pass"))
						{
							
							Console.WriteLine("Subject Name : "+ students[i].getSubjects()[sbjR, 0]);
							Console.WriteLine("degree : "+students[i].getSubjects()[sbjR,1]);
						}

					}
				}
			}
		}
		

		public  void addStudent(Student[] std)
		{
			int stdNo = 0;
			Console.WriteLine("How many Student you want to add ? ");
			int employee_size = Convert.ToInt32(Console.ReadLine());
			std = Array.ConvertAll(Helper.Re2Dimension((Student[])std, std.GetLength(0) + employee_size),o=>(Student)o);

			for (int i = AutoIndexing; i < std.GetLength(0); i++)
			{
				std[i] = new Student();
				Console.WriteLine("Enter The Studnet Number :" + ++stdNo);
				Console.WriteLine("Student Id Is : " + (AutoIndexing + 1));
				std[i].setStudentId(AutoIndexing + 1);	
				Console.WriteLine("Enter Student Name");
				std[i].setStudentName(Console.ReadLine());
				Console.WriteLine("Enter Student Birth Date");
				std[i].setStudentBirthDate(Console.ReadLine());	
				Console.WriteLine("Enter Student Attending Date");
				std[i].setStudentAttendingDate(Console.ReadLine());
				Console.WriteLine("Enter Student Current Studying Year");
				std[i].setStudentCurrentStudyingYear(Convert.ToInt32(Console.ReadLine()));
				Console.WriteLine("Enter Student Department");
				std[i].setStudentDepartment(Console.ReadLine());
				Console.WriteLine("Enter Stuent Jpa");
				std[i].setStudentGpa((float)Convert.ToDouble(Console.ReadLine()));
				Console.WriteLine("Enter Student Graduation Date");
				std[i].setStudentGraduationDate(Console.ReadLine());
				Console.WriteLine("Enter Student Kunya");
				std[i].setStudentKunya(Console.ReadLine());
				Console.WriteLine("Enter how many subjects it has?");
				int subjectCount = Convert.ToInt32(Console.ReadLine());
				String[,] temp = new string[subjectCount , 2];
				for (int sbjR = 0; sbjR < subjectCount; sbjR++) {
					for (int sbjC = 0; sbjC < 2; sbjC++) {
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
				std[i].setSubjects(temp);

				AutoIndexing++;
			}
			Console.WriteLine("Student Added succesfully...");
			
			students = std;
			//	goBackIntoMainMenu(2);
		}
		private Student[] sortTopTenStudent(Student[] stds) {
			Student temp;
			// traverse 0 to array length
			for (int i = 0; i < stds.Length - 1; i++)
			{
				// traverse i+1 to array length
				for (int j = i + 1; j < stds.Length; j++)
				{
					// compare array element with 
					// all next element
					if (stds[i].getStudentGpa() < stds[j].getStudentGpa()&&stds[i].getSubjects().Length==stds[j].getSubjects().Length)
					{
						temp = stds[i];
						stds[i] = stds[j];
						stds[j] = temp;
					}
				}
			}
			return stds;
		}
		public virtual int printCountOfStudent() {
			return countOfStudents;
		}
		public void addIntialStudent(Student[] stds) {
			students = stds;
			AutoIndexing = students.GetUpperBound(0);
		}

	}
}
