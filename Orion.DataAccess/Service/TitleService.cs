using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityCatalogAmericanWheatley;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;
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
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemA1Id == item.Id).ToList();
                else if (item is ItemA2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemA2Id == item.Id).ToList();
                else if (item is ItemA3)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemA3Id == item.Id).ToList();
                else if (item is ItemA4)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemA4Id == item.Id).ToList();
                else if (item is ItemB1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemB1Id == item.Id).ToList();
                else if (item is ItemB2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemB2Id == item.Id).ToList();
                else if (item is ItemB3)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemB3Id == item.Id).ToList();
                else if (item is ItemB4)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemB4Id == item.Id).ToList();
                else if (item is ItemB5)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemB5Id == item.Id).ToList();
                else if (item is ItemC1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemC1Id == item.Id).ToList();
                else if (item is ItemC2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemC2Id == item.Id).ToList();
                else if (item is ItemC3)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemC3Id == item.Id).ToList();
                else if (item is ItemC4)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemC4Id == item.Id).ToList();
                return titles;
            }
        }

        public IList<Title> GetTitlesFromCatalog(ICatalog catalog)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<Title> titles = new List<Title>();

                if (catalog is CatalogA1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogA1Id == catalog.Id).ToList();
                else if (catalog is  CatalogA2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogA2Id == catalog.Id).ToList();
                else if (catalog is CatalogA3)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogA3Id == catalog.Id).ToList();
                else if (catalog is CatalogA4)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogA4Id == catalog.Id).ToList();
                else if (catalog is CatalogB1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogB1Id == catalog.Id).ToList();
                else if (catalog is CatalogB2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogB2Id == catalog.Id).ToList();
                else if (catalog is CatalogB3)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogB3Id == catalog.Id).ToList();
                else if (catalog is CatalogB4)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogB4Id == catalog.Id).ToList();
                else if (catalog is CatalogB5)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogB5Id == catalog.Id).ToList();
                else if (catalog is CatalogC1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogC1Id == catalog.Id).ToList();
                else if (catalog is CatalogC2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogC2Id == catalog.Id).ToList();
                else if (catalog is CatalogC3)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogC3Id == catalog.Id).ToList();
                else if (catalog is CatalogC4)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogC4Id == catalog.Id).ToList();
                return titles;
            }
        }

        public IList<Title> UpdateTitlesFromItem(IItem item, IList<Title> titles)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                IItem dbItem = null;

                if (item is ItemA1)
                    dbItem = context.ItemA1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemA2)
                    dbItem = context.ItemA2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemA3)
                    dbItem = context.ItemA3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemA4)
                    dbItem = context.ItemA4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemB1)
                    dbItem = context.ItemB1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemB2)
                    dbItem = context.ItemB2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemB3)
                    dbItem = context.ItemB3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemB4)
                    dbItem = context.ItemB4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemB5)
                    dbItem = context.ItemB5s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemC1)
                    dbItem = context.ItemC1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemC2)
                    dbItem = context.ItemC2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemC3)
                    dbItem = context.ItemC3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemC4)
                    dbItem = context.ItemC4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);

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
                    dbCatalog = context.CatalogA1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogA2)
                    dbCatalog = context.CatalogA2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogA3)
                    dbCatalog = context.CatalogA3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogA4)
                    dbCatalog = context.CatalogA4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogB1)
                    dbCatalog = context.CatalogB1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogB2)
                    dbCatalog = context.CatalogB2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogB3)
                    dbCatalog = context.CatalogB3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogB4)
                    dbCatalog = context.CatalogB4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogB5)
                    dbCatalog = context.CatalogB5s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogC1)
                    dbCatalog = context.CatalogC1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogC2)
                    dbCatalog = context.CatalogC2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogC3)
                    dbCatalog = context.CatalogC3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogC4)
                    dbCatalog = context.CatalogC4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);

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
