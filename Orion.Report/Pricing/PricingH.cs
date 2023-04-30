using Orion.Domain.Entity;
using Orion.Domain.EntityItemBACOpenLoopTowers;
using System.Collections.Generic;
using System;
using System.Linq;
using Orion.Domain.EntityItemBACClosedLoopTowers;
using Spire.Doc;

namespace Orion.Report.Pricing
{
    public class PricingH : ReportSettings
    {
        public List<PricingItem> CreateH1ItemTable(IList<ItemH1> items, Document document, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);
            String[] Header = { "Quantity", "Tag", "Base", "Model", "Flow Rate", "Water Temp", "DesignWB", "Fluid Pressure Drop", "Fan Motors", "Pump Motor", "Voltage" };

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                ItemH1 item = items[i];

                data[i] = new string[11] { item.Quantity.ToString(), item.Tag, item.CatalogH1.Model, item.Model, item.FlowRate, item.WaterTemp, item.DesignWB, item.FluidPressureDrop, item.FanMotors, item.PumpMotor, item.Voltage };
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items.ToList<IItem>(), tempItem, itemNumber);
        }
    }
}
