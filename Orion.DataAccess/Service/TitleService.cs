using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogQuantech;
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

                if (item is ItemA1)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemA1Id == item.Id).ToList();
                }
                else if (item is ItemA2)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemA2Id == item.Id).ToList();
                }
                else if (item is ItemA3)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemA3Id == item.Id).ToList();
                }
                else if (item is ItemA4)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemA4Id == item.Id).ToList();
                }
                return titles;
            }
        }

        public IList<Title> GetTitlesFromCatalog(ICatalog catalog)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<Title> titles = new List<Title>();

                if (catalog is CatalogA1)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogA1Id == catalog.Id).ToList();
                }
                else if (catalog is  CatalogA2)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogA2Id == catalog.Id).ToList();
                }
                else if (catalog is CatalogA3)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogA3Id == catalog.Id).ToList();
                }
                else if (catalog is CatalogA4)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogA4Id == catalog.Id).ToList();
                }
                return titles;
            }
        }

        public IList<Title> UpdateTitlesFromItem(IItem item, IList<Title> titles)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                IItem dbItem = null;

                if (item is ItemA1)
                {
                    ItemA1 itemA1 = context.ItemA1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                    dbItem = itemA1;
                }
                else if (item is ItemA2)
                {
                    ItemA2 itemA2 = context.ItemA2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                    dbItem = itemA2;
                }
                else if (item is ItemA3)
                {
                    ItemA3 itemA3 = context.ItemA3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                    dbItem = itemA3;
                }
                else if (item is ItemA4)
                {
                    ItemA4 itemA4 = context.ItemA4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                    dbItem = itemA4;
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

                if (catalog is CatalogA1)
                {
                    CatalogA1 catalogA1 = context.CatalogA1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                    dbCatalog = catalogA1;
                }
                else if (catalog is CatalogA2)
                {
                    CatalogA2 catalogA2 = context.CatalogA2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                    dbCatalog = catalogA2;
                }
                else if (catalog is CatalogA3)
                {
                    CatalogA3 catalogA3 = context.CatalogA3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                    dbCatalog = catalogA3;
                }
                else if (catalog is CatalogA4)
                {
                    CatalogA4 catalogA4 = context.CatalogA4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                    dbCatalog = catalogA4;
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
