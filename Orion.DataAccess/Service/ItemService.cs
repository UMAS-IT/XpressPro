﻿using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalog;
using Orion.Domain.EntityItem;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Collections.Specialized.BitVector32;

namespace Orion.DataAccess.Service
{
    public class ItemService
    {
        public IList<IItem> GetAllItemByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                IList<ItemAirCooledChiller> itemAirCooledChillers = context.ItemAirCooledChillers.Include(x => x.CatalogAirCooledChiller).Where(x => x.QuoteId == quoteId).ToList();

                IList<ItemUnit> itemUnits = context.ItemUnits.Include(x => x.CatalogUnit).Where(x => x.QuoteId == quoteId).ToList();

                IList<ItemPump> itemPumps = context.ItemPumps.Include(x => x.CatalogPump).Where(x => x.QuoteId == quoteId).ToList();

                IList<ItemVfd> itemVfds = context.ItemVfds.Include(x => x.CatalogVfd).Where(x => x.QuoteId == quoteId).ToList();

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
                    .Include(x => x.ItemAirCooledChillers).ThenInclude(x => x.CatalogAirCooledChiller)
                    .Include(x => x.ItemUnits).ThenInclude(x => x.CatalogUnit)
                    .Include(x => x.ItemPumps).ThenInclude(x => x.CatalogPump)
                    .Include(x => x.ItemVfds).ThenInclude(x => x.CatalogVfd)
                    .FirstOrDefault(x => x.Id == quote.Id);

                List<CatalogAirCooledChiller> catalogAirCooledChillers = context.CatalogAirCooledChillers.ToList();
                List<CatalogUnit> catalogUnits = context.CatalogUnits.ToList();
                List<CatalogPump> catalogPumps = context.CatalogPumps.ToList();
                List<CatalogVfd> catalogVfds = context.CatalogVfds.ToList();

                List<ICatalog> catalogs = new List<ICatalog>();
                catalogs.AddRange(catalogAirCooledChillers);
                catalogs.AddRange(catalogUnits);
                catalogs.AddRange(catalogPumps);
                catalogs.AddRange(catalogVfds);

                dbQuote.ItemAirCooledChillersName = quote.ItemAirCooledChillersName;
                dbQuote.ItemUnitsName = quote.ItemUnitsName;
                dbQuote.ItemPumpsName = quote.ItemPumpsName;
                dbQuote.ItemVfdsName = quote.ItemVfdsName;

