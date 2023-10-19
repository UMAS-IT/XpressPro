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
        public List<PricingItem> CreateC1ItemTable(IList<ItemC1> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model", "Description", "Size (in)", "Shipping Weight", "End Connection", "Product Type" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemC1 item = items[i];

                data[i] = new string[8] { item.Quantity.ToString(), item.Tag, item.CatalogC1.Model, item.CatalogC1.Description, item.CatalogC1.Size, item.CatalogC1.ShippingWeight, item.CatalogC1.EndConnection, item.CatalogC1.CatalogC1ProductType.Name };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
        }

        public List<PricingItem> CreateC2ItemTable(IList<ItemC2> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model", "System Flange (in)", "Pump Flange (in)", "Shipping Weight" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemC2 item = items[i];

                data[i] = new string[6] { item.Quantity.ToString(), item.Tag, item.CatalogC2.Model, item.CatalogC2.SystemFlange, item.CatalogC2.PumpFlange, item.CatalogC2.ShippingWeight };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
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

        public List<PricingItem> CreateC5ItemTable(IList<ItemC5> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model", "Description", "Volume (gal)", "Height A (in)", "Diameter B (in)", "Weight (lb)" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemC5 item = items[i];

                data[i] = new string[8] { item.Quantity.ToString(), item.Tag, item.CatalogC5.Model, item.CatalogC5.Description, item.CatalogC5.Volume, item.CatalogC5.HeightA, item.CatalogC5.DiameterB, item.CatalogC5.Weight };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
        }

        public List<PricingItem> CreateC6ItemTable(IList<ItemC6> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model", "Description", "Volume (gal)", "Height A (in)", "Diameter B (in)", "Weight (lb)" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemC6 item = items[i];

                data[i] = new string[8] { item.Quantity.ToString(), item.Tag, item.CatalogC6.Model, item.CatalogC6.Description, item.CatalogC6.Volume, item.CatalogC6.HeightA, item.CatalogC6.DiameterB, item.CatalogC6.Weight };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
        }

        public List<PricingItem> CreateC7ItemTable(IList<ItemC7> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Model", "Description" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemC7 item = items[i];

                data[i] = new string[4] { item.Quantity.ToString(), item.Tag, item.CatalogC7.Model, item.CatalogC7.Description};
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
        }

    }
}
