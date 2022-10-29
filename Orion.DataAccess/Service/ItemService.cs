using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalog;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemCatalog;
using Orion.Helper.Extension;
using Orion.Helper.Misc;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Orion.DataAccess.Service
{
    public class ItemService
    {
        public IList<IItemICatalog> GetItemCatalogsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItemICatalog> itemICatalogs = new List<IItemICatalog>();

                Quote quote = context.Quotes.Include(x => x.ItemAirCooledChiller)
                                            .Include(x => x.ItemPump)
                                            .Include(x => x.ItemUnit)
                                            .Include(x => x.ItemVfd)
                                            .FirstOrDefault(x => x.Id == quoteId);

                IList<ItemAirCooledChillerCatalogAirCooledChiller> airCooledChillerItems = context.ItemAirCooledChillerCatalogAirCooledChillers.Include(x => x.ItemAirCooledChiller).Include(x => x.CatalogAirCooledChiller).Where(x => x.ItemId == quote.ItemAirCooledChiller.Id).ToList();

                IList<ItemUnitCatalogUnit> itemUnitCatalogUnits = context.ItemUnitCatalogUnits.Include(x => x.ItemUnit).Include(x => x.CatalogUnit).Where(x => x.ItemId == quote.ItemUnit.Id).ToList();

                IList<ItemPumpCatalogPump> itemPumpCatalogPumps = context.ItemPumpCatalogPumps.Include(x => x.ItemPump).Include(x => x.CatalogPump).Where(x => x.ItemId == quote.ItemPump.Id).ToList();

                IList<ItemVfdCatalogVfd> itemVfdCatalogVfds = context.ItemVfdCatalogVfds.Include(x => x.ItemVfd).Include(x => x.CatalogVfd).Where(x => x.ItemId == quote.ItemVfd.Id).ToList();

                itemICatalogs.AddRange(airCooledChillerItems);
                itemICatalogs.AddRange(itemUnitCatalogUnits);
                itemICatalogs.AddRange(itemPumpCatalogPumps);
                itemICatalogs.AddRange(itemVfdCatalogVfds);

                itemICatalogs = itemICatalogs.OrderBy(x => x.DesignIndex).ToList();

                return itemICatalogs;
            }
        }

        public IList<IItem> UpdateItems(IList<IItem> items, int quoteId)
        {
            throw new NotImplementedException();
        }
    }
}
