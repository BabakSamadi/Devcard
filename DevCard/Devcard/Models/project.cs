using Microsoft.Build.Evaluation;

namespace Devcard.Models
{
	public class project
	{

		public long id { get; set; }

		public string name { get; set; }

		public string discription { get; set; }

		public  string client { get; set;  }
		

	}


	//پاس دادن دو تا مدل در قالب یک کلاس که بصورت دو تا پراپرتی لیست هست 
	public class indexModel
	{
		public List<Project> Projects { get; set; }
		public List<Article> Articles { get; set; }
	}
}
