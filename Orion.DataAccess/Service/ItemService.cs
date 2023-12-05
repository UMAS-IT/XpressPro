using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Orion.DataAccess.DataBase;
using Orion.DataAccess.Misc;
using Orion.Domain.BACClosedLoopTowers.Related;
using Orion.Domain.BACOpenLoopTowers.Related;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityCatalogAmericanWheatley;
using Orion.Domain.EntityCatalogBACClosedLoopTowers;
using Orion.Domain.EntityCatalogBACOpenLoopTowers;
using Orion.Domain.EntityCatalogGeneralProduct;
using Orion.Domain.EntityCatalogGroundfos;
using Orion.Domain.EntityCatalogPuroflux;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Domain.EntityCatalogUvResources;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Domain.EntityItemBACClosedLoopTowers;
using Orion.Domain.EntityItemBACOpenLoopTowers;
using Orion.Domain.EntityItemGeneralProduct;
using Orion.Domain.EntityItemGroundfos;
using Orion.Domain.EntityItemPuroFlux;
using Orion.Domain.EntityItemUvResources;
using Orion.Domain.Groundfos.Related;
using Orion.Domain.Marvair;
using Orion.Domain.Marvair.Catalog;
using Orion.Domain.Marvair.Item;
using Orion.Domain.Multiaqua.Catalog;
using Orion.Domain.Multiaqua.Item;
using Orion.Domain.PACE.Catalog;
using Orion.Domain.PACE.Item;
using Orion.Domain.Quantech.Related;
using Orion.Domain.UMAS.Item;
using Orion.Helper.Misc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using static Orion.Helper.Misc.GV;

