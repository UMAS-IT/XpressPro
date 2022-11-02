using Orion.DataAccess.DataBase;
using Orion.Domain.EntityCatalog;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.DataAccess.Service
{
    public class CatalogService
    {
        public IList<ICatalog> GetCatalogAirCooledChillers()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<ICatalog> catalogs = new List<ICatalog>();
                 IList<CatalogAirCooledChiller> catalogAirCooledChillers = context.CatalogAirCooledChillers.ToList();
                catalogs.AddRange(catalogAirCooledChillers);
                return catalogs;
            }
        }
    }
}