                foreach (IItem item in items)
                {
                    IItem dbItem = null;

                    if (item.QuoteId == dbQuote.Id)
                    {
                        if (item is ItemAirCooledChiller)
                        {
                            ItemAirCooledChiller itemAirCooledChiller = dbQuote.ItemAirCooledChillers.FirstOrDefault(x => x.Id == item.Id);
                            dbItem = itemAirCooledChiller;
                        }
                        if (item is ItemUnit)
                        {
                            ItemUnit itemUnit = dbQuote.ItemUnits.FirstOrDefault(x => x.Id == item.Id);
                            dbItem = itemUnit;
                        }
                        if (item is ItemPump)
                        {
                            ItemPump itemPump = dbQuote.ItemPumps.FirstOrDefault(x => x.Id == item.Id);
                            dbItem = itemPump;
                        }
                        if (item is ItemVfd)
                        {
                            ItemVfd itemVfd = dbQuote.ItemVfds.FirstOrDefault(x => x.Id == item.Id);
                            dbItem = itemVfd;
                        }
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.Price = item.Price;
                    }
                    else
                    {
                        if (item is ItemAirCooledChiller)
                        {
                            ItemAirCooledChiller newItemAirCooledChiller = item as ItemAirCooledChiller;
                            newItemAirCooledChiller.CatalogAirCooledChiller = catalogs.OfType<CatalogAirCooledChiller>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemAirCooledChillers.Add(newItemAirCooledChiller);
                        }
                        if (item is ItemUnit)
                        {
                            ItemUnit newItemUnit = item as ItemUnit;
                            newItemUnit.CatalogUnit = catalogs.OfType<CatalogUnit>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemUnits.Add(newItemUnit);
                        }
                        if (item is ItemPump)
                        {
                            ItemUnit newItemUnit = item as ItemUnit;
                            newItemUnit.CatalogUnit = catalogs.OfType<CatalogUnit>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemUnits.Add(newItemUnit);
                        }
                        if (item is ItemVfd)
                        {
                            ItemVfd newItemVfd = item as ItemVfd;
                            newItemVfd.CatalogVfd = catalogs.OfType<CatalogVfd>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemVfds.Add(newItemVfd);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemAirCooledChillers.ToList<IItem>(), items.OfType<ItemAirCooledChiller>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemPumps.ToList<IItem>(), items.OfType<ItemPump>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemUnits.ToList<IItem>(), items.OfType<ItemUnit>().ToList<IItem>());
                DeleteItems(context, dbQuote.ItemVfds.ToList<IItem>(), items.OfType<ItemVfd>().ToList<IItem>());

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetAllItemByQuoteId(quote.Id);
        }



        public IList<IItem> UpdateAirCooledChillerItems(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemAirCooledChillers).ThenInclude(x => x.CatalogAirCooledChiller)
                    .Include(x => x.ItemAirCooledChillers).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogAirCooledChillers.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemAirCooledChillers.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.Price = item.Price;
                    }
                    else
                    {
                        if (item is ItemAirCooledChiller)
                        {
                            ItemAirCooledChiller newItem = item as ItemAirCooledChiller;
                            newItem.CatalogAirCooledChiller = catalogs.OfType<CatalogAirCooledChiller>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemAirCooledChillers.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemAirCooledChillers.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetAirCooledChillerItemsByQuoteId(quote.Id);
        }

        public IList<IItem> UpdatePumpItems(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemPumps).ThenInclude(x => x.CatalogPump)
                    .Include(x => x.ItemPumps).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogPumps.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemPumps.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.Price = item.Price;
                    }
                    else
                    {
                        if (item is ItemPump)
                        {
                            ItemPump newItem = item as ItemPump;
                            newItem.CatalogPump = catalogs.OfType<CatalogPump>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemPumps.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemPumps.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetPumpItemsByQuoteId(quote.Id);
        }

        public IList<IItem> UpdateUnitItems(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemUnits).ThenInclude(x => x.CatalogUnit)
                    .Include(x => x.ItemUnits).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogUnits.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemUnits.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.Price = item.Price;
                    }
                    else
                    {
                        if (item is ItemUnit)
                        {
                            ItemUnit newItem = item as ItemUnit;
                            newItem.CatalogUnit = catalogs.OfType<CatalogUnit>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemUnits.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemUnits.ToList<IItem>(), items);


                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetUnitItemsByQuoteId(quote.Id);
        }

        public IList<IItem> UpdateVfdItems(Quote quote, IList<IItem> items)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));

            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = context.Quotes
                    .Include(x => x.ItemVfds).ThenInclude(x => x.CatalogVfd)
                    .Include(x => x.ItemVfds).ThenInclude(x => x.Titles)
                    .FirstOrDefault(x => x.Id == quote.Id);

                IList<ICatalog> catalogs = context.CatalogVfds.ToList<ICatalog>();

                foreach (IItem item in items)
                {
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = dbQuote.ItemVfds.FirstOrDefault(x => x.Id == item.Id);
                        dbItem.Quantity = item.Quantity;
                        dbItem.DesignIndex = item.DesignIndex;
                        dbItem.Tag = item.Tag;
                        dbItem.IsExcluded = item.IsExcluded;
                        dbItem.OverridePrice = item.OverridePrice;
                        dbItem.Price = item.Price;
                    }
                    else
                    {
                        if (item is ItemVfd)
                        {
                            ItemVfd newItem = item as ItemVfd;
                            newItem.CatalogVfd = catalogs.OfType<CatalogVfd>().FirstOrDefault(x => x.Id == item.CatalogId);
                            dbQuote.ItemVfds.Add(newItem);
                        }
                    }
                }

                DeleteItems(context, dbQuote.ItemVfds.ToList<IItem>(), items);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();
            }

            return GetVfdItemsByQuoteId(quote.Id);
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



        private IList<IItem> GetAirCooledChillerItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemAirCooledChillers.Include(x => x.CatalogAirCooledChiller).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }

        private IList<IItem> GetUnitItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemUnits.Include(x => x.CatalogUnit).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }

        private IList<IItem> GetPumpItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemPumps.Include(x => x.CatalogPump).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }

        private IList<IItem> GetVfdItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                return context.ItemVfds.Include(x => x.CatalogVfd).Where(x => x.QuoteId == quoteId).ToList<IItem>();
            }
        }


    }
}
