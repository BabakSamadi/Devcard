using Devcard.Models;
using Microsoft.AspNetCore.Mvc;

namespace Devcard.Component
{
	public class ArticleViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var Article = new List<Article>()
			{
				new Article(1 , "پروژه شماره 1 " , " سایت بیمه دات کام " , "blog-post-Thumb-1.jpg"),
				new Article(1 , "پروژه شماره 2 " , " سایت دیجی کالا " , "blog-post-Thumb-2.jpg"),
				new Article(1 , "پروژه شماره 3 " , " سایت ترب " , "blog-post-Thumb-3.jpg")
			};


			return View("Article", Article);
		}



	}
}
