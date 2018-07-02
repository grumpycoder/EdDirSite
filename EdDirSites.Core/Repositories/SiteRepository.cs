using EdDirSites.Core.Data;
using EdDirSites.Core.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace EdDirSites.Core.Repositories
{
    public class SiteRepository : ISiteRepository
    {
        private readonly EdContext _context;

        public SiteRepository(EdContext context)
        {
            _context = context;
        }

        public IEnumerable<Site> GetAll()
        {
            return _context.Sites.ToList();
        }

        public async Task<IEnumerable<Site>> GetAllAsync()
        {
            return await _context.Sites.ToListAsync();
        }

        public IEnumerable<Site> GetBySystem(string systemCode)
        {
            return _context.Sites.Where(s => s.SystemCode == systemCode).ToList();
        }

        public async Task<IEnumerable<Site>> GetBySystemAsync(string systemCode)
        {
            return await _context.Sites.Where(s => s.SystemCode == systemCode).ToListAsync();
        }

        public Site GetSite(string systemCode, string sitecode)
        {
            return _context.Sites.FirstOrDefault(s => s.SystemCode == systemCode && s.SiteCode == sitecode);
        }

        public async Task<Site> GetSiteAsync(string systemCode, string sitecode)
        {
            return await _context.Sites.FirstOrDefaultAsync(s => s.SystemCode == systemCode && s.SiteCode == sitecode);
        }

        public Site GetSiteById(int id)
        {
            return _context.Sites.FirstOrDefault(s => s.Id == id);
        }

        public async Task<Site> GetSiteByIdAsync(int id)
        {
            return await _context.Sites.FirstOrDefaultAsync(s => s.Id == id);
        }
    }
}
