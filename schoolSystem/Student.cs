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
		private String[][] subjects;

		public void setSubjects(String[][] subjects) { this.subjects = subjects; }
		public String[][] getSubjects() { return subjects; }

		public Student(int studentId, string studentName, string kunya, float gpa, string department,
			String birthDate, String attendingDate, String graduationDate, int currentStudingYear, String[][] subjects)
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

		public  void addStudent(Student[] std)
		{
			throw new NotImplementedException();
		}

		public void getStudents(Student[] stds)
		{
			for (int i = 0; i < stds.Length; i++) { 
				Console.WriteLine(stds[i].getStudentName());
			}
		}

		public void getTopTenStudents(Student[] stds)
		{
			Student[] temp;
			temp = sortStudent(stds);
			

			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(temp[i].getStudentName());
			}
		}

		private Student[] sortStudent(Student[] stds) {
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

	}
}