namespace Orion.DataAccess.Service
{
    public class ItemService
    {
        // [new]
        public Quote GetQuote(Quote quote, ItemType itemType, GlobalDbContext context)
        {
            Quote dbQuote = null;

            switch (itemType)
            {
                case ItemType.ItemA1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemA1s).ThenInclude(x => x.CatalogA1)
                        .Include(x => x.ItemA1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemA2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemA2s).ThenInclude(x => x.CatalogA2)
                        .Include(x => x.ItemA2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemA3:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemA3s).ThenInclude(x => x.CatalogA3)
                        .Include(x => x.ItemA3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemA4:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemA4s).ThenInclude(x => x.CatalogA4)
                        .Include(x => x.ItemA4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemB1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemB1s).ThenInclude(x => x.CatalogB1)
                        .Include(x => x.ItemB1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemB2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemB2s).ThenInclude(x => x.CatalogB2)
                        .Include(x => x.ItemB2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemB3:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemB3s).ThenInclude(x => x.CatalogB3)
                        .Include(x => x.ItemB3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemB4:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemB4s).ThenInclude(x => x.CatalogB4)
                        .Include(x => x.ItemB4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemB5:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemB5s).ThenInclude(x => x.CatalogB5)
                        .Include(x => x.ItemB5s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemC1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemC1s).ThenInclude(x => x.CatalogC1).ThenInclude(x => x.CatalogC1ProductType)
                        .Include(x => x.ItemC1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemC2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemC2s).ThenInclude(x => x.CatalogC2)
                        .Include(x => x.ItemC2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemC3:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemC3s).ThenInclude(x => x.CatalogC3).ThenInclude(x => x.CatalogC3ProductType)
                        .Include(x => x.ItemC3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemC4:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemC4s).ThenInclude(x => x.CatalogC4)
                        .Include(x => x.ItemC4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemC5:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemC5s).ThenInclude(x => x.CatalogC5)
                        .Include(x => x.ItemC5s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemC6:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemC6s).ThenInclude(x => x.CatalogC6)
                        .Include(x => x.ItemC6s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemC7:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemC7s).ThenInclude(x => x.CatalogC7)
                        .Include(x => x.ItemC7s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemD1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemD1s).ThenInclude(x => x.CatalogD1)
                        .Include(x => x.ItemD1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemD2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemD2s).ThenInclude(x => x.CatalogD2)
                        .Include(x => x.ItemD2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemE1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemE1s).ThenInclude(x => x.CatalogE1)
                        .Include(x => x.ItemE1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemE2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemE2s).ThenInclude(x => x.CatalogE2)
                        .Include(x => x.ItemE2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemE3:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemE3s).ThenInclude(x => x.CatalogE3)
                        .Include(x => x.ItemE3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemE4:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemE4s).ThenInclude(x => x.CatalogE4)
                        .Include(x => x.ItemE4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemE5:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemE5s).ThenInclude(x => x.CatalogE5)
                        .Include(x => x.ItemE5s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemE6:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemE6s).ThenInclude(x => x.CatalogE6)
                        .Include(x => x.ItemE6s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemE7:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemE7s).ThenInclude(x => x.CatalogE7)
                        .Include(x => x.ItemE7s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemF1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemF1s).ThenInclude(x => x.CatalogF1).ThenInclude(x => x.CatalogF1ProductType)
                        .Include(x => x.ItemF1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemG1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemG1s).ThenInclude(x => x.CatalogG1)
                        .Include(x => x.ItemG1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemG2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemG2s).ThenInclude(x => x.CatalogG2)
                        .Include(x => x.ItemG2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemG3:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemG3s).ThenInclude(x => x.CatalogG3)
                        .Include(x => x.ItemG3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemG4:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemG4s).ThenInclude(x => x.CatalogG4)
                        .Include(x => x.ItemG4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemG5:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemG5s).ThenInclude(x => x.CatalogG5)
                        .Include(x => x.ItemG5s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemG6:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemG6s).ThenInclude(x => x.CatalogG6)
                        .Include(x => x.ItemG6s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemH1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemH1s).ThenInclude(x => x.CatalogH1)
                        .Include(x => x.ItemH1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemH2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemH2s).ThenInclude(x => x.CatalogH2)
                        .Include(x => x.ItemH2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemH3:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemH3s).ThenInclude(x => x.CatalogH3)
                        .Include(x => x.ItemH3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemH4:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemH4s).ThenInclude(x => x.CatalogH4)
                        .Include(x => x.ItemH4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemH5:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemH5s).ThenInclude(x => x.CatalogH5)
                        .Include(x => x.ItemH5s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemI1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemI1s).ThenInclude(x => x.CatalogI1)
                        .Include(x => x.ItemI1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemI2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemI2s).ThenInclude(x => x.CatalogI2)
                        .Include(x => x.ItemI2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemJ1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemJ1s).ThenInclude(x => x.CatalogJ1)
                        .Include(x => x.ItemJ1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemK1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemK1s).ThenInclude(x => x.CatalogK1)
                        .Include(x => x.ItemK1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemK2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemK2s).ThenInclude(x => x.CatalogK2)
                        .Include(x => x.ItemK2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemK3:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemK3s).ThenInclude(x => x.CatalogK3)
                        .Include(x => x.ItemK3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemL1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemL1s).ThenInclude(x => x.CatalogL1)
                        .Include(x => x.ItemL1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.ItemM1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemM1s).ThenInclude(x => x.CatalogM1)
                        .Include(x => x.ItemM1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                default:
                    throw new ArgumentException($"Invalid ItemType: {itemType}");
            }

            return dbQuote;
        }

        public void CreateItem(Quote quote, IList<ICatalog> catalogs, IItem item, ItemType itemType, GlobalDbContext context)
        {

            Type itemClassType = EntityHelper.GetItemClassTypeForItemType(itemType);
            Type catalogClassType = EntityHelper.GetCatalogClassTypeForItemType(itemType);

            IList<ICatalog> curretCatalogs = new List<ICatalog>();

            curretCatalogs = catalogs.Where(x => x.GetType().Equals(catalogClassType)).ToList();

            PropertyInfo itemListPropertyInfo = quote.GetType().GetProperty(itemClassType.Name + "s");
            PropertyInfo catalogPropertyInfo = itemClassType.GetProperty(catalogClassType.Name);

            var itemList = (IList)itemListPropertyInfo.GetValue(quote);
            itemList.Add(item);

            catalogPropertyInfo.SetValue(item, curretCatalogs.FirstOrDefault(x => x.Id == item.Catalog.Id));

        }

