using System.Web.Mvc;
using Knife.Service.Services;

namespace Knife.Web.Controllers
{
	public class HomeController : Controller
	{
		public HomeController() {
		}

		public ActionResult Index() {
			new CompanyService(new Data.KnifeDbContext()).GetAll();
			return View();
		}

		public ActionResult About() {
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact() {
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}