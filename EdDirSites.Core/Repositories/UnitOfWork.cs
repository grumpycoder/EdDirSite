namespace EdDirSites.Core.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public ISiteRepository Sites { get; set; }

        public UnitOfWork(ISiteRepository siteRepository)
        {
            Sites = siteRepository;
        }
    }

}
