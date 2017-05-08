using System.Web.Mvc;

namespace UrlShort.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Shortens URLs - for demo with Nintex";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Ian Bautista";

            return View();
        }
    }
}