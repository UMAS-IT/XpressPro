using Orion.DataAccess.Misc;
using Orion.Domain.Condair.Item;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using Orion.Helper.Misc;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Orion.Helper.Misc.GV;

namespace Orion.Report.Pricing
{
    public class PricingWordReport : ReportSettings
    {
        private Project project;
        private string currentProjectPath;
        private Document mainDocument;
        private IList<Quote> quotes;
        private bool extendedVersion;
        List<PricingItem> pricingItems;

        // [new]
        public PricingWordReport(Project project, string currentProjectPath, IList<Quote> quotes, bool extendedVersion)
        {
            this.project = project;
            this.currentProjectPath = currentProjectPath;
            this.quotes = quotes;
            this.extendedVersion = extendedVersion;
            this.pricingItems = new List<PricingItem>();
        }

        public void CreateReport()
        {
            GV.Extended = extendedVersion;

            foreach (Quote quote in quotes)
            {
                int itemNumber = 1;

                mainDocument = LoadDocument(currentProjectPath + $@"\Pricing\{project.Name} ({quote.Name.ToUpper()}).docx");

                LoadStarupData(mainDocument, project, quote);

                Section docSection = mainDocument.Sections[0];

                Dictionary<Type, List<IItem>> itemGroups = new Dictionary<Type, List<IItem>>();

                IList<IItem> items = quote.Items;

                foreach (IItem item in items)
                {
                    Type itemClassType = item.GetType();

                    if (!itemGroups.ContainsKey(itemClassType))
                    {
                        itemGroups[itemClassType] = new List<IItem>();
                    }
                    itemGroups[itemClassType].Add(item);
                }

                if (quote.QuoteCompanies != null && quote.QuoteCompanies.Count > 0)
                {
                    foreach (QuoteCompanies quoteCompany in quote.QuoteCompanies.OrderBy(x => x.DesignIndex))
                    {
                        foreach (var itemGroup in itemGroups)
                        {
                            string subfix = itemGroup.Key.Name.ToString().ToUpper();
                            subfix = subfix.Substring(4); // Remover los primeros 4 caracteres
                            subfix = new string(subfix.Where(c => !char.IsDigit(c)).ToArray()); // Remover todos los dígitos

                            if (quoteCompany.Company.Subfix.ToUpper().Trim() == subfix)
                            {
                                PropertyInfo itemListPropertyInfo = quote.GetType().GetProperty(itemGroup.Key.Name + "s");

                                IList<IItem> currentItems = ((IEnumerable)itemListPropertyInfo.GetValue(quote)).Cast<IItem>().ToList();

                                if (currentItems.Any(x => !x.IsExcluded))
                                {
                                    pricingItems.AddRange(CreateItemTable(currentItems, docSection, itemNumber++));
                                    AddTitlesAndSpecs(currentItems, docSection);
                                    AddBlankLine(mainDocument, docSection);
                                }
                            }
                        }
                    }
                }
                else
                {
                    foreach (var itemGroup in itemGroups)
                    {
                        string subfix = itemGroup.Key.Name.ToString().ToUpper();
                        subfix = subfix.Substring(4); // Remover los primeros 4 caracteres
                        subfix = new string(subfix.Where(c => !char.IsDigit(c)).ToArray()); // Remover todos los dígitos

                        PropertyInfo itemListPropertyInfo = quote.GetType().GetProperty(itemGroup.Key.Name + "s");

                        IList<IItem> currentItems = ((IEnumerable)itemListPropertyInfo.GetValue(quote)).Cast<IItem>().ToList();

                        if (currentItems.Any(x => !x.IsExcluded))
                        {
                            pricingItems.AddRange(CreateItemTable(currentItems, docSection, itemNumber++));
                            AddTitlesAndSpecs(currentItems, docSection);
                            AddBlankLine(mainDocument, docSection);
                        }
                    }
                }

                CreateSummaryTable(pricingItems, docSection);

                CreatePricingTable(pricingItems, docSection);

                AddBlankLine(mainDocument, docSection);

                CreateGrandTotalPriceTable(pricingItems, docSection);

                AddPleaseNote(docSection, project);


                AddTermsAndConditions();

                SaveAndConvertToPdf(mainDocument, currentProjectPath + $@"\Pricing\\{project.Name} ({quote.Name.ToUpper()}).docx");
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
                String[] Header = { "Item", "Tags", "Quantity", "Description", "Price Per Line", "Total" };

                for (int i = 0; i < pricingItems.Count; i++)
                {
                    PricingItem pricingItem = pricingItems[i];

                    //spec with price
                    if (pricingItem.IsSpec && lastWasSpec == false)
                    {
                        lastWasSpec = true;
                        itemNumber += 1;
                        data[i] = new string[6] { $"{GetColumnName(Convert.ToInt32(Math.Floor((decimal)baseItemNumber)))}{itemNumber}", "", "", pricingItem.Description, $"{string.Format("{0:C}", (pricingItem.Price).RoundUp())}", $"{string.Format("{0:C}", (pricingItem.Price).RoundUp())}" };

                    }
                    //spec with price
                    else if (pricingItem.IsSpec && lastWasSpec == true)
                    {
                        lastWasSpec = true;
                        itemNumber += 1;
                        data[i] = new string[6] { $"{GetColumnName(Convert.ToInt32(Math.Floor((decimal)baseItemNumber)))}{itemNumber}", "", "", pricingItem.Description, $"{string.Format("{0:C}", (pricingItem.Price).RoundUp())}", $"{string.Format("{0:C}", (pricingItem.Price).RoundUp())}" };
                    }
                    //title
                    else if (pricingItem.IsTitle)
                    {
                        data[i] = new string[6] { $"", pricingItem.Tags, "", pricingItem.Description, "", "" };
                    }
                    // item line
                    else
                    {
                        baseItemNumber = pricingItem.ItemNumber;
                        data[i] = new string[6] { $"{GetColumnName(Convert.ToInt32(Math.Floor((decimal)pricingItem.ItemNumber)))}", pricingItem.Tags, pricingItem.Quantity.ToString(), $"{pricingItem.Item.Catalog.Company}: {pricingItem.Item.Catalog.Product}", $"{string.Format("{0:C}", Convert.ToDecimal((pricingItem.Price).RoundUp()))}", $"{string.Format("{0:C}", Convert.ToDecimal((pricingItem.Price).RoundUp()))}" };
                    }
                }

                CreatePricingItemAndSpecsTable(docSection, itemsQuantity, title, Header, data);
            }
            else
            {
                String[] title = { $"Pricing" };
                String[] Header = { "Item", "Tags", "Quantity", "Description", "Price Each", "Extended Price", "Total" };

                for (int i = 0; i < pricingItems.Count; i++)
                {
                    PricingItem pricingItem = pricingItems[i];

                    if (pricingItem.IsSpec && lastWasSpec == false)
                    {
                        lastWasSpec = true;
                        itemNumber += 1;
                        data[i] = new string[7] { $"{GetColumnName(Convert.ToInt32(Math.Floor((decimal)baseItemNumber)))}{itemNumber}", "", "", pricingItem.Description, "", "", $"{string.Format("{0:C}", (pricingItem.Price).RoundUp())}" };
                    }
                    else if (pricingItem.IsSpec && lastWasSpec == true)
                    {
                        lastWasSpec = true;
                        itemNumber += 1;
                        data[i] = new string[7] { $"{GetColumnName(Convert.ToInt32(Math.Floor((decimal)baseItemNumber)))}{itemNumber}", "", "", pricingItem.Description, "", "", $"{string.Format("{0:C}", (pricingItem.Price).RoundUp())}" };
                    }
                    else if (pricingItem.IsTitle)
                    {
                        data[i] = new string[7] { $"", pricingItem.Tags, "", pricingItem.Description, "", "", "" };
                    }
                    else
                    {
                        baseItemNumber = pricingItem.ItemNumber;

                        data[i] = new string[7] { $"{GetColumnName(Convert.ToInt32(Math.Floor((decimal)pricingItem.ItemNumber)))}", pricingItem.Tags, pricingItem.Quantity.ToString(), $"{pricingItem.Item.Catalog.Company}: {pricingItem.Item.Catalog.Product}", $"{string.Format("{0:C}", (pricingItem.Price / pricingItem.Quantity).RoundUp())}", $"{string.Format("{0:C}", (pricingItem.Price).RoundUp())}", $"{string.Format("{0:C}", (pricingItem.Price).RoundUp())}" };
                    }
                }

                CreatePricingItemAndSpecsTable(docSection, itemsQuantity, title, Header, data);
            }


        }

        private void CreateGrandTotalPriceTable(List<PricingItem> pricingItems, Section docSection)
        {
            string[][] data = new string[1][];

            data[0] = new string[1] { $"{string.Format("{0:C}", pricingItems.Sum(x => (x.Price).RoundUp()))}" };

            CreateResultTable(docSection, data);

        }


    }
}
