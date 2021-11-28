using System;
using System.Collections.Generic;
using System.Text;

namespace schoolSystem
{
	interface StdOperationInerface
	{
		public Student[] addStudent(int lastIndex);
		

		public void getStudents(Student[] students);
		public void getTopTenStudents();
		public int printCountOfStudent();

	}
}
