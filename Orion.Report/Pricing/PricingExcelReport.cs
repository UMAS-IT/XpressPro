using ClosedXML.Excel;
using Orion.DataAccess.Misc;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Orion.Helper.Misc.GV;

namespace Orion.Report.Pricing
{
    public class PricingExcelReport : ReportSettings
    {
        private Project project;
        private string currentProjectPath;
        private IList<Quote> quotes;

        public PricingExcelReport(Project project, string currentProjectPath, IList<Quote> quotes)
        {
            this.project = project;
            this.currentProjectPath = currentProjectPath;
            this.quotes = quotes;
        }

        public void CreateReport()
        {
            XLWorkbook workbook = new XLWorkbook();
            ItemService itemService = new ItemService();

            foreach (Quote quote in quotes)
            {
                List<IItem> items = itemService.GetAllItemByQuoteId(quote.Id, false).ToList();

                if (quote.QuoteCompanies != null && quote.QuoteCompanies.Count > 0)
                {
                    Dictionary<Subfix, IList<IItem>> subfixGroups = new Dictionary<Subfix, IList<IItem>>();

                    foreach (QuoteCompanies quoteCompany in quote.QuoteCompanies.OrderBy(x => x.DesignIndex))
                    {
                        Subfix subfix = EntityHelper.GetSubfixFromCompanty(quoteCompany.Company);

                        subfixGroups[subfix] = new List<IItem>();
                    }

                    foreach (IItem item in items)
                    {
                        ItemType itemType = EntityHelper.ConvertIItemToItemType(item);
                        
                        Subfix subfix = EntityHelper.ConvertItemTypeToSubfix(itemType);

                        item.ItemType = itemType;

                        subfixGroups[subfix].Add(item);
                    }

                    subfixGroups.ToList().ForEach(x => subfixGroups[x.Key] = x.Value.OrderBy(y => y.ItemType).ThenBy(y => y.DesignIndex).ToList());

                    items = subfixGroups.SelectMany(x => x.Value).ToList();
                }

                int row = 2;
                int column = 2;

                IXLWorksheet worksheet = workbook.AddWorksheet(quote.Name);

                (int,int) indexStatus = AddProjectData(worksheet, project, column, row);

                column = indexStatus.Item1;
                row = indexStatus.Item2;

                indexStatus = CreateHeaders(column, row, worksheet);

                column = indexStatus.Item1;
                row = indexStatus.Item2;

                indexStatus = AddItems(worksheet, items, column, row);

                int startItemsRow = row;

                column = indexStatus.Item1;
                row = indexStatus.Item2;

                AddTotalAndProfit(worksheet, column, startItemsRow, row);

                worksheet.Column(5).Width = 30;
                worksheet.Column(5).Style.Alignment.WrapText = true;
            }

            workbook.SaveAs(currentProjectPath + $@"\Pricing\\{project.Name.ToUpper()}.xlsx");
        }

    }
}
