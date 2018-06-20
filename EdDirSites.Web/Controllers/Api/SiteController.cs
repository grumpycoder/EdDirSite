using EdDirSites.Core.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace EdDirSites.Web.Controllers.Api
{
    public class SiteController : ApiController
    {
        private EdContext context;

        public SiteController()
        {
            context = new EdContext();
        }

        public async Task<object> Get()
        {
            return Ok(context.Sites.OrderBy(x => x.Id).Skip(0).Take(100).ToList());
        }
    }
}
