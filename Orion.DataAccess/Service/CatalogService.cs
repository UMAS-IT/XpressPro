using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogQuantech;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Orion.DataAccess.Service
{
    public class CatalogService
    {
        public IList<ICatalog> GetCatalogA1s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogA1s.ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogA2s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogA2s.ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogA3s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogA3s.ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogA4s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogA4s.ToList<ICatalog>();
            }
        }

        public ICatalog GetCatalogByCatalogId(ICatalog catalog)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                if (catalog is CatalogA1)
                {
                    return context.CatalogA1s.FirstOrDefault(x => x.Id == catalog.Id);
                }
                else if (catalog is CatalogA2)
                {
                    return context.CatalogA2s.FirstOrDefault(x => x.Id == catalog.Id);
                }
                else if (catalog is CatalogA3)
                {
                    return context.CatalogA3s.FirstOrDefault(x => x.Id == catalog.Id);
                }
                else if (catalog is CatalogA4)
                {
                    return context.CatalogA4s.FirstOrDefault(x => x.Id == catalog.Id);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
