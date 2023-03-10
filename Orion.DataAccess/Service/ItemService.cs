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
                case ItemType.A1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemA1s).ThenInclude(x => x.CatalogA1)
                        .Include(x => x.ItemA1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.A2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemA2s).ThenInclude(x => x.CatalogA2)
                        .Include(x => x.ItemA2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.A3:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemA3s).ThenInclude(x => x.CatalogA3)
                        .Include(x => x.ItemA3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.A4:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemA4s).ThenInclude(x => x.CatalogA4)
                        .Include(x => x.ItemA4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.B1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemB1s).ThenInclude(x => x.CatalogB1)
                        .Include(x => x.ItemB1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.B2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemB2s).ThenInclude(x => x.CatalogB2)
                        .Include(x => x.ItemB2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.B3:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemB3s).ThenInclude(x => x.CatalogB3)
                        .Include(x => x.ItemB3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.B4:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemB4s).ThenInclude(x => x.CatalogB4)
                        .Include(x => x.ItemB4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.B5:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemB5s).ThenInclude(x => x.CatalogB5)
                        .Include(x => x.ItemB5s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.C1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemC1s).ThenInclude(x => x.CatalogC1)
                        .Include(x => x.ItemC1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.C2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemC2s).ThenInclude(x => x.CatalogC2)
                        .Include(x => x.ItemC2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.C3:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemC3s).ThenInclude(x => x.CatalogC3)
                        .Include(x => x.ItemC3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.C4:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemC4s).ThenInclude(x => x.CatalogC4)
                        .Include(x => x.ItemC4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.D1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemD1s).ThenInclude(x => x.CatalogD1)
                        .Include(x => x.ItemD1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.D2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemD2s).ThenInclude(x => x.CatalogD2)
                        .Include(x => x.ItemD2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.E1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemE1s).ThenInclude(x => x.CatalogE1)
                        .Include(x => x.ItemE1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.E2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemE2s).ThenInclude(x => x.CatalogE2)
                        .Include(x => x.ItemE2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.E3:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemE3s).ThenInclude(x => x.CatalogE3)
                        .Include(x => x.ItemE3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.E4:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemE4s).ThenInclude(x => x.CatalogE4)
                        .Include(x => x.ItemE4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.E5:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemE5s).ThenInclude(x => x.CatalogE5)
                        .Include(x => x.ItemE5s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.E6:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemE6s).ThenInclude(x => x.CatalogE6)
                        .Include(x => x.ItemE6s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.E7:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemE7s).ThenInclude(x => x.CatalogE7)
                        .Include(x => x.ItemE7s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.F1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemF1s).ThenInclude(x => x.CatalogF1).ThenInclude(x => x.CatalogF1ProductType)
                        .Include(x => x.ItemF1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.G1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemG1s).ThenInclude(x => x.CatalogG1)
                        .Include(x => x.ItemG1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.G2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemG2s).ThenInclude(x => x.CatalogG2)
                        .Include(x => x.ItemG2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.G3:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemG3s).ThenInclude(x => x.CatalogG3)
                        .Include(x => x.ItemG3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.G4:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemG4s).ThenInclude(x => x.CatalogG4)
                        .Include(x => x.ItemG4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.G5:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemG5s).ThenInclude(x => x.CatalogG5)
                        .Include(x => x.ItemG5s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.G6:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemG6s).ThenInclude(x => x.CatalogG6)
                        .Include(x => x.ItemG6s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.H1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemH1s).ThenInclude(x => x.CatalogH1)
                        .Include(x => x.ItemH1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.H2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemH2s).ThenInclude(x => x.CatalogH2)
                        .Include(x => x.ItemH2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.H3:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemH3s).ThenInclude(x => x.CatalogH3)
                        .Include(x => x.ItemH3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.H4:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemH4s).ThenInclude(x => x.CatalogH4)
                        .Include(x => x.ItemH4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;

                case ItemType.H5:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemH5s).ThenInclude(x => x.CatalogH5)
                        .Include(x => x.ItemH5s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
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
                case ItemType.A1:
                    ItemA1 newItemA1 = item as ItemA1;
                    newItemA1.CatalogA1 = catalogs.OfType<CatalogA1>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemA1s.Add(newItemA1);
                    break;

                case ItemType.A2:
                    ItemA2 newItemA2 = item as ItemA2;
                    newItemA2.CatalogA2 = catalogs.OfType<CatalogA2>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemA2s.Add(newItemA2);
                    break;

                case ItemType.A3:
                    ItemA3 newItemA3 = item as ItemA3;
                    newItemA3.CatalogA3 = catalogs.OfType<CatalogA3>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemA3s.Add(newItemA3);
                    break;

                case ItemType.A4:
                    ItemA4 newItemA4 = item as ItemA4;
                    newItemA4.CatalogA4 = catalogs.OfType<CatalogA4>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemA4s.Add(newItemA4);
                    break;

                case ItemType.B1:
                    ItemB1 newItemB1 = item as ItemB1;
                    newItemB1.CatalogB1 = catalogs.OfType<CatalogB1>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemB1s.Add(newItemB1);
                    break;

                case ItemType.B2:
                    ItemB2 newItemB2 = item as ItemB2;
                    newItemB2.CatalogB2 = catalogs.OfType<CatalogB2>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemB2s.Add(newItemB2);
                    break;

                case ItemType.B3:
                    ItemB3 newItemB3 = item as ItemB3;
                    newItemB3.CatalogB3 = catalogs.OfType<CatalogB3>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemB3s.Add(newItemB3);
                    break;

                case ItemType.B4:
                    ItemB4 newItemB4 = item as ItemB4;
                    newItemB4.CatalogB4 = catalogs.OfType<CatalogB4>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemB4s.Add(newItemB4);
                    break;

                case ItemType.B5:
                    ItemB5 newItemB5 = item as ItemB5;
                    newItemB5.CatalogB5 = catalogs.OfType<CatalogB5>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemB5s.Add(newItemB5);
                    break;

                case ItemType.C1:
                    ItemC1 newItemC1 = item as ItemC1;
                    newItemC1.CatalogC1 = catalogs.OfType<CatalogC1>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemC1s.Add(newItemC1);
                    break;

                case ItemType.C2:
                    ItemC2 newItemC2 = item as ItemC2;
                    newItemC2.CatalogC2 = catalogs.OfType<CatalogC2>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemC2s.Add(newItemC2);
                    break;

                case ItemType.C3:
                    ItemC3 newItemC3 = item as ItemC3;
                    newItemC3.CatalogC3 = catalogs.OfType<CatalogC3>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemC3s.Add(newItemC3);
                    break;

                case ItemType.C4:
                    ItemC4 newItemC4 = item as ItemC4;
                    newItemC4.CatalogC4 = catalogs.OfType<CatalogC4>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemC4s.Add(newItemC4);
                    break;

                case ItemType.D1:
                    ItemD1 newItemD1 = item as ItemD1;
                    newItemD1.CatalogD1 = catalogs.OfType<CatalogD1>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemD1s.Add(newItemD1);
                    break;

                case ItemType.D2:
                    ItemD2 newItemD2 = item as ItemD2;
                    newItemD2.CatalogD2 = catalogs.OfType<CatalogD2>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemD2s.Add(newItemD2);
                    break;
                case ItemType.E1:
                    ItemE1 newItemE1 = item as ItemE1;
                    newItemE1.CatalogE1 = catalogs.OfType<CatalogE1>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemE1s.Add(newItemE1);
                    break;

                case ItemType.E2:
                    ItemE2 newItemE2 = item as ItemE2;
                    newItemE2.CatalogE2 = catalogs.OfType<CatalogE2>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemE2s.Add(newItemE2);
                    break;

                case ItemType.E3:
                    ItemE3 newItemE3 = item as ItemE3;
                    newItemE3.CatalogE3 = catalogs.OfType<CatalogE3>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemE3s.Add(newItemE3);
                    break;

                case ItemType.E4:
                    ItemE4 newItemE4 = item as ItemE4;
                    newItemE4.CatalogE4 = catalogs.OfType<CatalogE4>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemE4s.Add(newItemE4);
                    break;

                case ItemType.E5:
                    ItemE5 newItemE5 = item as ItemE5;
                    newItemE5.CatalogE5 = catalogs.OfType<CatalogE5>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemE5s.Add(newItemE5);
                    break;

                case ItemType.E6:
                    ItemE6 newItemE6 = item as ItemE6;
                    newItemE6.CatalogE6 = catalogs.OfType<CatalogE6>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemE6s.Add(newItemE6);
                    break;

                case ItemType.E7:
                    ItemE7 newItemE7 = item as ItemE7;
                    newItemE7.CatalogE7 = catalogs.OfType<CatalogE7>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemE7s.Add(newItemE7);
                    break;

                case ItemType.F1:
                    ItemF1 newItemF1 = item as ItemF1;
                    newItemF1.CatalogF1 = catalogs.OfType<CatalogF1>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemF1s.Add(newItemF1);
                    break;

                case ItemType.G1:
                    ItemG1 newItemG1 = item as ItemG1;
                    newItemG1.CatalogG1 = catalogs.OfType<CatalogG1>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemG1s.Add(newItemG1);
                    break;

                case ItemType.G2:
                    ItemG2 newItemG2 = item as ItemG2;
                    newItemG2.CatalogG2 = catalogs.OfType<CatalogG2>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemG2s.Add(newItemG2);
                    break;

                case ItemType.G3:
                    ItemG3 newItemG3 = item as ItemG3;
                    newItemG3.CatalogG3 = catalogs.OfType<CatalogG3>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemG3s.Add(newItemG3);
                    break;

                case ItemType.G4:
                    ItemG4 newItemG4 = item as ItemG4;
                    newItemG4.CatalogG4 = catalogs.OfType<CatalogG4>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemG4s.Add(newItemG4);
                    break;

                case ItemType.G5:
                    ItemG5 newItemG5 = item as ItemG5;
                    newItemG5.CatalogG5 = catalogs.OfType<CatalogG5>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemG5s.Add(newItemG5);
                    break;

                case ItemType.G6:
                    ItemG6 newItemG6 = item as ItemG6;
                    newItemG6.CatalogG6 = catalogs.OfType<CatalogG6>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemG6s.Add(newItemG6);
                    break;

                case ItemType.H1:
                    ItemH1 newItemH1 = item as ItemH1;
                    newItemH1.CatalogH1 = catalogs.OfType<CatalogH1>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemH1s.Add(newItemH1);
                    break;

                case ItemType.H2:
                    ItemH2 newItemH2 = item as ItemH2;
                    newItemH2.CatalogH2 = catalogs.OfType<CatalogH2>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemH2s.Add(newItemH2);
                    break;

                case ItemType.H3:
                    ItemH3 newItemH3 = item as ItemH3;
                    newItemH3.CatalogH3 = catalogs.OfType<CatalogH3>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemH3s.Add(newItemH3);
                    break;

                case ItemType.H4:
                    ItemH4 newItemH4 = item as ItemH4;
                    newItemH4.CatalogH4 = catalogs.OfType<CatalogH4>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemH4s.Add(newItemH4);
                    break;

                case ItemType.H5:
                    ItemH5 newItemH5 = item as ItemH5;
                    newItemH5.CatalogH5 = catalogs.OfType<CatalogH5>().FirstOrDefault(x => x.Id == item.CatalogId);
                    quote.ItemH5s.Add(newItemH5);
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
                case ItemType.A1:
                    dbItems = quote.ItemA1s.ToList<IItem>();
                    break;
                case ItemType.A2:
                    dbItems = quote.ItemA2s.ToList<IItem>();
                    break;
                case ItemType.A3:
                    dbItems = quote.ItemA3s.ToList<IItem>();
                    break;
                case ItemType.A4:
                    dbItems = quote.ItemA4s.ToList<IItem>();
                    break;
                case ItemType.B1:
                    dbItems = quote.ItemB1s.ToList<IItem>();
                    break;
                case ItemType.B2:
                    dbItems = quote.ItemB2s.ToList<IItem>();
                    break;
                case ItemType.B3:
                    dbItems = quote.ItemB3s.ToList<IItem>();
                    break;
                case ItemType.B4:
                    dbItems = quote.ItemB4s.ToList<IItem>();
                    break;
                case ItemType.B5:
                    dbItems = quote.ItemB5s.ToList<IItem>();
                    break;
                case ItemType.C1:
                    dbItems = quote.ItemC1s.ToList<IItem>();
                    break;
                case ItemType.C2:
                    dbItems = quote.ItemC2s.ToList<IItem>();
                    break;
                case ItemType.C3:
                    dbItems = quote.ItemC3s.ToList<IItem>();
                    break;
                case ItemType.C4:
                    dbItems = quote.ItemC4s.ToList<IItem>();
                    break;
                case ItemType.D1:
                    dbItems = quote.ItemD1s.ToList<IItem>();
                    break;
                case ItemType.D2:
                    dbItems = quote.ItemD2s.ToList<IItem>();
                    break;
                case ItemType.E1:
                    dbItems = quote.ItemE1s.ToList<IItem>();
                    break;
                case ItemType.E2:
                    dbItems = quote.ItemE2s.ToList<IItem>();
                    break;
                case ItemType.E3:
                    dbItems = quote.ItemE3s.ToList<IItem>();
                    break;
                case ItemType.E4:
                    dbItems = quote.ItemE4s.ToList<IItem>();
                    break;
                case ItemType.E5:
                    dbItems = quote.ItemE5s.ToList<IItem>();
                    break;
                case ItemType.E6:
                    dbItems = quote.ItemE6s.ToList<IItem>();
                    break;
                case ItemType.E7:
                    dbItems = quote.ItemE7s.ToList<IItem>();
                    break;
                case ItemType.F1:
                    dbItems = quote.ItemF1s.ToList<IItem>();
                    break;
                case ItemType.G1:
                    dbItems = quote.ItemG1s.ToList<IItem>();
                    break;
                case ItemType.G2:
                    dbItems = quote.ItemG2s.ToList<IItem>();
                    break;
                case ItemType.G3:
                    dbItems = quote.ItemG3s.ToList<IItem>();
                    break;
                case ItemType.G4:
                    dbItems = quote.ItemG4s.ToList<IItem>();
                    break;
                case ItemType.G5:
                    dbItems = quote.ItemG5s.ToList<IItem>();
                    break;
                case ItemType.G6:
                    dbItems = quote.ItemG6s.ToList<IItem>();
                    break;
                case ItemType.H1:
                    dbItems = quote.ItemH1s.ToList<IItem>();
                    break;
                case ItemType.H2:
                    dbItems = quote.ItemH2s.ToList<IItem>();
                    break;
                case ItemType.H3:
                    dbItems = quote.ItemH3s.ToList<IItem>();
                    break;
                case ItemType.H4:
                    dbItems = quote.ItemH4s.ToList<IItem>();
                    break;
                case ItemType.H5:
                    dbItems = quote.ItemH5s.ToList<IItem>();
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
                case ItemType.A1:
                    dbItem = quote.ItemA1s.First(x => x.Id == item.Id);
                    break;
                case ItemType.A2:
                    dbItem = quote.ItemA2s.First(x => x.Id == item.Id);
                    break;
                case ItemType.A3:
                    dbItem = quote.ItemA3s.First(x => x.Id == item.Id);
                    break;
                case ItemType.A4:
                    dbItem = quote.ItemA4s.First(x => x.Id == item.Id);
                    break;
                case ItemType.B1:
                    dbItem = quote.ItemB1s.First(x => x.Id == item.Id);
                    break;
                case ItemType.B2:
                    dbItem = quote.ItemB2s.First(x => x.Id == item.Id);
                    break;
                case ItemType.B3:
                    dbItem = quote.ItemB3s.First(x => x.Id == item.Id);
                    break;
                case ItemType.B4:
                    dbItem = quote.ItemB4s.First(x => x.Id == item.Id);
                    break;
                case ItemType.B5:
                    dbItem = quote.ItemB5s.First(x => x.Id == item.Id);
                    break;
                case ItemType.C1:
                    dbItem = quote.ItemC1s.First(x => x.Id == item.Id);
                    break;
                case ItemType.C2:
                    dbItem = quote.ItemC2s.First(x => x.Id == item.Id);
                    break;
                case ItemType.C3:
                    dbItem = quote.ItemC3s.First(x => x.Id == item.Id);
                    break;
                case ItemType.C4:
                    dbItem = quote.ItemC4s.First(x => x.Id == item.Id);
                    break;
                case ItemType.D1:
                    dbItem = quote.ItemD1s.First(x => x.Id == item.Id);
                    break;
                case ItemType.D2:
                    dbItem = quote.ItemD2s.First(x => x.Id == item.Id);
                    break;
                case ItemType.E1:
                    dbItem = quote.ItemE1s.First(x => x.Id == item.Id);
                    break;
                case ItemType.E2:
                    dbItem = quote.ItemE2s.First(x => x.Id == item.Id);
                    break;
                case ItemType.E3:
                    dbItem = quote.ItemE3s.First(x => x.Id == item.Id);
                    break;
                case ItemType.E4:
                    dbItem = quote.ItemE4s.First(x => x.Id == item.Id);
                    break;
                case ItemType.E5:
                    dbItem = quote.ItemE5s.First(x => x.Id == item.Id);
                    break;
                case ItemType.E6:
                    dbItem = quote.ItemE6s.First(x => x.Id == item.Id);
                    break;
                case ItemType.E7:
                    dbItem = quote.ItemE7s.First(x => x.Id == item.Id);
                    break;
                case ItemType.F1:
                    dbItem = quote.ItemF1s.First(x => x.Id == item.Id);
                    break;
                case ItemType.G1:
                    dbItem = quote.ItemG1s.First(x => x.Id == item.Id);
                    break;
                case ItemType.G2:
                    dbItem = quote.ItemG2s.First(x => x.Id == item.Id);
                    break;
                case ItemType.G3:
                    dbItem = quote.ItemG3s.First(x => x.Id == item.Id);
                    break;
                case ItemType.G4:
                    dbItem = quote.ItemG4s.First(x => x.Id == item.Id);
                    break;
                case ItemType.G5:
                    dbItem = quote.ItemG5s.First(x => x.Id == item.Id);
                    break;
                case ItemType.G6:
                    dbItem = quote.ItemG6s.First(x => x.Id == item.Id);
                    break;
                case ItemType.H1:
                    dbItem = quote.ItemH1s.First(x => x.Id == item.Id);
                    break;
                case ItemType.H2:
                    dbItem = quote.ItemH2s.First(x => x.Id == item.Id);
                    break;
                case ItemType.H3:
                    dbItem = quote.ItemH3s.First(x => x.Id == item.Id);
                    break;
                case ItemType.H4:
                    dbItem = quote.ItemH4s.First(x => x.Id == item.Id);
                    break;
                case ItemType.H5:
                    dbItem = quote.ItemH5s.First(x => x.Id == item.Id);
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

            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemA1>().ToList<IItem>(), ItemType.A1));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemA2>().ToList<IItem>(), ItemType.A2));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemA3>().ToList<IItem>(), ItemType.A3));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemA4>().ToList<IItem>(), ItemType.A4));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemB1>().ToList<IItem>(), ItemType.B1));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemB2>().ToList<IItem>(), ItemType.B2));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemB3>().ToList<IItem>(), ItemType.B3));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemB4>().ToList<IItem>(), ItemType.B4));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemB5>().ToList<IItem>(), ItemType.B5));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemC1>().ToList<IItem>(), ItemType.C1));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemC2>().ToList<IItem>(), ItemType.C2));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemC3>().ToList<IItem>(), ItemType.C3));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemC4>().ToList<IItem>(), ItemType.C4));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemD1>().ToList<IItem>(), ItemType.D1));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemD2>().ToList<IItem>(), ItemType.D2));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemE1>().ToList<IItem>(), ItemType.E1));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemE2>().ToList<IItem>(), ItemType.E2));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemE3>().ToList<IItem>(), ItemType.E3));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemE4>().ToList<IItem>(), ItemType.E4));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemE5>().ToList<IItem>(), ItemType.E5));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemE6>().ToList<IItem>(), ItemType.E6));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemE7>().ToList<IItem>(), ItemType.E7));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemF1>().ToList<IItem>(), ItemType.F1));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemG1>().ToList<IItem>(), ItemType.G1));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemG2>().ToList<IItem>(), ItemType.G2));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemG3>().ToList<IItem>(), ItemType.G3));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemG4>().ToList<IItem>(), ItemType.G4));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemG5>().ToList<IItem>(), ItemType.G5));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemG6>().ToList<IItem>(), ItemType.G6));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemH1>().ToList<IItem>(), ItemType.H1));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemH2>().ToList<IItem>(), ItemType.H2));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemH3>().ToList<IItem>(), ItemType.H3));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemH4>().ToList<IItem>(), ItemType.H4));
            itemsToReturn.AddRange(UpdateItems(quote, items.OfType<ItemH5>().ToList<IItem>(), ItemType.H5));

            return itemsToReturn;
        }

        public IList<IItem> GetAllItemByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
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
                items.AddRange(context.ItemC3s.Include(x => x.CatalogC3).Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList());
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

                items = items.OrderBy(x => x.DesignIndex).ToList();

                return items;
            }
        }

    }

}
