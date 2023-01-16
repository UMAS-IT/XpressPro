using Orion.Domain.Entity;
using Orion.Domain.EntityItem;
using Orion.Helper.Extension;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Report.Pricing
{
    public class PricingA : ReportSettings
    {
        public PricingItem CreateA1ItemTable(IList<ItemA1> itemA1s, Document document, Section docSection, int itemNumber)
        {
            itemA1s = itemA1s.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = itemA1s.Count;

            string itemName = $"Air Cooled Chillers Factory Lead Time. Quantity ({itemA1s.Select(x => x.Quantity).Sum()})";

            String[] sectionTitle = { $"Item #{itemNumber}) {itemName}"};
            String[] Header = { "Quantity", "Tag", "Model", "Unit Size", "Description", "Voltage" };

            string[][] data = new string[itemA1s.Count][];

            for (int i = 0; i < itemA1s.Count; i++)
            {
                ItemA1 item = itemA1s[i];

                data[i] = new string[6] { item.Quantity.ToString(), item.Tag, item.CatalogA1.Model, item.CatalogA1.UnitSize, item.CatalogA1.Description, item.CatalogA1.Voltage};
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            double totalSellPrice = 0;

            foreach (ItemA1 item in itemA1s)
            {
                if (item.OverridePrice)
                    totalSellPrice += item.Quantity * item.SellPrice;
                else
                    totalSellPrice += item.Quantity * item.CatalogA1.SellPrice;
            }

            return new PricingItem(itemNumber, itemName, totalSellPrice);
        }

        public PricingItem CreateA2ItemTable(IList<ItemA2> itemA2s, Document document, Section docSection, int itemNumber)
        {
            itemA2s = itemA2s.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = itemA2s.Count;

            string itemName = $"Air Cooled Chillers Stock Non Coated Condenser. Quantity ({itemA2s.Select(x => x.Quantity).Sum()})";

            String[] sectionTitle = { $"Item #{itemNumber}) {itemName}"};
            String[] Header = { "Quantity", "Tag", "Model", "Unit Size", "Description", "Voltage" };

            string[][] data = new string[itemA2s.Count][];

            for (int i = 0; i < itemA2s.Count; i++)
            {
                ItemA2 item = itemA2s[i];

                data[i] = new string[6] { item.Quantity.ToString(), item.Tag, item.CatalogA2.Model, item.CatalogA2.UnitSize, item.CatalogA2.Description, item.CatalogA2.Voltage };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            double totalSellPrice = 0;

            foreach (ItemA2 item in itemA2s)
            {
                if (item.OverridePrice)
                    totalSellPrice += item.Quantity * item.SellPrice;
                else
                    totalSellPrice += item.Quantity * item.CatalogA2.SellPrice;
            }

            return new PricingItem(itemNumber, itemName, totalSellPrice);
        }

        public PricingItem CreateA3ItemTable(IList<ItemA3> itemA3s, Document document, Section docSection, int itemNumber)
        {
            itemA3s = itemA3s.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = itemA3s.Count;

            string itemName = $"Air Cooled Chillers Stock Post Coated Condenser. Quantity ({itemA3s.Select(x => x.Quantity).Sum()})";

            String[] sectionTitle = { $"Item #{itemNumber}) {itemName}"};
            String[] Header = { "Quantity", "Tag", "Model", "Unit Size", "Description", "Voltage" };

            string[][] data = new string[itemA3s.Count][];

            for (int i = 0; i < itemA3s.Count; i++)
            {
                ItemA3 item = itemA3s[i];

                data[i] = new string[6] { item.Quantity.ToString(), item.Tag, item.CatalogA3.Model, item.CatalogA3.UnitSize, item.CatalogA3.Description, item.CatalogA3.Voltage };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            double totalSellPrice = 0;

            foreach (ItemA3 item in itemA3s)
            {
                if (item.OverridePrice)
                    totalSellPrice += item.Quantity * item.SellPrice;
                else
                    totalSellPrice += item.Quantity * item.CatalogA3.SellPrice;
            }

            return new PricingItem(itemNumber, itemName, totalSellPrice);
        }

        public PricingItem CreateA4ItemTable(IList<ItemA4> itemA4s, Document document, Section docSection, int itemNumber)
        {
            itemA4s = itemA4s.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = itemA4s.Count;

            string itemName = $"Water Cooled Chillers Factory Lead Time. Quantity ({itemA4s.Select(x => x.Quantity).Sum()})";

            String[] sectionTitle = { $"Item #{itemNumber}) {itemName}"};
            String[] Header = { "Quantity", "Tag", "Model", "Unit Size", "Description", "Voltage" };

            string[][] data = new string[itemA4s.Count][];

            for (int i = 0; i < itemA4s.Count; i++)
            {
                ItemA4 item = itemA4s[i];

                data[i] = new string[6] { item.Quantity.ToString(), item.Tag, item.CatalogA4.Model, item.CatalogA4.UnitSize, item.CatalogA4.Description, item.CatalogA4.Voltage };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            double totalSellPrice = 0;

            foreach (ItemA4 item in itemA4s)
            {
                if (item.OverridePrice)
                    totalSellPrice += item.Quantity * item.SellPrice;
                else
                    totalSellPrice += item.Quantity * item.CatalogA4.SellPrice;
            }

            return new PricingItem(itemNumber, itemName, totalSellPrice);
        }
    }
}
