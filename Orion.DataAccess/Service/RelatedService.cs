using Orion.DataAccess.DataBase;
using Orion.Domain.UvResources.Related;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.DataAccess.Service
{
    public class RelatedService
    {
        public IList<CatalogF1ProductType> GetCatalogF1ProductTypes()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogF1ProductTypes.ToList();
            }
        }
    }
}
