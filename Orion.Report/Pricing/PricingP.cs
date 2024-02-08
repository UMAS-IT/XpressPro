using Orion.Domain.AERCO.Item;
using Orion.Domain.Baldor.Item;
using Orion.Domain.Entity;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Report.Pricing
{
    public class PricingP : ReportSettings
    {
        public List<PricingItem> CreateP1ItemTable(IList<ItemP1> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Base", "Model", "Frame", "HP", "RPM", "Voltage", "Enclosure", "Efficiency", "Weight" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemP1 item = items[i];

                data[i] = new string[11] { item.Quantity.ToString(), item.Tag, item.CatalogP1.Model, item.Model, item.Frame, item.Hp, item.Rpm, item.Voltage, item.Enclosure, item.Efficiency, item.Weight };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
        }
    }
}
