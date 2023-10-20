using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Domain.EntityItemBACClosedLoopTowers;
using Orion.Domain.EntityItemBACOpenLoopTowers;
using Orion.Domain.EntityItemGeneralProduct;
using Orion.Domain.EntityItemGroundfos;
using Orion.Domain.EntityItemPuroFlux;
using Orion.Domain.EntityItemUvResources;
using Orion.Domain.Marvair.Item;
using Orion.Domain.Multiaqua.Item;
using Orion.Domain.PACE.Item;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

        public Quote CreateQuote(int projectId, string quoteName)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                Project project = context.Projects.FirstOrDefault(p => p.Id == projectId);

                Quote quote = new Quote()
                {
                    Name = quoteName
                };

                project.Quotes.Add(quote);

                context.SaveChanges();

                return quote;
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
                return context.Quotes.Include(x => x.QuoteCompanies).ThenInclude(x => x.Company).FirstOrDefault(x => x.Id == quoteId);
            }
        }

        public void CloneQuoteCompanies(Quote refQuote, Quote newQuote)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                // Carga el Quote original de la base de datos.
                Quote dbrefQuote = context.Quotes
                    .Include(x => x.QuoteCompanies)
                    .ThenInclude(x => x.Company)
                    .FirstOrDefault(x => x.Id == refQuote.Id);

                Quote dbNewQuote = context.Quotes
                    .Include(x => x.QuoteCompanies)
                    .ThenInclude(x => x.Company)
                    .FirstOrDefault(x => x.Id == newQuote.Id);

                List<Company> dbCompanies = context.Companies.ToList();

                foreach (QuoteCompanies quoteCompany in dbrefQuote.QuoteCompanies)
                {
                    QuoteCompanies newQuoteCompany = new QuoteCompanies()
                    {
                        Quote = dbNewQuote,
                        Company = dbCompanies.FirstOrDefault(x => x.Id == quoteCompany.Company.Id),
                        DesignIndex = quoteCompany.DesignIndex,
                    };
                    dbNewQuote.QuoteCompanies.Add(newQuoteCompany);
                }
                context.SaveChanges();
            }
        }

        public IList<QuoteCompanies> UpdateQuoteCompanies(Quote quote)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                // Carga el Quote original de la base de datos.
                Quote dbQuote = context.Quotes
                    .Include(x => x.QuoteCompanies)
                    .ThenInclude(x => x.Company)
                    .FirstOrDefault(x => x.Id == quote.Id);

                List<Company> dbCompanies = context.Companies.ToList();

                if (dbQuote != null)
                {
                    // Elimina todas las QuoteCompanies existentes para este Quote.
                    context.QuoteCompanies.RemoveRange(dbQuote.QuoteCompanies);

                    foreach (QuoteCompanies quoteCompany in quote.QuoteCompanies)
                    {
                        QuoteCompanies newQuoteCompany = new QuoteCompanies()
                        {
                            Quote = dbQuote,
                            Company = dbCompanies.FirstOrDefault(x => x.Id == quoteCompany.Company.Id),
                            DesignIndex = quoteCompany.DesignIndex,
                        };
                        dbQuote.QuoteCompanies.Add(newQuoteCompany);
                    }

                    // Guarda los cambios en la base de datos.
                    context.SaveChanges();

                    // Devuelve la lista actualizada de QuoteCompanies.
                    return dbQuote.QuoteCompanies.ToList();
                }

                return null; // Puedes manejar el caso si el Quote no se encuentra en la base de datos.
            }
        }
        // [new]
        public Quote GetQuoteForReportsByQuoteId(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                Quote quote = context.Quotes.Include(x => x.QuoteCompanies).ThenInclude(x => x.Company).FirstOrDefault(x => x.Id == quoteId);

                quote.ItemA1s = context.ItemA1s.Include(x => x.CatalogA1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemA2s = context.ItemA2s.Include(x => x.CatalogA2).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemA3s = context.ItemA3s.Include(x => x.CatalogA3).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemA4s = context.ItemA4s.Include(x => x.CatalogA4).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemB1s = context.ItemB1s.Include(x => x.CatalogB1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemB2s = context.ItemB2s.Include(x => x.CatalogB2).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemB3s = context.ItemB3s.Include(x => x.CatalogB3).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemB4s = context.ItemB4s.Include(x => x.CatalogB4).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemB5s = context.ItemB5s.Include(x => x.CatalogB5).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemC1s = context.ItemC1s.Include(x => x.CatalogC1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.CatalogC1).ThenInclude(x => x.CatalogC1ProductType)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemC2s = context.ItemC2s.Include(x => x.CatalogC2).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemC3s = context.ItemC3s.Include(x => x.CatalogC3).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.CatalogC3).ThenInclude(x => x.CatalogC3ProductType)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemC4s = context.ItemC4s.Include(x => x.CatalogC4).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemC5s = context.ItemC5s.Include(x => x.CatalogC5).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemC6s = context.ItemC6s.Include(x => x.CatalogC6).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemC7s = context.ItemC7s.Include(x => x.CatalogC7).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemD1s = context.ItemD1s.Include(x => x.CatalogD1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemD2s = context.ItemD2s.Include(x => x.CatalogD2).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemE1s = context.ItemE1s.Include(x => x.CatalogE1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemE2s = context.ItemE2s.Include(x => x.CatalogE2).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemE3s = context.ItemE3s.Include(x => x.CatalogE3).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemE4s = context.ItemE4s.Include(x => x.CatalogE4).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemE5s = context.ItemE5s.Include(x => x.CatalogE5).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemE6s = context.ItemE6s.Include(x => x.CatalogE6).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemE7s = context.ItemE7s.Include(x => x.CatalogE7).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemF1s = context.ItemF1s.Include(x => x.CatalogF1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemG1s = context.ItemG1s.Include(x => x.CatalogG1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemG2s = context.ItemG2s.Include(x => x.CatalogG2).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemG3s = context.ItemG3s.Include(x => x.CatalogG3).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemG4s = context.ItemG4s.Include(x => x.CatalogG4).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemG5s = context.ItemG5s.Include(x => x.CatalogG5).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemG6s = context.ItemG6s.Include(x => x.CatalogG6).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemH1s = context.ItemH1s.Include(x => x.CatalogH1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemH2s = context.ItemH2s.Include(x => x.CatalogH2).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemH3s = context.ItemH3s.Include(x => x.CatalogH3).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemH4s = context.ItemH4s.Include(x => x.CatalogH4).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemH5s = context.ItemH5s.Include(x => x.CatalogH5).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemI1s = context.ItemI1s.Include(x => x.CatalogI1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemI2s = context.ItemI2s.Include(x => x.CatalogI2).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemJ1s = context.ItemJ1s.Include(x => x.CatalogJ1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemK1s = context.ItemK1s.Include(x => x.CatalogK1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemK2s = context.ItemK2s.Include(x => x.CatalogK2).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemK3s = context.ItemK3s.Include(x => x.CatalogK3).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemL1s = context.ItemL1s.Include(x => x.CatalogL1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                quote.ItemM1s = context.ItemM1s.Include(x => x.CatalogM1).ThenInclude(x => x.DataSheet).ThenInclude(x => x.Titles).ThenInclude(x => x.Specs)
                    .Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.QuoteId == quoteId).ToList();

                return quote;
            }
        }
        // [new]
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
                    .Include(x => x.ItemC5s)
                    .Include(x => x.ItemC6s)
                    .Include(x => x.ItemC7s)

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

                    .Include(x => x.ItemI1s)
                    .Include(x => x.ItemI2s)

                    .Include(x => x.ItemJ1s)

                    .Include(x => x.ItemK1s)
                    .Include(x => x.ItemK2s)
                    .Include(x => x.ItemK3s)

                    .Include(x => x.ItemL1s)

                    .Include(x => x.ItemM1s)

                    .Where(u => u.ProjectId == projectId).ToList();

                quotes.ForEach(u =>
                {
                    u.CanCreateReports = true;
                    if (
                        !u.ItemA1s.Any() && !u.ItemA2s.Any() && !u.ItemA3s.Any() && !u.ItemA4s.Any()
                        && !u.ItemB1s.Any() && !u.ItemB2s.Any() && !u.ItemB3s.Any() && !u.ItemB4s.Any() && !u.ItemB5s.Any()
                        && !u.ItemC1s.Any() && !u.ItemC2s.Any() && !u.ItemC3s.Any() && !u.ItemC4s.Any() && !u.ItemC5s.Any() && !u.ItemC6s.Any() && !u.ItemC7s.Any()
                        && !u.ItemD1s.Any() && !u.ItemD2s.Any()
                        && !u.ItemE1s.Any() && !u.ItemE2s.Any() && !u.ItemE3s.Any() && !u.ItemE4s.Any() && !u.ItemE5s.Any() && !u.ItemE6s.Any() && !u.ItemE7s.Any()
                        && !u.ItemF1s.Any()
                        && !u.ItemG1s.Any() && !u.ItemG2s.Any() && !u.ItemG3s.Any() && !u.ItemG4s.Any() && !u.ItemG5s.Any() && !u.ItemG6s.Any()
                        && !u.ItemH1s.Any() && !u.ItemH2s.Any() && !u.ItemH3s.Any() && !u.ItemH4s.Any() && !u.ItemH5s.Any()
                        && !u.ItemI1s.Any() && !u.ItemI2s.Any()
                        && !u.ItemJ1s.Any()
                        && !u.ItemK1s.Any() && !u.ItemK2s.Any() && !u.ItemK3s.Any() 
                        && !u.ItemL1s.Any()
                        && !u.ItemM1s.Any()
                        )

                        u.CanCreateReports = false;
                });

                return quotes;
            }
        }
        // [new]
        public async Task DeleteQuoteAsync(int quoteId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<IItem> items = new List<IItem>();

                Quote quote = context.Quotes.FirstOrDefault(x => x.Id == quoteId);

                items.AddRange(context.ItemA1s.Include(x => x.Titles).Include(x => x.CatalogA1).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemA2s.Include(x => x.Titles).Include(x => x.CatalogA2).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemA3s.Include(x => x.Titles).Include(x => x.CatalogA3).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemA4s.Include(x => x.Titles).Include(x => x.CatalogA4).Where(x => x.QuoteId == quoteId).ToList());

                items.AddRange(context.ItemB1s.Include(x => x.Titles).Include(x => x.CatalogB1).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemB2s.Include(x => x.Titles).Include(x => x.CatalogB2).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemB3s.Include(x => x.Titles).Include(x => x.CatalogB3).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemB4s.Include(x => x.Titles).Include(x => x.CatalogB4).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemB5s.Include(x => x.Titles).Include(x => x.CatalogB5).Where(x => x.QuoteId == quoteId).ToList());

                items.AddRange(context.ItemC1s.Include(x => x.Titles).Include(x => x.CatalogC1).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemC2s.Include(x => x.Titles).Include(x => x.CatalogC2).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemC3s.Include(x => x.Titles).Include(x => x.CatalogC3).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemC4s.Include(x => x.Titles).Include(x => x.CatalogC4).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemC4s.Include(x => x.Titles).Include(x => x.CatalogC4).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemC4s.Include(x => x.Titles).Include(x => x.CatalogC4).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemC4s.Include(x => x.Titles).Include(x => x.CatalogC4).Where(x => x.QuoteId == quoteId).ToList());
                                                                                                                 
                items.AddRange(context.ItemD1s.Include(x => x.Titles).Include(x => x.CatalogD1).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemD2s.Include(x => x.Titles).Include(x => x.CatalogD2).Where(x => x.QuoteId == quoteId).ToList());
                                                                                                                         
                items.AddRange(context.ItemE1s.Include(x => x.Titles).Include(x => x.CatalogE1).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemE2s.Include(x => x.Titles).Include(x => x.CatalogE2).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemE3s.Include(x => x.Titles).Include(x => x.CatalogE3).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemE4s.Include(x => x.Titles).Include(x => x.CatalogE4).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemE5s.Include(x => x.Titles).Include(x => x.CatalogE5).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemE6s.Include(x => x.Titles).Include(x => x.CatalogE6).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemE7s.Include(x => x.Titles).Include(x => x.CatalogE7).Where(x => x.QuoteId == quoteId).ToList());
                                                                                                              
                items.AddRange(context.ItemF1s.Include(x => x.Titles).Include(x => x.CatalogF1).Where(x => x.QuoteId == quoteId).ToList());
                                                                                                       
                items.AddRange(context.ItemG1s.Include(x => x.Titles).Include(x => x.CatalogG1).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemG2s.Include(x => x.Titles).Include(x => x.CatalogG2).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemG3s.Include(x => x.Titles).Include(x => x.CatalogG3).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemG4s.Include(x => x.Titles).Include(x => x.CatalogG4).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemG5s.Include(x => x.Titles).Include(x => x.CatalogG5).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemG6s.Include(x => x.Titles).Include(x => x.CatalogG6).Where(x => x.QuoteId == quoteId).ToList());
                                                                                                         
                items.AddRange(context.ItemH1s.Include(x => x.Titles).Include(x => x.CatalogH1).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemH2s.Include(x => x.Titles).Include(x => x.CatalogH2).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemH3s.Include(x => x.Titles).Include(x => x.CatalogH3).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemH4s.Include(x => x.Titles).Include(x => x.CatalogH4).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemH5s.Include(x => x.Titles).Include(x => x.CatalogH5).Where(x => x.QuoteId == quoteId).ToList());
                                                                                                        
                items.AddRange(context.ItemI1s.Include(x => x.Titles).Include(x => x.CatalogI1).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemI2s.Include(x => x.Titles).Include(x => x.CatalogI2).Where(x => x.QuoteId == quoteId).ToList());
                                                                                                        
                items.AddRange(context.ItemJ1s.Include(x => x.Titles).Include(x => x.CatalogJ1).Where(x => x.QuoteId == quoteId).ToList());
                                                                                                       
                items.AddRange(context.ItemK1s.Include(x => x.Titles).Include(x => x.CatalogK1).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemK2s.Include(x => x.Titles).Include(x => x.CatalogK2).Where(x => x.QuoteId == quoteId).ToList());
                items.AddRange(context.ItemK3s.Include(x => x.Titles).Include(x => x.CatalogK3).Where(x => x.QuoteId == quoteId).ToList());
                                                                                                                          
                items.AddRange(context.ItemL1s.Include(x => x.Titles).Include(x => x.CatalogL1).Where(x => x.QuoteId == quoteId).ToList());

                items.AddRange(context.ItemM1s.Include(x => x.Titles).Include(x => x.CatalogM1).Where(x => x.QuoteId == quoteId).ToList());

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
