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
using Orion.Domain.Groundfos.Related;
using Orion.Domain.Marvair;
using Orion.Domain.Marvair.Catalog;
using Orion.Domain.Marvair.Item;
using Orion.Domain.Multiaqua.Catalog;
using Orion.Domain.Multiaqua.Item;
using Orion.Domain.PACE.Catalog;
using Orion.Domain.PACE.Item;
using Orion.Domain.UvResources.Related;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using static Orion.Helper.Misc.GV;

namespace Orion.DataAccess.Service
{
    public class ItemService
    {
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
                        .Include(x => x.ItemC1s).ThenInclude(x => x.CatalogC1)
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

                default:
                    throw new ArgumentException($"Invalid ItemType: {itemType}");
            }

            return dbQuote;
        }

        public void CreateItem(Quote quote, IList<ICatalog> catalogs, IItem item, ItemType itemType, GlobalDbContext context)
        {
            switch (itemType)
            {
                case ItemType.ItemA1:
                    ItemA1 newItemA1 = item as ItemA1;
                    newItemA1.CatalogA1 = catalogs.OfType<CatalogA1>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemA1s.Add(newItemA1);
                    break;

                case ItemType.ItemA2:
                    ItemA2 newItemA2 = item as ItemA2;
                    newItemA2.CatalogA2 = catalogs.OfType<CatalogA2>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemA2s.Add(newItemA2);
                    break;

                case ItemType.ItemA3:
                    ItemA3 newItemA3 = item as ItemA3;
                    newItemA3.CatalogA3 = catalogs.OfType<CatalogA3>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemA3s.Add(newItemA3);
                    break;

                case ItemType.ItemA4:
                    ItemA4 newItemA4 = item as ItemA4;
                    newItemA4.CatalogA4 = catalogs.OfType<CatalogA4>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemA4s.Add(newItemA4);
                    break;

                case ItemType.ItemB1:
                    ItemB1 newItemB1 = item as ItemB1;
                    newItemB1.CatalogB1 = catalogs.OfType<CatalogB1>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemB1s.Add(newItemB1);
                    break;

                case ItemType.ItemB2:
                    ItemB2 newItemB2 = item as ItemB2;
                    newItemB2.CatalogB2 = catalogs.OfType<CatalogB2>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemB2s.Add(newItemB2);
                    break;

                case ItemType.ItemB3:
                    ItemB3 newItemB3 = item as ItemB3;
                    newItemB3.CatalogB3 = catalogs.OfType<CatalogB3>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemB3s.Add(newItemB3);
                    break;

                case ItemType.ItemB4:
                    ItemB4 newItemB4 = item as ItemB4;
                    newItemB4.CatalogB4 = catalogs.OfType<CatalogB4>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemB4s.Add(newItemB4);
                    break;

                case ItemType.ItemB5:
                    ItemB5 newItemB5 = item as ItemB5;
                    newItemB5.CatalogB5 = catalogs.OfType<CatalogB5>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemB5s.Add(newItemB5);
                    break;

                case ItemType.ItemC1:
                    ItemC1 newItemC1 = item as ItemC1;
                    newItemC1.CatalogC1 = catalogs.OfType<CatalogC1>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemC1s.Add(newItemC1);
                    break;

                case ItemType.ItemC2:
                    ItemC2 newItemC2 = item as ItemC2;
                    newItemC2.CatalogC2 = catalogs.OfType<CatalogC2>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemC2s.Add(newItemC2);
                    break;

                case ItemType.ItemC3:
                    ItemC3 newItemC3 = item as ItemC3;
                    newItemC3.CatalogC3 = catalogs.OfType<CatalogC3>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemC3s.Add(newItemC3);
                    break;

                case ItemType.ItemC4:
                    ItemC4 newItemC4 = item as ItemC4;
                    newItemC4.CatalogC4 = catalogs.OfType<CatalogC4>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemC4s.Add(newItemC4);
                    break;

                case ItemType.ItemD1:
                    ItemD1 newItemD1 = item as ItemD1;
                    newItemD1.CatalogD1 = catalogs.OfType<CatalogD1>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemD1s.Add(newItemD1);
                    break;

                case ItemType.ItemD2:
                    ItemD2 newItemD2 = item as ItemD2;
                    newItemD2.CatalogD2 = catalogs.OfType<CatalogD2>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemD2s.Add(newItemD2);
                    break;
                case ItemType.ItemE1:
                    ItemE1 newItemE1 = item as ItemE1;
                    newItemE1.CatalogE1 = catalogs.OfType<CatalogE1>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemE1s.Add(newItemE1);
                    break;

                case ItemType.ItemE2:
                    ItemE2 newItemE2 = item as ItemE2;
                    newItemE2.CatalogE2 = catalogs.OfType<CatalogE2>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemE2s.Add(newItemE2);
                    break;

                case ItemType.ItemE3:
                    ItemE3 newItemE3 = item as ItemE3;
                    newItemE3.CatalogE3 = catalogs.OfType<CatalogE3>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemE3s.Add(newItemE3);
                    break;

                case ItemType.ItemE4:
                    ItemE4 newItemE4 = item as ItemE4;
                    newItemE4.CatalogE4 = catalogs.OfType<CatalogE4>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemE4s.Add(newItemE4);
                    break;

                case ItemType.ItemE5:
                    ItemE5 newItemE5 = item as ItemE5;
                    newItemE5.CatalogE5 = catalogs.OfType<CatalogE5>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemE5s.Add(newItemE5);
                    break;

                case ItemType.ItemE6:
                    ItemE6 newItemE6 = item as ItemE6;
                    newItemE6.CatalogE6 = catalogs.OfType<CatalogE6>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemE6s.Add(newItemE6);
                    break;

                case ItemType.ItemE7:
                    ItemE7 newItemE7 = item as ItemE7;
                    newItemE7.CatalogE7 = catalogs.OfType<CatalogE7>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemE7s.Add(newItemE7);
                    break;

                case ItemType.ItemF1:
                    ItemF1 newItemF1 = item as ItemF1;
                    newItemF1.CatalogF1 = catalogs.OfType<CatalogF1>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemF1s.Add(newItemF1);
                    break;

                case ItemType.ItemG1:
                    ItemG1 newItemG1 = item as ItemG1;
                    newItemG1.CatalogG1 = catalogs.OfType<CatalogG1>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemG1s.Add(newItemG1);
                    break;

                case ItemType.ItemG2:
                    ItemG2 newItemG2 = item as ItemG2;
                    newItemG2.CatalogG2 = catalogs.OfType<CatalogG2>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemG2s.Add(newItemG2);
                    break;

                case ItemType.ItemG3:
                    ItemG3 newItemG3 = item as ItemG3;
                    newItemG3.CatalogG3 = catalogs.OfType<CatalogG3>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemG3s.Add(newItemG3);
                    break;

                case ItemType.ItemG4:
                    ItemG4 newItemG4 = item as ItemG4;
                    newItemG4.CatalogG4 = catalogs.OfType<CatalogG4>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemG4s.Add(newItemG4);
                    break;

                case ItemType.ItemG5:
                    ItemG5 newItemG5 = item as ItemG5;
                    newItemG5.CatalogG5 = catalogs.OfType<CatalogG5>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemG5s.Add(newItemG5);
                    break;

                case ItemType.ItemG6:
                    ItemG6 newItemG6 = item as ItemG6;
                    newItemG6.CatalogG6 = catalogs.OfType<CatalogG6>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemG6s.Add(newItemG6);
                    break;

                case ItemType.ItemH1:
                    ItemH1 newItemH1 = item as ItemH1;
                    newItemH1.CatalogH1 = catalogs.OfType<CatalogH1>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemH1s.Add(newItemH1);
                    break;

                case ItemType.ItemH2:
                    ItemH2 newItemH2 = item as ItemH2;
                    newItemH2.CatalogH2 = catalogs.OfType<CatalogH2>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemH2s.Add(newItemH2);
                    break;

                case ItemType.ItemH3:
                    ItemH3 newItemH3 = item as ItemH3;
                    newItemH3.CatalogH3 = catalogs.OfType<CatalogH3>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemH3s.Add(newItemH3);
                    break;

                case ItemType.ItemH4:
                    ItemH4 newItemH4 = item as ItemH4;
                    newItemH4.CatalogH4 = catalogs.OfType<CatalogH4>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemH4s.Add(newItemH4);
                    break;

                case ItemType.ItemH5:
                    ItemH5 newItemH5 = item as ItemH5;
                    newItemH5.CatalogH5 = catalogs.OfType<CatalogH5>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemH5s.Add(newItemH5);
                    break;

                case ItemType.ItemI1:
                    ItemI1 newItemI1 = item as ItemI1;
                    newItemI1.CatalogI1 = catalogs.OfType<CatalogI1>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemI1s.Add(newItemI1);
                    break;

                case ItemType.ItemI2:
                    ItemI2 newItemI2 = item as ItemI2;
                    newItemI2.CatalogI2 = catalogs.OfType<CatalogI2>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemI2s.Add(newItemI2);
                    break;

                case ItemType.ItemJ1:
                    ItemJ1 newItemJ1 = item as ItemJ1;
                    newItemJ1.CatalogJ1 = catalogs.OfType<CatalogJ1>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemJ1s.Add(newItemJ1);
                    break;

                case ItemType.ItemK1:
                    ItemK1 newItemK1 = item as ItemK1;
                    newItemK1.CatalogK1 = catalogs.OfType<CatalogK1>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemK1s.Add(newItemK1);
                    break;

                case ItemType.ItemK2:
                    ItemK2 newItemK2 = item as ItemK2;
                    newItemK2.CatalogK2 = catalogs.OfType<CatalogK2>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemK2s.Add(newItemK2);
                    break;

                case ItemType.ItemK3:
                    ItemK3 newItemK3 = item as ItemK3;
                    newItemK3.CatalogK3 = catalogs.OfType<CatalogK3>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemK3s.Add(newItemK3);
                    break;

                default:
                    throw new ArgumentException("Invalid ItemType value.");
            }
        }

        public IList<IItem> DeleteItems(Quote quote, IList<IItem> items, ItemType itemType, GlobalDbContext context)
        {
            IList<IItem> dbItems = null;

            switch (itemType)
            {
                case ItemType.ItemA1:
                    dbItems = quote.ItemA1s.ToList<IItem>();
                    break;
                case ItemType.ItemA2:
                    dbItems = quote.ItemA2s.ToList<IItem>();
                    break;
                case ItemType.ItemA3:
                    dbItems = quote.ItemA3s.ToList<IItem>();
                    break;
                case ItemType.ItemA4:
                    dbItems = quote.ItemA4s.ToList<IItem>();
                    break;
                case ItemType.ItemB1:
                    dbItems = quote.ItemB1s.ToList<IItem>();
                    break;
                case ItemType.ItemB2:
                    dbItems = quote.ItemB2s.ToList<IItem>();
                    break;
                case ItemType.ItemB3:
                    dbItems = quote.ItemB3s.ToList<IItem>();
                    break;
                case ItemType.ItemB4:
                    dbItems = quote.ItemB4s.ToList<IItem>();
                    break;
                case ItemType.ItemB5:
                    dbItems = quote.ItemB5s.ToList<IItem>();
                    break;
                case ItemType.ItemC1:
                    dbItems = quote.ItemC1s.ToList<IItem>();
                    break;
                case ItemType.ItemC2:
                    dbItems = quote.ItemC2s.ToList<IItem>();
                    break;
                case ItemType.ItemC3:
                    dbItems = quote.ItemC3s.ToList<IItem>();
                    break;
                case ItemType.ItemC4:
                    dbItems = quote.ItemC4s.ToList<IItem>();
                    break;
                case ItemType.ItemD1:
                    dbItems = quote.ItemD1s.ToList<IItem>();
                    break;
                case ItemType.ItemD2:
                    dbItems = quote.ItemD2s.ToList<IItem>();
                    break;
                case ItemType.ItemE1:
                    dbItems = quote.ItemE1s.ToList<IItem>();
                    break;
                case ItemType.ItemE2:
                    dbItems = quote.ItemE2s.ToList<IItem>();
                    break;
                case ItemType.ItemE3:
                    dbItems = quote.ItemE3s.ToList<IItem>();
                    break;
                case ItemType.ItemE4:
                    dbItems = quote.ItemE4s.ToList<IItem>();
                    break;
                case ItemType.ItemE5:
                    dbItems = quote.ItemE5s.ToList<IItem>();
                    break;
                case ItemType.ItemE6:
                    dbItems = quote.ItemE6s.ToList<IItem>();
                    break;
                case ItemType.ItemE7:
                    dbItems = quote.ItemE7s.ToList<IItem>();
                    break;
                case ItemType.ItemF1:
                    dbItems = quote.ItemF1s.ToList<IItem>();
                    break;
                case ItemType.ItemG1:
                    dbItems = quote.ItemG1s.ToList<IItem>();
                    break;
                case ItemType.ItemG2:
                    dbItems = quote.ItemG2s.ToList<IItem>();
                    break;
                case ItemType.ItemG3:
                    dbItems = quote.ItemG3s.ToList<IItem>();
                    break;
                case ItemType.ItemG4:
                    dbItems = quote.ItemG4s.ToList<IItem>();
                    break;
                case ItemType.ItemG5:
                    dbItems = quote.ItemG5s.ToList<IItem>();
                    break;
                case ItemType.ItemG6:
                    dbItems = quote.ItemG6s.ToList<IItem>();
                    break;
                case ItemType.ItemH1:
                    dbItems = quote.ItemH1s.ToList<IItem>();
                    break;
                case ItemType.ItemH2:
                    dbItems = quote.ItemH2s.ToList<IItem>();
                    break;
                case ItemType.ItemH3:
                    dbItems = quote.ItemH3s.ToList<IItem>();
                    break;
                case ItemType.ItemH4:
                    dbItems = quote.ItemH4s.ToList<IItem>();
                    break;
                case ItemType.ItemH5:
                    dbItems = quote.ItemH5s.ToList<IItem>();
                    break;
                case ItemType.ItemI1:
                    dbItems = quote.ItemI1s.ToList<IItem>();
                    break;
                case ItemType.ItemI2:
                    dbItems = quote.ItemI2s.ToList<IItem>();
                    break;
                case ItemType.ItemJ1:
                    dbItems = quote.ItemJ1s.ToList<IItem>();
                    break;
                case ItemType.ItemK1:
                    dbItems = quote.ItemK1s.ToList<IItem>();
                    break;
                case ItemType.ItemK2:
                    dbItems = quote.ItemK2s.ToList<IItem>();
                    break;
                case ItemType.ItemK3:
                    dbItems = quote.ItemK3s.ToList<IItem>();
                    break;
                default:
                    throw new ArgumentException("Invalid item type.");
            }

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
            IItem dbItem = null;

            switch (itemType)
            {
                case ItemType.ItemA1:
                    dbItem = quote.ItemA1s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemA2:
                    dbItem = quote.ItemA2s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemA3:
                    dbItem = quote.ItemA3s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemA4:
                    dbItem = quote.ItemA4s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemB1:
                    dbItem = quote.ItemB1s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemB2:
                    dbItem = quote.ItemB2s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemB3:
                    dbItem = quote.ItemB3s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemB4:
                    dbItem = quote.ItemB4s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemB5:
                    dbItem = quote.ItemB5s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemC1:
                    dbItem = quote.ItemC1s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemC2:
                    dbItem = quote.ItemC2s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemC3:
                    dbItem = quote.ItemC3s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemC4:
                    dbItem = quote.ItemC4s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemD1:
                    dbItem = quote.ItemD1s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemD2:
                    dbItem = quote.ItemD2s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemE1:
                    dbItem = quote.ItemE1s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemE2:
                    dbItem = quote.ItemE2s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemE3:
                    dbItem = quote.ItemE3s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemE4:
                    dbItem = quote.ItemE4s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemE5:
                    dbItem = quote.ItemE5s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemE6:
                    dbItem = quote.ItemE6s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemE7:
                    dbItem = quote.ItemE7s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemF1:
                    dbItem = quote.ItemF1s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemG1:
                    dbItem = quote.ItemG1s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemG2:
                    dbItem = quote.ItemG2s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemG3:
                    dbItem = quote.ItemG3s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemG4:
                    dbItem = quote.ItemG4s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemG5:
                    dbItem = quote.ItemG5s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemG6:
                    dbItem = quote.ItemG6s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemH1:
                    dbItem = quote.ItemH1s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemH2:
                    dbItem = quote.ItemH2s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemH3:
                    dbItem = quote.ItemH3s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemH4:
                    dbItem = quote.ItemH4s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemH5:
                    dbItem = quote.ItemH5s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemI1:
                    dbItem = quote.ItemI1s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemI2:
                    dbItem = quote.ItemI2s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemJ1:
                    dbItem = quote.ItemJ1s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemK1:
                    dbItem = quote.ItemK1s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemK2:
                    dbItem = quote.ItemK2s.First(x => x.Id == item.Id);
                    break;
                case ItemType.ItemK3:
                    dbItem = quote.ItemK3s.First(x => x.Id == item.Id);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(itemType), itemType, "Item type not supported.");
            }

            return dbItem;
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

                        if (dbItem is ItemE)
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

                            dbItem = dbItemE;
                        }
                        else if (dbItem is  ItemJ1)
                        {
                            ItemJ1 itemJ1 = item as ItemJ1;
                            ItemJ1 dbItemJ1 = dbItem as ItemJ1;

                            dbItemJ1.Cfm = itemJ1.Cfm;
                            dbItemJ1.Voltage = itemJ1.Voltage;
                            dbItemJ1.Weight = itemJ1.Weight;

                            dbItem = dbItemJ1;
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
            List<IItem> itemsToReturn = new List<IItem>();

            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemA1>().ToList<IItem>(), ItemType.ItemA1));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemA2>().ToList<IItem>(), ItemType.ItemA2));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemA3>().ToList<IItem>(), ItemType.ItemA3));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemA4>().ToList<IItem>(), ItemType.ItemA4));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemB1>().ToList<IItem>(), ItemType.ItemB1));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemB2>().ToList<IItem>(), ItemType.ItemB2));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemB3>().ToList<IItem>(), ItemType.ItemB3));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemB4>().ToList<IItem>(), ItemType.ItemB4));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemB5>().ToList<IItem>(), ItemType.ItemB5));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemC1>().ToList<IItem>(), ItemType.ItemC1));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemC2>().ToList<IItem>(), ItemType.ItemC2));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemC3>().ToList<IItem>(), ItemType.ItemC3));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemC4>().ToList<IItem>(), ItemType.ItemC4));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemD1>().ToList<IItem>(), ItemType.ItemD1));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemD2>().ToList<IItem>(), ItemType.ItemD2));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemE1>().ToList<IItem>(), ItemType.ItemE1));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemE2>().ToList<IItem>(), ItemType.ItemE2));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemE3>().ToList<IItem>(), ItemType.ItemE3));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemE4>().ToList<IItem>(), ItemType.ItemE4));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemE5>().ToList<IItem>(), ItemType.ItemE5));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemE6>().ToList<IItem>(), ItemType.ItemE6));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemE7>().ToList<IItem>(), ItemType.ItemE7));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemF1>().ToList<IItem>(), ItemType.ItemF1));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemG1>().ToList<IItem>(), ItemType.ItemG1));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemG2>().ToList<IItem>(), ItemType.ItemG2));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemG3>().ToList<IItem>(), ItemType.ItemG3));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemG4>().ToList<IItem>(), ItemType.ItemG4));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemG5>().ToList<IItem>(), ItemType.ItemG5));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemG6>().ToList<IItem>(), ItemType.ItemG6));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemH1>().ToList<IItem>(), ItemType.ItemH1));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemH2>().ToList<IItem>(), ItemType.ItemH2));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemH3>().ToList<IItem>(), ItemType.ItemH3));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemH4>().ToList<IItem>(), ItemType.ItemH4));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemH5>().ToList<IItem>(), ItemType.ItemH5));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemI1>().ToList<IItem>(), ItemType.ItemI1));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemI2>().ToList<IItem>(), ItemType.ItemI2));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemJ1>().ToList<IItem>(), ItemType.ItemJ1));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemK1>().ToList<IItem>(), ItemType.ItemK1));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemK2>().ToList<IItem>(), ItemType.ItemK2));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemK3>().ToList<IItem>(), ItemType.ItemK3));

            return itemsToReturn;
        }

        public string ValidateAllItemsTag(IList<IItem>items)
        {
            string message = "";

            message += ValidataItemsTag(items.OfType<ItemA1>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemA2>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemA3>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemA4>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemB1>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemB2>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemB3>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemB4>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemB5>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemC1>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemC2>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemC3>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemC4>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemD1>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemD2>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemE1>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemE2>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemE3>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemE4>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemE5>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemE6>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemE7>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemF1>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemG1>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemG2>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemG3>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemG4>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemG5>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemG6>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemH1>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemH2>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemH3>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemH4>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemH5>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemI1>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemI2>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemJ1>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemK1>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemK2>().ToList<IItem>());
            message += ValidataItemsTag(items.OfType<ItemK3>().ToList<IItem>());

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

        public IList<IItem> GetAllItemByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return GetAllItemByQuoteId(quoteId, context);
            }
        }

        public IList<IItem> GetAllItemByQuoteId(int quoteId, GlobalDbContext context)
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
            items.AddRange(context.ItemC1s.Include(x => x.CatalogC1).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemC2s.Include(x => x.CatalogC2).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemC3s.Include(x => x.CatalogC3).ThenInclude(x => x.CatalogC3ProductType).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
            items.AddRange(context.ItemC4s.Include(x => x.CatalogC4).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
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

            items = items.OrderBy(x => x.DesignIndex).ToList();

            return items;

        }

        public IItem AddItem(ICatalog catalog, ItemType itemType)
        {
            IItem item = null;

            switch (itemType)
            {
                case ItemType.ItemA1:
                    ItemA1 newItemA1 = new ItemA1()
                    {
                        CatalogA1 = catalog as CatalogA1,
                        CatalogA1Id = catalog.Id,
                    };

                    item = newItemA1;
                    break;

                case ItemType.ItemA2:
                    ItemA2 newItemA2 = new ItemA2()
                    {
                        CatalogA2 = catalog as CatalogA2,
                        CatalogA2Id = catalog.Id,
                    };

                    item = newItemA2;
                    break;

                case ItemType.ItemA3:
                    ItemA3 newItemA3 = new ItemA3()
                    {
                        CatalogA3 = catalog as CatalogA3,
                        CatalogA3Id = catalog.Id,
                    };

                    item = newItemA3;
                    break;

                case ItemType.ItemA4:
                    ItemA4 newItemA4 = new ItemA4()
                    {
                        CatalogA4 = catalog as CatalogA4,
                        CatalogA4Id = catalog.Id,
                    };

                    item = newItemA4;
                    break;

                case ItemType.ItemB1:
                    ItemB1 newItemB1 = new ItemB1()
                    {
                        CatalogB1 = catalog as CatalogB1,
                        CatalogB1Id = catalog.Id,
                    };

                    item = newItemB1;
                    break;

                case ItemType.ItemB2:
                    ItemB2 newItemB2 = new ItemB2()
                    {
                        CatalogB2 = catalog as CatalogB2,
                        CatalogB2Id = catalog.Id,
                    };

                    item = newItemB2;
                    break;

                case ItemType.ItemB3:
                    ItemB3 newItemB3 = new ItemB3()
                    {
                        CatalogB3 = catalog as CatalogB3,
                        CatalogB3Id = catalog.Id,
                    };

                    item = newItemB3;
                    break;

                case ItemType.ItemB4:
                    ItemB4 newItemB4 = new ItemB4()
                    {
                        CatalogB4 = catalog as CatalogB4,
                        CatalogB4Id = catalog.Id,
                    };

                    item = newItemB4;
                    break;

                case ItemType.ItemB5:
                    ItemB5 newItemB5 = new ItemB5()
                    {
                        CatalogB5 = catalog as CatalogB5,
                        CatalogB5Id = catalog.Id,
                    };

                    item = newItemB5;
                    break;

                case ItemType.ItemC1:
                    ItemC1 newItemC1 = new ItemC1()
                    {
                        CatalogC1 = catalog as CatalogC1,
                        CatalogC1Id = catalog.Id,
                    };

                    item = newItemC1;
                    break;

                case ItemType.ItemC2:
                    ItemC2 newItemC2 = new ItemC2()
                    {
                        CatalogC2 = catalog as CatalogC2,
                        CatalogC2Id = catalog.Id,
                    };

                    item = newItemC2;
                    break;

                case ItemType.ItemC3:
                    ItemC3 newItemC3 = new ItemC3()
                    {
                        CatalogC3 = catalog as CatalogC3,
                        CatalogC3Id = catalog.Id,
                    };

                    item = newItemC3;
                    break;

                case ItemType.ItemC4:
                    ItemC4 newItemC4 = new ItemC4()
                    {
                        CatalogC4 = catalog as CatalogC4,
                        CatalogC4Id = catalog.Id,
                    };

                    item = newItemC4;
                    break;

                case ItemType.ItemD1:
                    ItemD1 newItemD1 = new ItemD1()
                    {
                        CatalogD1 = catalog as CatalogD1,
                        CatalogD1Id = catalog.Id,
                    };

                    item = newItemD1;
                    break;

                case ItemType.ItemD2:
                    ItemD2 newItemD2 = new ItemD2()
                    {
                        CatalogD2 = catalog as CatalogD2,
                        CatalogD2Id = catalog.Id,
                    };

                    item = newItemD2;
                    break;

                case ItemType.ItemE1:
                    ItemE1 newItemE1 = new ItemE1()
                    {
                        CatalogE1 = catalog as CatalogE1,
                        CatalogE1Id = catalog.Id,
                    };

                    item = newItemE1;
                    break;

                case ItemType.ItemE2:
                    ItemE2 newItemE2 = new ItemE2()
                    {
                        CatalogE2 = catalog as CatalogE2,
                        CatalogE2Id = catalog.Id,
                    };

                    item = newItemE2;
                    break;

                case ItemType.ItemE3:
                    ItemE3 newItemE3 = new ItemE3()
                    {
                        CatalogE3 = catalog as CatalogE3,
                        CatalogE3Id = catalog.Id,
                    };

                    item = newItemE3;
                    break;

                case ItemType.ItemE4:
                    ItemE4 newItemE4 = new ItemE4()
                    {
                        CatalogE4 = catalog as CatalogE4,
                        CatalogE4Id = catalog.Id,
                    };

                    item = newItemE4;
                    break;

                case ItemType.ItemE5:
                    ItemE5 newItemE5 = new ItemE5()
                    {
                        CatalogE5 = catalog as CatalogE5,
                        CatalogE5Id = catalog.Id,
                    };

                    item = newItemE5;
                    break;

                case ItemType.ItemE6:
                    ItemE6 newItemE6 = new ItemE6()
                    {
                        CatalogE6 = catalog as CatalogE6,
                        CatalogE6Id = catalog.Id,
                    };

                    item = newItemE6;
                    break;

                case ItemType.ItemE7:
                    ItemE7 newItemE7 = new ItemE7()
                    {
                        CatalogE7 = catalog as CatalogE7,
                        CatalogE7Id = catalog.Id,
                    };

                    item = newItemE7;
                    break;

                case ItemType.ItemF1:
                    ItemF1 newItemF1 = new ItemF1()
                    {
                        CatalogF1 = catalog as CatalogF1,
                        CatalogF1Id = catalog.Id,
                    };

                    item = newItemF1;
                    break;

                case ItemType.ItemG1:
                    ItemG1 newItemG1 = new ItemG1()
                    {
                        CatalogG1 = catalog as CatalogG1,
                        CatalogG1Id = catalog.Id,
                    };

                    item = newItemG1;
                    break;

                case ItemType.ItemG2:
                    ItemG2 newItemG2 = new ItemG2()
                    {
                        CatalogG2 = catalog as CatalogG2,
                        CatalogG2Id = catalog.Id,
                    };

                    item = newItemG2;
                    break;

                case ItemType.ItemG3:
                    ItemG3 newItemG3 = new ItemG3()
                    {
                        CatalogG3 = catalog as CatalogG3,
                        CatalogG3Id = catalog.Id,
                    };

                    item = newItemG3;
                    break;

                case ItemType.ItemG4:
                    ItemG4 newItemG4 = new ItemG4()
                    {
                        CatalogG4 = catalog as CatalogG4,
                        CatalogG4Id = catalog.Id,
                    };

                    item = newItemG4;
                    break;

                case ItemType.ItemG5:
                    ItemG5 newItemG5 = new ItemG5()
                    {
                        CatalogG5 = catalog as CatalogG5,
                        CatalogG5Id = catalog.Id,
                    };
                                                                                                                         
                    item = newItemG5;
                    break;

                case ItemType.ItemG6:
                    ItemG6 newItemG6 = new ItemG6()
                    {
                        CatalogG6 = catalog as CatalogG6,
                        CatalogG6Id = catalog.Id,
                    };

                    item = newItemG6;
                    break;

                case ItemType.ItemH1:
                    ItemH1 newItemH1 = new ItemH1()
                    {
                        CatalogH1 = catalog as CatalogH1,
                        CatalogH1Id = catalog.Id,
                    };

                    item = newItemH1;
                    break;

                case ItemType.ItemH2:
                    ItemH2 newItemH2 = new ItemH2()
                    {
                        CatalogH2 = catalog as CatalogH2,
                        CatalogH2Id = catalog.Id,
                    };

                    item = newItemH2;
                    break;

                case ItemType.ItemH3:
                    ItemH3 newItemH3 = new ItemH3()
                    {
                        CatalogH3 = catalog as CatalogH3,
                        CatalogH3Id = catalog.Id,
                    };

                    item = newItemH3;
                    break;

                case ItemType.ItemH4:
                    ItemH4 newItemH4 = new ItemH4()
                    {
                        CatalogH4 = catalog as CatalogH4,
                        CatalogH4Id = catalog.Id,
                    };

                    item = newItemH4;
                    break;

                case ItemType.ItemH5:
                    ItemH5 newItemH5 = new ItemH5()
                    {
                        CatalogH5 = catalog as CatalogH5,
                        CatalogH5Id = catalog.Id,
                    };

                    item = newItemH5;
                    break;

                case ItemType.ItemI1:
                    ItemI1 newItemI1 = new ItemI1()
                    {
                        CatalogI1 = catalog as CatalogI1,
                        CatalogI1Id = catalog.Id,
                    };

                    item = newItemI1;
                    break;

                case ItemType.ItemI2:
                    ItemI2 newItemI2 = new ItemI2()
                    {
                        CatalogI2 = catalog as CatalogI2,
                        CatalogI2Id = catalog.Id,
                    };

                    item = newItemI2;
                    break;

                case ItemType.ItemJ1:
                    ItemJ1 newItemJ1 = new ItemJ1()
                    {
                        CatalogJ1 = catalog as CatalogJ1,
                        CatalogJ1Id = catalog.Id,
                    };

                    item = newItemJ1;
                    break;

                case ItemType.ItemK1:
                    ItemK1 newItemK1 = new ItemK1()
                    {
                        CatalogK1 = catalog as CatalogK1,
                        CatalogK1Id = catalog.Id,
                    };

                    item = newItemK1;
                    break;

                case ItemType.ItemK2:
                    ItemK2 newItemK2 = new ItemK2()
                    {
                        CatalogK2 = catalog as CatalogK2,
                        CatalogK2Id = catalog.Id,
                    };

                    item = newItemK2;
                    break;

                case ItemType.ItemK3:
                    ItemK3 newItemK3 = new ItemK3()
                    {
                        CatalogK3 = catalog as CatalogK3,
                        CatalogK3Id = catalog.Id,
                    };

                    item = newItemK3;
                    break;

                default:
                    throw new ArgumentException("Invalid item type.");
            }

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
