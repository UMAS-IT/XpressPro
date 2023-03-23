using Orion.Domain.Entity;
using Orion.Domain.Marvair.Item;
using Orion.Domain.Multiaqua.Item;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Report.Pricing
{
    public class PricingK : ReportSettings
    {
        public List<PricingItem> CreateK1ItemTable(IList<ItemK1> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model", "Description" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemK1 item = items[i];

                data[i] = new string[4] { item.Quantity.ToString(), item.Tag, item.CatalogK1.Model, item.CatalogK1.Description };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
        }

        public List<PricingItem> CreateK2ItemTable(IList<ItemK2> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model", "Description" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemK2 item = items[i];

                data[i] = new string[4] { item.Quantity.ToString(), item.Tag, item.CatalogK2.Model, item.CatalogK2.Description };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
        }

        public List<PricingItem> CreateK3ItemTable(IList<ItemK3> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model", "Description" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemK3 item = items[i];

                data[i] = new string[4] { item.Quantity.ToString(), item.Tag, item.CatalogK3.Model, item.CatalogK3.Description };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
        }
    }
}
