﻿using System;
using System.Collections.Generic;
using System.Text;

namespace schoolSystem
{
	class FullTimeTeacher : PartTimeTeacher  , TeacherOperations
	{
		private float salaryOfMonth;
		private float countOfHours;
		private int AutoIndexing = 2;

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

		public void getSpecificTeacherSalary(int teacherId)
		{
			Console.WriteLine("getSpecificTeacherSalary : FullTimeTeacher");
		}

		public Teacher[] addTeacher(Teacher[] teachers)
		{
			int teacherNo = 0;
			Console.WriteLine("How many Student you want to add ? ");
			int teacherSize = Convert.ToInt32(Console.ReadLine());
			teachers = Array.ConvertAll(Helper.Re2Dimension(teachers, teachers.GetLength(0) + teacherSize), o => (Teacher)o);
			Console.WriteLine(teachers[0].getTeacherName());	
			for (int i = AutoIndexing; i < teachers.GetLength(0); i++)
			{
				Console.WriteLine("Enter The Studnet Number :" + ++teacherNo);
				Console.WriteLine("Student Id Is : " + (AutoIndexing + 1));
				Console.WriteLine("Enter Teacher ID");
				Console.WriteLine("Enter Teacer Name");
				String teacherName = Console.ReadLine();
				Console.WriteLine("Enter Teacher kuna");
				String kunya = Console.ReadLine(); 
				Console.WriteLine("Enter Salary");
				float salary = (float)Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("How many hours he worked in part time ?");
				float countOfHours = (float)Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("How many subjects he teach?");
				int countOfSubjects = Convert.ToInt32(Console.ReadLine());
				String[] temp = new String[countOfSubjects];
				for (int j = 0; j < countOfSubjects; j++)
				{
					Console.WriteLine("Enter Subject Name # "+j+1);

					temp[j] = Console.ReadLine();
				}
				teachers[i] = new FullTimeTeacher(AutoIndexing + 1 , teacherName , kunya , salary , temp , countOfHours);
			}
			
			return teachers;
		}
	}
}
