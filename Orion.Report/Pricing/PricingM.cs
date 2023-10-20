using Orion.Domain.Entity;
using Orion.Domain.PACE.Item;
using Orion.Domain.UMAS.Item;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Report.Pricing
{
    public class PricingM : ReportSettings
    {
        public List<PricingItem> CreateM1ItemTable(IList<ItemM1> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Base", "Model", "Description", "CFM", "Voltage", "Weight" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemM1 item = items[i];

                data[i] = new string[8] { item.Quantity.ToString(), item.Tag, item.CatalogM1.Model, item.Model, item.CatalogM1.Description, item.Cfm, item.Voltage, item.Weight };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
        }
    }
}

