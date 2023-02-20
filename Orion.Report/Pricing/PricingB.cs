using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Helper.Extension;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Report.Pricing
{
    public class PricingB : ReportSettings
    {
        public PricingItem CreateB1ItemTable(IList<ItemB1> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model", "HP", "Description", "Nema", "Bypass", "Disconnect", "Voltage" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemB1 item = items[i];

                CatalogB1 catalog = item.CatalogB1;

                data[i] = new string[9] { item.Quantity.ToString(), item.Tag, catalog.Model, catalog.Hp.ToString(), catalog.Description, catalog.Nema, catalog.Bypass.ToYesNo(), catalog.CircuitBreakerDisconnect.ToYesNo(), catalog.Voltage };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()));
        }

        public PricingItem CreateB2ItemTable(IList<ItemB2> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model", "HP", "Description", "Nema", "Bypass", "Disconnect", "Voltage"};

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemB2 item = items[i];

                CatalogB2 catalog = item.CatalogB2;

                data[i] = new string[9] { item.Quantity.ToString(), item.Tag, catalog.Model, catalog.Hp.ToString(), catalog.Description, catalog.Nema, catalog.Bypass.ToYesNo(), catalog.CircuitBreakerDisconnect.ToYesNo(), catalog.Voltage};
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()));
        }

        public PricingItem CreateB3ItemTable(IList<ItemB3> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model", "HP", "Description", "Nema", "Bypass", "Disconnect", "Voltage" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemB3 item = items[i];

                CatalogB3 catalog = item.CatalogB3;

                data[i] = new string[9] { item.Quantity.ToString(), item.Tag, catalog.Model, catalog.Hp.ToString(), catalog.Description, catalog.Nema, catalog.Bypass.ToYesNo(), catalog.CircuitBreakerDisconnect.ToYesNo(), catalog.Voltage };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()));
        }

        public PricingItem CreateB4ItemTable(IList<ItemB4> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model", "HP", "Description", "Nema", "Bypass", "Disconnect", "Voltage" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemB4 item = items[i];

                CatalogB4 catalog = item.CatalogB4;

                data[i] = new string[9] { item.Quantity.ToString(), item.Tag, catalog.Model, catalog.Hp.ToString(), catalog.Description, catalog.Nema, catalog.Bypass.ToYesNo(), catalog.CircuitBreakerDisconnect.ToYesNo(), catalog.Voltage };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()));
        }

        public PricingItem CreateB5ItemTable(IList<ItemB5> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model", "Description" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemB5 item = items[i];
                CatalogB5 catalog = item.CatalogB5;

                data[i] = new string[4] { item.Quantity.ToString(), item.Tag, catalog.Model, catalog.Description };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()));
        }
    }
}
