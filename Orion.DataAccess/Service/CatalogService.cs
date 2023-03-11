﻿using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityCatalogAmericanWheatley;
using Orion.Domain.EntityCatalogBACClosedCircuits;
using Orion.Domain.EntityCatalogBACCoolingTowers;
using Orion.Domain.EntityCatalogGroundfos;
using Orion.Domain.EntityCatalogPuroflux;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Domain.EntityCatalogUvResources;
using Orion.Domain.UvResources.Related;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using static Orion.Helper.Misc.GV;

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
                case ItemType.A1:
                    catalogs = context.CatalogA1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.A2:
                    catalogs = context.CatalogA2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.A3:
                    catalogs = context.CatalogA3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.A4:
                    catalogs = context.CatalogA4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.B1:
                    catalogs = context.CatalogB1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.B2:
                    catalogs = context.CatalogB2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.B3:
                    catalogs = context.CatalogB3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.B4:
                    catalogs = context.CatalogB4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.B5:
                    catalogs = context.CatalogB5s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.C1:
                    catalogs = context.CatalogC1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.C2:
                    catalogs = context.CatalogC2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.C3:
                    catalogs = context.CatalogC3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.C4:
                    catalogs = context.CatalogC4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.D1:
                    catalogs = context.CatalogD1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.D2:
                    catalogs = context.CatalogD2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.E1:
                    catalogs = context.CatalogE1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.E2:
                    catalogs = context.CatalogE2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.E3:
                    catalogs = context.CatalogE3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.E4:
                    catalogs = context.CatalogE4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.E5:
                    catalogs = context.CatalogE5s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.E6:
                    catalogs = context.CatalogE6s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.E7:
                    catalogs = context.CatalogE7s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.F1:
                    catalogs = context.CatalogF1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).Include(x => x.CatalogF1ProductType).ToList<ICatalog>();
                    break;

                case ItemType.G1:
                    catalogs = context.CatalogG1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.G2:
                    catalogs = context.CatalogG2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.G3:
                    catalogs = context.CatalogG3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.G4:
                    catalogs = context.CatalogG4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.G5:
                    catalogs = context.CatalogG5s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.G6:
                    catalogs = context.CatalogG6s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.H1:
                    catalogs = context.CatalogH1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.H2:
                    catalogs = context.CatalogH2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.H3:
                    catalogs = context.CatalogH3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.H4:
                    catalogs = context.CatalogH4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
                    break;

                case ItemType.H5:
                    catalogs = context.CatalogH5s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).ToList<ICatalog>();
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
                    return context.CatalogC1s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogC2)
                    return context.CatalogC2s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogC3)
                    return context.CatalogC3s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogC4)
                    return context.CatalogC4s.Include(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);

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
                    CatalogA1 dbCatalogA1 = catalog.Id != 0 ? context.CatalogA1s.FirstOrDefault(x => x.Id == catalog.Id) : catalogA1;

                    dbCatalogA1.UnitSize = catalogA1.UnitSize;
                    dbCatalogA1.Description = catalogA1.Description;
                    dbCatalogA1.Voltage = catalogA1.Voltage;

                    dbCatalog = dbCatalogA1;
                }
                else if (catalog is CatalogA2)
                {
                    CatalogA2 catalogA2 = catalog as CatalogA2;
                    CatalogA2 dbCatalogA2 = catalog.Id != 0 ? context.CatalogA2s.FirstOrDefault(x => x.Id == catalog.Id) : catalogA2;

                    dbCatalogA2.UnitSize = catalogA2.UnitSize;
                    dbCatalogA2.Description = catalogA2.Description;
                    dbCatalogA2.Voltage = catalogA2.Voltage;

                    dbCatalog = dbCatalogA2;
                }
                else if (catalog is CatalogA3)
                {
                    CatalogA3 catalogA3 = catalog as CatalogA3;
                    CatalogA3 dbCatalogA3 = catalog.Id != 0 ? context.CatalogA3s.FirstOrDefault(x => x.Id == catalog.Id) : catalogA3;

                    dbCatalogA3.UnitSize = catalogA3.UnitSize;
                    dbCatalogA3.Description = catalogA3.Description;
                    dbCatalogA3.Voltage = catalogA3.Voltage;

                    dbCatalog = dbCatalogA3;
                }
                else if (catalog is CatalogA4)
                {
                    CatalogA4 catalogA4 = catalog as CatalogA4;
                    CatalogA4 dbCatalogA4 = catalog.Id != 0 ? context.CatalogA4s.FirstOrDefault(x => x.Id == catalog.Id) : catalogA4;

                    dbCatalogA4.UnitSize = catalogA4.UnitSize;
                    dbCatalogA4.Description = catalogA4.Description;
                    dbCatalogA4.Voltage = catalogA4.Voltage;

                    dbCatalog = dbCatalogA4;
                }
                else if (catalog is CatalogB1)
                {
                    CatalogB1 catalogB1 = catalog as CatalogB1;
                    CatalogB1 dbCatalogB1 = catalog.Id != 0 ? context.CatalogB1s.FirstOrDefault(x => x.Id == catalog.Id) : catalogB1;

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
                    CatalogB2 dbCatalogB2 = catalog.Id != 0 ? context.CatalogB2s.FirstOrDefault(x => x.Id == catalog.Id) : catalogB2;

                    dbCatalog = dbCatalogB2;
                }
                else if (catalog is CatalogB3)
                {
                    CatalogB3 catalogB3 = catalog as CatalogB3;
                    CatalogB3 dbCatalogB3 = catalog.Id != 0 ? context.CatalogB3s.FirstOrDefault(x => x.Id == catalog.Id) : catalogB3;

                    dbCatalog = dbCatalogB3;
                }
                else if (catalog is CatalogB4)
                {
                    CatalogB4 catalogB4 = catalog as CatalogB4;
                    CatalogB4 dbCatalogB4 = catalog.Id != 0 ? context.CatalogB4s.FirstOrDefault(x => x.Id == catalog.Id) : catalogB4;

                    dbCatalog = dbCatalogB4;
                }
                else if (catalog is CatalogB5)
                {
                    CatalogB5 catalogB5 = catalog as CatalogB5;
                    CatalogB5 dbCatalogB5 = catalog.Id != 0 ? context.CatalogB5s.FirstOrDefault(x => x.Id == catalog.Id) : catalogB5;

                    dbCatalogB5.Description = catalogB5.Description;

                    dbCatalog = dbCatalogB5;
                }
                else if (catalog is CatalogC1)
                {
                    CatalogC1 catalogC1 = catalog as CatalogC1;
                    CatalogC1 dbCatalogC1 = catalog.Id != 0 ? context.CatalogC1s.FirstOrDefault(x => x.Id == catalog.Id) : catalogC1;

                    dbCatalog = dbCatalogC1;
                }
                else if (catalog is CatalogC2)
                {
                    CatalogC2 catalogC2 = catalog as CatalogC2;
                    CatalogC2 dbCatalogC2 = catalog.Id != 0 ? context.CatalogC2s.FirstOrDefault(x => x.Id == catalog.Id) : catalogC2;

                    dbCatalog = dbCatalogC2;
                }
                else if (catalog is CatalogC3)
                {
                    CatalogC3 catalogC3 = catalog as CatalogC3;
                    CatalogC3 dbCatalogC3 = catalog.Id != 0 ? context.CatalogC3s.FirstOrDefault(x => x.Id == catalog.Id) : catalogC3;

                    dbCatalog = dbCatalogC3;
                }
                else if (catalog is CatalogC4)
                {
                    CatalogC4 catalogC4 = catalog as CatalogC4;
                    CatalogC4 dbCatalogC4 = catalog.Id != 0 ? context.CatalogC4s.FirstOrDefault(x => x.Id == catalog.Id) : catalogC4;

                    dbCatalog = dbCatalogC4;
                }
                else if (catalog is CatalogD1)
                {
                    CatalogD1 catalogD1 = catalog as CatalogD1;
                    CatalogD1 dbCatalogD1 = catalog.Id != 0 ? context.CatalogD1s.FirstOrDefault(x => x.Id == catalog.Id) : catalogD1;

                    dbCatalog = dbCatalogD1;
                }
                else if (catalog is CatalogD2)
                {
                    CatalogD2 catalogD2 = catalog as CatalogD2;
                    CatalogD2 dbCatalogD2 = catalog.Id != 0 ? context.CatalogD2s.FirstOrDefault(x => x.Id == catalog.Id) : catalogD2;

                    dbCatalog = dbCatalogD2;
                }
                else if (catalog is CatalogE1)
                {
                    CatalogE1 catalogE1 = catalog as CatalogE1;
                    CatalogE1 dbCatalogE1 = catalog.Id != 0 ? context.CatalogE1s.FirstOrDefault(x => x.Id == catalog.Id) : catalogE1;

                    dbCatalog = dbCatalogE1;
                }
                else if (catalog is CatalogE2)
                {
                    CatalogE2 catalogE2 = catalog as CatalogE2;
                    CatalogE2 dbCatalogE2 = catalog.Id != 0 ? context.CatalogE2s.FirstOrDefault(x => x.Id == catalog.Id) : catalogE2;

                    dbCatalog = dbCatalogE2;
                }
                else if (catalog is CatalogE3)
                {
                    CatalogE3 catalogE3 = catalog as CatalogE3;
                    CatalogE3 dbCatalogE3 = catalog.Id != 0 ? context.CatalogE3s.FirstOrDefault(x => x.Id == catalog.Id) : catalogE3;

                    dbCatalog = dbCatalogE3;
                }
                else if (catalog is CatalogE4)
                {
                    CatalogE4 catalogE4 = catalog as CatalogE4;
                    CatalogE4 dbCatalogE4 = catalog.Id != 0 ? context.CatalogE4s.FirstOrDefault(x => x.Id == catalog.Id) : catalogE4;

                    dbCatalog = dbCatalogE4;
                }
                else if (catalog is CatalogE5)
                {
                    CatalogE5 catalogE5 = catalog as CatalogE5;
                    CatalogE5 dbCatalogE5 = catalog.Id != 0 ? context.CatalogE5s.FirstOrDefault(x => x.Id == catalog.Id) : catalogE5;

                    dbCatalog = dbCatalogE5;
                }
                else if (catalog is CatalogE6)
                {
                    CatalogE6 catalogE6 = catalog as CatalogE6;
                    CatalogE6 dbCatalogE6 = catalog.Id != 0 ? context.CatalogE6s.FirstOrDefault(x => x.Id == catalog.Id) : catalogE6;

                    dbCatalog = dbCatalogE6;
                }
                else if (catalog is CatalogE7)
                {
                    CatalogE7 catalogE7 = catalog as CatalogE7;
                    CatalogE7 dbCatalogE7 = catalog.Id != 0 ? context.CatalogE7s.FirstOrDefault(x => x.Id == catalog.Id) : catalogE7;

                    dbCatalog = dbCatalogE7;
                }
                else if (catalog is CatalogF1)
                {
                    CatalogF1 catalogF1 = catalog as CatalogF1;
                    CatalogF1 dbCatalogF1 = catalog.Id != 0 ? context.CatalogF1s.FirstOrDefault(x => x.Id == catalog.Id) : catalogF1;

                    CatalogF1ProductType catalogF1ProductType = catalogF1.CatalogF1ProductType != null ? context.CatalogF1ProductTypes.FirstOrDefault(x => x.Id == catalogF1.CatalogF1ProductType.Id) : null;

                    dbCatalogF1.PartNumber = catalogF1.PartNumber;
                    dbCatalogF1.Description = catalogF1.Description;
                    dbCatalogF1.CatalogF1ProductType = catalogF1ProductType;

                    dbCatalog = dbCatalogF1;
                }
                else if (catalog is CatalogG1)
                {
                    CatalogG1 catalogG1 = catalog as CatalogG1;
                    CatalogG1 dbCatalogG1 = catalog.Id != 0 ? context.CatalogG1s.FirstOrDefault(x => x.Id == catalog.Id) : catalogG1;

                    dbCatalog = dbCatalogG1;
                }
                else if (catalog is CatalogG2)
                {
                    CatalogG2 catalogG2 = catalog as CatalogG2;
                    CatalogG2 dbCatalogG2 = catalog.Id != 0 ? context.CatalogG2s.FirstOrDefault(x => x.Id == catalog.Id) : catalogG2;

                    dbCatalog = dbCatalogG2;
                }
                else if (catalog is CatalogG3)
                {
                    CatalogG3 catalogG3 = catalog as CatalogG3;
                    CatalogG3 dbCatalogG3 = catalog.Id != 0 ? context.CatalogG3s.FirstOrDefault(x => x.Id == catalog.Id) : catalogG3;

                    dbCatalog = dbCatalogG3;
                }
                else if (catalog is CatalogG4)
                {
                    CatalogG4 catalogG4 = catalog as CatalogG4;
                    CatalogG4 dbCatalogG4 = catalog.Id != 0 ? context.CatalogG4s.FirstOrDefault(x => x.Id == catalog.Id) : catalogG4;

                    dbCatalog = dbCatalogG4;
                }
                else if (catalog is CatalogG5)
                {
                    CatalogG5 catalogG5 = catalog as CatalogG5;
                    CatalogG5 dbCatalogG5 = catalog.Id != 0 ? context.CatalogG5s.FirstOrDefault(x => x.Id == catalog.Id) : catalogG5;

                    dbCatalog = dbCatalogG5;
                }
                else if (catalog is CatalogG6)
                {
                    CatalogG6 catalogG6 = catalog as CatalogG6;
                    CatalogG6 dbCatalogG6 = catalog.Id != 0 ? context.CatalogG6s.FirstOrDefault(x => x.Id == catalog.Id) : catalogG6;

                    dbCatalog = dbCatalogG6;
                }
                else if (catalog is CatalogH1)
                {
                    CatalogH1 catalogH1 = catalog as CatalogH1;
                    CatalogH1 dbCatalogH1 = catalog.Id != 0 ? context.CatalogH1s.FirstOrDefault(x => x.Id == catalog.Id) : catalogH1;

                    dbCatalog = dbCatalogH1;
                }
                else if (catalog is CatalogH2)
                {
                    CatalogH2 catalogH2 = catalog as CatalogH2;
                    CatalogH2 dbCatalogH2 = catalog.Id != 0 ? context.CatalogH2s.FirstOrDefault(x => x.Id == catalog.Id) : catalogH2;

                    dbCatalog = dbCatalogH2;
                }
                else if (catalog is CatalogH3)
                {
                    CatalogH3 catalogH3 = catalog as CatalogH3;
                    CatalogH3 dbCatalogH3 = catalog.Id != 0 ? context.CatalogH3s.FirstOrDefault(x => x.Id == catalog.Id) : catalogH3;

                    dbCatalog = dbCatalogH3;
                }
                else if (catalog is CatalogH4)
                {
                    CatalogH4 catalogH4 = catalog as CatalogH4;
                    CatalogH4 dbCatalogH4 = catalog.Id != 0 ? context.CatalogH4s.FirstOrDefault(x => x.Id == catalog.Id) : catalogH4;

                    dbCatalog = dbCatalogH4;
                }
                else if (catalog is CatalogH5)
                {
                    CatalogH5 catalogH5 = catalog as CatalogH5;
                    CatalogH5 dbCatalogH5 = catalog.Id != 0 ? context.CatalogH5s.FirstOrDefault(x => x.Id == catalog.Id) : catalogH5;

                    dbCatalog = dbCatalogH5;
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

    }
}
