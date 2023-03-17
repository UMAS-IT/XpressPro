using Orion.Domain.Entity;
using Orion.Domain.EntityItemGroundfos;
using Orion.Domain.EntityItemPuroFlux;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Report.Pricing
{
    partial class PricingE : ReportSettings
    {
        public List<PricingItem> CreateE1ItemTable(IList<ItemE1> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;
            
            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Base", "Model", "GPM", "TDH", "HP", "Motor", "RPM", "Electrical" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemE1 item = items[i];

                data[i] = new string[10] { item.Quantity.ToString(), item.Tag, item.CatalogE1.Model, item.Model, item.Gpm, item.Tdh, item.Hp, item.Motor, item.Rpm, item.Electrical };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
        }
    }
}
