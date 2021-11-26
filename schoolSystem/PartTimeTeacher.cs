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

		public float getSpecificTeacherSalary(int teacherId)
		{
			return calculateTheSallary();
			Console.WriteLine("getSpecificTeacherSalary : PartTimeTeacher");
		}

	    public Teacher[] addTeacher(Teacher[] teachers)
		{
			int teacherNo = 0;
			Console.WriteLine("How many Teacher you want to add ? ");
			int teacherSize = Convert.ToInt32(Console.ReadLine());
			teachers = Array.ConvertAll(Helper.Re2Dimension(teachers, teachers.GetLength(0) + teacherSize), o => (Teacher)o);
			
			for (int i = AutoIndexing; i < teachers.GetLength(0); i++)
			{
				AutoIndexing = teachers.GetUpperBound(0);
				Console.WriteLine("Enter The Teacher Number :" + ++teacherNo);
				Console.WriteLine("Teacher Id Is : " + (AutoIndexing + 1));
				
				Console.WriteLine("Enter Teacher Name");
				String teacherName = Console.ReadLine();
				Console.WriteLine("Enter Teacher kunya");
				String kunya = Console.ReadLine();
				
				Console.WriteLine("How many hours he worked in part time ?");
				float countOfHours = (float)Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("How many subjects he teach?");
				int countOfSubjects = Convert.ToInt32(Console.ReadLine());
				String[] temp = new String[countOfSubjects];
				for (int j = 0; j < countOfSubjects; j++)
				{
					Console.WriteLine("Enter Subject Name # " + j + 1);

					temp[j] = Console.ReadLine();
				}
				teachers[i] = new PartTimeTeacher(AutoIndexing + 1, teacherName, kunya, temp, countOfHours);
			}

			return teachers;
		}

	}

}
