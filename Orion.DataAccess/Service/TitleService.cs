using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
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
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Domain.EntityItemBACClosedCircuits;
using Orion.Domain.EntityItemBACCoolingTowers;
using Orion.Domain.EntityItemGroundfos;
using Orion.Domain.EntityItemPuroFlux;
using Orion.Domain.EntityItemUvResources;
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

                else if (item is ItemD1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemD1Id == item.Id).ToList();
                else if (item is ItemD2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemD2Id == item.Id).ToList();

                else if (item is ItemE1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemE1Id == item.Id).ToList();
                else if (item is ItemE2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemE2Id == item.Id).ToList();
                else if (item is ItemE3)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemE3Id == item.Id).ToList();
                else if (item is ItemE4)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemE4Id == item.Id).ToList();
                else if (item is ItemE5)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemE5Id == item.Id).ToList();
                else if (item is ItemE6)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemE6Id == item.Id).ToList();
                else if (item is ItemE7)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemE7Id == item.Id).ToList();

                else if (item is ItemF1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemF1Id == item.Id).ToList();

                else if (item is ItemG1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemG1Id == item.Id).ToList();
                else if (item is ItemG2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemG2Id == item.Id).ToList();
                else if (item is ItemG3)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemG3Id == item.Id).ToList();
                else if (item is ItemG4)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemG4Id == item.Id).ToList();
                else if (item is ItemG5)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemG5Id == item.Id).ToList();
                else if (item is ItemG6)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemG6Id == item.Id).ToList();

                else if (item is ItemH1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemH1Id == item.Id).ToList();
                else if (item is ItemH2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemH2Id == item.Id).ToList();
                else if (item is ItemH3)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemH3Id == item.Id).ToList();
                else if (item is ItemH4)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemH4Id == item.Id).ToList();
                else if (item is ItemH5)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemH5Id == item.Id).ToList();

                return titles;
            }
        }

        //public IList<Title> GetTitlesFromCatalog(ICatalog catalog)
        //{
        //    using (GlobalDbContext context = new GlobalDbContext())
        //    {
        //        List<Title> titles = new List<Title>();

        //        if (catalog is CatalogA1)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogA1Id == catalog.Id).ToList();
        //        else if (catalog is  CatalogA2)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogA2Id == catalog.Id).ToList();
        //        else if (catalog is CatalogA3)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogA3Id == catalog.Id).ToList();
        //        else if (catalog is CatalogA4)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogA4Id == catalog.Id).ToList();

        //        else if (catalog is CatalogB1)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogB1Id == catalog.Id).ToList();
        //        else if (catalog is CatalogB2)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogB2Id == catalog.Id).ToList();
        //        else if (catalog is CatalogB3)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogB3Id == catalog.Id).ToList();
        //        else if (catalog is CatalogB4)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogB4Id == catalog.Id).ToList();
        //        else if (catalog is CatalogB5)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogB5Id == catalog.Id).ToList();

        //        else if (catalog is CatalogC1)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogC1Id == catalog.Id).ToList();
        //        else if (catalog is CatalogC2)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogC2Id == catalog.Id).ToList();
        //        else if (catalog is CatalogC3)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogC3Id == catalog.Id).ToList();
        //        else if (catalog is CatalogC4)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogC4Id == catalog.Id).ToList();

        //        else if (catalog is CatalogD1)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogD1Id == catalog.Id).ToList();
        //        else if (catalog is CatalogD2)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogD2Id == catalog.Id).ToList();

        //        else if (catalog is CatalogE1)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogE1Id == catalog.Id).ToList();
        //        else if (catalog is CatalogE2)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogE2Id == catalog.Id).ToList();
        //        else if (catalog is CatalogE3)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogE3Id == catalog.Id).ToList();
        //        else if (catalog is CatalogE4)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogE4Id == catalog.Id).ToList();
        //        else if (catalog is CatalogE5)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogE5Id == catalog.Id).ToList();
        //        else if (catalog is CatalogE6)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogE6Id == catalog.Id).ToList();
        //        else if (catalog is CatalogE7)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogE7Id == catalog.Id).ToList();

        //        else if (catalog is CatalogF1)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogF1Id == catalog.Id).ToList();

        //        else if (catalog is CatalogG1)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogG1Id == catalog.Id).ToList();
        //        else if (catalog is CatalogG2)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogG2Id == catalog.Id).ToList();
        //        else if (catalog is CatalogG3)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogG3Id == catalog.Id).ToList();
        //        else if (catalog is CatalogG4)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogG4Id == catalog.Id).ToList();
        //        else if (catalog is CatalogG5)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogG5Id == catalog.Id).ToList();
        //        else if (catalog is CatalogG6)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogG6Id == catalog.Id).ToList();

        //        else if (catalog is CatalogH1)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogH1Id == catalog.Id).ToList();
        //        else if (catalog is CatalogH2)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogH2Id == catalog.Id).ToList();
        //        else if (catalog is CatalogH3)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogH3Id == catalog.Id).ToList();
        //        else if (catalog is CatalogH4)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogH4Id == catalog.Id).ToList();
        //        else if (catalog is CatalogH5)
        //            titles = context.Titles.Include(x => x.Specs).Where(x => x.CatalogH5Id == catalog.Id).ToList();

        //        return titles;
        //    }
        //}

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

                else if (item is ItemD1)
                    dbItem = context.ItemD1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemD2)
                    dbItem = context.ItemD2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);

                else if (item is ItemE1)
                    dbItem = context.ItemE1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemE2)
                    dbItem = context.ItemE2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemE3)
                    dbItem = context.ItemE3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemE4)
                    dbItem = context.ItemE4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemE5)
                    dbItem = context.ItemE5s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemE6)
                    dbItem = context.ItemE6s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemE7)
                    dbItem = context.ItemE7s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);

                else if (item is ItemF1)
                    dbItem = context.ItemF1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);

                else if (item is ItemG1)
                    dbItem = context.ItemG1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemG2)
                    dbItem = context.ItemG2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemG3)
                    dbItem = context.ItemG3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemG4)
                    dbItem = context.ItemG4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemG5)
                    dbItem = context.ItemG5s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemG6)
                    dbItem = context.ItemG6s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);

                else if (item is ItemH1)
                    dbItem = context.ItemH1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemH2)
                    dbItem = context.ItemH2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemH3)
                    dbItem = context.ItemH3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemH4)
                    dbItem = context.ItemH4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemH5)
                    dbItem = context.ItemH5s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);

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

        //public IList<Title> UpdateTitlesFromCatalog(ICatalog catalog, IList<Title> titles)
        //{
        //    using (GlobalDbContext context = new GlobalDbContext())
        //    {
        //        ICatalog dbCatalog = null;

        //        if (catalog is CatalogA1)
        //            dbCatalog = context.CatalogA1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogA2)
        //            dbCatalog = context.CatalogA2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogA3)
        //            dbCatalog = context.CatalogA3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogA4)
        //            dbCatalog = context.CatalogA4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);

        //        else if (catalog is CatalogB1)
        //            dbCatalog = context.CatalogB1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogB2)
        //            dbCatalog = context.CatalogB2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogB3)
        //            dbCatalog = context.CatalogB3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogB4)
        //            dbCatalog = context.CatalogB4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogB5)
        //            dbCatalog = context.CatalogB5s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);

        //        else if (catalog is CatalogC1)
        //            dbCatalog = context.CatalogC1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogC2)
        //            dbCatalog = context.CatalogC2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogC3)
        //            dbCatalog = context.CatalogC3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogC4)
        //            dbCatalog = context.CatalogC4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);

        //        else if (catalog is CatalogD1)
        //            dbCatalog = context.CatalogD1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogD2)
        //            dbCatalog = context.CatalogD2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);

        //        else if (catalog is CatalogE1)
        //            dbCatalog = context.CatalogE1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogE2)
        //            dbCatalog = context.CatalogE2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogE3)
        //            dbCatalog = context.CatalogE3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogE4)
        //            dbCatalog = context.CatalogE4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogE5)
        //            dbCatalog = context.CatalogE5s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogE6)
        //            dbCatalog = context.CatalogE6s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogE7)
        //            dbCatalog = context.CatalogE7s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);

        //        else if (catalog is CatalogF1)
        //            dbCatalog = context.CatalogF1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);

        //        else if (catalog is CatalogG1)
        //            dbCatalog = context.CatalogG1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogG2)
        //            dbCatalog = context.CatalogG2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogG3)
        //            dbCatalog = context.CatalogG3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogG4)
        //            dbCatalog = context.CatalogG4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogG5)
        //            dbCatalog = context.CatalogG5s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogG6)
        //            dbCatalog = context.CatalogG6s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);

        //        else if (catalog is CatalogH1)
        //            dbCatalog = context.CatalogH1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogH2)
        //            dbCatalog = context.CatalogH2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogH3)
        //            dbCatalog = context.CatalogH3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogH4)
        //            dbCatalog = context.CatalogH4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);
        //        else if (catalog is CatalogH5)
        //            dbCatalog = context.CatalogH5s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == catalog.Id);

        //        foreach (Title title in titles)
        //        {
        //            if (dbCatalog.Titles.Any(x => x.Id == title.Id && !x.Saved))
        //            {
        //                Title dbTitle = dbCatalog.Titles.FirstOrDefault(x => x.Id == title.Id && !x.Saved);
        //                dbTitle.Name = title.Name;

        //                foreach (Spec spec in title.Specs)
        //                {
        //                    if (dbTitle.Specs.Any(x => x.Id == spec.Id && !x.Saved))
        //                    {
        //                        Spec dbSpec = dbTitle.Specs.FirstOrDefault(x => x.Id == spec.Id);
        //                        dbSpec.Name = spec.Name;
        //                        dbSpec.Price = spec.Price;
        //                        dbSpec.Saved = true;
        //                    }
        //                    else
        //                    {
        //                        spec.Saved = true;
        //                        dbTitle.Specs.Add(spec);
        //                    }
        //                }
        //            }
        //            else if (title.Id == 0)
        //            {
        //                title.Saved = true;
        //                dbCatalog.Titles.Add(title);
        //            }
        //        }

        //        foreach (Title title in dbCatalog.Titles.Where(x => !x.Saved))
        //        {
        //            if (!titles.ToList().Exists(sf => sf.Id == title.Id))
        //            {
        //                context.Remove(title);
        //                context.Entry(title).State = EntityState.Deleted;
        //            }
        //            else
        //            {
        //                foreach (Spec spec in title.Specs)
        //                {
        //                    if (!titles.SelectMany(x => x.Specs).ToList().Exists(sf => sf.Id == spec.Id))
        //                    {
        //                        context.Remove(spec);
        //                        context.Entry(spec).State = EntityState.Deleted;
        //                    }
        //                }
        //            }
        //        }

        //        context.Update(dbCatalog);

        //        context.SaveChanges();

        //        return GetTitlesFromCatalog(dbCatalog);
        //    }
        //}
    }
}
