using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalog;
using Orion.Domain.EntityItem;
using System.Collections.Generic;
using System.Linq;

namespace Orion.DataAccess.Service
{
    public class TitleService
    {
        public IList<Title> GetTitlesFromItem(IItem item)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<Title> titles = new List<Title>();

                if (item is ItemAirCooledChiller)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemAirCooledChillerId == item.Id).ToList();
                }
                else if (item is ItemUnit)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemUnitId == item.Id).ToList();
                }
                else if (item is ItemPump)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemPumpId == item.Id).ToList();
                }
                else if (item is ItemVfd)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemVfdId == item.Id).ToList();
                }
                return titles;
            }
        }

        public IList<Title> GetTitlesFromCatalog(ICatalog catalog)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<Title> titles = new List<Title>();

                if (catalog is CatalogAirCooledChiller)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogAirCooledChillerId == catalog.Id).ToList();
                }
                else if (catalog is CatalogUnit)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogUnitId == catalog.Id).ToList();
                }
                else if (catalog is CatalogPump)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogPumpId == catalog.Id).ToList();
                }
                else if (catalog is CatalogVfd)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogVfdId == catalog.Id).ToList();
                }
                return titles;
            }
        }

        public IList<Title> UpdateTitlesFromItem(IItem item, IList<Title> titles)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                IItem dbItem = null;

                if (item is ItemAirCooledChiller)
                {
                    ItemAirCooledChiller itemAirCooledChiller = context.ItemAirCooledChillers.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                    dbItem = itemAirCooledChiller;
                }
                else if (item is ItemUnit)
                {
                    ItemUnit catalogUnit = context.ItemUnits.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                    dbItem = catalogUnit;
                }
                else if (item is ItemPump)
                {
                    ItemPump catalogPump = context.ItemPumps.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                    dbItem = catalogPump;
                }
                else if (item is ItemVfd)
                {
                    ItemVfd catalogVfd = context.ItemVfds.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                    dbItem = catalogVfd;
                }

                foreach (Title title in titles)
                {
                    if (dbItem.Titles.Any(x => x.Id == title.Id && !x.Saved))
                    {
                        Title dbTitle = dbItem.Titles.FirstOrDefault(x => x.Id == title.Id && !x.Saved);
                        dbTitle.Name = title.Name;

                        foreach (Spec spec in title.Specs)
                        {
                            if (dbTitle.Specs.Any(x => x.Id == spec.Id && !x.Saved))
                            {
                                Spec dbSpec = dbTitle.Specs.FirstOrDefault(x => x.Id == spec.Id);
                                dbSpec.Name = spec.Name;
                                dbSpec.Price = spec.Price;
                                dbSpec.Saved = true;
                            }
                            else
                            {
                                spec.Saved = true;
                                dbTitle.Specs.Add(spec);
                            }
                        }
                    }
                    else if (title.Id == 0)
                    {
                        title.Saved = true;
                        dbItem.Titles.Add(title);
                    }
                }

                foreach (Title title in dbItem.Titles.Where(x => !x.Saved))
                {
                    if (!titles.ToList().Exists(sf => sf.Id == title.Id))
                    {
                        context.Remove(title);
                        context.Entry(title).State = EntityState.Deleted;
                    }
                    else
                    {
                        foreach (Spec spec in title.Specs)
                        {
                            if (!titles.SelectMany(x => x.Specs).ToList().Exists(sf => sf.Id == spec.Id))
                            {
                                context.Remove(spec);
                                context.Entry(spec).State = EntityState.Deleted;
                            }
                        }
                    }
                }

                context.Update(dbItem);

                context.SaveChanges();

                return GetTitlesFromItem(dbItem);
            }
        }

        public IList<Title> UpdateTitlesFromCatalog(ICatalog catalog, IList<Title> titles)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                ICatalog dbCatalog = null;

                if (catalog is CatalogAirCooledChiller)
                {
                    CatalogAirCooledChiller catalogAirCooledChiller = context.CatalogAirCooledChillers.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                    dbCatalog = catalogAirCooledChiller;
                }
                else if (catalog is CatalogUnit)
                {
                    CatalogUnit catalogUnit = context.CatalogUnits.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                    dbCatalog = catalogUnit;
                }
                else if (catalog is CatalogPump)
                {
                    CatalogPump catalogPump = context.CatalogPumps.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                    dbCatalog = catalogPump;
                }
                else if (catalog is CatalogVfd)
                {
                    CatalogVfd catalogVfd = context.CatalogVfds.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                    dbCatalog = catalogVfd;
                }

                foreach (Title title in titles)
                {
                    if (dbCatalog.Titles.Any(x => x.Id == title.Id && !x.Saved))
                    {
                        Title dbTitle = dbCatalog.Titles.FirstOrDefault(x => x.Id == title.Id && !x.Saved);
                        dbTitle.Name = title.Name;

                        foreach (Spec spec in title.Specs)
                        {
                            if (dbTitle.Specs.Any(x => x.Id == spec.Id && !x.Saved))
                            {
                                Spec dbSpec = dbTitle.Specs.FirstOrDefault(x => x.Id == spec.Id);
                                dbSpec.Name = spec.Name;
                                dbSpec.Price = spec.Price;
                                dbSpec.Saved = true;
                            }
                            else
                            {
                                spec.Saved = true;
                                dbTitle.Specs.Add(spec);
                            }
                        }
                    }
                    else if (title.Id == 0)
                    {
                        title.Saved = true;
                        dbCatalog.Titles.Add(title);
                    }
                }

                foreach (Title title in dbCatalog.Titles.Where(x => !x.Saved))
                {
                    if (!titles.ToList().Exists(sf => sf.Id == title.Id))
                    {
                        context.Remove(title);
                        context.Entry(title).State = EntityState.Deleted;
                    }
                    else
                    {
                        foreach (Spec spec in title.Specs)
                        {
                            if (!titles.SelectMany(x => x.Specs).ToList().Exists(sf => sf.Id == spec.Id))
                            {
                                context.Remove(spec);
                                context.Entry(spec).State = EntityState.Deleted;
                            }
                        }
                    }
                }

                context.Update(dbCatalog);

                context.SaveChanges();

                return GetTitlesFromCatalog(dbCatalog);
            }
        }
    }
}
