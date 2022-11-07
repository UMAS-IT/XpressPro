using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Domain.EntityItem;
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

                IList<ItemA1> itemAirCooledChillers = context.ItemA1s.Include(x => x.CatalogA1).Where(x => x.QuoteId == quoteId).ToList();

                IList<ItemA2> itemUnits = context.ItemA2s.Include(x => x.CatalogA2).Where(x => x.QuoteId == quoteId).ToList();

                IList<ItemA3> itemPumps = context.ItemA3s.Include(x => x.CatalogA3).Where(x => x.QuoteId == quoteId).ToList();

                IList<ItemA4> itemVfds = context.ItemA4s.Include(x => x.CatalogA4).Where(x => x.QuoteId == quoteId).ToList();

                items.AddRange(itemAirCooledChillers);
                items.AddRange(itemUnits);
                items.AddRange(itemPumps);
                items.AddRange(itemVfds);

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
                    .Include(x => x.ItemA2s).ThenInclude(x => x.CatalogA2)
                    .Include(x => x.ItemA3s).ThenInclude(x => x.CatalogA3)
                    .Include(x => x.ItemA4s).ThenInclude(x => x.CatalogA4)
                    .FirstOrDefault(x => x.Id == quote.Id);

                List<CatalogA1> catalogA1s = context.CatalogA1s.ToList();
                List<CatalogA2> catalogA2s = context.CatalogA2s.ToList();
                List<CatalogA3> catalogA3s = context.CatalogA3s.ToList();
                List<CatalogA4> catalogA4s = context.CatalogA4s.ToList();

                List<ICatalog> catalogs = new List<ICatalog>();
                catalogs.AddRange(catalogA1s);
                catalogs.AddRange(catalogA2s);
                catalogs.AddRange(catalogA3s);
                catalogs.AddRange(catalogA4s);

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
                    }
                }

                DeleteItems(context, dbQuote.ItemA1s.ToList<IItem>(), items.OfType<ItemA1>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemA2s.ToList<IItem>(), items.OfType<ItemA2>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemA3s.ToList<IItem>(), items.OfType<ItemA3>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemA4s.ToList<IItem>(), items.OfType<ItemA4>().ToList<IItem>());

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

            return GetA4ItemsByQuoteId(quote.Id);
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
    }
}
