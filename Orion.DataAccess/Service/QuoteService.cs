using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.DataAccess.Service
{
    public class QuoteService
    {
        public IList<Quote> GetQuotesByProjectId(int projectId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.Quotes.Where(u => u.ProjectId == projectId).ToList();
            }
        }

        public async Task DeleteQuoteAsync(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote quote = context.Quotes.FirstOrDefault(x => x.Id == quoteId);

                context.Remove(quote);

                await context.SaveChangesAsync();
            }
        }

        public async Task CreateQuoteAsync(int projectId, Quote quote)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                Project project = context.Projects.FirstOrDefault(p => p.Id == projectId);
                project.Quotes.Add(quote);

                context.Quotes.Update(quote);
                await context.SaveChangesAsync();
            }
        }

        public bool QuoteInProjectExist(int projectId, string targetQuoteName)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.Projects.Include(p => p.Quotes).FirstOrDefault(p => p.Id == projectId).Quotes.Any(u => u.Name.ToFormat() == targetQuoteName.ToFormat());
            }
        }

        public Quote GetQuoteByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.Quotes.Include(x => x.ItemAirCooledChiller).ThenInclude(x => x.ItemAirCooledChillerCatalogAirCooledChillers).ThenInclude(x => x.CatalogAirCooledChiller)
                                     .Include(x => x.ItemPump).ThenInclude(x => x.ItemPumpCatalogPumps).ThenInclude(x => x.CatalogPump)
                                     .Include(x => x.ItemUnit).ThenInclude(x => x.ItemUnitCatalogUnits).ThenInclude(x => x.CatalogUnit)
                                     .Include(x => x.ItemVfd).ThenInclude(x => x.ItemVfdCatalogVfds).ThenInclude(x => x.CatalogVfd)
                                     .FirstOrDefault(x => x.Id == quoteId);
            }
        }
    }
}
