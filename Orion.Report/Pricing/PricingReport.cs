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
        private string currentProjectPath;
        private Document mainDocument;
        private CompanyService companyService;

        public PricingReport()
        {
            companyService = new CompanyService();
        }

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

            List<Company> companies = companyService.GetCompanies().ToList();

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
                    AddTitlesAndSpecs(quote.ItemA1s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemA2s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingA.CreateA2ItemTable(quote.ItemA2s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemA2s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemA3s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingA.CreateA3ItemTable(quote.ItemA3s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemA3s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemA4s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingA.CreateA4ItemTable(quote.ItemA4s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemA4s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }



                if (quote.ItemB1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.AddRange(pricingB.CreateB1ItemTable(quote.ItemB1s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemB1s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemB2s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingB.CreateB2ItemTable(quote.ItemB2s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemB2s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemB3s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingB.CreateB3ItemTable(quote.ItemB3s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemB3s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemB4s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingB.CreateB4ItemTable(quote.ItemB4s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemB4s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemB5s.Any(x => !x.IsExcluded))
                {
                    pricingItems.AddRange(pricingB.CreateB5ItemTable(quote.ItemB5s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemB5s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }



                if (quote.ItemC1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingC.CreateC1ItemTable(quote.ItemC1s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemC1s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemC2s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingC.CreateC2ItemTable(quote.ItemC2s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemC2s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemC3s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingC.CreateC3ItemTable(quote.ItemC3s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemC3s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemC4s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingC.CreateC4ItemTable(quote.ItemC4s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemC4s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }


                if (quote.ItemD1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingD.CreateD1ItemTable(quote.ItemD1s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemD1s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemD2s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingD.CreateD2ItemTable(quote.ItemD2s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemD2s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }


                if (quote.ItemE1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingE.CreateE1ItemTable(quote.ItemE1s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemE1s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemE2s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingE.CreateE2ItemTable(quote.ItemE2s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemE2s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemE3s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingE.CreateE3ItemTable(quote.ItemE3s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemE3s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemE4s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingE.CreateE4ItemTable(quote.ItemE4s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemE4s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemE5s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingE.CreateE5ItemTable(quote.ItemE5s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemE5s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemE6s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingE.CreateE6ItemTable(quote.ItemE6s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemE6s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemE7s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingE.CreateE7ItemTable(quote.ItemE7s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemE7s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }


                if (quote.ItemF1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingF.CreateF1ItemTable(quote.ItemF1s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemF1s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }


                if (quote.ItemG1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingG.CreateG1ItemTable(quote.ItemG1s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemG1s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemG2s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingG.CreateG2ItemTable(quote.ItemG2s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemG2s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemG3s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingG.CreateG3ItemTable(quote.ItemG3s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemG3s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemG4s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingG.CreateG4ItemTable(quote.ItemG4s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemG4s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemG5s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingG.CreateG5ItemTable(quote.ItemG5s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemG5s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemG6s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingG.CreateG6ItemTable(quote.ItemG6s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemG6s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }


                if (quote.ItemH1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingH.CreateH1ItemTable(quote.ItemH1s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemH1s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemH2s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingH.CreateH2ItemTable(quote.ItemH2s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemH2s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemH3s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingH.CreateH3ItemTable(quote.ItemH3s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemH3s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemH4s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingH.CreateH4ItemTable(quote.ItemH4s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemH4s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemH5s.Any(x => !x.IsExcluded))
                {
                    pricingItems.Add(pricingH.CreateH5ItemTable(quote.ItemH5s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemH5s.ToList<IItem>(), companies, docSection);
                    AddBlankLine(mainDocument, docSection);
                }

                CreateSummaryTable(pricingItems, docSection);

                CreatePricingTable(pricingItems, docSection);
                
                AddBlankLine(mainDocument, docSection);

                CreateGrandTotalPriceTable(pricingItems, docSection);

                AddPleaseNote(docSection, project);


                AddTermsAndConditions();

                SaveAndConvertToPdf(mainDocument, currentProjectPath + $@"\Pricing\\{quote.Name.ToUpper()}.docx");

                Process.Start(currentProjectPath + $@"\Pricing");
                Process.Start(currentProjectPath + $@"\Pricing\\{quote.Name.ToUpper()}.pdf");
            }
        }

        private void CreateSummaryTable(List<PricingItem> pricingItems, Section docSection)
        {
            String[] title = { $"Summary" };
            String[] Header = { "Item", "Tag(s)", "Quantity", "Equipment", "Model" };

            List<PricingItem> summaryPricingItems = pricingItems.Where(x => x.ItemNumber != 0).ToList();

            string[][] data = new string[summaryPricingItems.Count][];

            for (int i = 0; i < summaryPricingItems.Count; i++)
            {
                PricingItem pricingItem = summaryPricingItems[i];

                data[i] = new string[5] { $"{pricingItem.ItemNumber}", pricingItem.Tags, pricingItem.Quantity.ToString(), pricingItem.Description, pricingItem.Company};
            }

            Table table = CreateItemTable(docSection, summaryPricingItems.Count, title, Header, data);

            BookmarksNavigator navigator = new BookmarksNavigator(mainDocument);
            navigator.MoveToBookmark(InitBk.sumaryTable.ToString());
            TextBodyPart part = new TextBodyPart(mainDocument);
            part.BodyItems.Add(table);
            navigator.ReplaceBookmarkContent(part);
        }

        private void AddPleaseNote(Section docSection, Project project)
        {
            Paragraph paragraph = docSection.AddParagraph();
            TextRange textRange = paragraph.AppendText("Please Note:");
            textRange.CharacterFormat.FontName = "Arial Narrow";
            textRange.CharacterFormat.Bold = true;
            paragraph.Format.BeforeSpacing = 0;
            paragraph.Format.AfterSpacing = 0;
            paragraph.Format.LineSpacing = 10;
            textRange.CharacterFormat.FontSize = 10;

            paragraph = docSection.AddParagraph();
            textRange = paragraph.AppendText("Freight is FOB Factory (freight allowed to first destination).");
            textRange.CharacterFormat.FontName = "Arial Narrow";
            paragraph.Format.BeforeSpacing = 0;
            paragraph.Format.AfterSpacing = 0;
            paragraph.Format.LineSpacing = 10;
            textRange.CharacterFormat.FontSize = 10;
            paragraph.ApplyStyle(BuiltinStyle.ListBullet);

            paragraph = docSection.AddParagraph();
            textRange = paragraph.AppendText("Taxes are not included in this proposal.");
            textRange.CharacterFormat.FontName = "Arial Narrow";
            paragraph.Format.BeforeSpacing = 0;
            paragraph.Format.AfterSpacing = 0;
            paragraph.Format.LineSpacing = 10;
            textRange.CharacterFormat.FontSize = 10;
            paragraph.ApplyStyle(BuiltinStyle.ListBullet);

            paragraph = docSection.AddParagraph();
            textRange = paragraph.AppendText("Price is valid 30 days from date on proposal.");
            textRange.CharacterFormat.FontName = "Arial Narrow";
            paragraph.Format.BeforeSpacing = 0;
            paragraph.Format.AfterSpacing = 0;
            paragraph.Format.LineSpacing = 10;
            textRange.CharacterFormat.FontSize = 10;
            paragraph.ApplyStyle(BuiltinStyle.ListBullet);

            paragraph = docSection.AddParagraph();
            textRange = paragraph.AppendText("See attached page for remainder of quotation terms and conditions.");
            textRange.CharacterFormat.FontName = "Arial Narrow";
            paragraph.Format.BeforeSpacing = 0;
            paragraph.Format.AfterSpacing = 0;
            paragraph.Format.LineSpacing = 10;
            textRange.CharacterFormat.FontSize = 10;
            paragraph.ApplyStyle(BuiltinStyle.ListBullet);

            AddBlankLine(mainDocument, docSection);

            paragraph = docSection.AddParagraph();
            textRange = paragraph.AppendText("Thank you for the opportunity to offer the equipment and services listed above.  We look forward to working with you on this project.  If you should require additional information, please contact us.");
            textRange.CharacterFormat.FontName = "Arial Narrow";
            paragraph.Format.BeforeSpacing = 0;
            paragraph.Format.AfterSpacing = 0;
            paragraph.Format.LineSpacing = 10;
            textRange.CharacterFormat.FontSize = 10;

            AddBlankLine(mainDocument, docSection);

            paragraph = docSection.AddParagraph();
            textRange = paragraph.AppendText("Sincerely,");
            textRange.CharacterFormat.FontName = "Arial Narrow";
            paragraph.Format.BeforeSpacing = 0;
            paragraph.Format.AfterSpacing = 0;
            paragraph.Format.LineSpacing = 10;
            textRange.CharacterFormat.FontSize = 10;

            paragraph = docSection.AddParagraph();
            textRange = paragraph.AppendText($"{project.User.Name}");
            textRange.CharacterFormat.FontName = "Arial Narrow";
            paragraph.Format.BeforeSpacing = 0;
            paragraph.Format.AfterSpacing = 0;
            paragraph.Format.LineSpacing = 10;
            textRange.CharacterFormat.FontSize = 10;

            paragraph = docSection.AddParagraph();
            textRange = paragraph.AppendText($"Air Treatment Corporation");
            textRange.CharacterFormat.FontName = "Arial Narrow";
            paragraph.Format.BeforeSpacing = 0;
            paragraph.Format.AfterSpacing = 0;
            paragraph.Format.LineSpacing = 10;
            textRange.CharacterFormat.FontSize = 10;

            paragraph = docSection.AddParagraph();
            textRange = paragraph.AppendText($"{project.User.Email}");
            textRange.CharacterFormat.FontName = "Arial Narrow";
            paragraph.Format.BeforeSpacing = 0;
            paragraph.Format.AfterSpacing = 0;
            paragraph.Format.LineSpacing = 10;
            textRange.CharacterFormat.FontSize = 10;

            paragraph = docSection.AddParagraph();
            textRange = paragraph.AppendText($"{project.User.Telephone}");
            textRange.CharacterFormat.FontName = "Arial Narrow";
            paragraph.Format.BeforeSpacing = 0;
            paragraph.Format.AfterSpacing = 0;
            paragraph.Format.LineSpacing = 10;
            textRange.CharacterFormat.FontSize = 10;
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

            double itemNumber = 0.0;
            bool lastWasSpec = false;

            for (int i = 0; i < pricingItems.Count; i++)
            {
                PricingItem pricingItem = pricingItems[i];

                if (pricingItem.IsSpec && lastWasSpec == false)
                {
                    lastWasSpec = true;
                    itemNumber += 0.01;
                    data[i] = new string[5] { $"{itemNumber}", pricingItem.Tags, "", pricingItem.Description, $"{string.Format("{0:C}", Convert.ToDecimal(pricingItem.Price.ToDecimal().Truncate(2)))}" };

                }
                else if (pricingItem.IsSpec && lastWasSpec == true)
                {
                    lastWasSpec = true;
                    itemNumber += 0.01;
                    data[i] = new string[5] { $"{itemNumber}", pricingItem.Tags, "", pricingItem.Description, $"{string.Format("{0:C}", Convert.ToDecimal(pricingItem.Price.ToDecimal().Truncate(2)))}" };
                }
                else if (pricingItem.IsTitle)
                {
                    data[i] = new string[5] { $"", pricingItem.Tags, "", pricingItem.Description, "" };
                }
                else
                {
                    itemNumber = pricingItem.ItemNumber;
                    data[i] = new string[5] { $"#{pricingItem.ItemNumber}", pricingItem.Tags, pricingItem.Quantity.ToString(), pricingItem.Description, $"{string.Format("{0:C}", Convert.ToDecimal(pricingItem.Price.ToDecimal().Truncate(2)))}" };
                }
            }

            CreatePricingItemAndSpecsTable(docSection, itemsQuantity, title, Header, data);
        }

        private void CreateGrandTotalPriceTable(List<PricingItem> pricingItems, Section docSection)
        {
            string[][] data = new string[1][];

            data[0] = new string[1] { $"{string.Format("{0:C}", Convert.ToDecimal(pricingItems.Sum(x => x.Price.ToDecimal().Truncate(2))))}" };

            CreateResultTable(docSection, data);

        }


    }
}
