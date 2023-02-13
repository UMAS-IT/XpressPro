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
            PricingC pricingC = new PricingC();
            PricingD pricingD = new PricingD();
            PricingE pricingE = new PricingE();
            PricingF pricingF = new PricingF();
            PricingG pricingG = new PricingG();
            PricingH pricingH = new PricingH();
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



                if (quote.ItemC1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingC.CreateC1ItemTable(quote.ItemC1s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemC2s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingC.CreateC2ItemTable(quote.ItemC2s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemC3s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingC.CreateC3ItemTable(quote.ItemC3s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemC4s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingC.CreateC4ItemTable(quote.ItemC4s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }


                if (quote.ItemD1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingD.CreateD1ItemTable(quote.ItemD1s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemD2s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingD.CreateD2ItemTable(quote.ItemD2s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }


                if (quote.ItemE1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingE.CreateE1ItemTable(quote.ItemE1s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemE2s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingE.CreateE2ItemTable(quote.ItemE2s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemE3s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingE.CreateE3ItemTable(quote.ItemE3s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemE4s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingE.CreateE4ItemTable(quote.ItemE4s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemE5s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingE.CreateE5ItemTable(quote.ItemE5s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemE6s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingE.CreateE6ItemTable(quote.ItemE6s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemE7s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingE.CreateE7ItemTable(quote.ItemE7s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }


                if (quote.ItemF1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingF.CreateF1ItemTable(quote.ItemF1s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }


                if (quote.ItemG1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingG.CreateG1ItemTable(quote.ItemG1s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemG2s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingG.CreateG2ItemTable(quote.ItemG2s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemG3s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingG.CreateG3ItemTable(quote.ItemG3s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemG4s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingG.CreateG4ItemTable(quote.ItemG4s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemG5s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingG.CreateG5ItemTable(quote.ItemG5s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemG6s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingG.CreateG6ItemTable(quote.ItemG6s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }


                if (quote.ItemH1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingH.CreateH1ItemTable(quote.ItemH1s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemH2s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingH.CreateH2ItemTable(quote.ItemH2s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemH3s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingH.CreateH3ItemTable(quote.ItemH3s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemH4s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingH.CreateH4ItemTable(quote.ItemH4s, mainDocument, docSection, itemNumber++));
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemH5s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingH.CreateH5ItemTable(quote.ItemH5s, mainDocument, docSection, itemNumber++));
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
