using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Domain.EntityItemBACClosedCircuits;
using Orion.Domain.EntityItemBACCoolingTowers;
using Orion.Domain.EntityItemGroundfos;
using Orion.Domain.EntityItemPuroFlux;
using Orion.Domain.EntityItemUvResources;
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
                return context.Quotes.FirstOrDefault(x => x.Id == quoteId);
            }
        }

        public Quote GetQuoteForReportsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.Quotes
                    .Include(x => x.ItemA1s).ThenInclude(x => x.CatalogA1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemA1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemA2s).ThenInclude(x => x.CatalogA2).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemA2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemA3s).ThenInclude(x => x.CatalogA3).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemA3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemA4s).ThenInclude(x => x.CatalogA4).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemA4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)

                    .Include(x => x.ItemB1s).ThenInclude(x => x.CatalogB1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemB1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemB2s).ThenInclude(x => x.CatalogB2).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemB2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemB3s).ThenInclude(x => x.CatalogB3).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemB3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemB4s).ThenInclude(x => x.CatalogB4).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemB4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemB5s).ThenInclude(x => x.CatalogB5).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemB5s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)

                    .Include(x => x.ItemC1s).ThenInclude(x => x.CatalogC1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemC1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemC2s).ThenInclude(x => x.CatalogC2).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemC2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemC3s).ThenInclude(x => x.CatalogC3).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemC3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemC4s).ThenInclude(x => x.CatalogC4).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemC4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)

                    .Include(x => x.ItemD1s).ThenInclude(x => x.CatalogD1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemD1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemD2s).ThenInclude(x => x.CatalogD2).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemD2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)

                    .Include(x => x.ItemE1s).ThenInclude(x => x.CatalogE1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemE1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemE2s).ThenInclude(x => x.CatalogE2).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemE2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemE3s).ThenInclude(x => x.CatalogE3).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemE3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemE4s).ThenInclude(x => x.CatalogE4).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemE4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemE5s).ThenInclude(x => x.CatalogE5).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemE5s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemE6s).ThenInclude(x => x.CatalogE6).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemE6s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemE7s).ThenInclude(x => x.CatalogE7).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemE7s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)

                    .Include(x => x.ItemF1s).ThenInclude(x => x.CatalogF1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemF1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)

                    .Include(x => x.ItemG1s).ThenInclude(x => x.CatalogG1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemG1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemG2s).ThenInclude(x => x.CatalogG2).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemG2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemG3s).ThenInclude(x => x.CatalogG3).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemG3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemG4s).ThenInclude(x => x.CatalogG4).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemG4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemG5s).ThenInclude(x => x.CatalogG5).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemG5s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemG6s).ThenInclude(x => x.CatalogG6).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemG6s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                                       
                    .Include(x => x.ItemH1s).ThenInclude(x => x.CatalogH1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemH1s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemH2s).ThenInclude(x => x.CatalogH2).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemH2s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemH3s).ThenInclude(x => x.CatalogH3).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemH3s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemH4s).ThenInclude(x => x.CatalogH4).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemH4s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemH5s).ThenInclude(x => x.CatalogH5).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.ItemH5s).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)

                    .FirstOrDefault(u => u.Id == quoteId);
            }
        }

        public IList<Quote> GetQuotesForReportsByProjectId(int projectId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<Quote> quotes = context.Quotes
                    .Include(x => x.ItemA1s)
                    .Include(x => x.ItemA2s)
                    .Include(x => x.ItemA3s)
                    .Include(x => x.ItemA4s)

                    .Include(x => x.ItemB1s)
                    .Include(x => x.ItemB2s)
                    .Include(x => x.ItemB3s)
                    .Include(x => x.ItemB4s)
                    .Include(x => x.ItemB5s)

                    .Include(x => x.ItemC1s)
                    .Include(x => x.ItemC2s)
                    .Include(x => x.ItemC3s)
                    .Include(x => x.ItemC4s)

                    .Include(x => x.ItemD1s)
                    .Include(x => x.ItemD2s)

                    .Include(x => x.ItemE1s)
                    .Include(x => x.ItemE2s)
                    .Include(x => x.ItemE3s)
                    .Include(x => x.ItemE4s)
                    .Include(x => x.ItemE5s)
                    .Include(x => x.ItemE6s)
                    .Include(x => x.ItemE7s)

                    .Include(x => x.ItemF1s)

                    .Include(x => x.ItemG1s)
                    .Include(x => x.ItemG2s)
                    .Include(x => x.ItemG3s)
                    .Include(x => x.ItemG4s)
                    .Include(x => x.ItemG5s)
                    .Include(x => x.ItemG6s)

                    .Include(x => x.ItemH1s)
                    .Include(x => x.ItemH2s)
                    .Include(x => x.ItemH3s)
                    .Include(x => x.ItemH4s)
                    .Include(x => x.ItemH5s)

                    .Where(u => u.ProjectId == projectId).ToList();

                quotes.ForEach(u =>
                {
                    u.CanCreateReports = true;
                    if (
                        !u.ItemA1s.Any() && !u.ItemA2s.Any() && !u.ItemA3s.Any() && !u.ItemA4s.Any()
                        && !u.ItemB1s.Any() && !u.ItemB2s.Any() && !u.ItemB3s.Any() && !u.ItemB4s.Any() && !u.ItemB5s.Any()
                        && !u.ItemC1s.Any() && !u.ItemC2s.Any() && !u.ItemC3s.Any() && !u.ItemC4s.Any()
                        && !u.ItemD1s.Any() && !u.ItemD2s.Any()
                        && !u.ItemE1s.Any() && !u.ItemE2s.Any() && !u.ItemE3s.Any() && !u.ItemE4s.Any() && !u.ItemE5s.Any() && !u.ItemE6s.Any() && !u.ItemE7s.Any()
                        && !u.ItemF1s.Any()
                        && !u.ItemG1s.Any() && !u.ItemG2s.Any() && !u.ItemG3s.Any() && !u.ItemG4s.Any() && !u.ItemG5s.Any() && !u.ItemG6s.Any()
                        && !u.ItemH1s.Any() && !u.ItemH2s.Any() && !u.ItemH3s.Any() && !u.ItemH4s.Any() && !u.ItemH5s.Any()
                        )

                        u.CanCreateReports = false;
                });

                return quotes;
            }
        }

        public async Task DeleteQuoteAsync(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                Quote quote = context.Quotes.FirstOrDefault(x => x.Id == quoteId);

                IList<ItemA1> itemA1s = context.ItemA1s.Include(x => x.Titles).Include(x => x.CatalogA1).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemA2> itemA2s = context.ItemA2s.Include(x => x.Titles).Include(x => x.CatalogA2).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemA3> itemA3s = context.ItemA3s.Include(x => x.Titles).Include(x => x.CatalogA3).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemA4> itemA4s = context.ItemA4s.Include(x => x.Titles).Include(x => x.CatalogA4).Where(x => x.QuoteId == quoteId).ToList();

                IList<ItemB1> itemB1s = context.ItemB1s.Include(x => x.Titles).Include(x => x.CatalogB1).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemB2> itemB2s = context.ItemB2s.Include(x => x.Titles).Include(x => x.CatalogB2).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemB3> itemB3s = context.ItemB3s.Include(x => x.Titles).Include(x => x.CatalogB3).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemB4> itemB4s = context.ItemB4s.Include(x => x.Titles).Include(x => x.CatalogB4).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemB5> itemB5s = context.ItemB5s.Include(x => x.Titles).Include(x => x.CatalogB5).Where(x => x.QuoteId == quoteId).ToList();

                IList<ItemC1> itemC1s = context.ItemC1s.Include(x => x.Titles).Include(x => x.CatalogC1).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemC2> itemC2s = context.ItemC2s.Include(x => x.Titles).Include(x => x.CatalogC2).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemC3> itemC3s = context.ItemC3s.Include(x => x.Titles).Include(x => x.CatalogC3).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemC4> itemC4s = context.ItemC4s.Include(x => x.Titles).Include(x => x.CatalogC4).Where(x => x.QuoteId == quoteId).ToList();

                IList<ItemD1> itemD1s = context.ItemD1s.Include(x => x.Titles).Include(x => x.CatalogD1).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemD2> itemD2s = context.ItemD2s.Include(x => x.Titles).Include(x => x.CatalogD2).Where(x => x.QuoteId == quoteId).ToList();

                IList<ItemE1> itemE1s = context.ItemE1s.Include(x => x.Titles).Include(x => x.CatalogE1).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemE2> itemE2s = context.ItemE2s.Include(x => x.Titles).Include(x => x.CatalogE2).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemE3> itemE3s = context.ItemE3s.Include(x => x.Titles).Include(x => x.CatalogE3).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemE4> itemE4s = context.ItemE4s.Include(x => x.Titles).Include(x => x.CatalogE4).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemE5> itemE5s = context.ItemE5s.Include(x => x.Titles).Include(x => x.CatalogE5).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemE6> itemE6s = context.ItemE6s.Include(x => x.Titles).Include(x => x.CatalogE6).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemE7> itemE7s = context.ItemE7s.Include(x => x.Titles).Include(x => x.CatalogE7).Where(x => x.QuoteId == quoteId).ToList();

                IList<ItemF1> itemF1s = context.ItemF1s.Include(x => x.Titles).Include(x => x.CatalogF1).Where(x => x.QuoteId == quoteId).ToList();

                IList<ItemG1> itemG1s = context.ItemG1s.Include(x => x.Titles).Include(x => x.CatalogG1).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemG2> itemG2s = context.ItemG2s.Include(x => x.Titles).Include(x => x.CatalogG2).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemG3> itemG3s = context.ItemG3s.Include(x => x.Titles).Include(x => x.CatalogG3).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemG4> itemG4s = context.ItemG4s.Include(x => x.Titles).Include(x => x.CatalogG4).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemG5> itemG5s = context.ItemG5s.Include(x => x.Titles).Include(x => x.CatalogG5).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemG6> itemG6s = context.ItemG6s.Include(x => x.Titles).Include(x => x.CatalogG6).Where(x => x.QuoteId == quoteId).ToList();

                IList<ItemH1> itemH1s = context.ItemH1s.Include(x => x.Titles).Include(x => x.CatalogH1).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemH2> itemH2s = context.ItemH2s.Include(x => x.Titles).Include(x => x.CatalogH2).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemH3> itemH3s = context.ItemH3s.Include(x => x.Titles).Include(x => x.CatalogH3).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemH4> itemH4s = context.ItemH4s.Include(x => x.Titles).Include(x => x.CatalogH4).Where(x => x.QuoteId == quoteId).ToList();
                IList<ItemH5> itemH5s = context.ItemH5s.Include(x => x.Titles).Include(x => x.CatalogH5).Where(x => x.QuoteId == quoteId).ToList();

                items.AddRange(itemA1s);
                items.AddRange(itemA2s);
                items.AddRange(itemA3s);
                items.AddRange(itemA4s);

                items.AddRange(itemB1s);
                items.AddRange(itemB2s);
                items.AddRange(itemB3s);
                items.AddRange(itemB4s);
                items.AddRange(itemB5s);

                items.AddRange(itemC1s);
                items.AddRange(itemC2s);
                items.AddRange(itemC3s);
                items.AddRange(itemC4s);

                items.AddRange(itemD1s);
                items.AddRange(itemD2s);

                items.AddRange(itemE1s);
                items.AddRange(itemE2s);
                items.AddRange(itemE3s);
                items.AddRange(itemE4s);
                items.AddRange(itemE5s);
                items.AddRange(itemE6s);
                items.AddRange(itemE7s);

                items.AddRange(itemF1s);

                items.AddRange(itemG1s);
                items.AddRange(itemG2s);
                items.AddRange(itemG3s);
                items.AddRange(itemG4s);
                items.AddRange(itemG5s);
                items.AddRange(itemG6s);

                items.AddRange(itemH1s);
                items.AddRange(itemH2s);
                items.AddRange(itemH3s);
                items.AddRange(itemH4s);
                items.AddRange(itemH5s);

                List<Title> titles = items.SelectMany(x => x.Titles).ToList();

                foreach (Title title in titles)
                {
                    context.Remove(title);
                }

                context.Remove(quote);

                await context.SaveChangesAsync();
            }
        }
    }
}
