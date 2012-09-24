using System.Web.Mvc;

namespace WAWS.Demo.App.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Message = "Welcome to the Windows Azure Web Sites Demo!";

			return View();
		}

		public ActionResult About()
		{
			return View();
		}
	}
}