using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdDirSites.Core.Repositories
{
    public interface IUnitOfWork
    {
        ISiteRepository Sites { get; set; }
    }

    public interface ISiteRepository
    {
    }
}
