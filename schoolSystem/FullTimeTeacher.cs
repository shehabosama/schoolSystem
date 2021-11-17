using System;
using System.Collections.Generic;
using System.Text;

namespace schoolSystem
{
	class FullTimeTeacher : PartTimeTeacher
	{
		private float salaryOfMonth;
		public void setSalaryOfMonth(float salaryOfMonth) { this.salaryOfMonth = salaryOfMonth; }
		public float getSalaryOfManth() { return salaryOfMonth; }

	}
}
