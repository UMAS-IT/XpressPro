using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Domain.EntityItem;
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
        public IList<IItem> GetItemsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();
                List<ItemAirCooledChiller> itemAirCooledChillers = context.ItemAirCooledChillers.Include(x => x.Quote).Where(x => x.QuoteId == quoteId).ToList();
                List<ItemPump> itemPumps = context.ItemPumps.Include(x => x.Quote).Where(x => x.QuoteId == quoteId).ToList();
                List<ItemUnit> itemUnits = context.ItemUnits.Include(x => x.Quote).Where(x => x.QuoteId == quoteId).ToList();
                List<ItemVfd> itemVfds = context.ItemVfds.Include(x => x.Quote).Where(x => x.QuoteId == quoteId).ToList();

                items.AddRange(itemAirCooledChillers);
                items.AddRange(itemPumps);
                items.AddRange(itemUnits);
                items.AddRange(itemVfds);

                items = items.OrderBy(x => x.DesignIndex).ToList();

                return items;
            }
        }

        public IList<IItem> UpdateItems(IList<IItem> items, int quoteId)
        {
            throw new NotImplementedException();
        }
    }
}
