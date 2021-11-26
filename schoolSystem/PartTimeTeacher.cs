using System;
using System.Collections.Generic;
using System.Text;

namespace schoolSystem
{
	class PartTimeTeacher : Teacher , TeacherOperations
	{
		private float countOfHours;
		private static int AutoIndexing = 2;
		private PartTimeTeacher[] pTeachers;
		public PartTimeTeacher()
		{
		}

		public PartTimeTeacher(int teacherId, string teacherName, string kunya, string[] subjects , float countOfHour) 
			:base(teacherId , teacherName , kunya ,  subjects){
			this.countOfHours = countOfHour;
		}
		public void setCountOfHours(float countOfHours) { this.countOfHours = countOfHours; }
		public float getCountOfHours() { return countOfHours; }

		public virtual float calculateTheSallary() {
			return countOfHours * 5;
		}

		public void getSpecificTeacherSalary(int teacherId)
		{
			Console.WriteLine("getSpecificTeacherSalary : PartTimeTeacher");
		}

		public Teacher[] addTeacher(Teacher[] teachers)
		{

			for (int i = AutoIndexing; i < teachers.GetLength(0); i++) {
				teachers[i] = new PartTimeTeacher();
				teachers[i].setTeacherId(Convert.ToInt32(Console.ReadLine()));
				teachers[i].setTeacherName(Console.ReadLine());
				teachers[i].setTeacherKuyna(Console.ReadLine());
				int countOfSubjects = Convert.ToInt32(Console.ReadLine());
				String[] temp = new String[countOfSubjects];
				for (int j = 0; j < countOfSubjects; j++) {
					temp[j] = Console.ReadLine();
				}
				teachers[i].setTeacherSubjects(temp);
			}
			this.pTeachers =(PartTimeTeacher[]) teachers;
			return pTeachers;
		}
		
	}

}
