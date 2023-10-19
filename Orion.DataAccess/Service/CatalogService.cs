using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.DataBase;
using Orion.Domain.AmericanWheatley.Related;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityCatalogAmericanWheatley;
using Orion.Domain.EntityCatalogGroundfos;
using Orion.Domain.EntityCatalogPuroflux;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Domain.EntityCatalogUvResources;
using Orion.Domain.Marvair.Catalog;
using Orion.Domain.Marvair;
using Orion.Domain.Multiaqua.Catalog;
using Orion.Domain.PACE.Catalog;
using Orion.Domain.UvResources.Related;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using static Orion.Helper.Misc.GV;
using Orion.Domain.EntityCatalogBACOpenLoopTowers;
using Orion.Domain.EntityCatalogBACClosedLoopTowers;
using Orion.Domain.EntityCatalogGeneralProduct;
using System.Data.SqlClient;
using Orion.DataAccess.Misc;

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

                else if (catalog is CatalogB1)
                    return context.CatalogB1s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogB2)
                    return context.CatalogB2s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogB3)
                    return context.CatalogB3s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogB4)
                    return context.CatalogB4s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogB5)
                    return context.CatalogB5s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);

                else if (catalog is CatalogC1)
                    return context.CatalogC1s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogC2)
                    return context.CatalogC2s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogC3)
                    return context.CatalogC3s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogC4)
                    return context.CatalogC4s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogC5)
                    return context.CatalogC5s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogC6)
                    return context.CatalogC6s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogC7)
                    return context.CatalogC7s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);

                else if (catalog is CatalogD1)
                    return context.CatalogD1s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogD2)
                    return context.CatalogD2s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);

                else if (catalog is CatalogE1)
                    return context.CatalogE1s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogE2)
                    return context.CatalogE2s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogE3)
                    return context.CatalogE3s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogE4)
                    return context.CatalogE4s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogE5)
                    return context.CatalogE5s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogE6)
                    return context.CatalogE6s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogE7)
                    return context.CatalogE7s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);

                else if (catalog is CatalogF1)
                    return context.CatalogF1s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);

                else if (catalog is CatalogG1)
                    return context.CatalogG1s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogG2)
                    return context.CatalogG2s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogG3)
                    return context.CatalogG3s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogG4)
                    return context.CatalogG4s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogG5)
                    return context.CatalogG5s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogG6)
                    return context.CatalogG6s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);

                else if (catalog is CatalogH1)
                    return context.CatalogH1s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogH2)
                    return context.CatalogH2s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogH3)
                    return context.CatalogH3s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogH4)
                    return context.CatalogH4s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogH5)
                    return context.CatalogH5s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);

                else if (catalog is CatalogI1)
                    return context.CatalogI1s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogI2)
                    return context.CatalogI2s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);

                else if (catalog is CatalogJ1)
                    return context.CatalogJ1s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);

                else if (catalog is CatalogK1)
                    return context.CatalogK1s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogK2)
                    return context.CatalogK2s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogK2)
                    return context.CatalogK3s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);

                else if (catalog is CatalogL1)
                    return context.CatalogL1s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);

                else
                    return true;
            }
        }

        public IList<ICatalog> GetCatalogs(ItemType itemType)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return GetCatalogs(itemType, context);
            }
        }

        public IList<ICatalog> GetCatalogs(ItemType itemType, GlobalDbContext context)
        {
            IList<ICatalog> catalogs = null;

            switch (itemType)
            {
                case ItemType.ItemA1:
                    catalogs = context.CatalogA1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemA2:
                    catalogs = context.CatalogA2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemA3:
                    catalogs = context.CatalogA3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemA4:
                    catalogs = context.CatalogA4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemB1:
                    catalogs = context.CatalogB1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).OrderBy(x => x.Hp).ToList<ICatalog>();
                    break;

                case ItemType.ItemB2:
                    catalogs = context.CatalogB2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemB3:
                    catalogs = context.CatalogB3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemB4:
                    catalogs = context.CatalogB4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemB5:
                    catalogs = context.CatalogB5s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemC1:
                    catalogs = context.CatalogC1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).Include(x => x.CatalogC1ProductType).ToList<ICatalog>();
                    break;

                case ItemType.ItemC2:
                    catalogs = context.CatalogC2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemC3:
                    catalogs = context.CatalogC3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).Include(x => x.CatalogC3ProductType).ToList<ICatalog>();
                    break;

                case ItemType.ItemC4:
                    catalogs = context.CatalogC4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemC5:
                    catalogs = context.CatalogC5s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemC6:
                    catalogs = context.CatalogC6s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemC7:
                    catalogs = context.CatalogC7s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemD1:
                    catalogs = context.CatalogD1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemD2:
                    catalogs = context.CatalogD2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemE1:
                    catalogs = context.CatalogE1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemE2:
                    catalogs = context.CatalogE2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemE3:
                    catalogs = context.CatalogE3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemE4:
                    catalogs = context.CatalogE4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemE5:
                    catalogs = context.CatalogE5s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemE6:
                    catalogs = context.CatalogE6s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemE7:
                    catalogs = context.CatalogE7s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemF1:
                    catalogs = context.CatalogF1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).Include(x => x.CatalogF1ProductType).ToList<ICatalog>();
                    break;

                case ItemType.ItemG1:
                    catalogs = context.CatalogG1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemG2:
                    catalogs = context.CatalogG2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemG3:
                    catalogs = context.CatalogG3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemG4:
                    catalogs = context.CatalogG4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemG5:
                    catalogs = context.CatalogG5s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemG6:
                    catalogs = context.CatalogG6s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemH1:
                    catalogs = context.CatalogH1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemH2:
                    catalogs = context.CatalogH2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemH3:
                    catalogs = context.CatalogH3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemH4:
                    catalogs = context.CatalogH4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemH5:
                    catalogs = context.CatalogH5s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.ItemI1:
                    catalogs = context.CatalogI1s.Include(c => c.DataSheet)
                        .ThenInclude(ds => ds.Titles)
                        .ThenInclude(t => t.Specs)
                        .ToList<ICatalog>();
                    break;

                case ItemType.ItemI2:
                    catalogs = context.CatalogI2s.Include(c => c.DataSheet)
                        .ThenInclude(ds => ds.Titles)
                        .ThenInclude(t => t.Specs)
                        .ToList<ICatalog>();
                    break;

                case ItemType.ItemJ1:
                    catalogs = context.CatalogJ1s.Include(c => c.DataSheet)
                        .ThenInclude(ds => ds.Titles)
                        .ThenInclude(t => t.Specs)
                        .ToList<ICatalog>();
                    break;

                case ItemType.ItemK1:
                    catalogs = context.CatalogK1s.Include(c => c.DataSheet)
                        .ThenInclude(ds => ds.Titles)
                        .ThenInclude(t => t.Specs)
                        .ToList<ICatalog>();
                    break;

                case ItemType.ItemK2:
                    catalogs = context.CatalogK2s.Include(c => c.DataSheet)
                        .ThenInclude(ds => ds.Titles)
                        .ThenInclude(t => t.Specs)
                        .ToList<ICatalog>();
                    break;

                case ItemType.ItemK3:
                    catalogs = context.CatalogK3s.Include(c => c.DataSheet)
                        .ThenInclude(ds => ds.Titles)
                        .ThenInclude(t => t.Specs)
                        .ToList<ICatalog>();
                    break;

                case ItemType.ItemL1:
                    catalogs = context.CatalogL1s.Include(c => c.DataSheet)
                        .ThenInclude(ds => ds.Titles)
                        .ThenInclude(t => t.Specs)
                        .ToList<ICatalog>();
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(itemType), itemType, null);
            }

            return catalogs;
        }

        public ICatalog GetCatalog(ICatalog catalog)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return GetCatalog(catalog, context);
            }
        }

        public ICatalog GetCatalog(ICatalog catalog, GlobalDbContext context)
        {
            if (catalog is CatalogA1)
                return context.CatalogA1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogA2)
                return context.CatalogA2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogA3)
                return context.CatalogA3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogA4)
                return context.CatalogA4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);

            else if (catalog is CatalogB1)
                return context.CatalogB1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogB2)
                return context.CatalogB2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogB3)
                return context.CatalogB3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogB4)
                return context.CatalogB4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogB5)
                return context.CatalogB5s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);

            else if (catalog is CatalogC1)
                return context.CatalogC1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).Include(x => x.CatalogC1ProductType).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogC2)
                return context.CatalogC2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogC3)
                return context.CatalogC3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).Include(x => x.CatalogC3ProductType).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogC4)
                return context.CatalogC4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogC5)
                return context.CatalogC5s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogC6)
                return context.CatalogC6s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogC7)
                return context.CatalogC7s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);

            else if (catalog is CatalogD1)
                return context.CatalogD1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogD2)
                return context.CatalogD2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);

            else if (catalog is CatalogE1)
                return context.CatalogE1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogE2)
                return context.CatalogE2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogE3)
                return context.CatalogE3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogE4)
                return context.CatalogE4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogE5)
                return context.CatalogE5s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogE6)
                return context.CatalogE6s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogE7)
                return context.CatalogE7s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);

            else if (catalog is CatalogF1)
                return context.CatalogF1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).Include(x => x.CatalogF1ProductType).FirstOrDefault(x => x.Id == catalog.Id);

            else if (catalog is CatalogG1)
                return context.CatalogG1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogG2)
                return context.CatalogG2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogG3)
                return context.CatalogG3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogG4)
                return context.CatalogG4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogG5)
                return context.CatalogG5s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogG6)
                return context.CatalogG6s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);

            else if (catalog is CatalogH1)
                return context.CatalogH1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogH2)
                return context.CatalogH2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogH3)
                return context.CatalogH3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogH4)
                return context.CatalogH4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogH5)
                return context.CatalogH5s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);

            else if (catalog is CatalogI1)
                return context.CatalogI1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogI2)
                return context.CatalogI2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);

            else if (catalog is CatalogJ1)
                return context.CatalogJ1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);

            else if (catalog is CatalogK1)
                return context.CatalogK1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogK2)
                return context.CatalogK2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
            else if (catalog is CatalogK3)
                return context.CatalogK3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);

            else if (catalog is CatalogL1)
                return context.CatalogL1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);

            else
                return null;
        }

        public ICatalog UpdateCatalogDataSheet(ICatalog catalog, IList<DataSheet> dataSheets)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                ICatalog dbCatalog = GetCatalog(catalog, context);

                DataSheet dataSheetSelected = dataSheets.Any(x => x.IsSelected) ? dataSheets.FirstOrDefault(x => x.IsSelected) : null;

                if (dataSheetSelected != null)
                    dataSheetSelected = context.DataSheets.FirstOrDefault(x => x.Id == dataSheetSelected.Id);

                dbCatalog.DataSheet = dataSheetSelected;

                context.Update(dbCatalog);

                context.SaveChanges();

                return dbCatalog;
            }
        }

        public ICatalog UpdateCatalogItem(ICatalog catalog)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                ICatalog dbCatalog = null;

                if (catalog is CatalogA1)
                {
                    CatalogA1 catalogA1 = catalog as CatalogA1;
                    CatalogA1 dbCatalogA1 = catalog.Id != 0 ? context.CatalogA1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogA1;

                    dbCatalogA1.UnitSize = catalogA1.UnitSize;
                    dbCatalogA1.Description = catalogA1.Description;
                    dbCatalogA1.Voltage = catalogA1.Voltage;

                    dbCatalog = dbCatalogA1;
                }
                else if (catalog is CatalogA2)
                {
                    CatalogA2 catalogA2 = catalog as CatalogA2;
                    CatalogA2 dbCatalogA2 = catalog.Id != 0 ? context.CatalogA2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogA2;

                    dbCatalogA2.UnitSize = catalogA2.UnitSize;
                    dbCatalogA2.Description = catalogA2.Description;
                    dbCatalogA2.Voltage = catalogA2.Voltage;

                    dbCatalog = dbCatalogA2;
                }
                else if (catalog is CatalogA3)
                {
                    CatalogA3 catalogA3 = catalog as CatalogA3;
                    CatalogA3 dbCatalogA3 = catalog.Id != 0 ? context.CatalogA3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogA3;

                    dbCatalogA3.UnitSize = catalogA3.UnitSize;
                    dbCatalogA3.Description = catalogA3.Description;
                    dbCatalogA3.Voltage = catalogA3.Voltage;

                    dbCatalog = dbCatalogA3;
                }
                else if (catalog is CatalogA4)
                {
                    CatalogA4 catalogA4 = catalog as CatalogA4;
                    CatalogA4 dbCatalogA4 = catalog.Id != 0 ? context.CatalogA4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogA4;

                    dbCatalogA4.UnitSize = catalogA4.UnitSize;
                    dbCatalogA4.Description = catalogA4.Description;
                    dbCatalogA4.Voltage = catalogA4.Voltage;

                    dbCatalog = dbCatalogA4;
                }
                else if (catalog is CatalogB1)
                {
                    CatalogB1 catalogB1 = catalog as CatalogB1;
                    CatalogB1 dbCatalogB1 = catalog.Id != 0 ? context.CatalogB1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogB1;

                    dbCatalogB1.Hp = catalogB1.Hp;
                    dbCatalogB1.Description = catalogB1.Description;
                    dbCatalogB1.Nema = catalogB1.Nema;
                    dbCatalogB1.Bypass = catalogB1.Bypass;
                    dbCatalogB1.CircuitBreakerDisconnect = catalogB1.CircuitBreakerDisconnect;
                    dbCatalogB1.Voltage = catalogB1.Voltage;

                    dbCatalog = dbCatalogB1;
                }
                else if (catalog is CatalogB2)
                {
                    CatalogB2 catalogB2 = catalog as CatalogB2;
                    CatalogB2 dbCatalogB2 = catalog.Id != 0 ? context.CatalogB2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogB2;

                    dbCatalog = dbCatalogB2;
                }
                else if (catalog is CatalogB3)
                {
                    CatalogB3 catalogB3 = catalog as CatalogB3;
                    CatalogB3 dbCatalogB3 = catalog.Id != 0 ? context.CatalogB3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogB3;

                    dbCatalog = dbCatalogB3;
                }
                else if (catalog is CatalogB4)
                {
                    CatalogB4 catalogB4 = catalog as CatalogB4;
                    CatalogB4 dbCatalogB4 = catalog.Id != 0 ? context.CatalogB4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogB4;

                    dbCatalog = dbCatalogB4;
                }
                else if (catalog is CatalogB5)
                {
                    CatalogB5 catalogB5 = catalog as CatalogB5;
                    CatalogB5 dbCatalogB5 = catalog.Id != 0 ? context.CatalogB5s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogB5;

                    dbCatalogB5.Description = catalogB5.Description;

                    dbCatalog = dbCatalogB5;
                }
                else if (catalog is CatalogC1)
                {
                    CatalogC1 catalogC1 = catalog as CatalogC1;
                    CatalogC1 dbCatalogC1 = catalog.Id != 0 ? context.CatalogC1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogC1;

                    CatalogC1ProductType dbCatalogC1ProductType = catalogC1.CatalogC1ProductType != null ? context.CatalogC1ProductTypes.FirstOrDefault(x => x.Id == catalogC1.CatalogC1ProductType.Id) : null;
                    dbCatalogC1.Description = catalogC1.Description;
                    dbCatalogC1.Size = catalogC1.Size;
                    dbCatalogC1.ShippingWeight = catalogC1.ShippingWeight;
                    dbCatalogC1.EndConnection = catalogC1.EndConnection;

                    dbCatalog = dbCatalogC1;
                }
                else if (catalog is CatalogC2)
                {
                    CatalogC2 catalogC2 = catalog as CatalogC2;
                    CatalogC2 dbCatalogC2 = catalog.Id != 0 ? context.CatalogC2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogC2;

                    dbCatalogC2.SystemFlange = catalogC2.SystemFlange;
                    dbCatalogC2.PumpFlange = catalogC2.PumpFlange;
                    dbCatalogC2.ShippingWeight = catalogC2.ShippingWeight;

                    dbCatalog = dbCatalogC2;
                }
                else if (catalog is CatalogC3)
                {
                    CatalogC3 catalogC3 = catalog as CatalogC3;
                    CatalogC3 dbCatalogC3 = catalog.Id != 0 ? context.CatalogC3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogC3;
                    CatalogC3ProductType dbCatalogC3ProductType = catalogC3.CatalogC3ProductType != null ? context.CatalogC3ProductTypes.FirstOrDefault(x => x.Id == catalogC3.CatalogC3ProductType.Id) : null;

                    dbCatalogC3.PartNumber = catalogC3.PartNumber;
                    dbCatalogC3.AcceptableVolume = catalogC3.AcceptableVolume;
                    dbCatalogC3.DiameterA = catalogC3.DiameterA;
                    dbCatalogC3.HeightB = catalogC3.HeightB;
                    dbCatalogC3.SystemConnect = catalogC3.SystemConnect;
                    dbCatalogC3.Weight = catalogC3.Weight;
                    dbCatalogC3.WorkingPressure = catalogC3.WorkingPressure;
                    dbCatalogC3.CatalogC3ProductType = dbCatalogC3ProductType;

                    dbCatalog = dbCatalogC3;
                }
                else if (catalog is CatalogC4)
                {
                    CatalogC4 catalogC4 = catalog as CatalogC4;
                    CatalogC4 dbCatalogC4 = catalog.Id != 0 ? context.CatalogC4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogC4;

                    dbCatalogC4.PartNumber = catalogC4.PartNumber;
                    dbCatalogC4.AcceptableVolume = catalogC4.AcceptableVolume;
                    dbCatalogC4.DiameterA = catalogC4.DiameterA;
                    dbCatalogC4.HeightB = catalogC4.HeightB;
                    dbCatalogC4.SystemConnect = catalogC4.SystemConnect;
                    dbCatalogC4.Weight = catalogC4.Weight;
                    dbCatalogC4.WorkingPressure = catalogC4.WorkingPressure;

                    dbCatalog = dbCatalogC4;
                }
                else if (catalog is CatalogC5)
                {
                    CatalogC5 catalogC5 = catalog as CatalogC5;
                    CatalogC5 dbCatalogC5 = catalog.Id != 0 ? context.CatalogC5s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogC5;

                    dbCatalogC5.Description = catalogC5.Description;
                    dbCatalogC5.Volume = catalogC5.Volume;
                    dbCatalogC5.HeightA = catalogC5.HeightA;
                    dbCatalogC5.DiameterB = catalogC5.DiameterB;
                    dbCatalogC5.Weight = catalogC5.Weight;

                    dbCatalog = dbCatalogC5;
                }
                else if (catalog is CatalogC6)
                {
                    CatalogC6 catalogC6 = catalog as CatalogC6;
                    CatalogC6 dbCatalogC6 = catalog.Id != 0 ? context.CatalogC6s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogC6;

                    dbCatalogC6.Description = catalogC6.Description;
                    dbCatalogC6.Volume = catalogC6.Volume;
                    dbCatalogC6.HeightA = catalogC6.HeightA;
                    dbCatalogC6.DiameterB = catalogC6.DiameterB;
                    dbCatalogC6.Weight = catalogC6.Weight;

                    dbCatalog = dbCatalogC6;
                }
                else if (catalog is CatalogC7)
                {
                    CatalogC7 catalogC7 = catalog as CatalogC7;
                    CatalogC7 dbCatalogC7 = catalog.Id != 0 ? context.CatalogC7s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogC7;

                    dbCatalogC7.Description = catalogC7.Description;

                    dbCatalog = dbCatalogC7;
                }
                else if (catalog is CatalogD1)
                {
                    CatalogD1 catalogD1 = catalog as CatalogD1;
                    CatalogD1 dbCatalogD1 = catalog.Id != 0 ? context.CatalogD1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogD1;

                    dbCatalog = dbCatalogD1;
                }
                else if (catalog is CatalogD2)
                {
                    CatalogD2 catalogD2 = catalog as CatalogD2;
                    CatalogD2 dbCatalogD2 = catalog.Id != 0 ? context.CatalogD2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogD2;

                    dbCatalog = dbCatalogD2;
                }
                else if (catalog is CatalogE1)
                {
                    CatalogE1 catalogE1 = catalog as CatalogE1;
                    CatalogE1 dbCatalogE1 = catalog.Id != 0 ? context.CatalogE1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogE1;

                    dbCatalog = dbCatalogE1;
                }
                else if (catalog is CatalogE2)
                {
                    CatalogE2 catalogE2 = catalog as CatalogE2;
                    CatalogE2 dbCatalogE2 = catalog.Id != 0 ? context.CatalogE2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogE2;

                    dbCatalog = dbCatalogE2;
                }
                else if (catalog is CatalogE3)
                {
                    CatalogE3 catalogE3 = catalog as CatalogE3;
                    CatalogE3 dbCatalogE3 = catalog.Id != 0 ? context.CatalogE3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogE3;

                    dbCatalog = dbCatalogE3;
                }
                else if (catalog is CatalogE4)
                {
                    CatalogE4 catalogE4 = catalog as CatalogE4;
                    CatalogE4 dbCatalogE4 = catalog.Id != 0 ? context.CatalogE4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogE4;

                    dbCatalog = dbCatalogE4;
                }
                else if (catalog is CatalogE5)
                {
                    CatalogE5 catalogE5 = catalog as CatalogE5;
                    CatalogE5 dbCatalogE5 = catalog.Id != 0 ? context.CatalogE5s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogE5;

                    dbCatalog = dbCatalogE5;
                }
                else if (catalog is CatalogE6)
                {
                    CatalogE6 catalogE6 = catalog as CatalogE6;
                    CatalogE6 dbCatalogE6 = catalog.Id != 0 ? context.CatalogE6s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogE6;

                    dbCatalog = dbCatalogE6;
                }
                else if (catalog is CatalogE7)
                {
                    CatalogE7 catalogE7 = catalog as CatalogE7;
                    CatalogE7 dbCatalogE7 = catalog.Id != 0 ? context.CatalogE7s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogE7;

                    dbCatalog = dbCatalogE7;
                }
                else if (catalog is CatalogF1)
                {
                    CatalogF1 catalogF1 = catalog as CatalogF1;
                    CatalogF1 dbCatalogF1 = catalog.Id != 0 ? context.CatalogF1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogF1;

                    CatalogF1ProductType catalogF1ProductType = catalogF1.CatalogF1ProductType != null ? context.CatalogF1ProductTypes.FirstOrDefault(x => x.Id == catalogF1.CatalogF1ProductType.Id) : null;

                    dbCatalogF1.PartNumber = catalogF1.PartNumber;
                    dbCatalogF1.Description = catalogF1.Description;
                    dbCatalogF1.CatalogF1ProductType = catalogF1ProductType;

                    dbCatalog = dbCatalogF1;
                }
                else if (catalog is CatalogG1)
                {
                    CatalogG1 catalogG1 = catalog as CatalogG1;
                    CatalogG1 dbCatalogG1 = catalog.Id != 0 ? context.CatalogG1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogG1;

                    dbCatalog = dbCatalogG1;
                }
                else if (catalog is CatalogG2)
                {
                    CatalogG2 catalogG2 = catalog as CatalogG2;
                    CatalogG2 dbCatalogG2 = catalog.Id != 0 ? context.CatalogG2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogG2;

                    dbCatalog = dbCatalogG2;
                }
                else if (catalog is CatalogG3)
                {
                    CatalogG3 catalogG3 = catalog as CatalogG3;
                    CatalogG3 dbCatalogG3 = catalog.Id != 0 ? context.CatalogG3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogG3;

                    dbCatalog = dbCatalogG3;
                }
                else if (catalog is CatalogG4)
                {
                    CatalogG4 catalogG4 = catalog as CatalogG4;
                    CatalogG4 dbCatalogG4 = catalog.Id != 0 ? context.CatalogG4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogG4;

                    dbCatalog = dbCatalogG4;
                }
                else if (catalog is CatalogG5)
                {
                    CatalogG5 catalogG5 = catalog as CatalogG5;
                    CatalogG5 dbCatalogG5 = catalog.Id != 0 ? context.CatalogG5s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogG5;

                    dbCatalog = dbCatalogG5;
                }
                else if (catalog is CatalogG6)
                {
                    CatalogG6 catalogG6 = catalog as CatalogG6;
                    CatalogG6 dbCatalogG6 = catalog.Id != 0 ? context.CatalogG6s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogG6;

                    dbCatalog = dbCatalogG6;
                }
                else if (catalog is CatalogH1)
                {
                    CatalogH1 catalogH1 = catalog as CatalogH1;
                    CatalogH1 dbCatalogH1 = catalog.Id != 0 ? context.CatalogH1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogH1;

                    dbCatalog = dbCatalogH1;
                }
                else if (catalog is CatalogH2)
                {
                    CatalogH2 catalogH2 = catalog as CatalogH2;
                    CatalogH2 dbCatalogH2 = catalog.Id != 0 ? context.CatalogH2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogH2;

                    dbCatalog = dbCatalogH2;
                }
                else if (catalog is CatalogH3)
                {
                    CatalogH3 catalogH3 = catalog as CatalogH3;
                    CatalogH3 dbCatalogH3 = catalog.Id != 0 ? context.CatalogH3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogH3;

                    dbCatalog = dbCatalogH3;
                }
                else if (catalog is CatalogH4)
                {
                    CatalogH4 catalogH4 = catalog as CatalogH4;
                    CatalogH4 dbCatalogH4 = catalog.Id != 0 ? context.CatalogH4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogH4;

                    dbCatalog = dbCatalogH4;
                }
                else if (catalog is CatalogH5)
                {
                    CatalogH5 catalogH5 = catalog as CatalogH5;
                    CatalogH5 dbCatalogH5 = catalog.Id != 0 ? context.CatalogH5s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogH5;

                    dbCatalog = dbCatalogH5;
                }
                else if (catalog is CatalogI1)
                {
                    CatalogI1 catalogI1 = catalog as CatalogI1;
                    CatalogI1 dbCatalogI1 = catalog.Id != 0 ? context.CatalogI1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogI1;

                    dbCatalogI1.UnitSize = catalogI1.UnitSize;
                    dbCatalogI1.Description = catalogI1.Description;
                    dbCatalogI1.Economizer = catalogI1.Economizer;
                    dbCatalogI1.Voltage = catalogI1.Voltage;

                    dbCatalog = dbCatalogI1;
                }
                else if (catalog is CatalogI2)
                {
                    CatalogI2 catalogI2 = catalog as CatalogI2;
                    CatalogI2 dbCatalogI2 = catalog.Id != 0 ? context.CatalogI2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogI2;

                    dbCatalogI2.Description = catalogI2.Description;

                    dbCatalog = dbCatalogI2;
                }
                else if (catalog is CatalogJ1)
                {
                    CatalogJ1 catalogJ1 = catalog as CatalogJ1;
                    CatalogJ1 dbCatalogJ1 = catalog.Id != 0 ? context.CatalogJ1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogJ1;

                    dbCatalogJ1.Description = catalogJ1.Description;

                    dbCatalog = dbCatalogJ1;
                }
                else if (catalog is CatalogK1)
                {
                    CatalogK1 catalogK1 = catalog as CatalogK1;
                    CatalogK1 dbCatalogK1 = catalog.Id != 0 ? context.CatalogK1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogK1;

                    dbCatalogK1.Description = catalogK1.Description;

                    dbCatalog = dbCatalogK1;
                }
                else if (catalog is CatalogK2)
                {
                    CatalogK2 catalogK2 = catalog as CatalogK2;
                    CatalogK2 dbCatalogK2 = catalog.Id != 0 ? context.CatalogK2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogK2;

                    dbCatalogK2.Description = catalogK2.Description;

                    dbCatalog = dbCatalogK2;
                }
                else if (catalog is CatalogK3)
                {
                    CatalogK3 catalogK3 = catalog as CatalogK3;
                    CatalogK3 dbCatalogK3 = catalog.Id != 0 ? context.CatalogK3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogK3;

                    dbCatalogK3.Description = catalogK3.Description;

                    dbCatalog = dbCatalogK3;
                }
                else if (catalog is CatalogL1)
                {
                    CatalogL1 catalogL1 = catalog as CatalogL1;
                    CatalogL1 dbCatalogL1 = catalog.Id != 0 ? context.CatalogL1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id) : catalogL1;

                    dbCatalog = dbCatalogL1;
                }

                dbCatalog.Model = catalog.Model;
                dbCatalog.ListPrice = catalog.ListPrice;
                dbCatalog.CostMultiplier = catalog.CostMultiplier;
                dbCatalog.SellMargin = catalog.SellMargin;

                if (catalog.Id != 0)
                    context.Update(dbCatalog);
                else
                    context.Add(dbCatalog);

                context.SaveChanges();

                return dbCatalog;
            }
        }

        public ICatalog CreateCatalog(ItemType itemType)
        {
            Type catalogClassType = EntityHelper.GetCatalogClassTypeForItemType(itemType);

            return (ICatalog)Activator.CreateInstance(catalogClassType);
        }
    }
}
