using EdDirSites.Core.Repositories;
using System.Threading.Tasks;
using System.Web.Http;

namespace EdDirSites.Web.Controllers.Api
{
    [RoutePrefix("api/site")]
    public class SiteController : ApiController
    {
        private readonly IUnitOfWork _uow;

        public SiteController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<object> Get()
        {
            return Ok(await _uow.Sites.GetAllAsync());
        }

        [HttpGet, Route("{systemcode}")]
        public async Task<object> Get(string systemcode)
        {
            var list = await _uow.Sites.GetBySystemAsync(systemcode);

            return Ok(list);
        }


        //[HttpGet, Route("{systemcode}/school/{sitecode}")]
        [HttpGet, Route("{systemcode}/{sitecode}")]
        public async Task<object> Get(string systemcode, string sitecode)
        {
            var site = await _uow.Sites.GetSiteAsync(systemcode, sitecode);
            return Ok(site);
        }
    }
}
