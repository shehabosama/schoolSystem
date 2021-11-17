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
		private float teacherSalary;
		private String[] supjects;
		public void setTeacherId(int teacherId) { this.teacherId = teacherId; }
		public int getTeacherID() { return teacherId; }
		public void setTeacherName(String teacherName) { this.teacherName = teacherName; }
		public String getTeacherName() { return teacherName; }
		public void setTeacherKuyna(String teacherKunya) {this.kunya = teacherKunya;}
		public String getTeacherkunya() { return kunya; }
		public void setTeacherSalary(float teacherSalary) { this.teacherSalary = teacherSalary; }
		public float getTeacherSalary() { return teacherSalary; }
		public void setTeacherSubjects(String[] teacherSubjects) {this.supjects = teacherSubjects;}
		public String[] getTeacherSupjects() { return supjects; }

	}
}
