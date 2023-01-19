using Orion.Domain.Entity;
using Orion.Domain.EntityItem;
using Orion.Helper.Extension;
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
        private string currentProjectPath;
        private Document mainDocument;

        public void Create(Project project, IList<Quote> quotes)
        {
            PricingA pricingA = new PricingA();
            PricingB pricingB = new PricingB();
            List<PricingItem> pricingItems = new List<PricingItem>();

            currentProjectPath = CreateFolders(project, quotes);

            CopyResource(DocumentResource.ResourcePricing);

            foreach (Quote quote in quotes.Where(x => x.IsSelected))
            {
                int itemNumber = 1;

                mainDocument = LoadDocument(currentProjectPath + $@"\Pricing\{quote.Name.ToUpper()}.docx");

                LoadStarupData(mainDocument, project, quote);

                Section docSection = mainDocument.Sections[0];

                if (quote.ItemA1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingA.CreateA1ItemTable(quote.ItemA1s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemA2s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingA.CreateA2ItemTable(quote.ItemA2s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemA3s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingA.CreateA3ItemTable(quote.ItemA3s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemA4s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingA.CreateA4ItemTable(quote.ItemA4s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemB1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingB.CreateB1ItemTable(quote.ItemB1s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemB2s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingB.CreateB2ItemTable(quote.ItemB2s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemB3s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingB.CreateB3ItemTable(quote.ItemB3s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemB4s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingB.CreateB4ItemTable(quote.ItemB4s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemB5s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingB.CreateB5ItemTable(quote.ItemB5s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }

                CreatePricingTable(pricingItems, docSection);

                AddTermsAndConditions();

                SaveAndConvertToPdf(mainDocument, currentProjectPath + $@"\Pricing\\{quote.Name.ToUpper()}.docx");
            }
        }

        private void AddTermsAndConditions()
        {
            Document document = LoadDocument($@"{TemplatesPath}\TermsAndConditionsTemplate.docx");

            MergerDocuments(document, mainDocument);

            document.Close();
        }

        private void CreatePricingTable(List<PricingItem> pricingItems, Section docSection)
        {
            int itemsQuantity = pricingItems.Count;

            String[] title = { $"Pricing" };
            String[] Header = { "Item", "Tags", "Quantity", "Description", "Price Per Line" };

            string[][] data = new string[pricingItems.Count][];

            for (int i = 0; i < pricingItems.Count; i++)
            {
                PricingItem pricingItem = pricingItems[i];

                data[i] = new string[5] { $"#{pricingItem.ItemNumber}", pricingItem.Tags, pricingItem.Quantity.ToString(), pricingItem.Description, $"{string.Format("{0:C}", Convert.ToDecimal(pricingItem.Price.ToDecimal().Truncate(2)))}" };
            }

            CreateItemTable(docSection, itemsQuantity, title, Header, data);
        }

    }
}
