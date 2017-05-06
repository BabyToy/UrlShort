using System.Web.Mvc;
using UrlShort.Models;

namespace UrlShort.Controllers
{
    public class UrlController : Controller
    {
        // GET: Url
        public ActionResult Index()
        {
            var url = new Url();
            return View(url);
        }

        [HttpGet]
        public ActionResult Index(Url url)
        {
            if (ModelState.IsValid)
            {
                // construct the short url and return to view
                // url =
            }
            return View(url);
        }
    }
}