        public IList<IItem> DeleteItems(Quote quote, IList<IItem> items, ItemType itemType, GlobalDbContext context)
        {
            IList<IItem> dbItems = null;

            Type itemClassType = EntityHelper.GetItemClassTypeForItemType(itemType);
            PropertyInfo itemListPropertyInfo = quote.GetType().GetProperty(itemClassType.Name + "s");

            dbItems = ((IEnumerable)itemListPropertyInfo.GetValue(quote)).Cast<IItem>().ToList();

            IList<IItem> itemsToDelete = dbItems.Where(a => !items.Select(b => b.Id).Contains(a.Id)).ToList();
            IList<IItem> itemsToReturn = dbItems.Where(a => items.Select(b => b.Id).Contains(a.Id)).ToList();

            foreach (IItem item in itemsToDelete)
            {
                foreach (Title title in item.Titles)
                {
                    context.Remove(title);
                }
                context.Remove(item);
                context.Entry(item).State = EntityState.Deleted;
            }

            return itemsToReturn;
        }

        public IItem GetItem(Quote quote, IItem item, ItemType itemType)
        {
            Type itemCollectionType = EntityHelper.GetItemClassTypeForItemType(itemType);

            // Get the property name corresponding to the item type
            string propertyName = itemType.ToString() + "s";

            PropertyInfo propertyInfo = quote.GetType().GetProperty(propertyName);

            var itemCollection = propertyInfo.GetValue(quote);

            var items = new ObservableCollection<IItem>();

            foreach (IItem specificItem in (IEnumerable)itemCollection)
            {
                items.Add(specificItem);
            }

            return items.FirstOrDefault(x => x.Id == item.Id);
        }

        public IList<IItem> UpdateItems(Quote quote, IList<IItem> items, ItemType itemType)
        {
            items.ToList().ForEach(s => s.DesignIndex = items.IndexOf(s));
            
            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote dbQuote = GetQuote(quote, itemType, context);

                IList<ICatalog> catalogs = new CatalogService().GetCatalogs(itemType, context);

                foreach (IItem item in items)
                { 
                    if (item.QuoteId == dbQuote.Id)
                    {
                        IItem dbItem = GetItem(dbQuote, item, itemType);
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
                        dbItem.Freight = item.Freight;

                        if (dbItem is ItemA)
                        {
                            ItemA itemA = item as ItemA;
                            ItemA dbItemA = dbItem as ItemA;

                            dbItemA.Tons = itemA.Tons;

                            //dbItem = dbItemA;
                        }
                        else if (dbItem is ItemE)
                        {
                            ItemE itemE = item as ItemE;
                            ItemE dbItemE = dbItem as ItemE;

                            dbItemE.Model = itemE.Model;
                            dbItemE.Gpm = itemE.Gpm;
                            dbItemE.Tdh = itemE.Tdh;
                            dbItemE.Hp = itemE.Hp;
                            dbItemE.Motor = itemE.Motor;
                            dbItemE.Rpm = itemE.Rpm;
                            dbItemE.Electrical = itemE.Electrical;

                            //dbItem = dbItemE;
                        }
                        else if (dbItem is  ItemJ1)
                        {
                            ItemJ1 itemJ1 = item as ItemJ1;
                            ItemJ1 dbItemJ1 = dbItem as ItemJ1;

                            dbItemJ1.Model = itemJ1.Model;
                            dbItemJ1.Cfm = itemJ1.Cfm;
                            dbItemJ1.Voltage = itemJ1.Voltage;
                            dbItemJ1.Weight = itemJ1.Weight;

                            //dbItem = dbItemJ1;
                        }
                        else if (dbItem is ItemG)
                        {
                            ItemG itemG = item as ItemG;
                            ItemG dbItemG = dbItem as ItemG;

                            dbItemG.Model = itemG.Model;
                            dbItemG.FlowRate = itemG.FlowRate;
                            dbItemG.WaterTemp = itemG.WaterTemp;
                            dbItemG.DesignWB = itemG.DesignWB;
                            dbItemG.FluidPressureDrop = itemG.FluidPressureDrop;
                            dbItemG.FanMotors = itemG.FanMotors;
                            dbItemG.PumpMotor = itemG.PumpMotor;
                            dbItemG.Voltage = itemG.Voltage;
                        }
                        else if (dbItem is ItemH)
                        {
                            ItemH itemH = item as ItemH;
                            ItemH dbItemH = dbItem as ItemH;

                            dbItemH.Model = itemH.Model;
                            dbItemH.FlowRate = itemH.FlowRate;
                            dbItemH.WaterTemp = itemH.WaterTemp;
                            dbItemH.DesignWB = itemH.DesignWB;
                            dbItemH.FluidPressureDrop = itemH.FluidPressureDrop;
                            dbItemH.FanMotors = itemH.FanMotors;
                            dbItemH.PumpMotor = itemH.PumpMotor;
                            dbItemH.Voltage = itemH.Voltage;
                        }
                        else if (dbItem is ItemL1)
                        {
                            ItemL1 itemL = item as ItemL1;
                            ItemL1 dbItemL1 = dbItem as ItemL1;

                            dbItemL1.Model = itemL.Model;
                            dbItemL1.Description = itemL.Description;
                        }
                        else if (dbItem is ItemM1)
                        {
                            ItemM1 itemM = item as ItemM1;
                            ItemM1 dbItemM1 = dbItem as ItemM1;

                            dbItemM1.Model = itemM.Model;
                            dbItemM1.Cfm = itemM.Cfm;
                            dbItemM1.Voltage = itemM.Voltage;
                            dbItemM1.Weight = itemM.Weight;
                        }
                    }
                    else
                    {
                        CreateItem(dbQuote, catalogs, item, itemType, context);
                    }
                }

                IList<IItem> itemsToReturn = DeleteItems(dbQuote, items, itemType, context);

                context.Quotes.Update(dbQuote);
                context.SaveChanges();

                return itemsToReturn;
            }
        }

