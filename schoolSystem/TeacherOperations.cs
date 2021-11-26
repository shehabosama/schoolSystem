using System;
using System.Collections.Generic;
using System.Text;

namespace schoolSystem
{
	interface TeacherOperations
	{
		float getSpecificTeacherSalary(int teacherId);
		Teacher[] addTeacher(Teacher[] teacher);
	}
}
