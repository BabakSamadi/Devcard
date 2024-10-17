namespace Devcard.Models;

public class Article
{

	public long Id { get; set; }

	public string Title { get; set; }

	public string Discription { get; set; }

	public string Image { get; set; }
	public Article(long id, string title, string discription, string image)
	{
		Id = id;
		Title = title;
		Discription = discription;
		Image = image;
	}




}


