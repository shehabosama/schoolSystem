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
		
		public void addTeacher(Teacher[] teachers , int type) {

			if (type == 1)
				this.teachers = fTeacher.addTeacher(teachers);
			else if (type == 2)
				this.teachers = pTeacher.addTeacher(teachers);
			else {
				Console.WriteLine("Please Select one of the selections");
				Program.programOptionsImplementation(Console.ReadLine());
			}
			Helper.goBackToMainMenu();

		}
		public void getSpecificTeacherSalary(int teacherId) {
			for (int i = 0; i < teachers.GetLength(0); i++) {

				if (teacherId == teachers[i].getTeacherID())
				{
					TeacherOperations teacher = (TeacherOperations)teachers[i];
					Console.WriteLine(teacher.getSpecificTeacherSalary(teacherId));
				}
			}
			Helper.goBackToMainMenu();
		}
		public void getTeachers() {
			for (int i = 0; i < teachers.GetLength(0); i++)
				Console.WriteLine(teachers[i].getTeacherName());

			Helper.goBackToMainMenu();
		}

	}
}