        public IList<IItem> UpdateQuoteAllItems(Quote quote, IList<IItem> items)
        {
            Dictionary<Type, List<IItem>> itemGroups = new Dictionary<Type, List<IItem>>();

            foreach (IItem item in items)
            {
                Type itemClassType = item.GetType();

                if (!itemGroups.ContainsKey(itemClassType))
                {
                    itemGroups[itemClassType] = new List<IItem>();
                }

                itemGroups[itemClassType].Add(item);
            }

            List<IItem> itemsToReturn = new List<IItem>();

            foreach (var itemGroup in itemGroups)
            {
                ItemType itemType = EntityHelper.GetItemTypeForItemClassType(itemGroup.Key);

                itemsToReturn.AddRange(UpdateItems(quote, itemGroup.Value, itemType));
            }

            return itemsToReturn;
        }

        public string ValidateAllItemsTag(IList<IItem> items)
        {
            string message = "";

            Dictionary<Type, List<IItem>> itemGroups = new Dictionary<Type, List<IItem>>();

            foreach (IItem item in items)
            {
                Type itemClassType = item.GetType();

                if (!itemGroups.ContainsKey(itemClassType))
                {
                    itemGroups[itemClassType] = new List<IItem>();
                }

                itemGroups[itemClassType].Add(item);
            }

            foreach (var itemGroup in itemGroups)
            {
                ItemType itemType = EntityHelper.GetItemTypeForItemClassType(itemGroup.Key);

                message += ValidataItemsTag(itemGroup.Value);
            }

            return message;
        }

        public string ValidataItemsTag(List<IItem> items)
        {
            string message = "";

            List<IGrouping<string, IItem>> duplicatedTagsGroupList = items.ToList().GroupBy(x => x.Tag)
            .Where(group => group.Count() > 1)
            .Select(group => group).ToList();

            foreach (IGrouping<string,IItem> group in duplicatedTagsGroupList)
            {
                IItem item = group.First();

                message += $"The Tag [{item.Tag.ToUpper()}] is duplicated {group.Count()} times in {item.Catalog.Company}, {item.Catalog.Product}\r";
            }

            return message;
        }

