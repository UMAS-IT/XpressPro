using DocumentFormat.OpenXml.ExtendedProperties;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Domain.EntityItem;
using Orion.Helper.Extension;
using Orion.Helper.Misc;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Report.Pricing
{
    public class PricingReport : ReportSettings
    {
        private Project project;
        private IList<Quote> quotes;
        private bool extendedVersion;
        private QuoteService quoteService;
        public string CurrentProjectPath { get; set; }

        public PricingReport(Project project, IList<Quote> quotes, bool extendedVersion)
        {
            this.quotes = quotes;
            this.project = project;
            this.extendedVersion = extendedVersion;
            quoteService = new QuoteService();
            GetProjectData();
            CreateFolders();
        }

        private void GetProjectData()
        {
            List<Quote> selectedQuotes = new List<Quote>();

            quotes.Where(x => x.IsSelected).ToList().ForEach(x => selectedQuotes.Add(quoteService.GetQuoteForReportsByQuoteId(x.Id)));

            quotes = selectedQuotes;
        }

        private void CreateFolders()
        {
            CurrentProjectPath = CreateFolders(project, quotes);

            CopyResource(DocumentResource.ResourcePricing);
        }

        public void CreatePricingWordReport()
        {
            PricingWordReport pricingWordReport = new PricingWordReport(project, CurrentProjectPath, quotes, extendedVersion);
            pricingWordReport.CreateReport();
        }

        public void CreatePricingExcelReport()
        {
            PricingExcelReport pricingExcelReport = new PricingExcelReport(project, CurrentProjectPath, quotes);
            pricingExcelReport.CreateReport();
        }

    }
}
