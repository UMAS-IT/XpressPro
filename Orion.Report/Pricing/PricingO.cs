using Orion.Domain.ABOVEAIR.Item;
using Orion.Domain.AERCO.Item;
using Orion.Domain.Entity;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Report.Pricing
{
    public class PricingO : ReportSettings
    {
        public List<PricingItem> CreateO1ItemTable(IList<ItemO1> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Base", "Model", "Fuel Type", "Capacity", "Voltage" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemO1 item = items[i];

                data[i] = new string[7] { item.Quantity.ToString(), item.Tag, item.CatalogO1.Model, item.Model, item.FuelType, item.Capacity, item.Voltage };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
        }

        public List<PricingItem> CreateO2ItemTable(IList<ItemO2> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Base", "Model", "Fuel Type", "Capacity", "Voltage" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemO2 item = items[i];

                data[i] = new string[7] { item.Quantity.ToString(), item.Tag, item.CatalogO2.Model, item.Model, item.FuelType, item.Capacity, item.Voltage };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
        }
    }
}
