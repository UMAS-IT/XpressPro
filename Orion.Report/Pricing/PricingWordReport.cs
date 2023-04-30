using Orion.Domain.Entity;
using Orion.Helper.Misc;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Report.Pricing
{
    public class PricingWordReport : ReportSettings
    {
        private Project project;
        private string currentProjectPath;
        private Document mainDocument;
        private IList<Quote> quotes;
        private bool extendedVersion;

        public PricingWordReport(Project project, string currentProjectPath, IList<Quote> quotes, bool extendedVersion)
        {
            this.project = project;
            this.currentProjectPath = currentProjectPath;
            this.quotes = quotes;
            this.extendedVersion = extendedVersion;
        }

        public void CreateReport()
        {
            GV.Extended = extendedVersion;

            PricingA pricingA = new PricingA();
            PricingB pricingB = new PricingB();
            PricingC pricingC = new PricingC();
            PricingD pricingD = new PricingD();
            PricingE pricingE = new PricingE();
            PricingF pricingF = new PricingF();
            PricingG pricingG = new PricingG();
            PricingH pricingH = new PricingH();
            PricingI pricingI = new PricingI();
            PricingJ pricingJ = new PricingJ();
            PricingK pricingK = new PricingK();
            List<PricingItem> pricingItems = new List<PricingItem>();

            foreach (Quote quote in quotes)
            {
                int itemNumber = 1;

                mainDocument = LoadDocument(currentProjectPath + $@"\Pricing\{quote.Name.ToUpper()}.docx");

                LoadStarupData(mainDocument, project, quote);

                Section docSection = mainDocument.Sections[0];


                if (quote.ItemA1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.AddRange(pricingA.CreateA1ItemTable(quote.ItemA1s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemA1s.ToList<IItem>(), docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemA2s.Any(x => !x.IsExcluded))
                {
                    pricingItems.AddRange(pricingA.CreateA2ItemTable(quote.ItemA2s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemA2s.ToList<IItem>(), docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemA3s.Any(x => !x.IsExcluded))
                {
                    pricingItems.AddRange(pricingA.CreateA3ItemTable(quote.ItemA3s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemA3s.ToList<IItem>(), docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemA4s.Any(x => !x.IsExcluded))
                {
                    pricingItems.AddRange(pricingA.CreateA4ItemTable(quote.ItemA4s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemA4s.ToList<IItem>(), docSection);
                    AddBlankLine(mainDocument, docSection);
                }



                if (quote.ItemB1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.AddRange(pricingB.CreateB1ItemTable(quote.ItemB1s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemB1s.ToList<IItem>(), docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemB5s.Any(x => !x.IsExcluded))
                {
                    pricingItems.AddRange(pricingB.CreateB5ItemTable(quote.ItemB5s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemB5s.ToList<IItem>(), docSection);
                    AddBlankLine(mainDocument, docSection);
                }



                if (quote.ItemC3s.Any(x => !x.IsExcluded))
                {
                    pricingItems.AddRange(pricingC.CreateC3ItemTable(quote.ItemC3s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemC3s.ToList<IItem>(), docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemC4s.Any(x => !x.IsExcluded))
                {
                    pricingItems.AddRange(pricingC.CreateC4ItemTable(quote.ItemC4s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemC4s.ToList<IItem>(), docSection);
                    AddBlankLine(mainDocument, docSection);
                }



                if (quote.ItemE1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.AddRange(pricingE.CreateE1ItemTable(quote.ItemE1s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemE1s.ToList<IItem>(), docSection);
                    AddBlankLine(mainDocument, docSection);
                }



                if (quote.ItemF1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.AddRange(pricingF.CreateF1ItemTable(quote.ItemF1s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemF1s.ToList<IItem>(), docSection);
                    AddBlankLine(mainDocument, docSection);
                }



                if (quote.ItemG1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.AddRange(pricingG.CreateG1ItemTable(quote.ItemG1s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemG1s.ToList<IItem>(), docSection);
                    AddBlankLine(mainDocument, docSection);
                }



                if (quote.ItemH1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.AddRange(pricingH.CreateH1ItemTable(quote.ItemH1s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemH1s.ToList<IItem>(), docSection);
                    AddBlankLine(mainDocument, docSection);
                }



                if (quote.ItemI1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.AddRange(pricingI.CreateI1ItemTable(quote.ItemI1s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemI1s.ToList<IItem>(), docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemI2s.Any(x => !x.IsExcluded))
                {
                    pricingItems.AddRange(pricingI.CreateI2ItemTable(quote.ItemI2s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemI2s.ToList<IItem>(), docSection);
                    AddBlankLine(mainDocument, docSection);
                }

                if (quote.ItemJ1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.AddRange(pricingJ.CreateJ1ItemTable(quote.ItemJ1s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemJ1s.ToList<IItem>(), docSection);
                    AddBlankLine(mainDocument, docSection);
                }

                if (quote.ItemK1s.Any(x => !x.IsExcluded))
                {
                    pricingItems.AddRange(pricingK.CreateK1ItemTable(quote.ItemK1s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemK1s.ToList<IItem>(), docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemK2s.Any(x => !x.IsExcluded))
                {
                    pricingItems.AddRange(pricingK.CreateK2ItemTable(quote.ItemK2s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemK2s.ToList<IItem>(), docSection);
                    AddBlankLine(mainDocument, docSection);
                }
                if (quote.ItemK3s.Any(x => !x.IsExcluded))
                {
                    pricingItems.AddRange(pricingK.CreateK3ItemTable(quote.ItemK3s, mainDocument, docSection, itemNumber++));
                    AddTitlesAndSpecs(quote.ItemK3s.ToList<IItem>(), docSection);
                    AddBlankLine(mainDocument, docSection);
                }

                CreateSummaryTable(pricingItems, docSection);

                CreatePricingTable(pricingItems, docSection);

                AddBlankLine(mainDocument, docSection);

                CreateGrandTotalPriceTable(pricingItems, docSection);

                AddPleaseNote(docSection, project);


                AddTermsAndConditions();

                SaveAndConvertToPdf(mainDocument, currentProjectPath + $@"\Pricing\\{quote.Name.ToUpper()}.docx");

                //Process.Start(currentProjectPath + $@"\Pricing");
                //Process.Start(currentProjectPath + $@"\Pricing\\{quote.Name.ToUpper()}.pdf");
                pricingItems.Clear();
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

                data[i] = new string[5] { $"{GetColumnName(pricingItem.ItemNumber)}", pricingItem.Tags, pricingItem.Quantity.ToString(), pricingItem.Description, pricingItem.Company };
            }

            Table table = CreateItemTable(docSection, summaryPricingItems.Count, title, Header, data, false);

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


            string[][] data = new string[pricingItems.Count][];

            double itemNumber = 0.0;
            bool lastWasSpec = false;
            int baseItemNumber = 0;

            if (!GV.Extended)
            {
                String[] title = { $"Pricing" };
                String[] Header = { "Item", "Tags", "Quantity", "Description", "Price Per Line", "Freight", "Total" };

                for (int i = 0; i < pricingItems.Count; i++)
                {
                    PricingItem pricingItem = pricingItems[i];

                    if (pricingItem.IsSpec && lastWasSpec == false)
                    {
                        lastWasSpec = true;
                        itemNumber += 1;
                        data[i] = new string[7] { $"{GetColumnName(Convert.ToInt32(Math.Floor((decimal)baseItemNumber)))}{itemNumber}", "", "", pricingItem.Description, $"{string.Format("{0:C}", Math.Ceiling(pricingItem.Price))}", "", $"{string.Format("{0:C}", Math.Ceiling(pricingItem.Price))}" };

                    }
                    else if (pricingItem.IsSpec && lastWasSpec == true)
                    {
                        lastWasSpec = true;
                        itemNumber += 1;
                        data[i] = new string[7] { $"{GetColumnName(Convert.ToInt32(Math.Floor((decimal)baseItemNumber)))}{itemNumber}", "", "", pricingItem.Description, $"{string.Format("{0:C}", Math.Ceiling(pricingItem.Price))}", "", $"{string.Format("{0:C}", Math.Ceiling(pricingItem.Price))}" };
                    }
                    else if (pricingItem.IsTitle)
                    {
                        data[i] = new string[7] { $"", pricingItem.Tags, "", pricingItem.Description, "", "", "" };
                    }
                    else
                    {

                        baseItemNumber = pricingItem.ItemNumber;
                        data[i] = new string[7] { $"{GetColumnName(Convert.ToInt32(Math.Floor((decimal)pricingItem.ItemNumber)))}", pricingItem.Tags, pricingItem.Quantity.ToString(), pricingItem.Description, $"{string.Format("{0:C}", Convert.ToDecimal(Math.Ceiling(pricingItem.Price)))}", $"{string.Format("{0:C}", Convert.ToDecimal(pricingItem.Freight))}", $"{string.Format("{0:C}", Convert.ToDecimal(Math.Ceiling(pricingItem.Price) + pricingItem.Freight))}" };
                    }
                }

                CreatePricingItemAndSpecsTable(docSection, itemsQuantity, title, Header, data);
            }
            else
            {
                String[] title = { $"Pricing" };
                String[] Header = { "Item", "Tags", "Quantity", "Description", "Price Each", "Extended Price", "Freight", "Total" };

                for (int i = 0; i < pricingItems.Count; i++)
                {
                    PricingItem pricingItem = pricingItems[i];

                    if (pricingItem.IsSpec && lastWasSpec == false)
                    {
                        lastWasSpec = true;
                        itemNumber += 1;
                        data[i] = new string[8] { $"{GetColumnName(Convert.ToInt32(Math.Floor((decimal)baseItemNumber)))}{itemNumber}", "", "", pricingItem.Description, "", "", "", $"{string.Format("{0:C}", Math.Ceiling(pricingItem.Price))}" };

                    }
                    else if (pricingItem.IsSpec && lastWasSpec == true)
                    {
                        lastWasSpec = true;
                        itemNumber += 1;
                        data[i] = new string[8] { $"{GetColumnName(Convert.ToInt32(Math.Floor((decimal)baseItemNumber)))}{itemNumber}", "", "", pricingItem.Description, "", "", "", $"{string.Format("{0:C}", Math.Ceiling(pricingItem.Price))}" };
                    }
                    else if (pricingItem.IsTitle)
                    {
                        data[i] = new string[8] { $"", pricingItem.Tags, "", pricingItem.Description, "", "", "", "" };
                    }
                    else
                    {
                        baseItemNumber = pricingItem.ItemNumber;

                        data[i] = new string[8] { $"{GetColumnName(Convert.ToInt32(Math.Floor((decimal)pricingItem.ItemNumber)))}", pricingItem.Tags, pricingItem.Quantity.ToString(), $"{pricingItem.Description}", $"{string.Format("{0:C}", Math.Ceiling(pricingItem.Price / pricingItem.Quantity))}", $"{string.Format("{0:C}", Math.Ceiling(pricingItem.Price))}", $"{string.Format("{0:C}", Math.Ceiling(pricingItem.Freight))}", $"{string.Format("{0:C}", Math.Ceiling(pricingItem.Price + pricingItem.Freight))}" };
                    }
                }

                CreatePricingItemAndSpecsTable(docSection, itemsQuantity, title, Header, data);
            }


        }

        private void CreateGrandTotalPriceTable(List<PricingItem> pricingItems, Section docSection)
        {
            string[][] data = new string[1][];

            data[0] = new string[1] { $"{string.Format("{0:C}", pricingItems.Sum(x => Math.Ceiling(x.Price + x.Freight)))}" };

            CreateResultTable(docSection, data);

        }


    }
}
