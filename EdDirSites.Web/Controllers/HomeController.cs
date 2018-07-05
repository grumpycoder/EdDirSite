using EdDirSites.Core.Repositories;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EdDirSites.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _uow;

        public HomeController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public ActionResult Index()
        {
            var list = _uow.Sites.GetAll();
            return View();
        }

        [Route("{systemcode}/{sitecode}")]
        public ActionResult SiteDetail(string systemcode, string sitecode)
        {
            var site = _uow.Sites.GetSite(systemcode, sitecode);

            return View(site);
        }

        [Route("{systemcode}")]
        public async Task<ActionResult> SiteList(string systemcode)
        {
            ViewBag.System = systemcode;
            var list = await _uow.Sites.GetBySystemAsync(systemcode);

            return View("Index");
        }

        [Route("about")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}