        public IList<IItem> GetAllItemByQuoteId(int quoteId, bool sortByDesignIndex = true)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return GetAllItemByQuoteId(quoteId, context, sortByDesignIndex);
            }
        }
        // [new]
        public IList<IItem> GetAllItemByQuoteId(int quoteId, GlobalDbContext context, bool sortByDesignIndex = true)
        {

            List<IItem> items = new List<IItem>();

            items.AddRange(context.ItemA1s.Include(x => x.CatalogA1).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemA2s.Include(x => x.CatalogA2).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemA3s.Include(x => x.CatalogA3).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemA4s.Include(x => x.CatalogA4).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemB1s.Include(x => x.CatalogB1).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemB2s.Include(x => x.CatalogB2).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemB3s.Include(x => x.CatalogB3).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemB4s.Include(x => x.CatalogB4).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemB5s.Include(x => x.CatalogB5).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemC1s.Include(x => x.CatalogC1).ThenInclude(x => x.CatalogC1ProductType).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemC2s.Include(x => x.CatalogC2).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemC3s.Include(x => x.CatalogC3).ThenInclude(x => x.CatalogC3ProductType).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemC4s.Include(x => x.CatalogC4).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemC5s.Include(x => x.CatalogC5).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemC6s.Include(x => x.CatalogC6).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemC7s.Include(x => x.CatalogC7).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemD1s.Include(x => x.CatalogD1).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemD2s.Include(x => x.CatalogD2).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemE1s.Include(x => x.CatalogE1).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemE2s.Include(x => x.CatalogE2).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemE3s.Include(x => x.CatalogE3).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemE4s.Include(x => x.CatalogE4).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemE5s.Include(x => x.CatalogE5).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemE6s.Include(x => x.CatalogE6).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemE7s.Include(x => x.CatalogE7).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemF1s.Include(x => x.CatalogF1).ThenInclude(x => x.CatalogF1ProductType).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemG1s.Include(x => x.CatalogG1).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemG2s.Include(x => x.CatalogG2).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemG3s.Include(x => x.CatalogG3).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemG4s.Include(x => x.CatalogG4).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemG5s.Include(x => x.CatalogG5).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemG6s.Include(x => x.CatalogG6).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemH1s.Include(x => x.CatalogH1).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemH2s.Include(x => x.CatalogH2).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemH3s.Include(x => x.CatalogH3).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemH4s.Include(x => x.CatalogH4).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemH5s.Include(x => x.CatalogH5).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemH5s.Include(x => x.CatalogH5).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemI1s.Include(x => x.CatalogI1).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemI2s.Include(x => x.CatalogI2).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemJ1s.Include(x => x.CatalogJ1).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemK1s.Include(x => x.CatalogK1).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemK2s.Include(x => x.CatalogK2).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemK3s.Include(x => x.CatalogK3).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemL1s.Include(x => x.CatalogL1).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemM1s.Include(x => x.CatalogM1).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());

            if (sortByDesignIndex)
                items = items.OrderBy(x => x.DesignIndex).ToList();

            return items;

        }

        public IItem AddItem(ICatalog catalog, ItemType itemType)
        {
            Type itemClassType =  EntityHelper.GetItemClassTypeForItemType(itemType);
            Type catalogClassType = EntityHelper.GetCatalogClassTypeForItemType(itemType);

            IItem item = (IItem)Activator.CreateInstance(itemClassType);

            PropertyInfo catalogPropertyInfo = itemClassType.GetProperty(catalogClassType.Name);
            PropertyInfo catalogIdPropertyInfo = itemClassType.GetProperty(catalogClassType.Name + "Id");

            catalogPropertyInfo.SetValue(item, catalog);
            catalogIdPropertyInfo.SetValue(item, catalog.Id);

            // Set the common properties
            item.ListPrice = catalog.ListPrice;
            item.SellPrice = catalog.SellPrice;
            item.Cost = catalog.Cost;
            item.SellMargin = catalog.SellMargin;
            item.CostMultiplier = catalog.CostMultiplier;

            return item;
        }

        public void CloneQuoteItems(Quote sourceQuote, Quote newQuote)
        {
            List<IItem> clonedItems = new List<IItem>();

            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> dbItems = GetAllItemByQuoteId(sourceQuote.Id, context).ToList();

                foreach (IItem item in dbItems)
                {
                    Item clonedItem = (Item)item.Clone();
                    clonedItem.QuoteId = 0;
                    clonedItem.Id = 0;

                    clonedItem.Titles = new List<Title>();

                    foreach (Title title in item.Titles)
                    {
                        Title clonedTitle = (Title)title.Clone();
                        clonedTitle.Id = 0;
                        clonedItem.Titles.Add(clonedTitle);

                        clonedTitle.Specs = new List<Spec>();

                        foreach (Spec spec in title.Specs)
                        {
                            Spec clonedSpec = (Spec)spec.Clone();
                            clonedSpec.Id = 0;
                            clonedTitle.Specs.Add(clonedSpec);
                        }
                    }
                    clonedItems.Add(clonedItem);
                }
            }
            UpdateQuoteAllItems(newQuote, clonedItems);
        }


    }
}
