using System.Collections.Generic;
using System.Threading.Tasks;
using EdDirSites.Core.Model;

namespace EdDirSites.Core.Repositories
{
    public interface ISiteRepository
    {
        IEnumerable<Site> GetAll();
        Task<IEnumerable<Site>> GetAllAsync();
        IEnumerable<Site> GetBySystem(string systemCode);
        Task<IEnumerable<Site>> GetBySystemAsync(string systemCode);
        Site GetSite(string systemCode, string schoolCode);
        Task<Site> GetSiteAsync(string systemCode, string schoolCode);
        Site GetSiteById(int id);
        Task<Site> GetSiteByIdAsync(int id);
    }
}