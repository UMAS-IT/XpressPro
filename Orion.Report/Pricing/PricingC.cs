using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogAmericanWheatley;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Domain.EntityItemUvResources;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Report.Pricing
{
    public class PricingC : ReportSettings
    {
        public PricingItem CreateC1ItemTable(IList<ItemC1> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemC1 item = items[i];

                data[i] = new string[3] { item.Quantity.ToString(), item.Tag, item.CatalogC1.Model };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()));
        }

        public PricingItem CreateC2ItemTable(IList<ItemC2> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemC2 item = items[i];

                data[i] = new string[3] { item.Quantity.ToString(), item.Tag, item.CatalogC2.Model };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()));
        }

        public List<PricingItem> CreateC3ItemTable(IList<ItemC3> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model", "Acceptable Volume (GPM)", "Diameter A (in)", "Height B (in)", "System Connect (in)", "Weight (lb)", "Working Pressure (PSI)", "Product Type" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemC3 item = items[i];

                data[i] = new string[10] { item.Quantity.ToString(), item.Tag, item.CatalogC3.Model, item.CatalogC3.AcceptableVolume, item.CatalogC3.DiameterA, item.CatalogC3.HeightB, item.CatalogC3.SystemConnect, item.CatalogC3.Weight, item.CatalogC3.WorkingPressure, item.CatalogC3.CatalogC3ProductType.Name };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
        }

        public List<PricingItem> CreateC4ItemTable(IList<ItemC4> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model", "Acceptable Volume (GPM)", "Diameter A (in)", "Height B (in)", "System Connect (in)", "Weight (lb)", "Working Pressure (PSI)"};

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemC4 item = items[i];

                data[i] = new string[9] { item.Quantity.ToString(), item.Tag, item.CatalogC4.Model, item.CatalogC4.AcceptableVolume, item.CatalogC4.DiameterA, item.CatalogC4.HeightB, item.CatalogC4.SystemConnect, item.CatalogC4.Weight, item.CatalogC4.WorkingPressure};
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
        }

    }
}
