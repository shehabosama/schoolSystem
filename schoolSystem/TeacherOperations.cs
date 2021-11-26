using System;
using System.Collections.Generic;
using System.Text;

namespace schoolSystem
{
	interface TeacherOperations
	{
		void getSpecificTeacherSalary(int teacherId);
		Teacher[] addTeacher(Teacher[] teacher);
	}
}
