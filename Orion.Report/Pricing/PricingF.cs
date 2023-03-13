using Orion.Domain.Entity;
using Orion.Domain.EntityItemGroundfos;
using Orion.Domain.EntityItemUvResources;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Report.Pricing
{
    public class PricingF : ReportSettings
    {
        public List<PricingItem> CreateF1ItemTable(IList<ItemF1> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model", "Part Number", "Description" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemF1 item = items[i];

                data[i] = new string[5] { item.Quantity.ToString(), item.Tag, item.CatalogF1.Model, item.CatalogF1.PartNumber, item.CatalogF1.Description };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
        }
    }
}
