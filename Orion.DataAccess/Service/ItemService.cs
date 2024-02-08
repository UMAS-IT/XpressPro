using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Orion.DataAccess.DataBase;
using Orion.DataAccess.Misc;
using Orion.Domain.ABOVEAIR.Item;
using Orion.Domain.AERCO.Related;
using Orion.Domain.BACClosedLoopTowers.Related;
using Orion.Domain.BACOpenLoopTowers.Related;
using Orion.Domain.Baldor.Item;
using Orion.Domain.Condair.Item;
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
using Orion.Domain.EnviroTec.Related;
using Orion.Domain.Groundfos.Related;
using Orion.Domain.LYNC.Item;
using Orion.Domain.Marvair;
using Orion.Domain.Marvair.Catalog;
using Orion.Domain.Marvair.Item;
using Orion.Domain.Multiaqua.Catalog;
using Orion.Domain.Multiaqua.Item;
using Orion.Domain.Nortek.Item;
using Orion.Domain.NYLE.Item;
using Orion.Domain.PACE.Catalog;
using Orion.Domain.PACE.Item;
using Orion.Domain.PlasmaAir.Item;
using Orion.Domain.Polaris.Item;
using Orion.Domain.PVI.Item;
using Orion.Domain.Quantech.Related;
using Orion.Domain.Robur.Item;
using Orion.Domain.UMAS.Item;
using Orion.Domain.Valent.Item;
using Orion.Domain.Whalen.Item;
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

                case ItemType.ItemN1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemN1s).ThenInclude(x => x.CatalogN1)
                        .Include(x => x.ItemN1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemO1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemO1s).ThenInclude(x => x.CatalogO1)
                        .Include(x => x.ItemO1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemO2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemO2s).ThenInclude(x => x.CatalogO2)
                        .Include(x => x.ItemO2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemP1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemP1s).ThenInclude(x => x.CatalogP1)
                        .Include(x => x.ItemP1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemQ1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemQ1s).ThenInclude(x => x.CatalogQ1)
                        .Include(x => x.ItemQ1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemQ2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemQ2s).ThenInclude(x => x.CatalogQ2)
                        .Include(x => x.ItemQ2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemQ3:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemQ3s).ThenInclude(x => x.CatalogQ3)
                        .Include(x => x.ItemQ3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemQ4:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemQ4s).ThenInclude(x => x.CatalogQ4)
                        .Include(x => x.ItemQ4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemR1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemR1s).ThenInclude(x => x.CatalogR1)
                        .Include(x => x.ItemR1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemR2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemR2s).ThenInclude(x => x.CatalogR2)
                        .Include(x => x.ItemR2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemR3:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemR3s).ThenInclude(x => x.CatalogR3)
                        .Include(x => x.ItemR3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemR4:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemR4s).ThenInclude(x => x.CatalogR4)
                        .Include(x => x.ItemR4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemS1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemS1s).ThenInclude(x => x.CatalogS1)
                        .Include(x => x.ItemS1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemT1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemT1s).ThenInclude(x => x.CatalogT1)
                        .Include(x => x.ItemT1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemT2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemT2s).ThenInclude(x => x.CatalogT2)
                        .Include(x => x.ItemT2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemT3:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemT3s).ThenInclude(x => x.CatalogT3)
                        .Include(x => x.ItemT3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemU1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemU1s).ThenInclude(x => x.CatalogU1)
                        .Include(x => x.ItemU1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemV1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemV1s).ThenInclude(x => x.CatalogV1)
                        .Include(x => x.ItemV1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemW1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemW1s).ThenInclude(x => x.CatalogW1)
                        .Include(x => x.ItemW1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemX1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemX1s).ThenInclude(x => x.CatalogX1)
                        .Include(x => x.ItemX1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemX2:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemX2s).ThenInclude(x => x.CatalogX2)
                        .Include(x => x.ItemX2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemX3:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemX3s).ThenInclude(x => x.CatalogX3)
                        .Include(x => x.ItemX3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemX4:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemX4s).ThenInclude(x => x.CatalogX4)
                        .Include(x => x.ItemX4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemX5:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemX5s).ThenInclude(x => x.CatalogX5)
                        .Include(x => x.ItemX5s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemY1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemY1s).ThenInclude(x => x.CatalogY1)
                        .Include(x => x.ItemY1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemZ1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemZ1s).ThenInclude(x => x.CatalogZ1)
                        .Include(x => x.ItemZ1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                        .FirstOrDefault(x => x.Id == quote.Id);
                    break;
                case ItemType.ItemAA1:
                    dbQuote = context.Quotes
                        .Include(x => x.ItemAA1s).ThenInclude(x => x.CatalogAA1)
                        .Include(x => x.ItemAA1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
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
                        else if (dbItem is ItemN1)
                        {
                            ItemN1 itemN = item as ItemN1;
                            ItemN1 dbItemN1 = dbItem as ItemN1;

                            dbItemN1.Model = itemN.Model;
                            dbItemN1.Cfm = itemN.Cfm;
                            dbItemN1.Voltage = itemN.Voltage;
                            dbItemN1.CoolingCapacity = itemN.CoolingCapacity;
                            dbItemN1.Refrigerant = itemN.Refrigerant;
                        }
                        else if (dbItem is ItemO)
                        {
                            ItemO itemO = item as ItemO;
                            ItemO dbItemO = dbItem as ItemO;

                            dbItemO.Model = itemO.Model;
                            dbItemO.FuelType = itemO.FuelType;
                            dbItemO.Capacity = itemO.Capacity;
                            dbItemO.Voltage = itemO.Voltage;
                        }
                        else if (dbItem is ItemP1)
                        {
                            ItemP1 itemP1 = item as ItemP1;
                            ItemP1 dbItemP1 = dbItem as ItemP1;

                            dbItemP1.Model = itemP1.Model;
                            dbItemP1.Frame = itemP1.Frame;
                            dbItemP1.Hp = itemP1.Hp;
                            dbItemP1.Rpm = itemP1.Rpm;
                            dbItemP1.Voltage = itemP1.Voltage;
                            dbItemP1.Enclosure = itemP1.Enclosure;
                            dbItemP1.Efficiency = itemP1.Efficiency;
                            dbItemP1.Weight = itemP1.Weight;
                        }
                        else if (dbItem is ItemQ1)
                        {
                            ItemQ1 itemQ1 = item as ItemQ1;
                            ItemQ1 dbItemQ1 = dbItem as ItemQ1;

                            dbItemQ1.Model = itemQ1.Model;
                            dbItemQ1.Capacity = itemQ1.Capacity;
                            dbItemQ1.Voltage = itemQ1.Voltage;
                        }
                        else if (dbItem is ItemQ2)
                        {
                            ItemQ2 itemQ2 = item as ItemQ2;
                            ItemQ2 dbItemQ2 = dbItem as ItemQ2;

                            dbItemQ2.Model = itemQ2.Model;
                            dbItemQ2.WaterType = itemQ2.WaterType;
                            dbItemQ2.LbsHr = itemQ2.LbsHr;
                            dbItemQ2.Voltage = itemQ2.Voltage;
                        }
                        else if (dbItem is ItemQ3)
                        {
                            ItemQ3 itemQ3 = item as ItemQ3;
                            ItemQ3 dbItemQ3 = dbItem as ItemQ3;

                            dbItemQ3.Model = itemQ3.Model;
                            dbItemQ3.RateCapacity = itemQ3.RateCapacity;
                            dbItemQ3.RoSystemOutput = itemQ3.RoSystemOutput;
                            dbItemQ3.Voltage = itemQ3.Voltage;
                        }
                        else if (dbItem is ItemQ4)
                        {
                            ItemQ4 itemQ4 = item as ItemQ4;
                            ItemQ4 dbItemQ4 = dbItem as ItemQ4;

                            dbItemQ4.Model = itemQ4.Model;
                            dbItemQ4.Capacity = itemQ4.Capacity;
                            dbItemQ4.Distributor = itemQ4.Distributor;
                            dbItemQ4.Voltage = itemQ4.Voltage;
                        }
                        else if (dbItem is ItemR)
                        {
                            ItemR itemR = item as ItemR;
                            ItemR dbItemR = dbItem as ItemR;

                            dbItemR.Model = itemR.Model;
                            dbItemR.Cfm = itemR.Cfm;
                            dbItemR.ChwCapacity = itemR.ChwCapacity;
                            dbItemR.ChwRowsFpi = itemR.ChwRowsFpi;
                            dbItemR.HwCapacity = itemR.HwCapacity;
                            dbItemR.HwRowsFpi = itemR.HwRowsFpi;
                            dbItemR.Voltage = itemR.Voltage;
                        }
                        else if (dbItem is ItemS1)
                        {
                            ItemS1 itemS1 = item as ItemS1;
                            ItemS1 dbItemS1 = dbItem as ItemS1;

                            dbItemS1.Model = itemS1.Model;
                            dbItemS1.HeatingCapacity = itemS1.HeatingCapacity;
                            dbItemS1.CoolingCapacity = itemS1.CoolingCapacity;
                            dbItemS1.Refrigerant = itemS1.Refrigerant;
                            dbItemS1.Voltage = itemS1.Voltage;
                        }
                        else if (dbItem is ItemT1)
                        {
                            ItemT1 itemT1 = item as ItemT1;
                            ItemT1 dbItemT1 = dbItem as ItemT1;

                            dbItemT1.Model = itemT1.Model;
                            dbItemT1.Cfm = itemT1.Cfm;
                            dbItemT1.Size = itemT1.Size;
                            dbItemT1.Rows = itemT1.Rows;
                            dbItemT1.Fpi = itemT1.Fpi;
                        }
                        else if (dbItem is ItemT2)
                        {
                            ItemT2 itemT2 = item as ItemT2;
                            ItemT2 dbItemT2 = dbItem as ItemT2;

                            dbItemT2.Model = itemT2.Model;
                            dbItemT2.Cfm = itemT2.Cfm;
                            dbItemT2.Voltage = itemT2.Voltage;
                        }
                        else if (dbItem is ItemT3)
                        {
                            ItemT3 itemT3 = item as ItemT3;
                            ItemT3 dbItemT3 = dbItem as ItemT3;

                            dbItemT3.Model = itemT3.Model;
                            dbItemT3.Cfm = itemT3.Cfm;
                            dbItemT3.Tsp = itemT3.Tsp;
                            dbItemT3.Bhp = itemT3.Bhp;
                            dbItemT3.TotalHp = itemT3.TotalHp;
                            dbItemT3.VfdHp = itemT3.VfdHp;
                            dbItemT3.ActiveFans = itemT3.ActiveFans;
                            dbItemT3.FanArrays = itemT3.FanArrays;
                            dbItemT3.Cell = itemT3.Cell;
                            dbItemT3.Array = itemT3.Array;
                        }
                        else if (dbItem is ItemU1)
                        {
                            ItemU1 itemU1 = item as ItemU1;
                            ItemU1 dbItemU1 = dbItem as ItemU1;

                            dbItemU1.Model = itemU1.Model;
                            dbItemU1.HeatingCapacity = itemU1.HeatingCapacity;
                            dbItemU1.CoolingCapacity = itemU1.CoolingCapacity;
                            dbItemU1.Compressor = itemU1.Compressor;
                            dbItemU1.Voltage = itemU1.Voltage;
                        }
                        else if (dbItem is ItemV1)
                        {
                            ItemV1 itemV1 = item as ItemV1;
                            ItemV1 dbItemV1 = dbItem as ItemV1;

                            dbItemV1.Model = itemV1.Model;
                            dbItemV1.AirFlowCapacity = itemV1.AirFlowCapacity;
                            dbItemV1.NoIonizationModules = itemV1.NoIonizationModules;
                            dbItemV1.Voltage = itemV1.Voltage;
                        }
                        else if (dbItem is ItemW1)
                        {
                            ItemW1 itemW1 = item as ItemW1;
                            ItemW1 dbItemW1 = dbItem as ItemW1;

                            dbItemW1.Model = itemW1.Model;
                            dbItemW1.Cfm = itemW1.Cfm;
                            dbItemW1.HotSideGpm = itemW1.HotSideGpm;
                            dbItemW1.HotSideEwt = itemW1.HotSideEwt;
                            dbItemW1.ColdSideGpm = itemW1.ColdSideGpm;
                            dbItemW1.ColdSideEwt = itemW1.ColdSideEwt;
                        }
                        else if (dbItem is ItemX1)
                        {
                            ItemX1 itemX1 = item as ItemX1;
                            ItemX1 dbItemX1 = dbItem as ItemX1;

                            dbItemX1.Model = itemX1.Model;
                            dbItemX1.Weight = itemX1.Weight;
                        }
                        else if (dbItem is ItemX2)
                        {
                            ItemX2 itemX2 = item as ItemX2;
                            ItemX2 dbItemX2 = dbItem as ItemX2;

                            dbItemX2.Model = itemX2.Model;
                            dbItemX2.Capacity = itemX2.Capacity;
                        }
                        else if (dbItem is ItemX3)
                        {
                            ItemX3 itemX3 = item as ItemX3;
                            ItemX3 dbItemX3 = dbItem as ItemX3;

                            dbItemX3.Model = itemX3.Model;
                            dbItemX3.Tank = itemX3.Tank;
                            dbItemX3.Connection = itemX3.Connection;
                            dbItemX3.Location = itemX3.Location;
                        }
                        else if (dbItem is ItemX4)
                        {
                            ItemX4 itemX4 = item as ItemX4;
                            ItemX4 dbItemX4 = dbItem as ItemX4;

                            dbItemX4.Model = itemX4.Model;
                            dbItemX4.Weight = itemX4.Weight;
                        }
                        else if (dbItem is ItemX5)
                        {
                            ItemX5 itemX5 = item as ItemX5;
                            ItemX5 dbItemX5 = dbItem as ItemX5;

                            dbItemX5.Model = itemX5.Model;
                            dbItemX5.Weight = itemX5.Weight;
                        }
                        else if (dbItem is ItemY1)
                        {
                            ItemY1 itemY1 = item as ItemY1;
                            ItemY1 dbItemY1 = dbItem as ItemY1;

                            dbItemY1.Model = itemY1.Model;
                            dbItemY1.CoolingNominalTons = itemY1.CoolingNominalTons;
                            dbItemY1.HeatingMbhOutput = itemY1.HeatingMbhOutput;
                            dbItemY1.Fuel = itemY1.Fuel;
                            dbItemY1.Voltage = itemY1.Voltage;
                        }
                        else if (dbItem is ItemZ1)
                        {
                            ItemZ1 itemZ1 = item as ItemZ1;
                            ItemZ1 dbItemZ1 = dbItem as ItemZ1;

                            dbItemZ1.Model = itemZ1.Model;
                            dbItemZ1.Cfm = itemZ1.Cfm;
                            dbItemZ1.Voltage = itemZ1.Voltage;
                        }
                        else if (dbItem is ItemAA1)
                        {
                            ItemAA1 itemAA1 = item as ItemAA1;
                            ItemAA1 dbItemAA1 = dbItem as ItemAA1;

                            dbItemAA1.Model = itemAA1.Model;
                            dbItemAA1.Voltage = itemAA1.Voltage;
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
            // Para ItemN1
            items.AddRange(context.ItemN1s
                .Include(x => x.CatalogN1)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemO1
            items.AddRange(context.ItemO1s
                .Include(x => x.CatalogO1)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemO2
            items.AddRange(context.ItemO2s
                .Include(x => x.CatalogO2)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemP1
            items.AddRange(context.ItemP1s
                .Include(x => x.CatalogP1)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemQ1
            items.AddRange(context.ItemQ1s
                .Include(x => x.CatalogQ1)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemQ2
            items.AddRange(context.ItemQ2s
                .Include(x => x.CatalogQ2)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemQ3
            items.AddRange(context.ItemQ3s
                .Include(x => x.CatalogQ3)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemQ4
            items.AddRange(context.ItemQ4s
                .Include(x => x.CatalogQ4)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemR1
            items.AddRange(context.ItemR1s
                .Include(x => x.CatalogR1)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemR2
            items.AddRange(context.ItemR2s
                .Include(x => x.CatalogR2)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemR3
            items.AddRange(context.ItemR3s
                .Include(x => x.CatalogR3)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemR4
            items.AddRange(context.ItemR4s
                .Include(x => x.CatalogR4)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemS1
            items.AddRange(context.ItemS1s
                .Include(x => x.CatalogS1)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemT1
            items.AddRange(context.ItemT1s
                .Include(x => x.CatalogT1)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemT2
            items.AddRange(context.ItemT2s
                .Include(x => x.CatalogT2)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemT3
            items.AddRange(context.ItemT3s
                .Include(x => x.CatalogT3)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemU1
            items.AddRange(context.ItemU1s
                .Include(x => x.CatalogU1)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemV1
            items.AddRange(context.ItemV1s
                .Include(x => x.CatalogV1)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemW1
            items.AddRange(context.ItemW1s
                .Include(x => x.CatalogW1)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemX1
            items.AddRange(context.ItemX1s
                .Include(x => x.CatalogX1)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemX2
            items.AddRange(context.ItemX2s
                .Include(x => x.CatalogX2)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemX3
            items.AddRange(context.ItemX3s
                .Include(x => x.CatalogX3)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemX4
            items.AddRange(context.ItemX4s
                .Include(x => x.CatalogX4)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemX5
            items.AddRange(context.ItemX5s
                .Include(x => x.CatalogX5)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemY1
            items.AddRange(context.ItemY1s
                .Include(x => x.CatalogY1)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemZ1
            items.AddRange(context.ItemZ1s
                .Include(x => x.CatalogZ1)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

            // Para ItemAA1
            items.AddRange(context.ItemAA1s
                .Include(x => x.CatalogAA1)
                .Include(x => x.Titles).ThenInclude(x => x.Specs)
                .Where(x => x.QuoteId == quoteId)
                .ToList());

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
