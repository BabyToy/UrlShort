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
                var shortUrl = await this.handler.UrlShorten(url.LongUrl, Request.UserHostAddress);
                var requestUrl = Request.Url;
                url.ShortUrl = string.Format("{0}://{1}{2}{3}",
                    requestUrl.Scheme,
                    requestUrl.Authority,
                    Url.Content("~"),
                    shortUrl.Segment);
            }
            return View(url);
        }
    }
}