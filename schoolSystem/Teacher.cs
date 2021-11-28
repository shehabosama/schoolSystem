using System;
using System.Collections.Generic;
using System.Text;

namespace schoolSystem
{
	class Teacher
	{
		private int teacherId;
		private String teacherName;
		private String kunya;
		private String[] subjects;
		private Teacher[] teachers;
		private TeacherOperations pTeacher, fTeacher;
		private static int AutoInexing = 2;
		
		public Teacher() { }
		public Teacher(int teacherId, string teacherName, string kunya, string[] subjects)
		{
			this.teacherId = teacherId;
			this.teacherName = teacherName;
			this.kunya = kunya;
			this.subjects = subjects;
			pTeacher = new PartTimeTeacher();
			fTeacher = new FullTimeTeacher();
			

		}

		public void initialTeachers(Teacher[] teachers) {
			this.teachers = teachers;
		}
		public void setTeacherId(int teacherId) { this.teacherId = teacherId; }
		public int getTeacherID() { return teacherId; }
		public void setTeacherName(String teacherName) { this.teacherName = teacherName; }
		public String getTeacherName() { return teacherName; }
		public void setTeacherKuyna(String teacherKunya) {this.kunya = teacherKunya;}
		public String getTeacherkunya() { return kunya; }
		public void setTeacherSubjects(String[] teacherSubjects) {this.subjects = teacherSubjects;}
		public String[] getTeacherSupjects() { return subjects; }
		
		public void addTeacher(Teacher[] teach , int type) {

			if (type == 1)
			{

				Teacher[] temp = fTeacher.addTeacher(AutoInexing);
				teachers = Array.ConvertAll(Helper.Re2Dimension(teachers, teachers.GetLength(0) + temp.Length), o => (Teacher)o);
				for (int i = AutoInexing, j = 0; j < temp.GetLength(0); i++, j++)
				{
					teachers[i] = temp[j];
					if (temp.GetLength(0) - 1 == j)
						Console.WriteLine("Student Added succesfully...");
				}
			}
			else if (type == 2) {
				Teacher[] temp = pTeacher.addTeacher(AutoInexing);
				teachers = Array.ConvertAll(Helper.Re2Dimension(teachers, teachers.GetLength(0) + temp.Length), o => (Teacher)o);
				for (int i = AutoInexing, j = 0; j < temp.GetLength(0); i++, j++)
				{
					teachers[i] = temp[j];
					if (temp.GetLength(0) - 1 == j)
						Console.WriteLine("Student Added succesfully...");
				}
			}
				
			else
			{
				Console.WriteLine("Please Select one of the selections");
				Program.programOptionsImplementation(Console.ReadLine());
			}
			AutoInexing = teachers.Length;

			Helper.goBackToMainMenu();

		}
		public void getSpecificTeacherSalary(int teacherId) {
			for (int i = 0; i < teachers.GetLength(0); i++) {
				Helper.spreateLine(2);
				if (teacherId == teachers[i].getTeacherID())
				{
					
					TeacherOperations teacher = (TeacherOperations)teachers[i];
					Console.WriteLine("Teacher Name   : "+teachers[i].getTeacherName());
					Console.WriteLine("Teacher Salary : " + teacher.getSpecificTeacherSalary(teacherId));
				}
			}
			Helper.goBackToMainMenu();
		}
		public void getTeachers() {
			for (int i = 0; i < teachers.GetLength(0); i++)
			{
				Helper.spreateLine(2);
				Console.WriteLine("Teacher ID     : " + teachers[i].getTeacherID()
						      + "\nTeacher Name   : " + teachers[i].getTeacherName());
			}
			Helper.goBackToMainMenu();
		}

		
	}
}
