namespace WPF_DataBinding_ObjectList
{
	public class Student
	{
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string Neptun { get; set; }
		public string email { get; set; }
		public double OverallAverage { get; set; }

		public Student(string ln, string fn, string nc, string e, double oa)
		{
			LastName = ln;
			FirstName = fn;
			Neptun = nc;
			email = e;
			OverallAverage = oa;
		}

		public Student() : this("Very", "Clever", "NAOKXX", "naok@net.hu", 3.24) { }

	}
}
