

namespace Devcard.Models
{
	public class project
	{

		public long Id { get; set; }

		public string Name { get; set; }

		public string Discription { get; set; }

		public  string Client { get; set;  }

		public string Image { get; set; }


		public project( long id , string name , string discription , string client, string image)
		{

			Id = id;
			Name = name;
			Discription = discription;
			Client = client;
			Image = image;

		}
	}


	//پاس دادن دو تا مدل در قالب یک کلاس که بصورت دو تا پراپرتی لیست هست 
	//public class indexModel
	//{
	//	public List<Project> Projects { get; set; }
	//	public List<Article> Articles { get; set; }
	//}
}
