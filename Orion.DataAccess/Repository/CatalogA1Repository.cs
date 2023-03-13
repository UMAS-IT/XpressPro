using Microsoft.EntityFrameworkCore;
using Orion.Domain.EntityCatalogQuantech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.DataAccess.Repository
{
    public class CatalogA1Repository : GenericRepository<CatalogA1>
    {
        public CatalogA1Repository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
