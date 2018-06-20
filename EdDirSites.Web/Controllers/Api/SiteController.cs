using EdDirSites.Core.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace EdDirSites.Web.Controllers.Api
{
    [RoutePrefix("api/site")]
    public class SiteController : ApiController
    {
        private EdContext context;

        public SiteController()
        {
            context = new EdContext();
        }

        public async Task<object> Get()
        {
            return Ok(await context.Sites.OrderBy(x => x.Id).Skip(0).Take(100).ToListAsync());
        }

        [HttpGet, Route("{id}")]
        public async Task<object> Get(int id)
        {
            var site = await context.Sites.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(site);
        }
    }
}
