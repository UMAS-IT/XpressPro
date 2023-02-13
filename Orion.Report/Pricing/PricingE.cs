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
        public PricingItem CreateE1ItemTable(IList<ItemE1> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemE1 item = items[i];

                data[i] = new string[3] { item.Quantity.ToString(), item.Tag, item.CatalogE1.Model };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()));
        }

        public PricingItem CreateE2ItemTable(IList<ItemE2> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemE2 item = items[i];

                data[i] = new string[3] { item.Quantity.ToString(), item.Tag, item.CatalogE2.Model };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()));
        }

        public PricingItem CreateE3ItemTable(IList<ItemE3> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemE3 item = items[i];

                data[i] = new string[3] { item.Quantity.ToString(), item.Tag, item.CatalogE3.Model };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()));
        }

        public PricingItem CreateE4ItemTable(IList<ItemE4> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemE4 item = items[i];

                data[i] = new string[3] { item.Quantity.ToString(), item.Tag, item.CatalogE4.Model };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()));
        }

        public PricingItem CreateE5ItemTable(IList<ItemE5> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemE5 item = items[i];

                data[i] = new string[3] { item.Quantity.ToString(), item.Tag, item.CatalogE5.Model };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()));
        }

        public PricingItem CreateE6ItemTable(IList<ItemE6> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemE6 item = items[i];

                data[i] = new string[3] { item.Quantity.ToString(), item.Tag, item.CatalogE6.Model };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()));
        }

        public PricingItem CreateE7ItemTable(IList<ItemE7> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemE7 item = items[i];

                data[i] = new string[3] { item.Quantity.ToString(), item.Tag, item.CatalogE7.Model };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()));
        }
    }
}
