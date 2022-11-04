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
                 return context.CatalogAirCooledChillers.ToList<ICatalog>();
            }
        }

        public ICatalog GetCatalogByCatalogId(ICatalog catalog)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                if (catalog is CatalogAirCooledChiller)
                {
                    return context.CatalogAirCooledChillers.FirstOrDefault(x => x.Id == catalog.Id);
                }
                else if (catalog is CatalogPump)
                {
                    return context.CatalogPumps.FirstOrDefault(x => x.Id == catalog.Id);
                }
                else if (catalog is CatalogUnit)
                {
                    return context.CatalogUnits.FirstOrDefault(x => x.Id == catalog.Id);
                }
                else if (catalog is CatalogVfd)
                {
                    return context.CatalogVfds.FirstOrDefault(x => x.Id == catalog.Id);
                }
                else
                {
                    return null;
                }
            }
        }

        public IList<ICatalog> GetCatalogPumps()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogPumps.ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogUnits()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogUnits.ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogVfds()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogVfds.ToList<ICatalog>();
            }
        }
    }
}
