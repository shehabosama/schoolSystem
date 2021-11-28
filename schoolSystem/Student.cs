using System;
using System.Collections.Generic;
using System.Text;

namespace schoolSystem
{
	class Student
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
		private static Student[] students , topTenStudents;
		private StdOperationInerface cStudnt, sStudnt;
		private static int  AutoInexing =12;
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
			cStudnt = new CreditStudent();
			sStudnt = new ScholarshipStudent();
		}

		public Student()
		{
			
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

		public  void getStudents(int studentType)
		{
			if (studentType == 1)
			{
				cStudnt.getStudents(students);
			}
			else if (studentType == 2)
			{
				sStudnt.getStudents(students);
			}
			else if (studentType == 3) { 
			for (int i = 0; i < students.Length; i++) {
					bool checkType = students[i].GetType().ToString().Equals("schoolSystem.ScholarshipStudent");
					string type = checkType ? "Scholarship Student" : "Credit Student";
				Console.WriteLine(
					  "\nStudent Type      : " + type
					+ "\nStudent ID        : " + students[i].getStudentId()
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
		
		public  void getTopTenStudents()
		{
			topTenStudents = sortTopTenStudent(students);
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Student Name : "+topTenStudents[i].getStudentName() 
					+"\nStudent GPA  : "+topTenStudents[i].getStudentGpa() );
				Helper.spreateLine(2);
				for (int sbjR = 0; sbjR < topTenStudents[i].getSubjects().GetLength(0); sbjR++)
				{
					for (int sbjC = 0; sbjC < 2; sbjC++)
					{
						if(sbjC == 0)
						Console.WriteLine("Student subject   : "+topTenStudents[i].getSubjects()[sbjR,0]);
						else
						Console.WriteLine("Status of subject : " + topTenStudents[i].getSubjects()[sbjR, 1]+"\n");

					}
				}
				Helper.spreateLine(2);
			}

			Helper.goBackToMainMenu();
		}
		
		public void getStudentSubjectsAndStatus(int studentNumber)
		{
			for (int i = 0; i < students.GetLength(0); i++)
			{

				if (students[i].getStudentId() == studentNumber)
				{
					Console.WriteLine("Student Name : " + students[i].getStudentName()
						+"\n\n"+ "Subjects that he passed in : " + "\n");
					for (int sbjR = 0; sbjR < students[i].getSubjects().GetLength(0); sbjR++)
					{
						
						if (students[i].getSubjects()[sbjR, 1].Equals("pass"))
						{
							
							Console.WriteLine("Subject Name : "+ students[i].getSubjects()[sbjR, 0]);
							Console.WriteLine("degree : "+students[i].getSubjects()[sbjR,1]+"\n");
							
						}

					}
				}
			}
			Helper.goBackToMainMenu();
		}
		

		public  void addStudent(Student[] std , int type)
		{

			if (type == 1)
			{
				Student[] newStudent = cStudnt.addStudent(AutoInexing);
				assignNewStudentToOldStudent(newStudent);
			}
			else if(type == 2)
			{
				Student[] newStudent= sStudnt.addStudent(AutoInexing);
				assignNewStudentToOldStudent(newStudent);
			}
			else
			{
				Console.WriteLine("Please Select one of the selections");
				Program.programOptionsImplementation(Console.ReadLine());
			}
			AutoInexing = students.Length;
			Helper.goBackToMainMenu();
		}
		public void assignNewStudentToOldStudent(Student[] newStudent) {
			students = Array.ConvertAll(Helper.Re2Dimension((Student[])students, students.GetLength(0) + newStudent.Length), o => (Student)o);
			for (int i = AutoInexing, j = 0; j < newStudent.GetLength(0); i++, j++)
			{
				students[i] = newStudent[j];
				if (newStudent.GetLength(0) - 1 == j)
					Console.WriteLine("Student Added succesfully...");
			}
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
		}

	}
}
