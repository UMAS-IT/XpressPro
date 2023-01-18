using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
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
                else if (item is ItemB1)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemB1Id == item.Id).ToList();
                }
                else if (item is ItemB2)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemB2Id == item.Id).ToList();
                }
                else if (item is ItemB3)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemB3Id == item.Id).ToList();
                }
                else if (item is ItemB4)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemB4Id == item.Id).ToList();
                }
                else if (item is ItemB5)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemB5Id == item.Id).ToList();
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
                else if (catalog is CatalogB1)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogB1Id == catalog.Id).ToList();
                }
                else if (catalog is CatalogB2)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogB2Id == catalog.Id).ToList();
                }
                else if (catalog is CatalogB3)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogB3Id == catalog.Id).ToList();
                }
                else if (catalog is CatalogB4)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogB4Id == catalog.Id).ToList();
                }
                else if (catalog is CatalogB5)
                {
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogB5Id == catalog.Id).ToList();
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
                else if (item is ItemB1)
                {
                    ItemB1 itemB1 = context.ItemB1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                    dbItem = itemB1;
                }
                else if (item is ItemB2)
                {
                    ItemB2 itemB2 = context.ItemB2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                    dbItem = itemB2;
                }
                else if (item is ItemB3)
                {
                    ItemB3 itemB3 = context.ItemB3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                    dbItem = itemB3;
                }
                else if (item is ItemB4)
                {
                    ItemB4 itemB4 = context.ItemB4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                    dbItem = itemB4;
                }
                else if (item is ItemB5)
                {
                    ItemB5 itemB5 = context.ItemB5s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                    dbItem = itemB5;
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
                else if (catalog is CatalogB1)
                {
                    CatalogB1 catalogB1 = context.CatalogB1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                    dbCatalog = catalogB1;
                }
                else if (catalog is CatalogB2)
                {
                    CatalogB2 catalogB2 = context.CatalogB2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                    dbCatalog = catalogB2;
                }
                else if (catalog is CatalogB3)
                {
                    CatalogB3 catalogB3 = context.CatalogB3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                    dbCatalog = catalogB3;
                }
                else if (catalog is CatalogB4)
                {
                    CatalogB4 catalogB4 = context.CatalogB4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                    dbCatalog = catalogB4;
                }
                else if (catalog is CatalogB5)
                {
                    CatalogB5 catalogB5 = context.CatalogB5s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                    dbCatalog = catalogB5;
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
