using Microsoft.EntityFrameworkCore;
using Orion.Domain.EntityCatalogQuantech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.DataAccess.Repository
{
    public class CatalogA2Repository : GenericRepository<CatalogA2>
    {
        public CatalogA2Repository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
