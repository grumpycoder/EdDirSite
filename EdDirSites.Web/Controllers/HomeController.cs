using System.Web.Mvc;

namespace EdDirSites.Web.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
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