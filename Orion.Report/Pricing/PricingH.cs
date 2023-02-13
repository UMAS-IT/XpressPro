using Orion.Domain.Entity;
using Orion.Domain.EntityItemBACClosedCircuits;
using Orion.Domain.EntityItemBACCoolingTowers;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Report.Pricing
{
    public class PricingH : ReportSettings
    {
        public PricingItem CreateH1ItemTable(IList<ItemH1> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemH1 item = items[i];

                data[i] = new string[3] { item.Quantity.ToString(), item.Tag, item.CatalogH1.Model };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()));
        }

        public PricingItem CreateH2ItemTable(IList<ItemH2> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemH2 item = items[i];

                data[i] = new string[3] { item.Quantity.ToString(), item.Tag, item.CatalogH2.Model };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()));
        }

        public PricingItem CreateH3ItemTable(IList<ItemH3> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemH3 item = items[i];

                data[i] = new string[3] { item.Quantity.ToString(), item.Tag, item.CatalogH3.Model };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()));
        }

        public PricingItem CreateH4ItemTable(IList<ItemH4> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemH4 item = items[i];

                data[i] = new string[3] { item.Quantity.ToString(), item.Tag, item.CatalogH4.Model };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()));
        }

        public PricingItem CreateH5ItemTable(IList<ItemH5> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemH5 item = items[i];

                data[i] = new string[3] { item.Quantity.ToString(), item.Tag, item.CatalogH5.Model };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()));
        }
    }
}
