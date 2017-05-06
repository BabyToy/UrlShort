using System.Web.Mvc;

namespace UrlShort.Controllers
{
    public class UrlController : Controller
    {
        // GET: Url
        public ActionResult Index()
        {
            return View();
        }
    }
}