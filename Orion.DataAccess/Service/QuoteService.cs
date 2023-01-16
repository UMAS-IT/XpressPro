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
                return context.Quotes.Include(x => x.ItemA1s)
                                     .Include(x => x.ItemA2s)
                                     .Include(x => x.ItemA3s)
                                     .Include(x => x.ItemA4s)
                                     .FirstOrDefault(x => x.Id == quoteId);
            }
        }

        public IList<Quote> GetQuotesForReportsByProjectId(int projectId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<Quote> quotes = context.Quotes
                    .Include(x => x.ItemA1s).ThenInclude(x => x.CatalogA1)
                    .Include(x => x.ItemA1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemA2s).ThenInclude(x => x.CatalogA2)
                    .Include(x => x.ItemA2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemA3s).ThenInclude(x => x.CatalogA3)
                    .Include(x => x.ItemA3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemA4s).ThenInclude(x => x.CatalogA4)
                    .Include(x => x.ItemA4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Where(u => u.ProjectId == projectId).ToList();

                quotes.ForEach(u =>
                {
                    u.CanCreateReports = true;
                    if (!u.ItemA1s.Any() && !u.ItemA2s.Any() && !u.ItemA3s.Any() && !u.ItemA4s.Any())
                        u.CanCreateReports = false;
                });

                return quotes;
            }
        }
    }
}
