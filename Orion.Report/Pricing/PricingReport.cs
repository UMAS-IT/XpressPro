using Orion.Domain.Entity;
using Orion.Helper.Misc;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Report.Pricing
{
    public class PricingReport : ReportSettings
    {
        private Project project;
        private string currentProjectPath;
        private Document mainDocument;

        public PricingReport(Project project)
        {
            this.project = project;
        }

        public void Create()
        {
            PricingA pricingA = new PricingA();


            currentProjectPath = CreateFolders(project);
            CopyResource(DocumentResource.ResourcePricing);

            foreach (Quote quote in project.Quotes.Where(x => x.IsSelected))
            {
                mainDocument = LoadDocument(currentProjectPath + $@"\Pricing\{quote.Name.ToUpper()}.docx");


            }
        }

    }
}
