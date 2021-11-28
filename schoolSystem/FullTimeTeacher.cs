using System;
using System.Collections.Generic;
using System.Text;

namespace schoolSystem
{
	class FullTimeTeacher : PartTimeTeacher  , TeacherOperations
	{
		private float salaryOfMonth;
		private float countOfHours;

		public FullTimeTeacher()
		{
		}

		public FullTimeTeacher(int teacherId, string teacherName, string kunya, float teacherSalary, string[] subjects, float countOfHours)
			: base(teacherId, teacherName, kunya, subjects ,countOfHours)
		{
			this.countOfHours = countOfHours;
			this.salaryOfMonth = teacherSalary;
		}
		
		public void setSalaryOfMonth(float salaryOfMonth) { this.salaryOfMonth = salaryOfMonth; }
		public float getSalaryOfManth() { return salaryOfMonth; }
		public void setCountOfHours(float countOfHours) { this.countOfHours = countOfHours; }
		public override float calculateTheSallary() {
			float calcCountOfHours = countOfHours * 5;
			return salaryOfMonth + calcCountOfHours;
		}

		public float getSpecificTeacherSalary(int teacherId)
		{
			return calculateTheSallary();
			
		}

		public Teacher[] addTeacher(int lastIndex)
		{
			Teacher[] teachers;
			int teacherSize = 0;
			int teacherNo = 0;
			Console.WriteLine("How many Teacher you want to add ? ");
			try
			{
				teacherSize = Convert.ToInt32(Console.ReadLine());

			}
			catch (FormatException ex)
			{
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
				double salary = 0.0;
				try
				{
					Console.WriteLine("Enter The Teacher Number :" + ++teacherNo);
					Console.WriteLine("Teacher Id Is : " + (lastIndex + 1));
					Console.WriteLine("Enter Teacher Name");
					teacherName = Console.ReadLine();
					Console.WriteLine("Enter Teacher kunya");
					kunya = Console.ReadLine();
					Console.WriteLine("Enter Teacher Salary");
					salary = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("How many hours he worked in part time ?");
					countOfHours = (float)Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("How many subjects he teach?");
					countOfSubjects = Convert.ToInt32(Console.ReadLine());

				}
				catch (FormatException ex)
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
					Console.WriteLine("Enter Subject Name # "+j+1);
					temp[j] = Console.ReadLine();
				}
				teachers[i] = new FullTimeTeacher(lastIndex + 1 , teacherName , kunya , (float)salary , temp , countOfHours);
				lastIndex++;
			}
			
			return teachers;
		}
		
	}
}
