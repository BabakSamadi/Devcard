using Devcard.Models;
using Microsoft.AspNetCore.Mvc;

namespace Devcard
{
	
	public class ProjectViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{

			var project = new List<project>()
			{

               new project( 1 , "Taxi" , "درخواست آنلاین شهری" , "Atria", "project-1.jpg"  ),
               new project( 2 , "zoodfood" , "درخواست آنلاین غدا" ,"Atria", "project-2.jpg"  ),
               new project( 3 , "school" , "درخواست آنلاین مدارس" , "Atria", "project-3.jpg"),
               new project( 4 , "spaceship" , "برنامه مدیریت فضا پیما های سراسر کشور  " , "Atria" , "project-4.jpg")

			};
			return View("Project", project);
		}
	}
}
