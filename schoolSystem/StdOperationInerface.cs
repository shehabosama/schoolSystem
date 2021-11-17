using System;
using System.Collections.Generic;
using System.Text;

namespace schoolSystem
{
	interface StdOperationInerface
	{
		void addStudent(Student[] std);
		 void getStudents(Student[] stds);
		void getTopTenStudents(Student[] stds);

	}
}
