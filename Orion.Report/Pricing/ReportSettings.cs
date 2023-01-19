﻿using Microsoft.SqlServer.Server;
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

namespace Orion.Report.Pricing
{
    public class ReportSettings
    {
        public const string TemplatesPath = @"C:\temp\XPressPro Templates";

        public const string ProjectsPath = @"C:\temp\XPressPro Projects";

        public string pricingFilePath = Environment.CurrentDirectory + @"\ResourcePricing\PricingTemplate.docx";

        public string JoinTags(IList<IItem> items)
        {
            string tags = "";

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

            items.ToList().ForEach(x => sellPrice += x.OverridePrice ? x.Quantity * x.SellPrice : x.Quantity * x.Catalog.SellPrice);

            return sellPrice;

        }

        public void CreateItemTable(Section docSection, int itemsQuantity, string[] sectionTitle, string[] Header, string[][] data)
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
            tRange.CharacterFormat.FontName = "Calibri";
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
                textRange.CharacterFormat.FontName = "Calibri";
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

                    p2.Format.HorizontalAlignment = HorizontalAlignment.Left;
                    p2.Format.BeforeSpacing = 0;
                    p2.Format.AfterSpacing = 0;
                    p2.Format.LineSpacing = 10;
                    TR2.CharacterFormat.FontName = "Calibri";
                    TR2.CharacterFormat.FontSize = 10;
                    TR2.CharacterFormat.TextColor = Color.Black;
                }
            }
            table.AutoFit(AutoFitBehaviorType.AutoFitToWindow);
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
            Paragraph paragraph = new Paragraph(document);
            paragraph.AppendText("");
            TextBodyPart textBodyPart = new TextBodyPart(document);
            textBodyPart.BodyItems.Add(paragraph);
            docSection.Paragraphs.Add(paragraph);
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
            ParagraphStyle style24 = new ParagraphStyle(document);
            style24.Name = "style24";
            style24.CharacterFormat.Bold = false;
            style24.CharacterFormat.TextColor = Color.Black;
            style24.CharacterFormat.FontSize = 24;
            style24.CharacterFormat.FontName = "Arial";
            style24.ParagraphFormat.BeforeSpacing = 0;
            style24.ParagraphFormat.AfterSpacing = 0;
            document.Styles.Add(style24);

            ParagraphStyle style20 = new ParagraphStyle(document);
            style20.Name = "style20";
            style20.CharacterFormat.Bold = false;
            style20.CharacterFormat.TextColor = Color.Black;
            style20.CharacterFormat.FontSize = 20;
            style20.CharacterFormat.FontName = "Arial";
            style20.ParagraphFormat.BeforeSpacing = 0;
            style20.ParagraphFormat.AfterSpacing = 0;
            document.Styles.Add(style20);

            ParagraphStyle style18 = new ParagraphStyle(document);
            style18.Name = "style18";
            style18.CharacterFormat.Bold = false;
            style18.CharacterFormat.TextColor = Color.Black;
            style18.CharacterFormat.FontSize = 18;
            style18.CharacterFormat.FontName = "Arial";
            style18.ParagraphFormat.BeforeSpacing = 0;
            style18.ParagraphFormat.AfterSpacing = 0;
            document.Styles.Add(style18);

            ParagraphStyle style14 = new ParagraphStyle(document);
            style14.Name = "style14";
            style14.CharacterFormat.Bold = false;
            style14.CharacterFormat.TextColor = Color.Black;
            style14.CharacterFormat.FontSize = 14;
            style14.CharacterFormat.FontName = "Arial";
            style14.ParagraphFormat.BeforeSpacing = 0;
            style14.ParagraphFormat.AfterSpacing = 0;
            document.Styles.Add(style14);

            ParagraphStyle style16 = new ParagraphStyle(document);
            style16.Name = "style16";
            style16.CharacterFormat.Bold = false;
            style16.CharacterFormat.TextColor = Color.Black;
            style16.CharacterFormat.FontSize = 16;
            style16.CharacterFormat.FontName = "Arial";
            style16.ParagraphFormat.BeforeSpacing = 0;
            style16.ParagraphFormat.AfterSpacing = 0;
            document.Styles.Add(style16);

            ParagraphStyle style16WhiteAndBold = new ParagraphStyle(document);
            style16WhiteAndBold.Name = "style16WhiteAndBold";
            style16WhiteAndBold.CharacterFormat.Bold = true;
            style16WhiteAndBold.CharacterFormat.TextColor = Color.White;
            style16WhiteAndBold.CharacterFormat.FontSize = 16;
            style16WhiteAndBold.CharacterFormat.FontName = "Arial";
            style16WhiteAndBold.ParagraphFormat.BeforeSpacing = 0;
            style16WhiteAndBold.ParagraphFormat.AfterSpacing = 0;
            document.Styles.Add(style16WhiteAndBold);

            ParagraphStyle style11 = new ParagraphStyle(document);
            style11.Name = "style11";
            style11.CharacterFormat.Bold = false;
            style11.CharacterFormat.TextColor = Color.Black;
            style11.CharacterFormat.FontSize = 11;
            style11.CharacterFormat.FontName = "Arial";
            style11.ParagraphFormat.BeforeSpacing = 0;
            style11.ParagraphFormat.AfterSpacing = 0;
            style11.ParagraphFormat.LineSpacing = 10;
            document.Styles.Add(style11);

            ParagraphStyle style11WhiteAndBold = new ParagraphStyle(document);
            style11WhiteAndBold.Name = "style11WhiteAndBold";
            style11WhiteAndBold.CharacterFormat.Bold = true;
            style11WhiteAndBold.CharacterFormat.TextColor = Color.White;
            style11WhiteAndBold.CharacterFormat.FontSize = 11;
            style11WhiteAndBold.CharacterFormat.FontName = "Arial";
            style11WhiteAndBold.ParagraphFormat.BeforeSpacing = 0;
            style11WhiteAndBold.ParagraphFormat.AfterSpacing = 0;
            style11WhiteAndBold.ParagraphFormat.LineSpacing = 10;
            document.Styles.Add(style11WhiteAndBold);

            ParagraphStyle style12 = new ParagraphStyle(document);
            style12.Name = "style12";
            style12.CharacterFormat.Bold = false;
            style12.CharacterFormat.TextColor = Color.Black;
            style12.CharacterFormat.FontSize = 12;
            style12.CharacterFormat.FontName = "Arial";
            style12.ParagraphFormat.BeforeSpacing = 0;
            style12.ParagraphFormat.AfterSpacing = 0;
            style12.ParagraphFormat.LineSpacing = 10;
            document.Styles.Add(style12);

            ParagraphStyle style10 = new ParagraphStyle(document);
            style10.Name = "style10";
            style10.CharacterFormat.Bold = false;
            style10.CharacterFormat.TextColor = Color.Black;
            style10.CharacterFormat.FontSize = 10;
            style10.CharacterFormat.FontName = "Arial";
            style10.ParagraphFormat.BeforeSpacing = 0;
            style10.ParagraphFormat.AfterSpacing = 0;
            style10.ParagraphFormat.LineSpacing = 10;
            document.Styles.Add(style10);

            ParagraphStyle style10Especial = new ParagraphStyle(document);
            style10Especial.Name = "style10Especial";
            style10Especial.CharacterFormat.Bold = false;
            style10Especial.CharacterFormat.TextColor = Color.Black;
            style10Especial.CharacterFormat.FontSize = 10;
            style10Especial.CharacterFormat.FontName = "Arial";
            style10Especial.ParagraphFormat.BeforeSpacing = 0;
            style10Especial.ParagraphFormat.AfterSpacing = 0;
            //style10Especial.ParagraphFormat.LineSpacing = 10;
            document.Styles.Add(style10Especial);

            ParagraphStyle style15WhiteAndBold = new ParagraphStyle(document);
            style15WhiteAndBold.Name = "style15WhiteAndBold";
            style15WhiteAndBold.CharacterFormat.Bold = true;
            style15WhiteAndBold.CharacterFormat.TextColor = Color.White;
            style15WhiteAndBold.CharacterFormat.FontSize = 15;
            style15WhiteAndBold.CharacterFormat.FontName = "Arial";
            style15WhiteAndBold.ParagraphFormat.BeforeSpacing = 0;
            style15WhiteAndBold.ParagraphFormat.AfterSpacing = 0;
            style15WhiteAndBold.ParagraphFormat.LineSpacing = 10;
            document.Styles.Add(style15WhiteAndBold);
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
            AddText(InitBk.projectName, project.Name, ParaStyle.style10, document);
            AddText(InitBk.to, project.Contractor, ParaStyle.style10, document);
            AddText(InitBk.attention, project.Engineer, ParaStyle.style10, document);
            AddText(InitBk.from, project.User.Name, ParaStyle.style10, document);
            AddText(InitBk.email, project.User.Email, ParaStyle.style10, document);
            AddText(InitBk.telephone, project.Contact, ParaStyle.style10, document);
            AddText(InitBk.date, project.CreationDate.ToShortDateString(), ParaStyle.style10, document);
            AddText(InitBk.quote, quote.Name, ParaStyle.style10, document);
            AddText(InitBk.revision, "1", ParaStyle.style10, document);
        }

        public string CreateFolders(Project project, IList<Quote> quotes)
        {
            string currentProjectPath = ProjectsPath + $@"\ {project.Name}({DateTime.Now.ToString("MM-dd-yy HH.mm.ss")})";
            Directory.CreateDirectory(ProjectsPath);
            Directory.CreateDirectory(currentProjectPath);
            Directory.CreateDirectory(currentProjectPath + $@"\Pricing");

            foreach (Quote quote in quotes.Where(x => x.IsSelected))
            {
                File.Copy(pricingFilePath, currentProjectPath + $@"\Pricing\{quote.Name.ToUpper()}.docx", true);
            }

            return currentProjectPath;
        }

        public enum InitBk
        {
            projectName,
            to,
            attention,
            from,
            email,
            telephone,
            date,
            quote,
            revision,
        }

        public enum ParaStyle
        {
            style24,
            style20,
            style18,
            style16WhiteAndBold,
            style16,
            style14,
            style12,
            style11,
            style11WhiteAndBold,
            style10,
            style15WhiteAndBold,
            style10Especial,
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