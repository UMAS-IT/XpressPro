using Microsoft.EntityFrameworkCore;
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
using System;
using System.Collections.Generic;
using System.Linq;

namespace Orion.DataAccess.Service
{
    public class ItemService
    {
        public IList<IItem> GetAllItemByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                IList<ItemA1> itemA1s = context.ItemA1s.Include(x => x.CatalogA1).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemA2> itemA2s = context.ItemA2s.Include(x => x.CatalogA2).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemA3> itemA3s = context.ItemA3s.Include(x => x.CatalogA3).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemA4> itemA4s = context.ItemA4s.Include(x => x.CatalogA4).Where(x => x.QuoteId == quoteId).ToList();

                IList<ItemB1> itemB1s = context.ItemB1s.Include(x => x.CatalogB1).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemB2> itemB2s = context.ItemB2s.Include(x => x.CatalogB2).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemB3> itemB3s = context.ItemB3s.Include(x => x.CatalogB3).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemB4> itemB4s = context.ItemB4s.Include(x => x.CatalogB4).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemB5> itemB5s = context.ItemB5s.Include(x => x.CatalogB5).Where(x => x.QuoteId == quoteId).ToList();

                IList<ItemC1> itemC1s = context.ItemC1s.Include(x => x.CatalogC1).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemC2> itemC2s = context.ItemC2s.Include(x => x.CatalogC2).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemC3> itemC3s = context.ItemC3s.Include(x => x.CatalogC3).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemC4> itemC4s = context.ItemC4s.Include(x => x.CatalogC4).Where(x => x.QuoteId == quoteId).ToList();

                IList<ItemD1> itemD1s = context.ItemD1s.Include(x => x.CatalogD1).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemD2> itemD2s = context.ItemD2s.Include(x => x.CatalogD2).Where(x => x.QuoteId == quoteId).ToList();

                IList<ItemE1> itemE1s = context.ItemE1s.Include(x => x.CatalogE1).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemE2> itemE2s = context.ItemE2s.Include(x => x.CatalogE2).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemE3> itemE3s = context.ItemE3s.Include(x => x.CatalogE3).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemE4> itemE4s = context.ItemE4s.Include(x => x.CatalogE4).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemE5> itemE5s = context.ItemE5s.Include(x => x.CatalogE5).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemE6> itemE6s = context.ItemE6s.Include(x => x.CatalogE6).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemE7> itemE7s = context.ItemE7s.Include(x => x.CatalogE7).Where(x => x.QuoteId == quoteId).ToList();

                IList<ItemF1> itemF1s = context.ItemF1s.Include(x => x.CatalogF1).Where(x => x.QuoteId == quoteId).ToList();

                IList<ItemG1> itemG1s = context.ItemG1s.Include(x => x.CatalogG1).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemG2> itemG2s = context.ItemG2s.Include(x => x.CatalogG2).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemG3> itemG3s = context.ItemG3s.Include(x => x.CatalogG3).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemG4> itemG4s = context.ItemG4s.Include(x => x.CatalogG4).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemG5> itemG5s = context.ItemG5s.Include(x => x.CatalogG5).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemG6> itemG6s = context.ItemG6s.Include(x => x.CatalogG6).Where(x => x.QuoteId == quoteId).ToList();

                IList<ItemH1> itemH1s = context.ItemH1s.Include(x => x.CatalogH1).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemH2> itemH2s = context.ItemH2s.Include(x => x.CatalogH2).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemH3> itemH3s = context.ItemH3s.Include(x => x.CatalogH3).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemH4> itemH4s = context.ItemH4s.Include(x => x.CatalogH4).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemH5> itemH5s = context.ItemH5s.Include(x => x.CatalogH5).Where(x => x.QuoteId == quoteId).ToList();

                items.AddRange(itemA1s);
                items.AddRange(itemA2s);
                items.AddRange(itemA3s);
                items.AddRange(itemA4s);

                items.AddRange(itemB1s);
                items.AddRange(itemB2s);
                items.AddRange(itemB3s);
                items.AddRange(itemB4s);
                items.AddRange(itemB5s);

                items.AddRange(itemC1s);
                items.AddRange(itemC2s);
                items.AddRange(itemC3s);
                items.AddRange(itemC4s);

                items.AddRange(itemD1s);
                items.AddRange(itemD2s);

                items.AddRange(itemE1s);
                items.AddRange(itemE2s);
                items.AddRange(itemE3s);
                items.AddRange(itemE4s);
                items.AddRange(itemE5s);
                items.AddRange(itemE6s);
                items.AddRange(itemE7s);

                items.AddRange(itemF1s);

                items.AddRange(itemG1s);
                items.AddRange(itemG2s);
                items.AddRange(itemG3s);
                items.AddRange(itemG4s);
                items.AddRange(itemG5s);
                items.AddRange(itemG6s);

                items.AddRange(itemH1s);
                items.AddRange(itemH2s);
                items.AddRange(itemH3s);
                items.AddRange(itemH4s);
                items.AddRange(itemH5s);

                items = items.OrderBy(x => x.DesignIndex).ToList();

