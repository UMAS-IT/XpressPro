using ClosedXML.Excel;
using Microsoft.SqlServer.Server;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using Orion.Helper.Misc;
using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Orion.Report.Pricing
{
    public class ReportSettings
    {
        public const string TemplatesPath = @"C:\temp\XPressPro Templates";

        public const string ProjectsPath = @"C:\temp\XPressPro Projects";

        public string pricingFilePath = Environment.CurrentDirectory + @"\ResourcePricing\PricingTemplate.docx";

        public String[] CreateSectionTitle(IItem item, int itemNumber)
        {
            return new[] { $"Item {GetColumnName(itemNumber)}) {item.Catalog.Company} : {item.Catalog.Product}" };
        }

        public string JoinTags(IList<IItem> items)
        {
            string tags = "";

            //items.ToList().ForEach(x => tags += $"[{x.Tag}]({x.Quantity}) ");
            items.ToList().ForEach(x => tags += $"[{x.Tag}] ");
            return tags;
        }
        public int JoinQuantities(IList<IItem> items)
        {
            int qty = 0;

            items.ToList().ForEach(x => qty += x.Quantity);

            return qty;
        }

        public double JoinSellPrices(IList<IItem> items)
        {
            double sellPrice = 0;

            items.ToList().ForEach(x => sellPrice += x.OverridePrice ? Math.Ceiling(x.Quantity * x.SellPrice) : Math.Ceiling(x.Quantity * x.Catalog.SellPrice));

            return sellPrice;

        }

        public double JoinFreights(IList<IItem> items)
        {
            return Math.Ceiling(items.Sum(x => x.Freight));
        }

        public string GetColumnName(int number)
        {
            if (number < 1)
            {
                throw new ArgumentException("Number must be a positive integer.");
            }

            StringBuilder columnName = new StringBuilder();

            while (number > 0)
            {
                int remainder = (number - 1) % 26;
                columnName.Insert(0, (char)(65 + remainder));
                number = (number - 1) / 26;
            }

            return columnName.ToString();
        }



        public Table CreateItemTable(Section docSection, int itemsQuantity, string[] sectionTitle, string[] Header, string[][] data, bool KeepInSamePage = true)
        {
            Table table = docSection.AddTable(true);
            table.TableFormat.IsBreakAcrossPages = false;

            table.ResetCells(itemsQuantity + 2, Header.Length);
            table.TableFormat.HorizontalAlignment = RowAlignment.Center;

            TableRow titleRow = table.Rows[0];

            titleRow.RowFormat.BackColor = Color.FromArgb(155, 194, 230);

            Paragraph tp = titleRow.Cells[0].AddParagraph();
            titleRow.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            tp.Format.HorizontalAlignment = HorizontalAlignment.Center;
            tp.Format.BeforeSpacing = 0;
            tp.Format.AfterSpacing = 0;
            tp.Format.LineSpacing = 10;
            TextRange tRange = tp.AppendText(sectionTitle[0]);
            tRange.CharacterFormat.FontName = "Arial Narrow";
            tRange.CharacterFormat.FontSize = 10;
            tRange.CharacterFormat.TextColor = Color.Black;
            tRange.CharacterFormat.Bold = true;

            table.ApplyHorizontalMerge(0, 0, Header.Count() - 1);

            TableRow headerRow = table.Rows[1];

            headerRow.RowFormat.BackColor = Color.FromArgb(155, 194, 230);


            for (int i = 0; i < Header.Length; i++)
            {

                table.Rows[0].Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                TableCell cell = headerRow.Cells[i];
                cell.CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                Paragraph paragraph = headerRow.Cells[i].AddParagraph();
                paragraph.Format.HorizontalAlignment = HorizontalAlignment.Center;
                paragraph.Format.BeforeSpacing = 0;
                paragraph.Format.AfterSpacing = 0;
                paragraph.Format.LineSpacing = 10;
                TextRange textRange = paragraph.AppendText(Header[i]);
                textRange.CharacterFormat.FontName = "Arial Narrow";
                textRange.CharacterFormat.FontSize = 10;
                textRange.CharacterFormat.TextColor = Color.Black;
                textRange.CharacterFormat.Bold = true;
            }


            for (int r = 0; r < data.Length; r++)
            {
                TableRow DataRow = table.Rows[r + 2];

                for (int c = 0; c < data[r].Length; c++)
                {
                    TableCell cell = DataRow.Cells[c];

                    cell.CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                    Paragraph p2 = DataRow.Cells[c].AddParagraph();

                    TextRange TR2 = p2.AppendText(data[r][c]);

                    p2.Format.HorizontalAlignment = HorizontalAlignment.Center;
                    p2.Format.BeforeSpacing = 0;
                    p2.Format.AfterSpacing = 0;
                    p2.Format.LineSpacing = 10;
                    TR2.CharacterFormat.FontName = "Arial Narrow";
                    TR2.CharacterFormat.FontSize = 10;
                    TR2.CharacterFormat.TextColor = Color.Black;
                }
            }
            table.AutoFit(AutoFitBehaviorType.AutoFitToWindow);
            if (KeepInSamePage)
            {
                KeepTableInSamePage(table);
            }
            return table;
        }

        public void CreatePricingItemAndSpecsTable(Section docSection, int itemsQuantity, string[] sectionTitle, string[] Header, string[][] data)
        {
            Table table = docSection.AddTable(true);
            table.TableFormat.IsBreakAcrossPages = false;

            table.ResetCells(itemsQuantity + 2, Header.Length);
            table.TableFormat.HorizontalAlignment = RowAlignment.Center;

            TableRow titleRow = table.Rows[0];

            titleRow.RowFormat.BackColor = Color.FromArgb(155, 194, 230);

            Paragraph tp = titleRow.Cells[0].AddParagraph();
            titleRow.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            tp.Format.HorizontalAlignment = HorizontalAlignment.Center;
            tp.Format.BeforeSpacing = 0;
            tp.Format.AfterSpacing = 0;
            tp.Format.LineSpacing = 10;
            TextRange tRange = tp.AppendText(sectionTitle[0]);
            tRange.CharacterFormat.FontName = "Arial Narrow";
            tRange.CharacterFormat.FontSize = 10;
            tRange.CharacterFormat.TextColor = Color.Black;
            tRange.CharacterFormat.Bold = true;

            table.ApplyHorizontalMerge(0, 0, Header.Count() - 1);

            TableRow headerRow = table.Rows[1];

            headerRow.RowFormat.BackColor = Color.FromArgb(155, 194, 230);


            for (int i = 0; i < Header.Length; i++)
            {

                table.Rows[0].Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                TableCell cell = headerRow.Cells[i];
                cell.CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                Paragraph paragraph = headerRow.Cells[i].AddParagraph();
                paragraph.Format.HorizontalAlignment = HorizontalAlignment.Center;
                paragraph.Format.BeforeSpacing = 0;
                paragraph.Format.AfterSpacing = 0;
                paragraph.Format.LineSpacing = 10;
                TextRange textRange = paragraph.AppendText(Header[i]);
                textRange.CharacterFormat.FontName = "Arial Narrow";
                textRange.CharacterFormat.FontSize = 10;
                textRange.CharacterFormat.TextColor = Color.Black;
                textRange.CharacterFormat.Bold = true;
            }


            for (int r = 0; r < data.Length; r++)
            {
                TableRow DataRow = table.Rows[r + 2];

                bool itemNumberEmpty = string.IsNullOrWhiteSpace(data[r][0]);
                bool itemQuantityEmpty = string.IsNullOrWhiteSpace(data[r][2]);


                for (int c = 0; c < data[r].Length; c++)
                {

                    TableCell cell = DataRow.Cells[c];
                     
                    cell.CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                    Paragraph p2 = DataRow.Cells[c].AddParagraph();

                    TextRange TR2 = p2.AppendText(data[r][c]);

                    p2.Format.HorizontalAlignment = HorizontalAlignment.Center;
                    p2.Format.BeforeSpacing = 0;
                    p2.Format.AfterSpacing = 0;
                    p2.Format.LineSpacing = 10;

                    if (itemNumberEmpty && itemQuantityEmpty)
                    {
                        TR2.CharacterFormat.FontName = "Arial Narrow";
                        TR2.CharacterFormat.FontSize = 10;
                        TR2.CharacterFormat.Bold = true;
                        //cell.CellFormat.BackColor = Color.FromArgb(0, 135, 176, 54);
                        //cell.CellFormat.BackColor = Color.DarkCyan;
                        TR2.CharacterFormat.TextColor = Color.DarkBlue;
                    }
                    else if (!itemNumberEmpty && !itemQuantityEmpty)
                    {
                        TR2.CharacterFormat.FontName = "Arial Narrow";
                        TR2.CharacterFormat.FontSize = 10;
                        TR2.CharacterFormat.TextColor = Color.Black;
                        //cell.CellFormat.BackColor = Color.FromArgb(0, 255, 204, 102);
                        //cell.CellFormat.BackColor = Color.FromArgb(0, 135, 176, 54);

                        TR2.CharacterFormat.Bold = true;
                    }
                    else
                    {
                        TR2.CharacterFormat.FontName = "Arial Narrow";
                        TR2.CharacterFormat.FontSize = 10;
                        TR2.CharacterFormat.TextColor = Color.Black;
                        if (c == 3)
                            p2.ApplyStyle(BuiltinStyle.ListBullet);
                    }
                }
            }
            table.AutoFit(AutoFitBehaviorType.AutoFitToWindow);

            KeepTableInSamePage(table);
        }

        public void CreateResultTable(Section docSection, string[][] data)
        {
            Table table = docSection.AddTable(true);
            table.TableFormat.IsBreakAcrossPages = false;

            table.ResetCells(2, 1);
            table.TableFormat.HorizontalAlignment = RowAlignment.Center;

            TableRow titleRow = table.Rows[0];

            titleRow.RowFormat.BackColor = Color.FromArgb(155, 194, 230);

            Paragraph tp = titleRow.Cells[0].AddParagraph();
            titleRow.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            tp.Format.HorizontalAlignment = HorizontalAlignment.Center;
            tp.Format.BeforeSpacing = 0;
            tp.Format.AfterSpacing = 0;
            tp.Format.LineSpacing = 10;
            TextRange tRange = tp.AppendText("Grand Total");
            tRange.CharacterFormat.FontName = "Arial Narrow";
            tRange.CharacterFormat.FontSize = 10;
            tRange.CharacterFormat.TextColor = Color.Black;
            tRange.CharacterFormat.Bold = true;

            for (int r = 0; r < data.Length; r++)
            {
                TableRow DataRow = table.Rows[r + 1];

                for (int c = 0; c < data[r].Length; c++)
                {
                    TableCell cell = DataRow.Cells[c];

                    cell.CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                    Paragraph p2 = DataRow.Cells[c].AddParagraph();

                    TextRange TR2 = p2.AppendText(data[r][c]);

                    p2.Format.HorizontalAlignment = HorizontalAlignment.Left;
                    p2.Format.BeforeSpacing = 0;
                    p2.Format.AfterSpacing = 0;
                    p2.Format.LineSpacing = 10;
                    TR2.CharacterFormat.FontName = "Arial Narrow";
                    TR2.CharacterFormat.FontSize = 10;
                    TR2.CharacterFormat.TextColor = Color.Black;
                }
            }
            table.TableFormat.HorizontalAlignment = RowAlignment.Right;
            table.AutoFit(AutoFitBehaviorType.AutoFitToContents);
            KeepTableInSamePage(table);

        }




        public void SaveAndConvertToPdf(Document document, string filePath)
        {
            document.SaveToFile(filePath, FileFormat.Docx);

            document.Close();

            document = new Document();

            document.LoadFromFile(filePath);

            document.SaveToFile(Path.ChangeExtension(filePath, ".pdf"), FileFormat.PDF);

            document.Close();
        }

        public void SetSectionMargin(Section section, float value)
        {

            section.PageSetup.Margins.Top = section.PageSetup.Margins.Left = section.PageSetup.Margins.Right = section.PageSetup.Margins.Bottom = value;

            section.PageSetup.PageSize = PageSize.A4;
        }

        public void KeepTableInSamePage(Table table)
        {
            foreach (TableRow tableRow in table.Rows)
            {
                TableCell cell = tableRow.Cells.FirstItem as TableCell;
                foreach (Paragraph paragraph in cell.Paragraphs)
                {
                    paragraph.Format.KeepFollow = true;
                }
            }
        }

        public void AddBlankLine(Document document, Section docSection)
        {
            //Paragraph paragraph = new Paragraph(document);
            //paragraph.AppendText("");
            //TextBodyPart textBodyPart = new TextBodyPart(document);
            //textBodyPart.BodyItems.Add(paragraph);
            //docSection.Paragraphs.Add(paragraph);

            Paragraph paragraph = docSection.AddParagraph();
            TextRange textRange = paragraph.AppendText("");
            textRange.CharacterFormat.FontName = "Arial Narrow";
            paragraph.Format.BeforeSpacing = 0;
            paragraph.Format.AfterSpacing = 0;
            paragraph.Format.LineSpacing = 10;
            textRange.CharacterFormat.FontSize = 10;
        }

        public void AddTitlesAndSpecs(IList<IItem> items, Section section)
        {
            List<DataSheet> dataSheets = items.Where(x => x.Catalog.DataSheet != null).Select(x => x.Catalog.DataSheet).GroupBy(x => x.Id).Select(x => x.First()).ToList();

            foreach (DataSheet dataSheet in dataSheets)
            {

                List<IItem> dataSheetItems = items.Where(x => x.Catalog.DataSheet != null && x.Catalog.DataSheet.Id == dataSheet.Id).ToList();

                foreach (Title title in dataSheet.Titles)
                {
                    AddTitlesAndSpecsText(section, title.Name + " " + JoinTags(dataSheetItems), true);

                    foreach (Spec spec in title.Specs)
                    {
                        AddTitlesAndSpecsText(section, spec.Name);
                    }
                }

                foreach (IItem item in dataSheetItems.Where(x => x.Titles.Any()))
                {
                    foreach (Title title in item .Titles)
                    {
                        //AddTitlesAndSpecsText(section, title.Name + $" [{item.Tag}]({item.Quantity})", true);
                        AddTitlesAndSpecsText(section, title.Name + $" [{item.Tag}]", true);


                        foreach (Spec spec in title.Specs)
                        {
                            AddTitlesAndSpecsText(section, spec.Name);
                        }
                    }
                }
            }

            List<IItem> noDataSheetItems = items.Where(x => x.Catalog.DataSheet == null).ToList();
            
            foreach (IItem item in noDataSheetItems.Where(x => x.Titles.Any()))
            {
                foreach (Title title in item.Titles)
                {
                    //AddTitlesAndSpecsText(section, title.Name + $" [{item.Tag}]({item.Quantity})", true);
                    AddTitlesAndSpecsText(section, title.Name + $" [{item.Tag}]", true);


                    foreach (Spec spec in title.Specs)
                    {
                        AddTitlesAndSpecsText(section, spec.Name);
                    }
                }
            }
        }

        public List<PricingItem> GetPricingItems(IList<IItem> items, IItem tempItem, int itemNumber)
        {
            List<PricingItem> pricingItems = new List<PricingItem>();

            if (GV.Extended)
            {
                foreach (IItem item in items)
                {
                    pricingItems.Add(new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(new List<IItem>() { item }), JoinTags(new List<IItem>() { item }), JoinQuantities(new List<IItem>() { item }), tempItem.Catalog.Company, JoinFreights(new List<IItem>() { item }), item));

                    foreach (Title title in item.Titles)
                    {
                        if (title.Specs.All(x => x.Price <= 0))
                            continue;

                        //pricingItems.Add(new PricingItem(0, title.Name, 0, $"[{item.Tag}]({item.Quantity})", 0, tempItem.Catalog.Company, true, false));
                        pricingItems.Add(new PricingItem(0, title.Name, 0, $"[{item.Tag}]", 0, tempItem.Catalog.Company, 0, null, true, false));

                        foreach (Spec spec in title.Specs)
                        {
                            if (spec.Price <= 0)
                                continue;

                            //pricingItems.Add(new PricingItem(0, spec.Name, spec.Price, $"[{item.Tag}]({item.Quantity})", 1, tempItem.Catalog.Company, false, true));
                            pricingItems.Add(new PricingItem(0, spec.Name, spec.Price, $"[{item.Tag}]", 1, tempItem.Catalog.Company, 0, null, false, true));
                        }
                    }
                }
            }
            else
            {

                pricingItems.Add(new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()), tempItem.Catalog.Company, JoinFreights(items.ToList<IItem>())));


                foreach (IItem item in items.Where(x => x.Titles.Any()))
                {
                    foreach (Title title in item.Titles)
                    {
                        if (title.Specs.All(x => x.Price <= 0))
                            continue;

                        //pricingItems.Add(new PricingItem(0, title.Name, 0, $"[{item.Tag}]({item.Quantity})", 0, tempItem.Catalog.Company, true, false));
                        pricingItems.Add(new PricingItem(0, title.Name, 0, $"[{item.Tag}]", 0, tempItem.Catalog.Company,0, null, true, false));


                        foreach (Spec spec in title.Specs)
                        {
                            if (spec.Price <= 0)
                                continue;

                            //pricingItems.Add(new PricingItem(0, spec.Name, spec.Price, $"[{item.Tag}]({item.Quantity})", 1, tempItem.Catalog.Company, false, true));
                            pricingItems.Add(new PricingItem(0, spec.Name, spec.Price, $"[{item.Tag}]", 1, tempItem.Catalog.Company,0, null, false, true));
                        }
                    }
                }
            }

            return pricingItems;
        }

        public void AddTitlesAndSpecsText(Section docSection, string text, bool isTitle = false)
        {

            Paragraph paragraph = docSection.AddParagraph();
            TextRange textRange = null;
            if (isTitle)
            {
                textRange = paragraph.AppendText( "\n" + text);
                textRange.CharacterFormat.Bold = true;
                //textRange.CharacterFormat.TextColor = Color.DarkCyan;
                textRange.CharacterFormat.TextColor = Color.DarkBlue;
            }
            else
            {
                textRange = paragraph.AppendText(text);
                paragraph.ApplyStyle(BuiltinStyle.ListBullet);
            }
            textRange.CharacterFormat.FontName = "Arial Narrow";
            paragraph.Format.BeforeSpacing = 0;
            paragraph.Format.AfterSpacing = 0;
            paragraph.Format.LineSpacing = 10;
            textRange.CharacterFormat.FontSize = 10;
        }

        public Document LoadDocument(string filePath)
        {
            Document document = new Document();

            document.LoadFromFile(filePath, FileFormat.Docx);

            CreateStyles(document);

            return document;
        }

        public void CreateStyles(Document document)
        {
            //ParagraphStyle calibriStyle10 = new ParagraphStyle(document);
            //calibriStyle10.Name = "calibriStyle10";
            //calibriStyle10.CharacterFormat.Bold = false;
            //calibriStyle10.CharacterFormat.TextColor = Color.Black;
            //calibriStyle10.CharacterFormat.FontSize = 10;
            //calibriStyle10.CharacterFormat.FontName = "Calibri";
            //calibriStyle10.ParagraphFormat.BeforeSpacing = 0;
            //calibriStyle10.ParagraphFormat.AfterSpacing = 0;
            //calibriStyle10.ParagraphFormat.LineSpacing = 10;
            //document.Styles.Add(calibriStyle10);

            //ParagraphStyle calibriStyle12 = new ParagraphStyle(document);
            //calibriStyle12.Name = "calibriStyle12";
            //calibriStyle12.CharacterFormat.Bold = false;
            //calibriStyle12.CharacterFormat.TextColor = Color.Black;
            //calibriStyle12.CharacterFormat.FontSize = 12;
            //calibriStyle12.CharacterFormat.FontName = "Calibri";
            //calibriStyle12.ParagraphFormat.BeforeSpacing = 0;
            //calibriStyle12.ParagraphFormat.AfterSpacing = 0;
            //calibriStyle12.ParagraphFormat.LineSpacing = 10;
            //document.Styles.Add(calibriStyle12);

            ////Century Gothic
            //ParagraphStyle centuryGothicStyle8 = new ParagraphStyle(document);
            //centuryGothicStyle8.Name = "centuryGothicStyle8";
            //centuryGothicStyle8.CharacterFormat.Bold = false;
            //centuryGothicStyle8.CharacterFormat.TextColor = Color.Black;
            //centuryGothicStyle8.CharacterFormat.FontSize = 8;
            //centuryGothicStyle8.CharacterFormat.FontName = "Century Gothic";
            //centuryGothicStyle8.ParagraphFormat.BeforeSpacing = 0;
            //centuryGothicStyle8.ParagraphFormat.AfterSpacing = 0;
            //centuryGothicStyle8.ParagraphFormat.LineSpacing = 10;
            //document.Styles.Add(centuryGothicStyle8);

            //ParagraphStyle style24 = new ParagraphStyle(document);
            //style24.Name = "style24";
            //style24.CharacterFormat.Bold = false;
            //style24.CharacterFormat.TextColor = Color.Black;
            //style24.CharacterFormat.FontSize = 24;
            //style24.CharacterFormat.FontName = "Arial";
            //style24.ParagraphFormat.BeforeSpacing = 0;
            //style24.ParagraphFormat.AfterSpacing = 0;
            //document.Styles.Add(style24);

            //ParagraphStyle style20 = new ParagraphStyle(document);
            //style20.Name = "style20";
            //style20.CharacterFormat.Bold = false;
            //style20.CharacterFormat.TextColor = Color.Black;
            //style20.CharacterFormat.FontSize = 20;
            //style20.CharacterFormat.FontName = "Arial";
            //style20.ParagraphFormat.BeforeSpacing = 0;
            //style20.ParagraphFormat.AfterSpacing = 0;
            //document.Styles.Add(style20);

            //ParagraphStyle style18 = new ParagraphStyle(document);
            //style18.Name = "style18";
            //style18.CharacterFormat.Bold = false;
            //style18.CharacterFormat.TextColor = Color.Black;
            //style18.CharacterFormat.FontSize = 18;
            //style18.CharacterFormat.FontName = "Arial";
            //style18.ParagraphFormat.BeforeSpacing = 0;
            //style18.ParagraphFormat.AfterSpacing = 0;
            //document.Styles.Add(style18);

            //ParagraphStyle style14 = new ParagraphStyle(document);
            //style14.Name = "style14";
            //style14.CharacterFormat.Bold = false;
            //style14.CharacterFormat.TextColor = Color.Black;
            //style14.CharacterFormat.FontSize = 14;
            //style14.CharacterFormat.FontName = "Arial";
            //style14.ParagraphFormat.BeforeSpacing = 0;
            //style14.ParagraphFormat.AfterSpacing = 0;
            //document.Styles.Add(style14);

            //ParagraphStyle style16 = new ParagraphStyle(document);
            //style16.Name = "style16";
            //style16.CharacterFormat.Bold = false;
            //style16.CharacterFormat.TextColor = Color.Black;
            //style16.CharacterFormat.FontSize = 16;
            //style16.CharacterFormat.FontName = "Arial";
            //style16.ParagraphFormat.BeforeSpacing = 0;
            //style16.ParagraphFormat.AfterSpacing = 0;
            //document.Styles.Add(style16);

            //ParagraphStyle style16WhiteAndBold = new ParagraphStyle(document);
            //style16WhiteAndBold.Name = "style16WhiteAndBold";
            //style16WhiteAndBold.CharacterFormat.Bold = true;
            //style16WhiteAndBold.CharacterFormat.TextColor = Color.White;
            //style16WhiteAndBold.CharacterFormat.FontSize = 16;
            //style16WhiteAndBold.CharacterFormat.FontName = "Arial";
            //style16WhiteAndBold.ParagraphFormat.BeforeSpacing = 0;
            //style16WhiteAndBold.ParagraphFormat.AfterSpacing = 0;
            //document.Styles.Add(style16WhiteAndBold);

            //ParagraphStyle style11 = new ParagraphStyle(document);
            //style11.Name = "style11";
            //style11.CharacterFormat.Bold = false;
            //style11.CharacterFormat.TextColor = Color.Black;
            //style11.CharacterFormat.FontSize = 11;
            //style11.CharacterFormat.FontName = "Arial";
            //style11.ParagraphFormat.BeforeSpacing = 0;
            //style11.ParagraphFormat.AfterSpacing = 0;
            //style11.ParagraphFormat.LineSpacing = 10;
            //document.Styles.Add(style11);

            //ParagraphStyle style11WhiteAndBold = new ParagraphStyle(document);
            //style11WhiteAndBold.Name = "style11WhiteAndBold";
            //style11WhiteAndBold.CharacterFormat.Bold = true;
            //style11WhiteAndBold.CharacterFormat.TextColor = Color.White;
            //style11WhiteAndBold.CharacterFormat.FontSize = 11;
            //style11WhiteAndBold.CharacterFormat.FontName = "Arial";
            //style11WhiteAndBold.ParagraphFormat.BeforeSpacing = 0;
            //style11WhiteAndBold.ParagraphFormat.AfterSpacing = 0;
            //style11WhiteAndBold.ParagraphFormat.LineSpacing = 10;
            //document.Styles.Add(style11WhiteAndBold);

            //ParagraphStyle style12 = new ParagraphStyle(document);
            //style12.Name = "style12";
            //style12.CharacterFormat.Bold = false;
            //style12.CharacterFormat.TextColor = Color.Black;
            //style12.CharacterFormat.FontSize = 12;
            //style12.CharacterFormat.FontName = "Arial";
            //style12.ParagraphFormat.BeforeSpacing = 0;
            //style12.ParagraphFormat.AfterSpacing = 0;
            //style12.ParagraphFormat.LineSpacing = 10;
            //document.Styles.Add(style12);

            ParagraphStyle style10 = new ParagraphStyle(document);
            style10.Name = "style10";
            style10.CharacterFormat.Bold = false;
            style10.CharacterFormat.TextColor = Color.Black;
            style10.CharacterFormat.FontSize = 10;
            style10.CharacterFormat.FontName = "Arial Narrow";
            style10.ParagraphFormat.BeforeSpacing = 0;
            style10.ParagraphFormat.AfterSpacing = 0;
            style10.ParagraphFormat.LineSpacing = 10;
            document.Styles.Add(style10);

            //ParagraphStyle style10Especial = new ParagraphStyle(document);
            //style10Especial.Name = "style10Especial";
            //style10Especial.CharacterFormat.Bold = false;
            //style10Especial.CharacterFormat.TextColor = Color.Black;
            //style10Especial.CharacterFormat.FontSize = 10;
            //style10Especial.CharacterFormat.FontName = "Arial";
            //style10Especial.ParagraphFormat.BeforeSpacing = 0;
            //style10Especial.ParagraphFormat.AfterSpacing = 0;
            ////style10Especial.ParagraphFormat.LineSpacing = 10;
            //document.Styles.Add(style10Especial);

            //ParagraphStyle style15WhiteAndBold = new ParagraphStyle(document);
            //style15WhiteAndBold.Name = "style15WhiteAndBold";
            //style15WhiteAndBold.CharacterFormat.Bold = true;
            //style15WhiteAndBold.CharacterFormat.TextColor = Color.White;
            //style15WhiteAndBold.CharacterFormat.FontSize = 15;
            //style15WhiteAndBold.CharacterFormat.FontName = "Arial";
            //style15WhiteAndBold.ParagraphFormat.BeforeSpacing = 0;
            //style15WhiteAndBold.ParagraphFormat.AfterSpacing = 0;
            //style15WhiteAndBold.ParagraphFormat.LineSpacing = 10;
            //document.Styles.Add(style15WhiteAndBold);
        }

        public void GetBookmarks(Document document)
        {
            BookmarkCollection bookmarks = document.Bookmarks;

            using (StreamWriter sw = File.CreateText(@"C:\Users\TRINITY BUILD\Desktop\bookMarks.txt"))
            {
                foreach (Bookmark bookmark in bookmarks)
                    sw.Write(bookmark.Name + ",\n");

                sw.Write("\n");
                sw.Write("\n");
                sw.Write("\n");

                foreach (Bookmark bookmark in bookmarks)
                    sw.Write($@"AddText(SectionDirectEvapBk.{bookmark.Name}, """", ParaStyle.text, document);" + "\n");
            }
        }

        public void MergerDocuments(Document sourceDocument, Document targetDocument)
        {
            foreach (Section section in sourceDocument.Sections)
            {
                targetDocument.Sections.Add(section.Clone());
            }
        }

        public void FillTableRow(string[] data, Table table)
        {
            TableRow row = table.AddRow(false);

            for (int i = 0; i < data.Length; i++)
            {
                TableCell cell = row.Cells[i];
                Paragraph paragraph = row.Cells[i].AddParagraph();
                paragraph.AppendText(data[i]);
                paragraph.ApplyStyle(ParaStyle.style10.ToString());
                paragraph.Format.HorizontalAlignment = HorizontalAlignment.Center;
                cell.CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            }
        }

        public void LoadStarupData(Document document, Project project, Quote quote)
        {
            AddText(InitBk.to, project.Contractor, ParaStyle.style10, document);
            AddText(InitBk.attention, project.Contact, ParaStyle.style10, document);
            AddText(InitBk.engineer, project.Engineer, ParaStyle.style10, document);
            AddText(InitBk.projectName, project.Name, ParaStyle.style10, document);

            AddText(InitBk.date, project.CreationDate.ToShortDateString(), ParaStyle.style10, document);
            AddText(InitBk.proposalNumber, project.ProposalNumber, ParaStyle.style10, document);
            AddText(InitBk.revision, quote.Name, ParaStyle.style10, document);
            AddText(InitBk.plansDate, project.PlansDate.ToShortDateString(), ParaStyle.style10, document);
            AddText(InitBk.addendum, project.Addendum, ParaStyle.style10, document);
        }

        public string CreateFolders(Project project, IList<Quote> quotes)
        {
            string currentProjectPath = ProjectsPath + $@"\ {project.Name}({DateTime.Now.ToString("MM-dd-yy HH.mm.ss")})";
            Directory.CreateDirectory(ProjectsPath);
            Directory.CreateDirectory(currentProjectPath);
            Directory.CreateDirectory(currentProjectPath + $@"\Pricing");

            foreach (Quote quote in quotes)
            {
                File.Copy(pricingFilePath, currentProjectPath + $@"\Pricing\{quote.Name.ToUpper()}.docx", true);
            }

            return currentProjectPath;
        }

        public enum InitBk
        {
            to,
            attention,
            engineer,
            projectName,
            date,
            proposalNumber,
            revision,
            plansDate,
            addendum,
            //from,
            //email,
            //telephone,
            //quote,
            sumaryTable,
        }

        public enum ParaStyle
        {
            //style24,
            //style20,
            //style18,
            //style16WhiteAndBold,
            //style16,
            //style14,
            //style12,
            //style11,
            //style11WhiteAndBold,
            style10,
            //style15WhiteAndBold,
            //style10Especial,

            //calibriStyle10,
            //calibriStyle12,
        }

        public enum UnitBk
        {
            unitNumber,
            projectName,
            projectNumber,
            unitTag,
            date,
        }

        public enum WeightBk
        {
            totalWeight
        }

        public void AddText(Enum bookmark, string text, ParaStyle style, Document document, HorizontalAlignment alignment = HorizontalAlignment.Left)
        {
            BookmarksNavigator navigator = new BookmarksNavigator(document);
            navigator.MoveToBookmark(bookmark.ToString());
            Paragraph paragraph = new Paragraph(document);
            paragraph.AppendText(text);
            paragraph.ApplyStyle(style.ToString());
            TextBodyPart textBodyPart = new TextBodyPart(document);
            textBodyPart.BodyItems.Add(paragraph);
            paragraph.Format.HorizontalAlignment = alignment;
            navigator.ReplaceBookmarkContent(textBodyPart, true);
        }

        public Table GetTable(DocTable unitInfoTable, Document document)
        {
            Table table = null;

            SectionCollection sections = document.Sections;

            foreach (Section section in sections)
            {
                foreach (Table tb in section.Tables)
                {
                    if (tb.Title.ToFormat() == unitInfoTable.ToString().ToFormat())
                    {
                        table = tb;
                        break;
                    }
                }
            }
            if (table == null)
            {

            }

            return table;
        }

        public (int,int) CreateHeaders(int column, int row, IXLWorksheet worksheet)
        {
            worksheet.Cell(row, column).Value = "Item";
            worksheet.Cell(row, column + 1).Value = "Tags";
            worksheet.Cell(row, column + 2).Value = "Quantity";
            worksheet.Cell(row, column + 3).Value = "Product Name";
            worksheet.Cell(row, column + 4).Value = "List Price";
            worksheet.Cell(row, column + 5).Value = "List Adders";
            worksheet.Cell(row, column + 6).Value = "Cost Multiplier";
            worksheet.Cell(row, column + 7).Value = "Cost";
            worksheet.Cell(row, column + 8).Value = "Start-Up";
            worksheet.Cell(row, column + 9).Value = "Net Adders";
            worksheet.Cell(row, column + 10).Value = "Sell Margin (%)";
            worksheet.Cell(row, column + 11).Value = "Unit Sell Price";
            worksheet.Cell(row, column + 12).Value = "Freight";
            worksheet.Cell(row, column + 13).Value = "Total";

            worksheet.Cell(row, column + 15).Value = "Profit";


            IXLRange range = worksheet.Range(row, column, row, column + 15);

            range.Style.Font.FontSize = 10;
            range.Style.Font.FontName = "Century Gothic";
            range.Style.Fill.BackgroundColor = XLColor.FromArgb(155, 194, 230);
            range.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            range.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            range.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            range.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            range.Style.Font.SetBold(true);
            range.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            range.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            worksheet.Columns(column, column + 15).AdjustToContents();

            return (column, row + 1);
        }

        public (int, int) AddItems(IXLWorksheet worksheet, IList<IItem> items, int column, int row)
        {
            int itemNumber = 0;
            int specNumber = 0;

            int startRow = row;

            IItem currentItem = null;
            IItem oldItem = null;

            foreach (IItem item in items)
            {
                currentItem = item;

                if (oldItem == null || currentItem.Catalog.Product.ToFormat() != oldItem.Catalog.Product.ToFormat())
                    itemNumber++;


                string letter = GetColumnName(itemNumber);


                worksheet.Cell(row, column).Value = letter;
                worksheet.Cell(row, column + 1).Value = $"[{item.Tag}]";
                worksheet.Cell(row, column + 2).Value = item.Quantity;
                worksheet.Cell(row, column + 3).Value = $"{item.Catalog.Company}: {item.Catalog.Product}";
                worksheet.Cell(row, column + 4).Value = item.OverridePrice ? Math.Ceiling(item.ListPrice) : Math.Ceiling(item.Catalog.ListPrice);
                worksheet.Cell(row, column + 5).Value = 0;
                worksheet.Cell(row, column + 6).Value = item.OverridePrice ? item.CostMultiplier : item.Catalog.CostMultiplier;
                worksheet.Cell(row, column + 7).FormulaA1 = $"=CEILING((F{row}+G{row})*H{row}, 1)";
                worksheet.Cell(row, column + 8).Value = 0;
                worksheet.Cell(row, column + 9).Value = 0;
                worksheet.Cell(row, column + 10).Value = item.OverridePrice ? item.SellMargin / 100.0 : item.Catalog.SellMargin / 100.0;

                //worksheet.Cell(row, column + 11).FormulaA1 = $"=CEILING((I{row}+J{row}+K{row})*(D{row}/(1-L{row})),1)";
                worksheet.Cell(row, column + 11).FormulaA1 = $"=CEILING((I{row}+J{row}+K{row})/(1-L{row}),1)";

                worksheet.Cell(row, column + 12).Value = Math.Ceiling(item.Freight);

                //worksheet.Cell(row, column + 13).FormulaA1 = $"=CEILING(M{row}+N{row}, 1)";
                worksheet.Cell(row, column + 13).FormulaA1 = $"=CEILING(M{row}*D{row}, 1)+N{row}";


                //worksheet.Cell(row, column + 15).FormulaA1 = $"=CEILING(O{row}-SUM(I{row},J{row},K{row},N{row}), 1)";
                worksheet.Cell(row, column + 15).FormulaA1 = $"=CEILING(((O{row}-N{row})-(SUM(I{row},J{row},K{row})*D{row})+N{row}), 1)";


                IXLRange itemRange = worksheet.Range(row, column, row, column + 15);
                itemRange.Style.Font.SetBold(true);

                row++;

                foreach (Title title in item.Titles.Where(x => x.Specs.Any(y => y.Price != 0)))
                {
                    worksheet.Cell(row, column + 1).Value = $"[{item.Tag}]";
                    worksheet.Cell(row, column + 1).Style.Font.SetBold(true);
                    worksheet.Cell(row, column + 1).Style.Font.FontColor = XLColor.FromHtml("#00008b");
                    worksheet.Cell(row, column + 3).Value = $"{title.Name}";
                    worksheet.Cell(row, column + 3).Style.Font.SetBold(true);
                    worksheet.Cell(row, column + 3).Style.Font.FontColor = XLColor.FromHtml("#00008b");
                    row++;

                    foreach (Spec spec in title.Specs.Where(x => x.Price != 0))
                    {
                        specNumber++;

                        worksheet.Cell(row, column).Value = letter + specNumber;
                        worksheet.Cell(row, column + 3).Value = $"{spec.Name}";
                        worksheet.Cell(row, column + 11).Value = Math.Ceiling(spec.Price);
                        worksheet.Cell(row, column + 12).Value = 0;
                        worksheet.Cell(row, column + 13).FormulaA1 = $"=CEILING(M{row}+N{row}, 1)";
                        worksheet.Cell(row, column + 15).FormulaA1 = $"=CEILING(O{row}-SUM(I{row},J{row},K{row},N{row}), 1)";

                        row++;
                    }
                }

                oldItem = item;
            }

            IXLRange range = worksheet.Range(startRow, column, row - 1, column + 15);

            range.Style.Font.FontSize = 10;
            range.Style.Font.FontName = "Century Gothic";
            range.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            range.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            range.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            range.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            range.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            range.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            worksheet.Column(12).Style.NumberFormat.Format = "0%";

            var currencyFormat = "$ #,##0.00";
            worksheet.Column(6).Style.NumberFormat.Format = currencyFormat;
            worksheet.Column(7).Style.NumberFormat.Format = currencyFormat;
            worksheet.Column(9).Style.NumberFormat.Format = currencyFormat;
            worksheet.Column(10).Style.NumberFormat.Format = currencyFormat;
            worksheet.Column(11).Style.NumberFormat.Format = currencyFormat;
            worksheet.Column(13).Style.NumberFormat.Format = currencyFormat;
            worksheet.Column(14).Style.NumberFormat.Format = currencyFormat;
            worksheet.Column(15).Style.NumberFormat.Format = currencyFormat;
            worksheet.Column(17).Style.NumberFormat.Format = currencyFormat;


            IXLRange dataRange = worksheet.Range(startRow, column + 4, row - 1, column + 8);
            dataRange.Style.Font.SetBold(true);
            dataRange.Style.Font.FontColor = XLColor.FromHtml("#4472c4");

            dataRange = worksheet.Range(startRow, column + 9, row - 1, column + 9);
            dataRange.Style.Font.SetBold(true);
            dataRange.Style.Font.FontColor = XLColor.FromHtml("#c65911");


            dataRange = worksheet.Range(startRow, column + 10, row - 1, column + 15);
            dataRange.Style.Font.SetBold(true);
            dataRange.Style.Font.FontColor = XLColor.FromHtml("#4472c4");

            return (column, row);
        }


        public void AddTotalAndProfit(IXLWorksheet worksheet, int column, int startItemsRow, int row)
        {
            worksheet.Cell(row + 1, column + 13).Value = "Grand Total";
            worksheet.Cell(row + 1, column + 13).Style.Font.FontSize = 10;
            worksheet.Cell(row + 1, column + 13).Style.Font.FontName = "Century Gothic";
            worksheet.Cell(row + 1, column + 13).Style.Fill.BackgroundColor = XLColor.FromArgb(155, 194, 230);
            worksheet.Cell(row + 1, column + 13).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 1, column + 13).Style.Border.TopBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 1, column + 13).Style.Border.RightBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 1, column + 13).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 1, column + 13).Style.Font.SetBold(true);
            worksheet.Cell(row + 1, column + 13).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            worksheet.Cell(row + 1, column + 13).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            worksheet.Cell(row + 2, column + 13).FormulaA1 = $"=SUM(O{startItemsRow}:O{row})";
            worksheet.Cell(row + 2, column + 13).Style.Font.FontSize = 10;
            worksheet.Cell(row + 2, column + 13).Style.Font.FontName = "Century Gothic";
            worksheet.Cell(row + 2, column + 13).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 2, column + 13).Style.Border.TopBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 2, column + 13).Style.Border.RightBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 2, column + 13).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 2, column + 13).Style.Font.SetBold(true);
            worksheet.Cell(row + 2, column + 13).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            worksheet.Cell(row + 2, column + 13).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            worksheet.Cell(row + 2, column + 13).Style.Font.FontColor = XLColor.FromHtml("#4472c4");

            worksheet.Cell(row + 1, column + 15).Value = "Grand Total Profit";
            worksheet.Cell(row + 1, column + 15).Style.Font.FontSize = 10;
            worksheet.Cell(row + 1, column + 15).Style.Font.FontName = "Century Gothic";
            worksheet.Cell(row + 1, column + 15).Style.Fill.BackgroundColor = XLColor.FromArgb(155, 194, 230);
            worksheet.Cell(row + 1, column + 15).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 1, column + 15).Style.Border.TopBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 1, column + 15).Style.Border.RightBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 1, column + 15).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 1, column + 15).Style.Font.SetBold(true);
            worksheet.Cell(row + 1, column + 15).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            worksheet.Cell(row + 1, column + 15).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            worksheet.Cell(row + 2, column + 15).FormulaA1 = $"=SUM(Q{startItemsRow}:Q{row})";
            worksheet.Cell(row + 2, column + 15).Style.Font.FontSize = 10;
            worksheet.Cell(row + 2, column + 15).Style.Font.FontName = "Century Gothic";
            worksheet.Cell(row + 2, column + 15).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 2, column + 15).Style.Border.TopBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 2, column + 15).Style.Border.RightBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 2, column + 15).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 2, column + 15).Style.Font.SetBold(true);
            worksheet.Cell(row + 2, column + 15).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            worksheet.Cell(row + 2, column + 15).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            worksheet.Cell(row + 2, column + 15).Style.Font.FontColor = XLColor.FromHtml("#4472c4");



            worksheet.Columns(column, column + 15).AdjustToContents();

        }


        public (int, int) AddProjectData(IXLWorksheet worksheet, Project project, int column, int row)
        {
            IXLRange range = worksheet.Range(row, column, row, column + 1);

            range.Style.Font.FontSize = 12;
            range.Style.Font.FontName = "Century Gothic";
            range.Style.Fill.BackgroundColor = XLColor.FromHtml("#483D8B");
            range.Style.Font.FontColor = XLColor.White;
            range.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            range.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            range.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            range.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            range.Style.Font.SetBold(true);
            range.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            range.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            range.Merge();


            worksheet.Cell(row,column).Value = "Pricing Report";

            IXLRange dataRange = worksheet.Range(row + 1, column, row + 4, column);

            dataRange.Style.Font.FontSize = 10;
            dataRange.Style.Font.FontName = "Century Gothic";
            dataRange.Style.Fill.BackgroundColor = XLColor.FromArgb(155, 194, 230);
            dataRange.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            dataRange.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            dataRange.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            dataRange.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            dataRange.Style.Font.SetBold(true);
            dataRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            dataRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            IXLRange valuesRange = worksheet.Range(row + 1, column + 1, row + 4, column + 1);

            valuesRange.Style.Font.FontSize = 10;
            valuesRange.Style.Font.FontName = "Century Gothic";
            valuesRange.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            valuesRange.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            valuesRange.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            valuesRange.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            valuesRange.Style.Font.SetBold(true);
            valuesRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            valuesRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            worksheet.Cell(row + 1,column).Value = "Project:";
            worksheet.Cell(row + 1,column + 1).Value = project.Name;

            worksheet.Cell(row + 2,column).Value = "Customer:";
            worksheet.Cell(row + 2,column + 1).Value = project.Contractor;

            worksheet.Cell(row + 3,column).Value = "Contact:";
            worksheet.Cell(row + 3,column + 1).Value = project.Engineer;

            worksheet.Cell(row + 4,column).Value = "Date:";
            worksheet.Cell(row + 4,column + 1).Value = project.CreationDate.ToLongDateString();

            return (column, row + 6);
        }

        public void GetTextBoxes(Document document)
        {
            SectionCollection sections = document.Sections;
            TextBoxCollection textBoxes = document.TextBoxes;

        }

        public enum DocTable
        {
            wallsAndRoof,
            floor,
            openings,
            dampers,
            weight,
        }

        public  void CopyResource(DocumentResource documentResource)
        {
            string sourcePath = Environment.CurrentDirectory + $@"\{documentResource.ToString()}";


            if (!Directory.Exists(TemplatesPath))
            {
                Directory.CreateDirectory(TemplatesPath);
            }

            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, TemplatesPath));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, TemplatesPath), true);
            }
        }

        public enum DocumentResource
        {
            ResourcePricing,
        }
    }
}
