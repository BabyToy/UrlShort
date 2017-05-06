using System.Threading.Tasks;
using System.Web.Mvc;
using UrlShort.Models;

namespace UrlShort.Controllers
{
    public class UrlController : Controller
    {
        private IUrlHandler handler;

        public UrlController(IUrlHandler handler)
        {
            this.handler = handler;
        }

        // GET: Url
        [HttpGet]
        public ActionResult Index()
        {
            var url = new Url();
            return View(url);
        }

        public async Task<ActionResult> Index(Url url)
        {
            if (ModelState.IsValid)
            {
                url.UrlShort = await this.handler.UrlShorten(url.UrlLong);
            }
            return View(url);
        }
    }
}