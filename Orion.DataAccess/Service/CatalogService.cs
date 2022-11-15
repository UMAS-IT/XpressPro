﻿using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Orion.DataAccess.Service
{
    public class CatalogService
    {
        public bool CatalogModelNameExist(ICatalog catalog)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                if (catalog is CatalogA1)
                    return context.CatalogA1s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogA2)
                    return context.CatalogA2s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogA3)
                    return context.CatalogA3s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogA4)
                    return context.CatalogA4s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else
                    return true;
            }
        }

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

        public ICatalog UpdateCatalogItem(ICatalog catalog)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                ICatalog dbCatalog = null;

                if (catalog is CatalogA1)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogA1 catalogA1 = catalog as CatalogA1;
                        CatalogA1 dbCatalogA1 = context.CatalogA1s.FirstOrDefault(x => x.Id == catalog.Id);
                        
                        dbCatalogA1.Model = catalogA1.Model;
                        dbCatalogA1.ListPrice = catalogA1.ListPrice;
                        dbCatalogA1.CostMultiplier = catalogA1.CostMultiplier;
                        dbCatalogA1.SellMargin = catalogA1.SellMargin;
                        dbCatalogA1.UnitSize = catalogA1.UnitSize;
                        dbCatalogA1.Description = catalogA1.Description;
                        dbCatalogA1.Voltage = catalogA1.Voltage;

                        context.CatalogA1s.Update(dbCatalogA1);
                        dbCatalog = dbCatalogA1;
                    }
                    else
                    {
                        context.CatalogA1s.Add(catalog as CatalogA1);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogA2)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogA2 catalogA2 = catalog as CatalogA2;
                        CatalogA2 dbCatalogA2 = context.CatalogA2s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogA2.Model = catalogA2.Model;
                        dbCatalogA2.ListPrice = catalogA2.ListPrice;
                        dbCatalogA2.CostMultiplier = catalogA2.CostMultiplier;
                        dbCatalogA2.SellMargin = catalogA2.SellMargin;
                        dbCatalogA2.UnitSize = catalogA2.UnitSize;
                        dbCatalogA2.Description = catalogA2.Description;
                        dbCatalogA2.Voltage = catalogA2.Voltage;

                        context.CatalogA2s.Update(dbCatalogA2);
                        dbCatalog = dbCatalogA2;
                    }
                    else
                    {
                        context.CatalogA2s.Add(catalog as CatalogA2);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogA3)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogA3 catalogA3 = catalog as CatalogA3;
                        CatalogA3 dbCatalogA3 = context.CatalogA3s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogA3.Model = catalogA3.Model;
                        dbCatalogA3.ListPrice = catalogA3.ListPrice;
                        dbCatalogA3.CostMultiplier = catalogA3.CostMultiplier;
                        dbCatalogA3.SellMargin = catalogA3.SellMargin;
                        dbCatalogA3.UnitSize = catalogA3.UnitSize;
                        dbCatalogA3.Description = catalogA3.Description;
                        dbCatalogA3.Voltage = catalogA3.Voltage;

                        context.CatalogA3s.Update(dbCatalogA3);
                        dbCatalog = dbCatalogA3;
                    }
                    else
                    {
                        context.CatalogA3s.Add(catalog as CatalogA3);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogA4)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogA4 catalogA4 = catalog as CatalogA4;
                        CatalogA4 dbCatalogA4 = context.CatalogA4s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogA4.Model = catalogA4.Model;
                        dbCatalogA4.ListPrice = catalogA4.ListPrice;
                        dbCatalogA4.CostMultiplier = catalogA4.CostMultiplier;
                        dbCatalogA4.SellMargin = catalogA4.SellMargin;
                        dbCatalogA4.UnitSize = catalogA4.UnitSize;
                        dbCatalogA4.Description = catalogA4.Description;
                        dbCatalogA4.Voltage = catalogA4.Voltage;

                        context.CatalogA4s.Update(dbCatalogA4);
                        dbCatalog = dbCatalogA4;
                    }
                    else
                    {
                        context.CatalogA4s.Add(catalog as CatalogA4);
                        dbCatalog = catalog;
                    }
                }

                context.SaveChanges();

                return dbCatalog;
            }
        }
    }
}
