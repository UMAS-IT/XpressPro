using Orion.Domain.Entity;
using Orion.Domain.EntityItemGroundfos;
using Orion.Domain.PACE.Item;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Report.Pricing
{
    public class PricingJ : ReportSettings
    {
        public List<PricingItem> CreateJ1ItemTable(IList<ItemJ1> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model", "Description", "CFM", "Voltage", "Weight"};

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemJ1 item = items[i];

                data[i] = new string[7] { item.Quantity.ToString(), item.Tag, item.CatalogJ1.Model, item.CatalogJ1.Description, item.Cfm, item.Voltage, item.Weight };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
        }
    }
}
