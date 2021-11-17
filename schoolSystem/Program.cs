using System;

namespace schoolSystem
{
	class Program
	{
		
		static void Main(string[] args)
		{
			
			
			
			Student[] arr= { 
				new Student(1, "jtkelj", "sdfsd", 12.2f, "cs", "11-10-1997", "20-2-2021", "2-6-2020", 1,new String[][]{ 
					new String[]{ "introduction to cs","pass"},
					new String[] { "operating system", "pass" } } ) ,

				new Student(1, "jtkelj", "sdfsd", 12.2f, "cs", "11-10-1997", "20-2-2021", "2-6-2020", 1,new String[][]{ 
					new String[]{ "introduction to cs","pass"},
					new String[] { "operating system", "pass" } } ),

				new Student(1, "jtkelj", "sdfsd", 12.2f, "cs", "11-10-1997", "20-2-2021", "2-6-2020", 1,new String[][]{
					new String[]{ "introduction to cs","pass"},
					new String[] { "operating system", "pass" } } ),

				new ScholarshipStudent(1, "shehab", "sdfsd", 12.2f, "cs", "11-10-1997", "20-2-2021", "2-6-2020", 1, new String[][]{
					new String[]{ "introduction to cs","pass"},
					new String[] { "operating system", "pass" } }),

			new ScholarshipStudent(2, "osama", "sdfsd", 12.2f, "cs", "11-10-1997", "20-2-2021", "2-6-2020", 1, new String[][]{
					new String[]{ "introduction to cs","pass"},
					new String[] { "operating system", "pass" } })};

			//Console.WriteLine(obj.GetType()==obj2.GetType());
			//for (int i = 0; i < arr.Length; i++)
			//		Console.WriteLine(arr[i].GetType() == new ScholarshipStudent().GetType());


			ScholarshipStudent st = (ScholarshipStudent)arr[3];
			Console.WriteLine(arr[0].printCountOfStudent()- st.printCountOfStudent());
			Console.WriteLine(st.printCountOfStudent());
		}
	}
}