                return items;
            }
        }

        public IList<IItem> UpdateQuoteAllItems(Quote quote, IList<IItem> items)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemA1s).ThenInclude(x => x.CatalogA1)
                    .Include(x => x.ItemA1s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemA2s).ThenInclude(x => x.CatalogA2)
                    .Include(x => x.ItemA2s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemA3s).ThenInclude(x => x.CatalogA3)
                    .Include(x => x.ItemA3s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemA4s).ThenInclude(x => x.CatalogA4)
                    .Include(x => x.ItemA4s).ThenInclude(x => x.Titles)

                    .Include(x => x.ItemB1s).ThenInclude(x => x.CatalogB1)
                    .Include(x => x.ItemB1s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemB2s).ThenInclude(x => x.CatalogB2)
                    .Include(x => x.ItemB2s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemB3s).ThenInclude(x => x.CatalogB3)
                    .Include(x => x.ItemB3s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemB4s).ThenInclude(x => x.CatalogB4)
                    .Include(x => x.ItemB4s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemB5s).ThenInclude(x => x.CatalogB5)
                    .Include(x => x.ItemB5s).ThenInclude(x => x.Titles)

                    .Include(x => x.ItemC1s).ThenInclude(x => x.CatalogC1)
                    .Include(x => x.ItemC1s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemC2s).ThenInclude(x => x.CatalogC2)
                    .Include(x => x.ItemC2s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemC3s).ThenInclude(x => x.CatalogC3)
                    .Include(x => x.ItemC3s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemC4s).ThenInclude(x => x.CatalogC4)
                    .Include(x => x.ItemC4s).ThenInclude(x => x.Titles)

                    .Include(x => x.ItemD1s).ThenInclude(x => x.CatalogD1)
                    .Include(x => x.ItemD1s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemD2s).ThenInclude(x => x.CatalogD2)
                    .Include(x => x.ItemD2s).ThenInclude(x => x.Titles)

                    .Include(x => x.ItemE1s).ThenInclude(x => x.CatalogE1)
                    .Include(x => x.ItemE1s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemE2s).ThenInclude(x => x.CatalogE2)
                    .Include(x => x.ItemE2s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemE3s).ThenInclude(x => x.CatalogE3)
                    .Include(x => x.ItemE3s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemE4s).ThenInclude(x => x.CatalogE4)
                    .Include(x => x.ItemE4s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemE5s).ThenInclude(x => x.CatalogE5)
                    .Include(x => x.ItemE5s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemE6s).ThenInclude(x => x.CatalogE6)
                    .Include(x => x.ItemE6s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemE7s).ThenInclude(x => x.CatalogE7)
                    .Include(x => x.ItemE7s).ThenInclude(x => x.Titles)

                    .Include(x => x.ItemF1s).ThenInclude(x => x.CatalogF1)
                    .Include(x => x.ItemF1s).ThenInclude(x => x.Titles)

                    .Include(x => x.ItemG1s).ThenInclude(x => x.CatalogG1)
                    .Include(x => x.ItemG1s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemG2s).ThenInclude(x => x.CatalogG2)
                    .Include(x => x.ItemG2s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemG3s).ThenInclude(x => x.CatalogG3)
                    .Include(x => x.ItemG3s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemG4s).ThenInclude(x => x.CatalogG4)
                    .Include(x => x.ItemG4s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemG5s).ThenInclude(x => x.CatalogG5)
                    .Include(x => x.ItemG5s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemG6s).ThenInclude(x => x.CatalogG6)
                    .Include(x => x.ItemG6s).ThenInclude(x => x.Titles)

                    .Include(x => x.ItemH1s).ThenInclude(x => x.CatalogH1)
                    .Include(x => x.ItemH1s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemH2s).ThenInclude(x => x.CatalogH2)
                    .Include(x => x.ItemH2s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemH3s).ThenInclude(x => x.CatalogH3)
                    .Include(x => x.ItemH3s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemH4s).ThenInclude(x => x.CatalogH4)
                    .Include(x => x.ItemH4s).ThenInclude(x => x.Titles)
                    .Include(x => x.ItemH5s).ThenInclude(x => x.CatalogH5)
                    .Include(x => x.ItemH5s).ThenInclude(x => x.Titles)

                    .FirstOrDefault(x => x.Id == quote.Id);

                List<CatalogA1> catalogA1s = context.CatalogA1s.ToList();
                List<CatalogA2> catalogA2s = context.CatalogA2s.ToList();
                List<CatalogA3> catalogA3s = context.CatalogA3s.ToList();
                List<CatalogA4> catalogA4s = context.CatalogA4s.ToList();

                List<CatalogB1> catalogB1s = context.CatalogB1s.ToList();
                List<CatalogB2> catalogB2s = context.CatalogB2s.ToList();
                List<CatalogB3> catalogB3s = context.CatalogB3s.ToList();
                List<CatalogB4> catalogB4s = context.CatalogB4s.ToList();
                List<CatalogB5> catalogB5s = context.CatalogB5s.ToList();

                List<CatalogC1> catalogC1s = context.CatalogC1s.ToList();
                List<CatalogC2> catalogC2s = context.CatalogC2s.ToList();
                List<CatalogC3> catalogC3s = context.CatalogC3s.ToList();
                List<CatalogC4> catalogC4s = context.CatalogC4s.ToList();

                List<CatalogD1> catalogD1s = context.CatalogD1s.ToList();
                List<CatalogD2> catalogD2s = context.CatalogD2s.ToList();

                List<CatalogE1> catalogE1s = context.CatalogE1s.ToList();
                List<CatalogE2> catalogE2s = context.CatalogE2s.ToList();
                List<CatalogE3> catalogE3s = context.CatalogE3s.ToList();
                List<CatalogE4> catalogE4s = context.CatalogE4s.ToList();
                List<CatalogE5> catalogE5s = context.CatalogE5s.ToList();
                List<CatalogE6> catalogE6s = context.CatalogE6s.ToList();
                List<CatalogE7> catalogE7s = context.CatalogE7s.ToList();

                List<CatalogF1> catalogF1s = context.CatalogF1s.ToList();

                List<CatalogG1> catalogG1s = context.CatalogG1s.ToList();
                List<CatalogG2> catalogG2s = context.CatalogG2s.ToList();
                List<CatalogG3> catalogG3s = context.CatalogG3s.ToList();
                List<CatalogG4> catalogG4s = context.CatalogG4s.ToList();
                List<CatalogG5> catalogG5s = context.CatalogG5s.ToList();
                List<CatalogG6> catalogG6s = context.CatalogG6s.ToList();

                List<CatalogH1> catalogH1s = context.CatalogH1s.ToList();
                List<CatalogH2> catalogH2s = context.CatalogH2s.ToList();
                List<CatalogH3> catalogH3s = context.CatalogH3s.ToList();
                List<CatalogH4> catalogH4s = context.CatalogH4s.ToList();
                List<CatalogH5> catalogH5s = context.CatalogH5s.ToList();

                List<ICatalog> catalogs = new List<ICatalog>();

                catalogs.AddRange(catalogA1s);
                catalogs.AddRange(catalogA2s);
                catalogs.AddRange(catalogA3s);
                catalogs.AddRange(catalogA4s);

                catalogs.AddRange(catalogB1s);
                catalogs.AddRange(catalogB2s);
                catalogs.AddRange(catalogB3s);
                catalogs.AddRange(catalogB4s);
                catalogs.AddRange(catalogB5s);
                
                catalogs.AddRange(catalogC1s);
                catalogs.AddRange(catalogC2s);
                catalogs.AddRange(catalogC3s);
                catalogs.AddRange(catalogC4s);

                catalogs.AddRange(catalogD1s);
                catalogs.AddRange(catalogD2s);

                catalogs.AddRange(catalogE1s);
                catalogs.AddRange(catalogE2s);
                catalogs.AddRange(catalogE3s);
                catalogs.AddRange(catalogE4s);
                catalogs.AddRange(catalogE5s);
                catalogs.AddRange(catalogE6s);
                catalogs.AddRange(catalogE7s);

                catalogs.AddRange(catalogF1s);

                catalogs.AddRange(catalogG1s);
                catalogs.AddRange(catalogG2s);
                catalogs.AddRange(catalogG3s);
                catalogs.AddRange(catalogG4s);
                catalogs.AddRange(catalogG5s);
                catalogs.AddRange(catalogG6s);

                catalogs.AddRange(catalogH1s);
                catalogs.AddRange(catalogH2s);
                catalogs.AddRange(catalogH3s);
                catalogs.AddRange(catalogH4s);
                catalogs.AddRange(catalogH5s);


                foreach (IItem item in items)
                {
                    IItem dbItem = null;

                    if (item.QuoteId == dbQuote.Id)
                    {
                        if (item is ItemA1)
                            dbItem = dbQuote.ItemA1s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemA2)
                            dbItem = dbQuote.ItemA2s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemA3)
                            dbItem = dbQuote.ItemA3s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemA4)
                            dbItem = dbQuote.ItemA4s.FirstOrDefault(x => x.Id == item.Id);

                        if (item is ItemB1)
                            dbItem = dbQuote.ItemB1s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemB2)
                            dbItem = dbQuote.ItemB2s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemB3)
                            dbItem = dbQuote.ItemB3s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemB4)
                            dbItem = dbQuote.ItemB4s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemB5)
                            dbItem = dbQuote.ItemB5s.FirstOrDefault(x => x.Id == item.Id);

                        if (item is ItemC1)
                            dbItem = dbQuote.ItemC1s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemC2)
                            dbItem = dbQuote.ItemC2s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemC3)
                            dbItem = dbQuote.ItemC3s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemC4)
                            dbItem = dbQuote.ItemC4s.FirstOrDefault(x => x.Id == item.Id);

                        if (item is ItemD1)
                            dbItem = dbQuote.ItemD1s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemD2)
                            dbItem = dbQuote.ItemD2s.FirstOrDefault(x => x.Id == item.Id);

                        if (item is ItemE1)
                            dbItem = dbQuote.ItemE1s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemE2)
                            dbItem = dbQuote.ItemE2s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemE3)
                            dbItem = dbQuote.ItemE3s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemE4)
                            dbItem = dbQuote.ItemE4s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemE5)
                            dbItem = dbQuote.ItemE5s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemE6)
                            dbItem = dbQuote.ItemE6s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemE7)
                            dbItem = dbQuote.ItemE7s.FirstOrDefault(x => x.Id == item.Id);

                        if (item is ItemF1)
                            dbItem = dbQuote.ItemF1s.FirstOrDefault(x => x.Id == item.Id);

                        if (item is ItemG1)
                            dbItem = dbQuote.ItemG1s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemG2)
                            dbItem = dbQuote.ItemG2s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemG3)
                            dbItem = dbQuote.ItemG3s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemG4)
                            dbItem = dbQuote.ItemG4s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemG5)
                            dbItem = dbQuote.ItemG5s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemG6)
                            dbItem = dbQuote.ItemG6s.FirstOrDefault(x => x.Id == item.Id);

                        if (item is ItemH1)
                            dbItem = dbQuote.ItemH1s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemH2)
                            dbItem = dbQuote.ItemH2s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemH3)
                            dbItem = dbQuote.ItemH3s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemH4)
                            dbItem = dbQuote.ItemH4s.FirstOrDefault(x => x.Id == item.Id);
                        if (item is ItemH5)
                            dbItem = dbQuote.ItemH5s.FirstOrDefault(x => x.Id == item.Id);

                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemA1)
                        {
                            ItemA1 newItemA1 = item as ItemA1;
                            newItemA1.CatalogA1 = catalogs.OfType<CatalogA1>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemA1s.Add(newItemA1);
                        }
                        if (item is ItemA2)
                        {
                            ItemA2 newItemA2 = item as ItemA2;
                            newItemA2.CatalogA2 = catalogs.OfType<CatalogA2>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemA2s.Add(newItemA2);
                        }
                        if (item is ItemA3)
                        {
                            ItemA3 newItemA3 = item as ItemA3;
                            newItemA3.CatalogA3 = catalogs.OfType<CatalogA3>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemA3s.Add(newItemA3);
                        }
                        if (item is ItemA4)
                        {
                            ItemA4 newItemA4 = item as ItemA4;
                            newItemA4.CatalogA4 = catalogs.OfType<CatalogA4>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemA4s.Add(newItemA4);
                        }

                        if (item is ItemB1)
                        {
                            ItemB1 newItemB1 = item as ItemB1;
                            newItemB1.CatalogB1 = catalogs.OfType<CatalogB1>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemB1s.Add(newItemB1);
                        }
                        if (item is ItemB2)
                        {
                            ItemB2 newItemB2 = item as ItemB2;
                            newItemB2.CatalogB2 = catalogs.OfType<CatalogB2>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemB2s.Add(newItemB2);
                        }
                        if (item is ItemB3)
                        {
                            ItemB3 newItemB3 = item as ItemB3;
                            newItemB3.CatalogB3 = catalogs.OfType<CatalogB3>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemB3s.Add(newItemB3);
                        }
                        if (item is ItemB4)
                        {
                            ItemB4 newItemB4 = item as ItemB4;
                            newItemB4.CatalogB4 = catalogs.OfType<CatalogB4>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemB4s.Add(newItemB4);
                        }
                        if (item is ItemB5)
                        {
                            ItemB5 newItemB5 = item as ItemB5;
                            newItemB5.CatalogB5 = catalogs.OfType<CatalogB5>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemB5s.Add(newItemB5);
                        }

                        if (item is ItemC1)
                        {
                            ItemC1 newItemC1 = item as ItemC1;
                            newItemC1.CatalogC1 = catalogs.OfType<CatalogC1>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemC1s.Add(newItemC1);
                        }
                        if (item is ItemC2)
                        {
                            ItemC2 newItemC2 = item as ItemC2;
                            newItemC2.CatalogC2 = catalogs.OfType<CatalogC2>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemC2s.Add(newItemC2);
                        }
                        if (item is ItemC3)
                        {
                            ItemC3 newItemC3 = item as ItemC3;
                            newItemC3.CatalogC3 = catalogs.OfType<CatalogC3>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemC3s.Add(newItemC3);
                        }
                        if (item is ItemC4)
                        {
                            ItemC4 newItemC4 = item as ItemC4;
                            newItemC4.CatalogC4 = catalogs.OfType<CatalogC4>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemC4s.Add(newItemC4);
                        }

                        if (item is ItemD1)
                        {
                            ItemD1 newItemD1 = item as ItemD1;
                            newItemD1.CatalogD1 = catalogs.OfType<CatalogD1>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemD1s.Add(newItemD1);
                        }
                        if (item is ItemD2)
                        {
                            ItemD2 newItemD2 = item as ItemD2;
                            newItemD2.CatalogD2 = catalogs.OfType<CatalogD2>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemD2s.Add(newItemD2);
                        }

                        if (item is ItemE1)
                        {
                            ItemE1 newItemE1 = item as ItemE1;
                            newItemE1.CatalogE1 = catalogs.OfType<CatalogE1>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemE1s.Add(newItemE1);
                        }
                        if (item is ItemE2)
                        {
                            ItemE2 newItemE2 = item as ItemE2;
                            newItemE2.CatalogE2 = catalogs.OfType<CatalogE2>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemE2s.Add(newItemE2);
                        }
                        if (item is ItemE3)
                        {
                            ItemE3 newItemE3 = item as ItemE3;
                            newItemE3.CatalogE3 = catalogs.OfType<CatalogE3>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemE3s.Add(newItemE3);
                        }
                        if (item is ItemE4)
                        {
                            ItemE4 newItemE4 = item as ItemE4;
                            newItemE4.CatalogE4 = catalogs.OfType<CatalogE4>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemE4s.Add(newItemE4);
                        }
                        if (item is ItemE5)
                        {
                            ItemE5 newItemE5 = item as ItemE5;
                            newItemE5.CatalogE5 = catalogs.OfType<CatalogE5>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemE5s.Add(newItemE5);
                        }
                        if (item is ItemE6)
                        {
                            ItemE6 newItemE6 = item as ItemE6;
                            newItemE6.CatalogE6 = catalogs.OfType<CatalogE6>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemE6s.Add(newItemE6);
                        }
                        if (item is ItemE7)
                        {
                            ItemE7 newItemE7 = item as ItemE7;
                            newItemE7.CatalogE7 = catalogs.OfType<CatalogE7>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemE7s.Add(newItemE7);
                        }

                        if (item is ItemF1)
                        {
                            ItemF1 newItemF1 = item as ItemF1;
                            newItemF1.CatalogF1 = catalogs.OfType<CatalogF1>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemF1s.Add(newItemF1);
                        }

                        if (item is ItemG1)
                        {
                            ItemG1 newItemG1 = item as ItemG1;
                            newItemG1.CatalogG1 = catalogs.OfType<CatalogG1>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemG1s.Add(newItemG1);
                        }
                        if (item is ItemG2)
                        {
                            ItemG2 newItemG2 = item as ItemG2;
                            newItemG2.CatalogG2 = catalogs.OfType<CatalogG2>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemG2s.Add(newItemG2);
                        }
                        if (item is ItemG3)
                        {
                            ItemG3 newItemG3 = item as ItemG3;
                            newItemG3.CatalogG3 = catalogs.OfType<CatalogG3>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemG3s.Add(newItemG3);
                        }
                        if (item is ItemG4)
                        {
                            ItemG4 newItemG4 = item as ItemG4;
                            newItemG4.CatalogG4 = catalogs.OfType<CatalogG4>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemG4s.Add(newItemG4);
                        }
                        if (item is ItemG5)
                        {
                            ItemG5 newItemG5 = item as ItemG5;
                            newItemG5.CatalogG5 = catalogs.OfType<CatalogG5>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemG5s.Add(newItemG5);
                        }
                        if (item is ItemG6)
                        {
                            ItemG6 newItemG6 = item as ItemG6;
                            newItemG6.CatalogG6 = catalogs.OfType<CatalogG6>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemG6s.Add(newItemG6);
                        }

                        if (item is ItemH1)
                        {
                            ItemH1 newItemH1 = item as ItemH1;
                            newItemH1.CatalogH1 = catalogs.OfType<CatalogH1>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemH1s.Add(newItemH1);
                        }
                        if (item is ItemH2)
                        {
                            ItemH2 newItemH2 = item as ItemH2;
                            newItemH2.CatalogH2 = catalogs.OfType<CatalogH2>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemH2s.Add(newItemH2);
                        }
                        if (item is ItemH3)
                        {
                            ItemH3 newItemH3 = item as ItemH3;
                            newItemH3.CatalogH3 = catalogs.OfType<CatalogH3>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemH3s.Add(newItemH3);
                        }
                        if (item is ItemH4)
                        {
                            ItemH4 newItemH4 = item as ItemH4;
                            newItemH4.CatalogH4 = catalogs.OfType<CatalogH4>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemH4s.Add(newItemH4);
                        }
                        if (item is ItemH5)
                        {
                            ItemH5 newItemH5 = item as ItemH5;
                            newItemH5.CatalogH5 = catalogs.OfType<CatalogH5>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemH5s.Add(newItemH5);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemA1s.ToList<IItem>(), items.OfType<ItemA1>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemA2s.ToList<IItem>(), items.OfType<ItemA2>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemA3s.ToList<IItem>(), items.OfType<ItemA3>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemA4s.ToList<IItem>(), items.OfType<ItemA4>().ToList<IItem>());

                DeleteItems(context, dbQuote.ItemB1s.ToList<IItem>(), items.OfType<ItemB1>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemB2s.ToList<IItem>(), items.OfType<ItemB2>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemB3s.ToList<IItem>(), items.OfType<ItemB3>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemB4s.ToList<IItem>(), items.OfType<ItemB4>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemB5s.ToList<IItem>(), items.OfType<ItemB5>().ToList<IItem>());

                DeleteItems(context, dbQuote.ItemC1s.ToList<IItem>(), items.OfType<ItemC1>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemC2s.ToList<IItem>(), items.OfType<ItemC2>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemC3s.ToList<IItem>(), items.OfType<ItemC3>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemC4s.ToList<IItem>(), items.OfType<ItemC4>().ToList<IItem>());

                DeleteItems(context, dbQuote.ItemD1s.ToList<IItem>(), items.OfType<ItemD1>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemD2s.ToList<IItem>(), items.OfType<ItemD2>().ToList<IItem>());

                DeleteItems(context, dbQuote.ItemE1s.ToList<IItem>(), items.OfType<ItemE1>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemE2s.ToList<IItem>(), items.OfType<ItemE2>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemE3s.ToList<IItem>(), items.OfType<ItemE3>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemE4s.ToList<IItem>(), items.OfType<ItemE4>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemE5s.ToList<IItem>(), items.OfType<ItemE5>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemE6s.ToList<IItem>(), items.OfType<ItemE6>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemE7s.ToList<IItem>(), items.OfType<ItemE7>().ToList<IItem>());

                DeleteItems(context, dbQuote.ItemF1s.ToList<IItem>(), items.OfType<ItemF1>().ToList<IItem>());

                DeleteItems(context, dbQuote.ItemG1s.ToList<IItem>(), items.OfType<ItemG1>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemG2s.ToList<IItem>(), items.OfType<ItemG2>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemG3s.ToList<IItem>(), items.OfType<ItemG3>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemG4s.ToList<IItem>(), items.OfType<ItemG4>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemG5s.ToList<IItem>(), items.OfType<ItemG5>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemG6s.ToList<IItem>(), items.OfType<ItemG6>().ToList<IItem>());

                DeleteItems(context, dbQuote.ItemH1s.ToList<IItem>(), items.OfType<ItemH1>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemH2s.ToList<IItem>(), items.OfType<ItemH2>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemH3s.ToList<IItem>(), items.OfType<ItemH3>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemH4s.ToList<IItem>(), items.OfType<ItemH4>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemH5s.ToList<IItem>(), items.OfType<ItemH5>().ToList<IItem>());

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetAllItemByQuoteId(quote.Id);
        }

        public IList<IItem> UpdateA1Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemA1s).ThenInclude(x => x.CatalogA1)
                    .Include(x => x.ItemA1s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogA1s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemA1s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemA1)
                        {
                            ItemA1 newItem = item as ItemA1;
                            newItem.CatalogA1 = catalogs.OfType<CatalogA1>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemA1s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemA1s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetA1ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateA2Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemA2s).ThenInclude(x => x.CatalogA2)
                    .Include(x => x.ItemA2s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogA2s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemA2s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemA2)
                        {
                            ItemA2 newItem = item as ItemA2;
                            newItem.CatalogA2 = catalogs.OfType<CatalogA2>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemA2s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemA2s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetA2ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateA3Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemA3s).ThenInclude(x => x.CatalogA3)
                    .Include(x => x.ItemA3s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogA3s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemA3s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemA3)
                        {
                            ItemA3 newItem = item as ItemA3;
                            newItem.CatalogA3 = catalogs.OfType<CatalogA3>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemA3s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemA3s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetA3ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateA4Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemA4s).ThenInclude(x => x.CatalogA4)
                    .Include(x => x.ItemA4s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogA4s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemA4s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemA4)
                        {
                            ItemA4 newItem = item as ItemA4;
                            newItem.CatalogA4 = catalogs.OfType<CatalogA4>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemA4s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemA4s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetA4ItemsByQuoteId(quote.Id);
        }

        public IList<IItem> UpdateB1Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemB1s).ThenInclude(x => x.CatalogB1)
                    .Include(x => x.ItemB1s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogB1s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemB1s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemB1)
                        {
                            ItemB1 newItem = item as ItemB1;
                            newItem.CatalogB1 = catalogs.OfType<CatalogB1>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemB1s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemB1s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetB1ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateB2Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemB2s).ThenInclude(x => x.CatalogB2)
                    .Include(x => x.ItemB2s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogB2s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemB2s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemB2)
                        {
                            ItemB2 newItem = item as ItemB2;
                            newItem.CatalogB2 = catalogs.OfType<CatalogB2>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemB2s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemB2s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetB2ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateB3Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemB3s).ThenInclude(x => x.CatalogB3)
                    .Include(x => x.ItemB3s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogB3s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemB3s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemB3)
                        {
                            ItemB3 newItem = item as ItemB3;
                            newItem.CatalogB3 = catalogs.OfType<CatalogB3>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemB3s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemB3s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetB3ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateB4Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemB4s).ThenInclude(x => x.CatalogB4)
                    .Include(x => x.ItemB4s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogB4s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemB4s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemB4)
                        {
                            ItemB4 newItem = item as ItemB4;
                            newItem.CatalogB4 = catalogs.OfType<CatalogB4>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemB4s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemB4s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetB4ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateB5Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemB5s).ThenInclude(x => x.CatalogB5)
                    .Include(x => x.ItemB5s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogB5s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemB5s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemB5)
                        {
                            ItemB5 newItem = item as ItemB5;
                            newItem.CatalogB5 = catalogs.OfType<CatalogB5>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemB5s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemB5s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetB5ItemsByQuoteId(quote.Id);
        }

        public IList<IItem> UpdateC1Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemC1s).ThenInclude(x => x.CatalogC1)
                    .Include(x => x.ItemC1s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogC1s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemC1s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemC1)
                        {
                            ItemC1 newItem = item as ItemC1;
                            newItem.CatalogC1 = catalogs.OfType<CatalogC1>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemC1s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemC1s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetC1ItemsCyQuoteId(quote.Id);
        }
        public IList<IItem> UpdateC2Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemC2s).ThenInclude(x => x.CatalogC2)
                    .Include(x => x.ItemC2s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogC2s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemC2s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemC2)
                        {
                            ItemC2 newItem = item as ItemC2;
                            newItem.CatalogC2 = catalogs.OfType<CatalogC2>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemC2s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemC2s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetC2ItemsCyQuoteId(quote.Id);
        }
        public IList<IItem> UpdateC3Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemC3s).ThenInclude(x => x.CatalogC3)
                    .Include(x => x.ItemC3s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogC3s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemC3s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemC3)
                        {
                            ItemC3 newItem = item as ItemC3;
                            newItem.CatalogC3 = catalogs.OfType<CatalogC3>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemC3s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemC3s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetC3ItemsCyQuoteId(quote.Id);
        }
        public IList<IItem> UpdateC4Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemC4s).ThenInclude(x => x.CatalogC4)
                    .Include(x => x.ItemC4s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogC4s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemC4s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemC4)
                        {
                            ItemC4 newItem = item as ItemC4;
                            newItem.CatalogC4 = catalogs.OfType<CatalogC4>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemC4s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemC4s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetC4ItemsCyQuoteId(quote.Id);
        }

        public IList<IItem> UpdateD1Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemD1s).ThenInclude(x => x.CatalogD1)
                    .Include(x => x.ItemD1s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogD1s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemD1s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemD1)
                        {
                            ItemD1 newItem = item as ItemD1;
                            newItem.CatalogD1 = catalogs.OfType<CatalogD1>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemD1s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemD1s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetD1ItemsCyQuoteId(quote.Id);
        }
        public IList<IItem> UpdateD2Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemD2s).ThenInclude(x => x.CatalogD2)
                    .Include(x => x.ItemD2s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogD2s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemD2s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemD2)
                        {
                            ItemD2 newItem = item as ItemD2;
                            newItem.CatalogD2 = catalogs.OfType<CatalogD2>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemD2s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemD2s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetD2ItemsCyQuoteId(quote.Id);
        }

        public IList<IItem> UpdateE1Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemE1s).ThenInclude(x => x.CatalogE1)
                    .Include(x => x.ItemE1s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogE1s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemE1s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemE1)
                        {
                            ItemE1 newItem = item as ItemE1;
                            newItem.CatalogE1 = catalogs.OfType<CatalogE1>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemE1s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemE1s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetE1ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateE2Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemE2s).ThenInclude(x => x.CatalogE2)
                    .Include(x => x.ItemE2s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogE2s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemE2s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemE2)
                        {
                            ItemE2 newItem = item as ItemE2;
                            newItem.CatalogE2 = catalogs.OfType<CatalogE2>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemE2s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemE2s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetE2ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateE3Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemE3s).ThenInclude(x => x.CatalogE3)
                    .Include(x => x.ItemE3s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogE3s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemE3s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemE3)
                        {
                            ItemE3 newItem = item as ItemE3;
                            newItem.CatalogE3 = catalogs.OfType<CatalogE3>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemE3s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemE3s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetE3ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateE4Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemE4s).ThenInclude(x => x.CatalogE4)
                    .Include(x => x.ItemE4s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogE4s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemE4s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemE4)
                        {
                            ItemE4 newItem = item as ItemE4;
                            newItem.CatalogE4 = catalogs.OfType<CatalogE4>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemE4s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemE4s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetE4ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateE5Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemE5s).ThenInclude(x => x.CatalogE5)
                    .Include(x => x.ItemE5s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogE5s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemE5s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemE5)
                        {
                            ItemE5 newItem = item as ItemE5;
                            newItem.CatalogE5 = catalogs.OfType<CatalogE5>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemE5s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemE5s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetE5ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateE6Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemE6s).ThenInclude(x => x.CatalogE6)
                    .Include(x => x.ItemE6s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogE6s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemE6s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemE6)
                        {
                            ItemE6 newItem = item as ItemE6;
                            newItem.CatalogE6 = catalogs.OfType<CatalogE6>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemE6s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemE6s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetE6ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateE7Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemE7s).ThenInclude(x => x.CatalogE7)
                    .Include(x => x.ItemE7s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogE7s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemE7s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemE7)
                        {
                            ItemE7 newItem = item as ItemE7;
                            newItem.CatalogE7 = catalogs.OfType<CatalogE7>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemE7s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemE7s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetE7ItemsByQuoteId(quote.Id);
        }

        public IList<IItem> UpdateF1Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemF1s).ThenInclude(x => x.CatalogF1)
                    .Include(x => x.ItemF1s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogF1s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemF1s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemF1)
                        {
                            ItemF1 newItem = item as ItemF1;
                            newItem.CatalogF1 = catalogs.OfType<CatalogF1>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemF1s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemF1s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetF1ItemsByQuoteId(quote.Id);
        }

        public IList<IItem> UpdateG1Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemG1s).ThenInclude(x => x.CatalogG1)
                    .Include(x => x.ItemG1s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogG1s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemG1s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemG1)
                        {
                            ItemG1 newItem = item as ItemG1;
                            newItem.CatalogG1 = catalogs.OfType<CatalogG1>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemG1s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemG1s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetG1ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateG2Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemG2s).ThenInclude(x => x.CatalogG2)
                    .Include(x => x.ItemG2s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogG2s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemG2s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemG2)
                        {
                            ItemG2 newItem = item as ItemG2;
                            newItem.CatalogG2 = catalogs.OfType<CatalogG2>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemG2s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemG2s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetG2ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateG3Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemG3s).ThenInclude(x => x.CatalogG3)
                    .Include(x => x.ItemG3s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogG3s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemG3s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemG3)
                        {
                            ItemG3 newItem = item as ItemG3;
                            newItem.CatalogG3 = catalogs.OfType<CatalogG3>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemG3s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemG3s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetG3ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateG4Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemG4s).ThenInclude(x => x.CatalogG4)
                    .Include(x => x.ItemG4s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogG4s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemG4s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemG4)
                        {
                            ItemG4 newItem = item as ItemG4;
                            newItem.CatalogG4 = catalogs.OfType<CatalogG4>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemG4s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemG4s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetG4ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateG5Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemG5s).ThenInclude(x => x.CatalogG5)
                    .Include(x => x.ItemG5s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogG5s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemG5s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemG5)
                        {
                            ItemG5 newItem = item as ItemG5;
                            newItem.CatalogG5 = catalogs.OfType<CatalogG5>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemG5s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemG5s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetG5ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateG6Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemG6s).ThenInclude(x => x.CatalogG6)
                    .Include(x => x.ItemG6s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogG6s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemG6s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemG6)
                        {
                            ItemG6 newItem = item as ItemG6;
                            newItem.CatalogG6 = catalogs.OfType<CatalogG6>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemG6s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemG6s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetG6ItemsByQuoteId(quote.Id);
        }

        public IList<IItem> UpdateH1Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemH1s).ThenInclude(x => x.CatalogH1)
                    .Include(x => x.ItemH1s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogH1s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemH1s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemH1)
                        {
                            ItemH1 newItem = item as ItemH1;
                            newItem.CatalogH1 = catalogs.OfType<CatalogH1>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemH1s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemH1s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetH1ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateH2Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemH2s).ThenInclude(x => x.CatalogH2)
                    .Include(x => x.ItemH2s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogH2s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemH2s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemH2)
                        {
                            ItemH2 newItem = item as ItemH2;
                            newItem.CatalogH2 = catalogs.OfType<CatalogH2>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemH2s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemH2s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetH2ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateH3Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemH3s).ThenInclude(x => x.CatalogH3)
                    .Include(x => x.ItemH3s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogH3s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemH3s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemH3)
                        {
                            ItemH3 newItem = item as ItemH3;
                            newItem.CatalogH3 = catalogs.OfType<CatalogH3>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemH3s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemH3s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetH3ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateH4Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemH4s).ThenInclude(x => x.CatalogH4)
                    .Include(x => x.ItemH4s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogH4s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemH4s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemH4)
                        {
                            ItemH4 newItem = item as ItemH4;
                            newItem.CatalogH4 = catalogs.OfType<CatalogH4>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemH4s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemH4s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetH4ItemsByQuoteId(quote.Id);
        }
        public IList<IItem> UpdateH5Items(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemH5s).ThenInclude(x => x.CatalogH5)
                    .Include(x => x.ItemH5s).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogH5s.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemH5s.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.ListPrice = item.ListPrice;
                        dbItem.CostMultiplier = item.CostMultiplier;
                        dbItem.Cost = item.Cost;
                        dbItem.SellMargin = item.SellMargin;
                        dbItem.SellPrice = item.SellPrice;
                    }
                    else
                    {
                        if (item is ItemH5)
                        {
                            ItemH5 newItem = item as ItemH5;
                            newItem.CatalogH5 = catalogs.OfType<CatalogH5>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemH5s.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemH5s.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetH5ItemsByQuoteId(quote.Id);
        }


        private void DeleteItems(DbContext context, IList<IItem> dbItems, IList<IItem> items)
        {
            foreach (IItem dbItem in dbItems)
            {
                if (!items.ToList().Exists(x => x.Id == dbItem.Id))
                {
                    foreach (Title title in dbItem.Titles)
                    {
                        context.Remove(title);
                    }
                    context.Remove(dbItem);
                    context.Entry(dbItem).State = EntityState.Deleted;
                }
            }
        }

        private IList<IItem> GetA1ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemA1s.Include(x => x.CatalogA1).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetA2ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemA2s.Include(x => x.CatalogA2).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetA3ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemA3s.Include(x => x.CatalogA3).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetA4ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemA4s.Include(x => x.CatalogA4).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }

        private IList<IItem> GetB1ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemB1s.Include(x => x.CatalogB1).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetB2ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemB2s.Include(x => x.CatalogB2).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetB3ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemB3s.Include(x => x.CatalogB3).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetB4ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemB4s.Include(x => x.CatalogB4).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetB5ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemB5s.Include(x => x.CatalogB5).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }

        private IList<IItem> GetC1ItemsCyQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemC1s.Include(x => x.CatalogC1).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetC2ItemsCyQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemC2s.Include(x => x.CatalogC2).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetC3ItemsCyQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemC3s.Include(x => x.CatalogC3).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetC4ItemsCyQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemC4s.Include(x => x.CatalogC4).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }

        private IList<IItem> GetD1ItemsCyQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemD1s.Include(x => x.CatalogD1).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetD2ItemsCyQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemD2s.Include(x => x.CatalogD2).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }

        private IList<IItem> GetE1ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemE1s.Include(x => x.CatalogE1).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetE2ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemE2s.Include(x => x.CatalogE2).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetE3ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemE3s.Include(x => x.CatalogE3).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetE4ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemE4s.Include(x => x.CatalogE4).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetE5ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemE5s.Include(x => x.CatalogE5).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetE6ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemE6s.Include(x => x.CatalogE6).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetE7ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemE7s.Include(x => x.CatalogE7).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }

        private IList<IItem> GetF1ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemF1s.Include(x => x.CatalogF1).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }

        private IList<IItem> GetG1ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemG1s.Include(x => x.CatalogG1).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetG2ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemG2s.Include(x => x.CatalogG2).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetG3ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemG3s.Include(x => x.CatalogG3).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetG4ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemG4s.Include(x => x.CatalogG4).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetG5ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemG5s.Include(x => x.CatalogG5).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetG6ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemG6s.Include(x => x.CatalogG6).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }

        private IList<IItem> GetH1ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemH1s.Include(x => x.CatalogH1).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetH2ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemH2s.Include(x => x.CatalogH2).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetH3ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemH3s.Include(x => x.CatalogH3).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetH4ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemH4s.Include(x => x.CatalogH4).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
        private IList<IItem> GetH5ItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemH5s.Include(x => x.CatalogH5).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }
    }
}
