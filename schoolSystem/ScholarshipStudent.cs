using System;
using System.Collections.Generic;
using System.Text;

namespace schoolSystem
{
	class ScholarshipStudent : Student
	{
		private static int scholarshipCountOfStudent = 0;

		public ScholarshipStudent()
		{
			
			scholarshipCountOfStudent++;
		}

		public ScholarshipStudent(int studentId, string studentName, string kunya, float gpa, string department, string birthDate, string attendingDate, string graduationDate, int currentStudingYear , String[][] subjects) 
			: base(studentId, studentName, kunya, gpa, department, birthDate, attendingDate, graduationDate, currentStudingYear,subjects)
		{
			scholarshipCountOfStudent++;
			Console.WriteLine(studentName);
		}

		public override int printCountOfStudent()
		{
			return scholarshipCountOfStudent;
		}
	}
}
