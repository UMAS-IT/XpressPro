using Orion.Domain.Entity;
using Orion.Domain.EntityItem;
using Orion.Domain.Marvair.Item;
using Orion.Helper.Extension;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Report.Pricing
{
    public class PricingI : ReportSettings
    {
        public List<PricingItem> CreateI1ItemTable(IList<ItemI1> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model", "Unit Size", "Description", "Economizer", "Voltage" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemI1 item = items[i];

                data[i] = new string[7] { item.Quantity.ToString(), item.Tag, item.CatalogI1.Model, item.CatalogI1.UnitSize, item.CatalogI1.Description, item.CatalogI1.Economizer.ToYesNo(), item.CatalogI1.Voltage };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
        }

        public List<PricingItem> CreateI2ItemTable(IList<ItemI2> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model", "Description" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemI2 item = items[i];

                data[i] = new string[4] { item.Quantity.ToString(), item.Tag, item.CatalogI2.Model, item.CatalogI2.Description };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
        }

    }
}
