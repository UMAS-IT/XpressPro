using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
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

                items.AddRange(itemA1s);
                items.AddRange(itemA2s);
                items.AddRange(itemA3s);
                items.AddRange(itemA4s);
                items.AddRange(itemB1s);
                items.AddRange(itemB2s);
                items.AddRange(itemB3s);
                items.AddRange(itemB4s);
                items.AddRange(itemB5s);

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
                //dbQuote.ItemAirCooledChillersName = quote.ItemAirCooledChillersName;
                //dbQuote.ItemUnitsName = quote.ItemUnitsName;
                //dbQuote.ItemPumpsName = quote.ItemPumpsName;
                //dbQuote.ItemVfdsName = quote.ItemVfdsName;

                foreach (IItem item in items)
                {
                    IItem dbItem = null;

                    if (item.QuoteId == dbQuote.Id)
                    {
                        if (item is ItemA1)
                        {
                            ItemA1 itemA1 = dbQuote.ItemA1s.FirstOrDefault(x => x.Id == item.Id);
                            dbItem = itemA1;
                        }
                        if (item is ItemA2)
                        {
                            ItemA2 itemA2 = dbQuote.ItemA2s.FirstOrDefault(x => x.Id == item.Id);
                            dbItem = itemA2;
                        }
                        if (item is ItemA3)
                        {
                            ItemA3 itemA3 = dbQuote.ItemA3s.FirstOrDefault(x => x.Id == item.Id);
                            dbItem = itemA3;
                        }
                        if (item is ItemA4)
                        {
                            ItemA4 itemA4 = dbQuote.ItemA4s.FirstOrDefault(x => x.Id == item.Id);
                            dbItem = itemA4;
                        }

                        if (item is ItemB1)
                        {
                            ItemB1 itemB1 = dbQuote.ItemB1s.FirstOrDefault(x => x.Id == item.Id);
                            dbItem = itemB1;
                        }
                        if (item is ItemB2)
                        {
                            ItemB2 itemB2 = dbQuote.ItemB2s.FirstOrDefault(x => x.Id == item.Id);
                            dbItem = itemB2;
                        }
                        if (item is ItemB3)
                        {
                            ItemB3 itemB3 = dbQuote.ItemB3s.FirstOrDefault(x => x.Id == item.Id);
                            dbItem = itemB3;
                        }
                        if (item is ItemB4)
                        {
                            ItemB4 itemB4 = dbQuote.ItemB4s.FirstOrDefault(x => x.Id == item.Id);
                            dbItem = itemB4;
                        }
                        if (item is ItemB5)
                        {
                            ItemB5 itemB5 = dbQuote.ItemB5s.FirstOrDefault(x => x.Id == item.Id);
                            dbItem = itemB5;
                        }

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
    }
}
