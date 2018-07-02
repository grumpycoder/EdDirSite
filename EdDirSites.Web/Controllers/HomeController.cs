using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Mvc;
using EdDirSites.Core.Data;

namespace EdDirSites.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly EdContext _context;

        public HomeController(EdContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            return View();
        }

        [Route("{systemcode}/{schoolcode}")]
        public ActionResult SiteDetail(string systemcode, string schoolcode)
        {
            ViewBag.System = systemcode + "/" + schoolcode;

            return View("Index");
        }

        [Route("{systemcode}")]
        public ActionResult SiteList(string systemcode)
        {
            ViewBag.System = systemcode;
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}