namespace EdDirSites.Core.Repositories
{
    public interface IUnitOfWork
    {
        ISiteRepository Sites { get; set; }
    }
}
