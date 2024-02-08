using Orion.Domain.ABOVEAIR.Item;
using Orion.Domain.Entity;
using Orion.Domain.UMAS.Item;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Report.Pricing
{
    public class PricingN : ReportSettings
    {
        public List<PricingItem> CreateN1ItemTable(IList<ItemN1> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Base", "Model", "CFM", "Cooling Capacity", "Refrigerant", "Voltage" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemN1 item = items[i];

                data[i] = new string[8] { item.Quantity.ToString(), item.Tag, item.CatalogN1.Model, item.Model, item.Cfm, item.CoolingCapacity, item.Refrigerant, item.Voltage };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
        }
    }
}
