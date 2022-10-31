using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalog;
using Orion.Domain.EntityItemCatalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Orion.DataAccess.Service
{
    public class TitleService
    {
        public IList<Title> GetTitles(IItemICatalog item)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<Title> titles = new List<Title>();

                if (item is ItemAirCooledChillerCatalogAirCooledChiller)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogAirCooledChillerId == item.CatalogId).ToList();
                }
                else if (item is ItemUnitCatalogUnit)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogUnitId == item.CatalogId).ToList();
                }
                else if (item is ItemPumpCatalogPump)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogPumpId == item.CatalogId).ToList();
                }
                else if (item is ItemVfdCatalogVfd)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogVfdId == item.CatalogId).ToList();
                }
                return titles;
            }
        }

        public IList<Title> GetTitles(ICatalog catalog)
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

        public IList<Title> UpdateTitles(IItemICatalog itemICatalog, IList<Title> titles)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                ICatalog dbCatalog = null;

                if (itemICatalog is ItemAirCooledChillerCatalogAirCooledChiller)
                {
                    CatalogAirCooledChiller catalogAirCooledChiller = context.CatalogAirCooledChillers.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == itemICatalog.CatalogId);
                    dbCatalog = catalogAirCooledChiller;
                }
                else if (itemICatalog is ItemUnitCatalogUnit)
                {
                    CatalogUnit catalogUnit = context.CatalogUnits.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == itemICatalog.CatalogId);
                    dbCatalog = catalogUnit;
                }
                else if (itemICatalog is ItemPumpCatalogPump)
                {
                    CatalogPump catalogPump = context.CatalogPumps.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == itemICatalog.CatalogId);
                    dbCatalog = catalogPump;
                }
                else if (itemICatalog is ItemVfdCatalogVfd)
                {
                    CatalogVfd catalogVfd = context.CatalogVfds.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == itemICatalog.CatalogId);
                    dbCatalog = catalogVfd;
                }

                foreach (Title title in titles)
                {
                    if (itemICatalog is ItemAirCooledChillerCatalogAirCooledChiller)
                    {
                        //Title exist in DB only needs update
                        if (dbCatalog.Titles.Any(x => x.Id == title.Id && !x.Saved))
                        {
                            Title dbTitle = dbCatalog.Titles.FirstOrDefault(x => x.Id == title.Id && !x.Saved);
                            dbTitle.Name = title.Name;

                            foreach (Spec spec in title.Specs)          
                            {
                                if (dbTitle.Specs.Any(x => x.Id == spec.Id))
                                {
                                    Spec dbSpec = dbTitle.Specs.FirstOrDefault(x => x.Id == spec.Id);
                                    dbSpec.Name = spec.Name;
                                }
                                else if (spec.Id == 0)
                                {
                                    dbTitle.Specs.Add(spec);
                                }
                                else
                                {
                                    Spec specToDelete = dbTitle.Specs.FirstOrDefault(x => x.Id == spec.Id);
                                    context.Remove(specToDelete);
                                    context.Entry(specToDelete).State = EntityState.Deleted;
                                }
                            }
                        }
                        else if (title.Id == 0)
                        {
                            title.Saved = true;
                            dbCatalog.Titles.Add(title);
                        }
                    }
                }

                if (dbCatalog is ItemAirCooledChillerCatalogAirCooledChiller)
                {
                    foreach (Title title in dbCatalog.Titles)
                    {
                        if (!titles.ToList().Exists(sf => sf.CatalogAirCooledChillerId == dbCatalog.Id))
                        {
                            context.Remove(title);
                        }
                    }
                }



                //foreach (Title title in dbCatalog.Titles)
                //{
                //    context.Remove(title);
                //    context.Entry(title).State = EntityState.Deleted;
                //}

                //dbCatalog.Titles = new List<Title>();

                //foreach (Title title in titles)
                //{
                //    Title newTitle = new Title();
                //    newTitle.Name = title.Name;

                //    foreach (Spec spec in title.Specs)
                //    {
                //        Spec newSpec = new Spec();
                //        newSpec.Name = spec.Name;
                //        newTitle.Specs.Add(newSpec);
                //    }
                //    dbCatalog.Titles.Add(newTitle);
                //}

                context.Update(dbCatalog);

                context.SaveChanges();

                return GetTitles(dbCatalog);
            }
        }
    }
}
