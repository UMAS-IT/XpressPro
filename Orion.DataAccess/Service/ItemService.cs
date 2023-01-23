using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityCatalogAmericanWheatley;
using Orion.Domain.EntityCatalogPuroflux;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Domain.EntityItemPuroFlux;
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

            return GetC1ItemsCyQuoteId(quote.Id);
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

            return GetC2ItemsCyQuoteId(quote.Id);
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
    }
}
