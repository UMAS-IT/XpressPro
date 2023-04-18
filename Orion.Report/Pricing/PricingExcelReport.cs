using ClosedXML.Excel;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
