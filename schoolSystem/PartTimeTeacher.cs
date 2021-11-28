using System;
using System.Collections.Generic;
using System.Text;

namespace schoolSystem
{
	class PartTimeTeacher : Teacher , TeacherOperations
	{
		private float countOfHours;
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

	    public Teacher[] addTeacher(int lastIndex)
		{
			Teacher[] teachers;
			int teacherSize = 0;
			int teacherNo = 0;
			Console.WriteLine("How many Teacher you want to add ? ");
			try {
				teacherSize = Convert.ToInt32(Console.ReadLine());
			} catch (FormatException ex) { 
				Console.WriteLine("Invaild Foramt Please Try again");
				addTeacher(lastIndex);
			}
			
			//	teachers = Array.ConvertAll(Helper.Re2Dimension(teachers, teachers.GetLength(0) + teacherSize), o => (Teacher)o);
			teachers = new Teacher[teacherSize];
			for (int i = 0; i < teachers.GetLength(0); i++)
			{
				String teacherName = "";
				String kunya = "";
				float countOfHours = 0.0f;
				int countOfSubjects = 0;
				try
				{
				Console.WriteLine("Enter The Teacher Number :" + ++teacherNo);
					Console.WriteLine("Teacher Id Is : " + (lastIndex + 1));
					Console.WriteLine("Enter Teacher Name");
					teacherName = Console.ReadLine();
					Console.WriteLine("Enter Teacher kunya");
					kunya = Console.ReadLine();
					Console.WriteLine("How many hours he worked in part time ?");
					countOfHours = (float)Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("How many subjects he teach?");
					countOfSubjects = Convert.ToInt32(Console.ReadLine());
				}catch (FormatException ex)
				{
					Console.WriteLine("Invaild Foramt Please Try again");
					addTeacher(lastIndex);
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error occure Please Try again");
					addTeacher(lastIndex);
				}
				String[] temp = new String[countOfSubjects];
				for (int j = 0; j < countOfSubjects; j++)
				{
					Console.WriteLine("Enter Subject Name # " + j + 1);

					temp[j] = Console.ReadLine();
				}
				teachers[i] = new PartTimeTeacher(lastIndex + 1, teacherName, kunya, temp, countOfHours);
				lastIndex++;
			}
			
			return teachers;
		}

	}

}
