using Orion.DataAccess.DataBase;
using Orion.Domain.AmericanWheatley.Related;
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

        public IList<CatalogC3ProductType> GetCatalogC3ProductTypes()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogC3ProductTypes.ToList();
            }
        }
    }
}
