using System;
using System.Collections.Generic;
using System.Text;

namespace schoolSystem
{
	class PartTimeTeacher : Teacher
	{
		private float countOfHours;

		public void setCountOfHours(float countOfHours) { this.countOfHours = countOfHours; }
		public float getCountOfHours() { return countOfHours; }

		public float calculateTheSallary() {
			return countOfHours * 5;
		}
	}
}
