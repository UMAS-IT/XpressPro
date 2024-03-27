using ClosedXML.Excel;
using Microsoft.SqlServer.Server;
using Orion.Domain.ABOVEAIR.Item;
using Orion.Domain.AERCO.Item;
using Orion.Domain.BACClosedLoopTowers.Related;
using Orion.Domain.Baldor.Item;
using Orion.Domain.Condair.Item;
using Orion.Domain.Entity;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Domain.EntityItemBACClosedLoopTowers;
using Orion.Domain.EntityItemBACOpenLoopTowers;
using Orion.Domain.EntityItemGeneralProduct;
using Orion.Domain.EntityItemGroundfos;
using Orion.Domain.EntityItemUvResources;
using Orion.Domain.EnviroTec.Item;
using Orion.Domain.LYNC.Item;
using Orion.Domain.Marvair.Item;
using Orion.Domain.Multiaqua.Item;
using Orion.Domain.Nortek.Item;
using Orion.Domain.NYLE.Item;
using Orion.Domain.PACE.Item;
using Orion.Domain.PlasmaAir.Item;
using Orion.Domain.Polaris.Item;
using Orion.Domain.PVI.Item;
using Orion.Domain.Robur.Item;
using Orion.Domain.UMAS.Item;
using Orion.Domain.Valent.Item;
using Orion.Domain.Whalen.Item;
using Orion.Helper.Extension;
using Orion.Helper.Misc;
using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Orion.Report.Pricing
{
    public class ReportSettings
    {
        public const string TemplatesPath = @"C:\temp\XPressPro Templates";

        public const string ProjectsPath = @"C:\temp\XPressPro Projects";

        public string pricingFilePath = Environment.CurrentDirectory + @"\ResourcePricing\PricingTemplate.docx";

        public String[] CreateSectionTitle(IItem item, int itemNumber)
        {
            return new[] { $"Item {GetColumnName(itemNumber)}) {item.Catalog.Company} : {item.Catalog.Product}" };
        }

        public List<PricingItem> CreateItemTable(IList<IItem> items, Section docSection, int itemNumber)
        {
            items = items.Where(x => !x.IsExcluded).OrderBy(x => x.DesignIndex).ToList();

            int itemsQuantity = items.Count;

            IItem tempItem = items.First();

            String[] sectionTitle = CreateSectionTitle(tempItem, itemNumber);

            String[] Header = GetHeader(tempItem);

            string[][] data = new string[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                data[i] = GetItemData(items[i]);
            }

            CreateItemTable(docSection, itemsQuantity, sectionTitle, Header, data);

            return GetPricingItems(items, tempItem, itemNumber);
        }

        public string[] GetHeader(IItem item)
        {
            if (item is ItemA1 || item is ItemA2 || item is ItemA3 || item is ItemA4)
                return new string[] { "Quantity", "Tag", "Model", "Tons", "Description", "Voltage" };



            else if (item is ItemB1)
                return new string[] { "Quantity", "Tag", "Model", "HP", "Description", "Nema", "Bypass", "Disconnect", "Voltage" };
            else if (item is ItemB5)
                return new string[] { "Quantity", "Tag", "Model", "Description" };



            else if (item is ItemC1)
                return new string[] { "Quantity", "Tag", "Model", "Description", "Size (in)", "Shipping Weight", "End Connection", "Product Type" };
            else if (item is ItemC2)
                return new string[] { "Quantity", "Tag", "Model", "System Flange (in)", "Pump Flange (in)", "Shipping Weight" };
            else if (item is ItemC3)
                return new string[] { "Quantity", "Tag", "Model", "Acceptable Volume (GPM)", "Diameter A (in)", "Height B (in)", "System Connect (in)", "Weight (lb)", "Working Pressure (PSI)", "Product Type" };
            else if (item is ItemC4)
                return new string[] { "Quantity", "Tag", "Model", "Acceptable Volume (GPM)", "Diameter A (in)", "Height B (in)", "System Connect (in)", "Weight (lb)", "Working Pressure (PSI)" };
            else if (item is ItemC5 || item is ItemC6)
                return new string[] { "Quantity", "Tag", "Model", "Description", "Volume (gal)", "Height A (in)", "Diameter B (in)", "Weight (lb)" };
            else if (item is ItemC7)
                return new string[] { "Quantity", "Tag", "Model", "Description" };



            else if (item is ItemE1)
                return new string[] { "Quantity", "Tag", "Base", "Model", "GPM", "TDH", "HP", "Motor", "RPM", "Electrical" };



            else if (item is ItemF1)
                return new string[] { "Quantity", "Tag", "Model", "Part Number", "Description" };



            else if (item is ItemG1)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Flow Rate", "Water Temp", "DesignWB", "Fluid Pressure Drop", "Fan Motors", "Pump Motor", "Voltage" };



            else if (item is ItemH1)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Flow Rate", "Water Temp", "DesignWB", "Fluid Pressure Drop", "Fan Motors", "Pump Motor", "Voltage" };



            else if (item is ItemI1)
                return new string[] { "Quantity", "Tag", "Model", "Unit Size", "Description", "Economizer", "Voltage" };
            else if (item is ItemI2)
                return new string[] { "Quantity", "Tag", "Model", "Description" };



            else if (item is ItemJ1)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Description", "CFM", "Voltage", "Weight" };



            else if (item is ItemK1 || item is ItemK2 || item is ItemK3)
                return new string[] { "Quantity", "Tag", "Model", "Description" };



            else if (item is ItemL1)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Description" };



            else if (item is ItemM1)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Description", "CFM", "Voltage", "Weight" };



            else if (item is ItemN1)
                return new string[] { "Quantity", "Tag", "Base", "Model", "CFM", "Cooling Capacity", "Refrigerant", "Voltage" };



            else if (item is ItemO1 || item is ItemO2)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Fuel Type", "Capacity", "Voltage" };



            else if (item is ItemP1)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Frame", "HP", "RPM", "Voltage", "Enclosure", "Efficiency", "Weight" };




            else if (item is ItemQ1)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Capacity (Lb/Hr)", "Voltage" };
            else if (item is ItemQ2)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Water Type", "Lb/Hr", "Voltage" };
            else if (item is ItemQ3)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Rate Capacity (Lb/Hr)", "RO System Output", "Voltage" };
            else if (item is ItemQ4)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Capacity (Lb/Hr)", "Distributor", "Voltage" };



            else if (item is ItemR1 || item is ItemR2 || item is ItemR3 || item is ItemR4)
                return new string[] { "Quantity", "Tag", "Base", "Model", "CFM", "CHW - Capacity (BTU/Hr)", "CHW - (Rows/FPI)", "HW - Capacity (BTU/Hr)2", "HW - (Rows/FPI)", "Voltage" };



            else if (item is ItemS1)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Heating Capacity", "Cooling Capacity", "Refirgerant", "Voltage" };



            else if (item is ItemT1)
                return new string[] { "Quantity", "Tag", "Base", "Model", "CFM", "Size (HxW)", "Rows", "FPI" };
            else if (item is ItemT2)
                return new string[] { "Quantity", "Tag", "Base", "Model", "CFM", "Voltage" };
            else if (item is ItemT3)
                return new string[] { "Quantity", "Tag", "Base", "Model", "CFM", "TSP", "BHP", "Total HP", "VFD HP", "Active Fans", "Fan Arrays", "Cell (WxH)", "Array (WxH)" };



            else if (item is ItemU1)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Heating Capacity", "Cooling Capacity", "Compressor", "Voltage" };



            else if (item is ItemV1)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Airflow Capacity", "No. Ionization Modules", "Voltage" };



            else if (item is ItemW1)
                return new string[] { "Quantity", "Tag", "Base", "Model", "CFM", "Hot Side GPM", "Hot Side (EWT(F) / LWT(F))", "Cold Side GPM", "Cold Side (EWT(F) / LWT(F))" };



            else if (item is ItemX1)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Weight (Lb)" };
            else if (item is ItemX2)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Capacity" };
            else if (item is ItemX3)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Tank", "Connection", "Location" };
            else if (item is ItemX4)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Weight (Lb)" };
            else if (item is ItemX5)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Weight (Lb)" };



            else if (item is ItemY1)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Cooling Nominal Tons", "Heating MBH Output", "Fuel", "Voltage" };



            else if (item is ItemZ1)
                return new string[] { "Quantity", "Tag", "Base", "Model", "CFM", "Voltage" };



            else if (item is ItemAA1)
                return new string[] { "Quantity", "Tag", "Base", "Model", "Voltage" };

            return null;
        }

        public string[] GetItemData(IItem pItem)
        {
            if (pItem is ItemA1)
            {
                ItemA1 item = (ItemA1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogA1.Model, item.Tons, item.CatalogA1.Description, item.CatalogA1.Voltage };
            }
            else if (pItem is ItemA2)
            {
                ItemA2 item = (ItemA2)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogA2.Model, item.Tons, item.CatalogA2.Description, item.CatalogA2.Voltage };
            }
            else if (pItem is ItemA3)
            {
                ItemA3 item = (ItemA3)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogA3.Model, item.Tons, item.CatalogA3.Description, item.CatalogA3.Voltage };
            }
            else if (pItem is ItemA4)
            {
                ItemA4 item = (ItemA4)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogA4.Model, item.Tons, item.CatalogA4.Description, item.CatalogA4.Voltage };
            }



            else if (pItem is ItemB1)
            {
                ItemB1 item = (ItemB1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogB1.Model, item.CatalogB1.Hp.ToString(), item.CatalogB1.Description, item.CatalogB1.Nema, item.CatalogB1.Bypass.ToYesNo(), item.CatalogB1.CircuitBreakerDisconnect.ToYesNo(), item.CatalogB1.Voltage };
            }
            else if (pItem is ItemB5)
            {
                ItemB5 item = (ItemB5)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogB5.Model, item.CatalogB5.Description };
            }



            else if (pItem is ItemC1)
            {
                ItemC1 item = (ItemC1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogC1.Model, item.CatalogC1.Description, item.CatalogC1.Size, item.CatalogC1.ShippingWeight, item.CatalogC1.EndConnection, item.CatalogC1.CatalogC1ProductType.Name };
            }
            else if (pItem is ItemC2)
            {
                ItemC2 item = (ItemC2)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogC2.Model, item.CatalogC2.SystemFlange, item.CatalogC2.PumpFlange, item.CatalogC2.ShippingWeight };
            }
            else if (pItem is ItemC3)
            {
                ItemC3 item = (ItemC3)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogC3.Model, item.CatalogC3.AcceptableVolume, item.CatalogC3.DiameterA, item.CatalogC3.HeightB, item.CatalogC3.SystemConnect, item.CatalogC3.Weight, item.CatalogC3.WorkingPressure, item.CatalogC3.CatalogC3ProductType.Name };
            }
            else if (pItem is ItemC4)
            {
                ItemC4 item = (ItemC4)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogC4.Model, item.CatalogC4.AcceptableVolume, item.CatalogC4.DiameterA, item.CatalogC4.HeightB, item.CatalogC4.SystemConnect, item.CatalogC4.Weight, item.CatalogC4.WorkingPressure };
            }
            else if (pItem is ItemC5)
            {
                ItemC5 item = (ItemC5)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogC5.Model, item.CatalogC5.Description, item.CatalogC5.Volume, item.CatalogC5.HeightA, item.CatalogC5.DiameterB, item.CatalogC5.Weight };
            }
            else if (pItem is ItemC6)
            {
                ItemC6 item = (ItemC6)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogC6.Model, item.CatalogC6.Description, item.CatalogC6.Volume, item.CatalogC6.HeightA, item.CatalogC6.DiameterB, item.CatalogC6.Weight };
            }
            else if (pItem is ItemC7)
            {
                ItemC7 item = (ItemC7)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogC7.Model, item.CatalogC7.Description };
            }



            else if (pItem is ItemE1)
            {
                ItemE1 item = (ItemE1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogE1.Model, item.Model, item.Gpm, item.Tdh, item.Hp, item.Motor, item.Rpm, item.Electrical };
            }



            else if (pItem is ItemF1)
            {
                ItemF1 item = (ItemF1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogF1.Model, item.CatalogF1.PartNumber, item.CatalogF1.Description };
            }



            else if (pItem is ItemG1)
            {
                ItemG1 item = (ItemG1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogG1.Model, item.Model, item.FlowRate, item.WaterTemp, item.DesignWB, item.FluidPressureDrop, item.FanMotors, item.PumpMotor, item.Voltage };
            }



            else if (pItem is ItemH1)
            {
                ItemH1 item = (ItemH1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogH1.Model, item.Model, item.FlowRate, item.WaterTemp, item.DesignWB, item.FluidPressureDrop, item.FanMotors, item.PumpMotor, item.Voltage };
            }



            else if (pItem is ItemI1)
            {
                ItemI1 item = (ItemI1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogI1.Model, item.CatalogI1.UnitSize, item.CatalogI1.Description, item.CatalogI1.Economizer.ToYesNo(), item.CatalogI1.Voltage };
            }
            else if (pItem is ItemI2)
            {
                ItemI2 item = (ItemI2)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogI2.Model, item.CatalogI2.Description };
            }



            else if (pItem is ItemJ1)
            {
                ItemJ1 item = (ItemJ1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogJ1.Model, item.Model, item.CatalogJ1.Description, item.Cfm, item.Voltage, item.Weight };
            }



            else if (pItem is ItemK1)
            {
                ItemK1 item = (ItemK1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogK1.Model, item.CatalogK1.Description };
            }
            else if (pItem is ItemK2)
            {
                ItemK2 item = (ItemK2)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogK2.Model, item.CatalogK2.Description };
            }
            else if (pItem is ItemK3)
            {
                ItemK3 item = (ItemK3)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogK3.Model, item.CatalogK3.Description };
            }



            else if (pItem is ItemL1)
            {
                ItemL1 item = (ItemL1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogL1.Model, item.Model, item.Description };
            }



            else if (pItem is ItemM1)
            {
                ItemM1 item = (ItemM1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogM1.Model, item.Model, item.CatalogM1.Description, item.Cfm, item.Voltage, item.Weight };
            }



            else if (pItem is ItemN1)
            {
                ItemN1 item = (ItemN1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogN1.Model, item.Model, item.Cfm, item.CoolingCapacity, item.Refrigerant, item.Voltage };
            }



            else if (pItem is ItemO1)
            {
                ItemO1 item = (ItemO1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogO1.Model, item.Model, item.FuelType, item.Capacity, item.Voltage };
            }
            else if (pItem is ItemO2)
            {
                ItemO2 item = (ItemO2)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogO2.Model, item.Model, item.FuelType, item.Capacity, item.Voltage };
            }



            else if (pItem is ItemP1)
            {
                ItemP1 item = (ItemP1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogP1.Model, item.Model, item.Frame, item.Hp, item.Rpm, item.Voltage, item.Enclosure, item.Efficiency, item.Weight };
            }



            else if (pItem is ItemQ1)
            {
                ItemQ1 item = (ItemQ1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogQ1.Model, item.Model, item.Capacity, item.Voltage };
            }
            else if (pItem is ItemQ2)
            {
                ItemQ2 item = (ItemQ2)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogQ2.Model, item.Model, item.WaterType, item.LbsHr, item.Voltage };
            }
            else if (pItem is ItemQ3)
            {
                ItemQ3 item = (ItemQ3)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogQ3.Model, item.Model, item.RateCapacity, item.RoSystemOutput, item.Voltage };
            }
            else if (pItem is ItemQ4)
            {
                ItemQ4 item = (ItemQ4)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogQ4.Model, item.Model, item.Capacity, item.Distributor, item.Voltage };
            }



            else if (pItem is ItemR1)
            {
                ItemR1 item = (ItemR1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogR1.Model, item.Model, item.Cfm, item.ChwCapacity, item.ChwRowsFpi, item.HwCapacity, item.HwRowsFpi, item.Voltage };
            }
            else if (pItem is ItemR2)
            {
                ItemR2 item = (ItemR2)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogR2.Model, item.Model, item.Cfm, item.ChwCapacity, item.ChwRowsFpi, item.HwCapacity, item.HwRowsFpi, item.Voltage };
            }
            else if (pItem is ItemR3)
            {
                ItemR3 item = (ItemR3)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogR3.Model, item.Model, item.Cfm, item.ChwCapacity, item.ChwRowsFpi, item.HwCapacity, item.HwRowsFpi, item.Voltage };
            }
            else if (pItem is ItemR4)
            {
                ItemR4 item = (ItemR4)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogR4.Model, item.Model, item.Cfm, item.ChwCapacity, item.ChwRowsFpi, item.HwCapacity, item.HwRowsFpi, item.Voltage };
            }



            else if (pItem is ItemS1)
            {
                ItemS1 item = (ItemS1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogS1.Model, item.Model, item.HeatingCapacity, item.CoolingCapacity, item.Refrigerant, item.Voltage };
            }



            else if (pItem is ItemT1)
            {
                ItemT1 item = (ItemT1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogT1.Model, item.Model, item.Cfm, item.Size, item.Rows, item.Fpi };
            }
            else if (pItem is ItemT2)
            {
                ItemT2 item = (ItemT2)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogT2.Model, item.Model, item.Cfm, item.Voltage };
            }
            else if (pItem is ItemT3)
            {
                ItemT3 item = (ItemT3)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogT3.Model, item.Model, item.Cfm, item.Tsp, item.Bhp, item.TotalHp, item.VfdHp, item.ActiveFans, item.FanArrays, item.Cell, item.Array };
            }



            else if (pItem is ItemU1)
            {
                ItemU1 item = (ItemU1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogU1.Model, item.Model, item.HeatingCapacity, item.CoolingCapacity, item.Compressor, item.Voltage };
            }



            else if (pItem is ItemV1)
            {
                ItemV1 item = (ItemV1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogV1.Model, item.Model, item.AirFlowCapacity, item.NoIonizationModules, item.Voltage };
            }



            else if (pItem is ItemW1)
            {
                ItemW1 item = (ItemW1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogW1.Model, item.Model, item.Cfm, item.HotSideGpm, item.HotSideEwt, item.ColdSideGpm, item.ColdSideEwt };
            }



            else if (pItem is ItemX1)
            {
                ItemX1 item = (ItemX1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogX1.Model, item.Model, item.Weight };
            }
            else if (pItem is ItemX2)
            {
                ItemX2 item = (ItemX2)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogX2.Model, item.Model, item.Capacity };
            }
            else if (pItem is ItemX3)
            {
                ItemX3 item = (ItemX3)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogX3.Model, item.Model, item.Tank, item.Connection, item.Location };
            }
            else if (pItem is ItemX4)
            {
                ItemX4 item = (ItemX4)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogX4.Model, item.Model, item.Weight };
            }
            else if (pItem is ItemX5)
            {
                ItemX5 item = (ItemX5)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogX5.Model, item.Model, item.Weight };
            }



            else if (pItem is ItemY1)
            {
                ItemY1 item = (ItemY1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogY1.Model, item.Model, item.CoolingNominalTons, item.HeatingMbhOutput, item.Fuel, item.Voltage };
            }



            else if (pItem is ItemZ1)
            {
                ItemZ1 item = (ItemZ1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogZ1.Model, item.Model, item.Cfm, item.Voltage };
            }



            else if (pItem is ItemAA1)
            {
                ItemAA1 item = (ItemAA1)pItem;
                return new string[] { item.Quantity.ToString(), item.Tag, item.CatalogAA1.Model, item.Model, item.Voltage };
            }



            return null;
        }

        public string JoinTags(IList<IItem> items)
        {
            string tags = "";

            //items.ToList().ForEach(x => tags += $"[{x.Tag}]({x.Quantity}) ");
            items.ToList().ForEach(x => tags += $"[{x.Tag}] ");
            return tags;
        }
        public int JoinQuantities(IList<IItem> items)
        {
            int qty = 0;

            items.ToList().ForEach(x => qty += x.Quantity);

            return qty;
        }

        public double JoinSellPrices(IList<IItem> items)
        {
            double sellPrice = 0;

            items.ToList().ForEach(x => sellPrice += x.OverridePrice ? (x.Quantity * x.SellPrice.RoundUp()) : (x.Quantity * x.Catalog.SellPrice.RoundUp()));

            return sellPrice;

        }

        public double JoinFreights(IList<IItem> items)
        {
            return (items.Sum(x => x.Freight.RoundUp()));

        }

        public string GetColumnName(int number)
        {
            if (number < 1)
            {
                throw new ArgumentException("Number must be a positive integer.");
            }

            StringBuilder columnName = new StringBuilder();

            while (number > 0)
            {
                int remainder = (number - 1) % 26;
                columnName.Insert(0, (char)(65 + remainder));
                number = (number - 1) / 26;
            }

            return columnName.ToString();
        }



        public Table CreateItemTable(Section docSection, int itemsQuantity, string[] sectionTitle, string[] Header, string[][] data, bool KeepInSamePage = true)
        {
            Table table = docSection.AddTable(true);
            table.TableFormat.IsBreakAcrossPages = false;

            table.ResetCells(itemsQuantity + 2, Header.Length);
            table.TableFormat.HorizontalAlignment = RowAlignment.Center;

            TableRow titleRow = table.Rows[0];

            titleRow.RowFormat.BackColor = Color.FromArgb(155, 194, 230);

            Paragraph tp = titleRow.Cells[0].AddParagraph();
            titleRow.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            tp.Format.HorizontalAlignment = HorizontalAlignment.Center;
            tp.Format.BeforeSpacing = 0;
            tp.Format.AfterSpacing = 0;
            tp.Format.LineSpacing = 10;
            TextRange tRange = tp.AppendText(sectionTitle[0]);
            tRange.CharacterFormat.FontName = "Arial Narrow";
            tRange.CharacterFormat.FontSize = 10;
            tRange.CharacterFormat.TextColor = Color.Black;
            tRange.CharacterFormat.Bold = true;

            table.ApplyHorizontalMerge(0, 0, Header.Count() - 1);

            TableRow headerRow = table.Rows[1];

            headerRow.RowFormat.BackColor = Color.FromArgb(155, 194, 230);


            for (int i = 0; i < Header.Length; i++)
            {

                table.Rows[0].Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                TableCell cell = headerRow.Cells[i];
                cell.CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                Paragraph paragraph = headerRow.Cells[i].AddParagraph();
                paragraph.Format.HorizontalAlignment = HorizontalAlignment.Center;
                paragraph.Format.BeforeSpacing = 0;
                paragraph.Format.AfterSpacing = 0;
                paragraph.Format.LineSpacing = 10;
                TextRange textRange = paragraph.AppendText(Header[i]);
                textRange.CharacterFormat.FontName = "Arial Narrow";
                textRange.CharacterFormat.FontSize = 10;
                textRange.CharacterFormat.TextColor = Color.Black;
                textRange.CharacterFormat.Bold = true;
            }


            for (int r = 0; r < data.Length; r++)
            {
                TableRow DataRow = table.Rows[r + 2];

                for (int c = 0; c < data[r].Length; c++)
                {
                    TableCell cell = DataRow.Cells[c];

                    cell.CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                    Paragraph p2 = DataRow.Cells[c].AddParagraph();

                    TextRange TR2 = p2.AppendText(data[r][c]);

                    p2.Format.HorizontalAlignment = HorizontalAlignment.Center;
                    p2.Format.BeforeSpacing = 0;
                    p2.Format.AfterSpacing = 0;
                    p2.Format.LineSpacing = 10;
                    TR2.CharacterFormat.FontName = "Arial Narrow";
                    TR2.CharacterFormat.FontSize = 10;
                    TR2.CharacterFormat.TextColor = Color.Black;
                }
            }
            table.AutoFit(AutoFitBehaviorType.AutoFitToWindow);
            if (KeepInSamePage)
            {
                KeepTableInSamePage(table);
            }
            return table;
        }

        public void CreatePricingItemAndSpecsTable(Section docSection, int itemsQuantity, string[] sectionTitle, string[] Header, string[][] data)
        {
            Table table = docSection.AddTable(true);
            table.TableFormat.IsBreakAcrossPages = false;

            table.ResetCells(itemsQuantity + 2, Header.Length);
            table.TableFormat.HorizontalAlignment = RowAlignment.Center;

            TableRow titleRow = table.Rows[0];

            titleRow.RowFormat.BackColor = Color.FromArgb(155, 194, 230);

            Paragraph tp = titleRow.Cells[0].AddParagraph();
            titleRow.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            tp.Format.HorizontalAlignment = HorizontalAlignment.Center;
            tp.Format.BeforeSpacing = 0;
            tp.Format.AfterSpacing = 0;
            tp.Format.LineSpacing = 10;
            TextRange tRange = tp.AppendText(sectionTitle[0]);
            tRange.CharacterFormat.FontName = "Arial Narrow";
            tRange.CharacterFormat.FontSize = 10;
            tRange.CharacterFormat.TextColor = Color.Black;
            tRange.CharacterFormat.Bold = true;

            table.ApplyHorizontalMerge(0, 0, Header.Count() - 1);

            TableRow headerRow = table.Rows[1];

            headerRow.RowFormat.BackColor = Color.FromArgb(155, 194, 230);


            for (int i = 0; i < Header.Length; i++)
            {

                table.Rows[0].Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                TableCell cell = headerRow.Cells[i];
                cell.CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                Paragraph paragraph = headerRow.Cells[i].AddParagraph();
                paragraph.Format.HorizontalAlignment = HorizontalAlignment.Center;
                paragraph.Format.BeforeSpacing = 0;
                paragraph.Format.AfterSpacing = 0;
                paragraph.Format.LineSpacing = 10;
                TextRange textRange = paragraph.AppendText(Header[i]);
                textRange.CharacterFormat.FontName = "Arial Narrow";
                textRange.CharacterFormat.FontSize = 10;
                textRange.CharacterFormat.TextColor = Color.Black;
                textRange.CharacterFormat.Bold = true;
            }


            for (int r = 0; r < data.Length; r++)
            {
                TableRow DataRow = table.Rows[r + 2];

                bool itemNumberEmpty = string.IsNullOrWhiteSpace(data[r][0]);
                bool itemQuantityEmpty = string.IsNullOrWhiteSpace(data[r][2]);


                for (int c = 0; c < data[r].Length; c++)
                {

                    TableCell cell = DataRow.Cells[c];
                     
                    cell.CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                    Paragraph p2 = DataRow.Cells[c].AddParagraph();

                    TextRange TR2 = p2.AppendText(data[r][c]);

                    p2.Format.HorizontalAlignment = HorizontalAlignment.Center;
                    p2.Format.BeforeSpacing = 0;
                    p2.Format.AfterSpacing = 0;
                    p2.Format.LineSpacing = 10;

                    if (itemNumberEmpty && itemQuantityEmpty)
                    {
                        TR2.CharacterFormat.FontName = "Arial Narrow";
                        TR2.CharacterFormat.FontSize = 10;
                        TR2.CharacterFormat.Bold = true;
                        //cell.CellFormat.BackColor = Color.FromArgb(0, 135, 176, 54);
                        //cell.CellFormat.BackColor = Color.DarkCyan;
                        TR2.CharacterFormat.TextColor = Color.DarkBlue;
                    }
                    else if (!itemNumberEmpty && !itemQuantityEmpty)
                    {
                        TR2.CharacterFormat.FontName = "Arial Narrow";
                        TR2.CharacterFormat.FontSize = 10;
                        TR2.CharacterFormat.TextColor = Color.Black;
                        //cell.CellFormat.BackColor = Color.FromArgb(0, 255, 204, 102);
                        //cell.CellFormat.BackColor = Color.FromArgb(0, 135, 176, 54);

                        TR2.CharacterFormat.Bold = true;
                    }
                    else
                    {
                        TR2.CharacterFormat.FontName = "Arial Narrow";
                        TR2.CharacterFormat.FontSize = 10;
                        TR2.CharacterFormat.TextColor = Color.Black;
                        if (c == 3)
                            p2.ApplyStyle(BuiltinStyle.ListBullet);
                    }
                }
            }
            table.AutoFit(AutoFitBehaviorType.AutoFitToWindow);

            KeepTableInSamePage(table);
        }

        public void CreateResultTable(Section docSection, string[][] data)
        {
            Table table = docSection.AddTable(true);
            table.TableFormat.IsBreakAcrossPages = false;

            table.ResetCells(2, 1);
            table.TableFormat.HorizontalAlignment = RowAlignment.Center;

            TableRow titleRow = table.Rows[0];

            titleRow.RowFormat.BackColor = Color.FromArgb(155, 194, 230);

            Paragraph tp = titleRow.Cells[0].AddParagraph();
            titleRow.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            tp.Format.HorizontalAlignment = HorizontalAlignment.Center;
            tp.Format.BeforeSpacing = 0;
            tp.Format.AfterSpacing = 0;
            tp.Format.LineSpacing = 10;
            TextRange tRange = tp.AppendText("Grand Total");
            tRange.CharacterFormat.FontName = "Arial Narrow";
            tRange.CharacterFormat.FontSize = 10;
            tRange.CharacterFormat.TextColor = Color.Black;
            tRange.CharacterFormat.Bold = true;

            for (int r = 0; r < data.Length; r++)
            {
                TableRow DataRow = table.Rows[r + 1];

                for (int c = 0; c < data[r].Length; c++)
                {
                    TableCell cell = DataRow.Cells[c];

                    cell.CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                    Paragraph p2 = DataRow.Cells[c].AddParagraph();

                    TextRange TR2 = p2.AppendText(data[r][c]);

                    p2.Format.HorizontalAlignment = HorizontalAlignment.Left;
                    p2.Format.BeforeSpacing = 0;
                    p2.Format.AfterSpacing = 0;
                    p2.Format.LineSpacing = 10;
                    TR2.CharacterFormat.FontName = "Arial Narrow";
                    TR2.CharacterFormat.FontSize = 10;
                    TR2.CharacterFormat.TextColor = Color.Black;
                }
            }
            table.TableFormat.HorizontalAlignment = RowAlignment.Right;
            table.AutoFit(AutoFitBehaviorType.AutoFitToContents);
            KeepTableInSamePage(table);

        }




        public void SaveAndConvertToPdf(Document document, string filePath)
        {
            document.SaveToFile(filePath, FileFormat.Docx);

            document.Close();

            document = new Document();

            document.LoadFromFile(filePath);

            document.SaveToFile(Path.ChangeExtension(filePath, ".pdf"), FileFormat.PDF);

            document.Close();
        }

        public void SetSectionMargin(Section section, float value)
        {

            section.PageSetup.Margins.Top = section.PageSetup.Margins.Left = section.PageSetup.Margins.Right = section.PageSetup.Margins.Bottom = value;

            section.PageSetup.PageSize = PageSize.A4;
        }

        public void KeepTableInSamePage(Table table)
        {
            foreach (TableRow tableRow in table.Rows)
            {
                TableCell cell = tableRow.Cells.FirstItem as TableCell;
                foreach (Paragraph paragraph in cell.Paragraphs)
                {
                    paragraph.Format.KeepFollow = true;
                }
            }
        }

        public void AddBlankLine(Document document, Section docSection)
        {
            //Paragraph paragraph = new Paragraph(document);
            //paragraph.AppendText("");
            //TextBodyPart textBodyPart = new TextBodyPart(document);
            //textBodyPart.BodyItems.Add(paragraph);
            //docSection.Paragraphs.Add(paragraph);

            Paragraph paragraph = docSection.AddParagraph();
            TextRange textRange = paragraph.AppendText("");
            textRange.CharacterFormat.FontName = "Arial Narrow";
            paragraph.Format.BeforeSpacing = 0;
            paragraph.Format.AfterSpacing = 0;
            paragraph.Format.LineSpacing = 10;
            textRange.CharacterFormat.FontSize = 10;
        }

        public void AddTitlesAndSpecs(IList<IItem> items, Section section)
        {
            List<DataSheet> dataSheets = items.Where(x => x.Catalog.DataSheet != null).Select(x => x.Catalog.DataSheet).GroupBy(x => x.Id).Select(x => x.First()).ToList();

            foreach (DataSheet dataSheet in dataSheets)
            {

                List<IItem> dataSheetItems = items.Where(x => x.Catalog.DataSheet != null && x.Catalog.DataSheet.Id == dataSheet.Id).ToList();

                foreach (Title title in dataSheet.Titles)
                {
                    AddTitlesAndSpecsText(section, title.Name + " " + JoinTags(dataSheetItems), title, true);

                    foreach (Spec spec in title.Specs)
                    {
                        AddTitlesAndSpecsText(section, spec.Name, spec);
                    }
                }

                foreach (IItem item in dataSheetItems.Where(x => x.Titles.Any()))
                {
                    foreach (Title title in item .Titles)
                    {
                        //AddTitlesAndSpecsText(section, title.Name + $" [{item.Tag}]({item.Quantity})", true);
                        AddTitlesAndSpecsText(section, title.Name + $" [{item.Tag}]", title, true);


                        foreach (Spec spec in title.Specs)
                        {
                            AddTitlesAndSpecsText(section, spec.Name, spec);
                        }
                    }
                }
            }

            List<IItem> noDataSheetItems = items.Where(x => x.Catalog.DataSheet == null).ToList();
            
            foreach (IItem item in noDataSheetItems.Where(x => x.Titles.Any()))
            {
                foreach (Title title in item.Titles)
                {
                    //AddTitlesAndSpecsText(section, title.Name + $" [{item.Tag}]({item.Quantity})", true);
                    AddTitlesAndSpecsText(section, title.Name + $" [{item.Tag}]", title, true);


                    foreach (Spec spec in title.Specs)
                    {
                        AddTitlesAndSpecsText(section, spec.Name, spec);
                    }
                }
            }
        }

        public List<PricingItem> GetPricingItems(IList<IItem> items, IItem tempItem, int itemNumber)
        {
            List<PricingItem> pricingItems = new List<PricingItem>();

            if (GV.Extended)
            {
                foreach (IItem item in items)
                {
                    pricingItems.Add(new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(new List<IItem>() { item }), JoinTags(new List<IItem>() { item }), JoinQuantities(new List<IItem>() { item }), tempItem.Catalog.Company, JoinFreights(new List<IItem>() { item }), item));

                    foreach (Title title in item.Titles)
                    {
                        if (title.Specs.All(x => x.Price <= 0))
                            continue;

                        //pricingItems.Add(new PricingItem(0, title.Name, 0, $"[{item.Tag}]({item.Quantity})", 0, tempItem.Catalog.Company, true, false));
                        pricingItems.Add(new PricingItem(0, title.Name, 0, $"[{item.Tag}]", 0, tempItem.Catalog.Company, 0, null, true, false));

                        foreach (Spec spec in title.Specs)
                        {
                            if (spec.Price <= 0)
                                continue;

                            //pricingItems.Add(new PricingItem(0, spec.Name, spec.Price, $"[{item.Tag}]({item.Quantity})", 1, tempItem.Catalog.Company, false, true));
                            pricingItems.Add(new PricingItem(0, spec.Name, spec.Price.RoundUp(), $"[{item.Tag}]", 1, tempItem.Catalog.Company, 0, null, false, true));
                        }
                    }
                }
            }
            else
            {

                pricingItems.Add(new PricingItem(itemNumber, tempItem.Catalog.Product, JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()), tempItem.Catalog.Company, JoinFreights(items.ToList<IItem>()),items.First()));

                //pricingItems.Add(new PricingItem(itemNumber,$"{tempItem.Catalog.Company}: {tempItem.Catalog.Product}", JoinSellPrices(items.ToList<IItem>()), JoinTags(items.ToList<IItem>()), JoinQuantities(items.ToList<IItem>()), tempItem.Catalog.Company, JoinFreights(items.ToList<IItem>())));


                foreach (IItem item in items.Where(x => x.Titles.Any()))
                {
                    foreach (Title title in item.Titles)
                    {
                        if (title.Specs.All(x => x.Price <= 0))
                            continue;

                        //pricingItems.Add(new PricingItem(0, title.Name, 0, $"[{item.Tag}]({item.Quantity})", 0, tempItem.Catalog.Company, true, false));
                        pricingItems.Add(new PricingItem(0, title.Name, 0, $"[{item.Tag}]", 0, tempItem.Catalog.Company,0, null, true, false));


                        foreach (Spec spec in title.Specs)
                        {
                            if (spec.Price <= 0)
                                continue;

                            //pricingItems.Add(new PricingItem(0, spec.Name, spec.Price, $"[{item.Tag}]({item.Quantity})", 1, tempItem.Catalog.Company, false, true));
                            pricingItems.Add(new PricingItem(0, spec.Name, spec.Price.RoundUp(), $"[{item.Tag}]", 1, tempItem.Catalog.Company,0, null, false, true));
                        }
                    }
                }
            }

            return pricingItems;
        }

        public void AddTitlesAndSpecsText(Section docSection, string text, ITexteable texteable, bool isTitle = false)
        {

            Paragraph paragraph = docSection.AddParagraph();
            TextRange textRange = null;
            if (isTitle)
            {
                textRange = paragraph.AppendText( "\n" + text);
                textRange.CharacterFormat.Bold = true;
                //textRange.CharacterFormat.TextColor = Color.DarkCyan;
                textRange.CharacterFormat.TextColor = Color.DarkBlue;
            }
            else
            {
                textRange = paragraph.AppendText(text);
                paragraph.ApplyStyle(BuiltinStyle.ListBullet);
            }
            textRange.CharacterFormat.FontName = "Arial Narrow";

            if (texteable.Highlighted)
            {
               textRange.CharacterFormat.Bold = true;
               textRange.CharacterFormat.TextColor = Color.Red;
                textRange.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            }

            paragraph.Format.BeforeSpacing = 0;
            paragraph.Format.AfterSpacing = 0;
            paragraph.Format.LineSpacing = 10;
            textRange.CharacterFormat.FontSize = 10;
        }

        public Document LoadDocument(string filePath)
        {
            Document document = new Document();

            document.LoadFromFile(filePath, FileFormat.Docx);

            CreateStyles(document);

            return document;
        }

        public void CreateStyles(Document document)
        {
            //ParagraphStyle calibriStyle10 = new ParagraphStyle(document);
            //calibriStyle10.Name = "calibriStyle10";
            //calibriStyle10.CharacterFormat.Bold = false;
            //calibriStyle10.CharacterFormat.TextColor = Color.Black;
            //calibriStyle10.CharacterFormat.FontSize = 10;
            //calibriStyle10.CharacterFormat.FontName = "Calibri";
            //calibriStyle10.ParagraphFormat.BeforeSpacing = 0;
            //calibriStyle10.ParagraphFormat.AfterSpacing = 0;
            //calibriStyle10.ParagraphFormat.LineSpacing = 10;
            //document.Styles.Add(calibriStyle10);

            //ParagraphStyle calibriStyle12 = new ParagraphStyle(document);
            //calibriStyle12.Name = "calibriStyle12";
            //calibriStyle12.CharacterFormat.Bold = false;
            //calibriStyle12.CharacterFormat.TextColor = Color.Black;
            //calibriStyle12.CharacterFormat.FontSize = 12;
            //calibriStyle12.CharacterFormat.FontName = "Calibri";
            //calibriStyle12.ParagraphFormat.BeforeSpacing = 0;
            //calibriStyle12.ParagraphFormat.AfterSpacing = 0;
            //calibriStyle12.ParagraphFormat.LineSpacing = 10;
            //document.Styles.Add(calibriStyle12);

            ////Century Gothic
            //ParagraphStyle centuryGothicStyle8 = new ParagraphStyle(document);
            //centuryGothicStyle8.Name = "centuryGothicStyle8";
            //centuryGothicStyle8.CharacterFormat.Bold = false;
            //centuryGothicStyle8.CharacterFormat.TextColor = Color.Black;
            //centuryGothicStyle8.CharacterFormat.FontSize = 8;
            //centuryGothicStyle8.CharacterFormat.FontName = "Century Gothic";
            //centuryGothicStyle8.ParagraphFormat.BeforeSpacing = 0;
            //centuryGothicStyle8.ParagraphFormat.AfterSpacing = 0;
            //centuryGothicStyle8.ParagraphFormat.LineSpacing = 10;
            //document.Styles.Add(centuryGothicStyle8);

            //ParagraphStyle style24 = new ParagraphStyle(document);
            //style24.Name = "style24";
            //style24.CharacterFormat.Bold = false;
            //style24.CharacterFormat.TextColor = Color.Black;
            //style24.CharacterFormat.FontSize = 24;
            //style24.CharacterFormat.FontName = "Arial";
            //style24.ParagraphFormat.BeforeSpacing = 0;
            //style24.ParagraphFormat.AfterSpacing = 0;
            //document.Styles.Add(style24);

            //ParagraphStyle style20 = new ParagraphStyle(document);
            //style20.Name = "style20";
            //style20.CharacterFormat.Bold = false;
            //style20.CharacterFormat.TextColor = Color.Black;
            //style20.CharacterFormat.FontSize = 20;
            //style20.CharacterFormat.FontName = "Arial";
            //style20.ParagraphFormat.BeforeSpacing = 0;
            //style20.ParagraphFormat.AfterSpacing = 0;
            //document.Styles.Add(style20);

            //ParagraphStyle style18 = new ParagraphStyle(document);
            //style18.Name = "style18";
            //style18.CharacterFormat.Bold = false;
            //style18.CharacterFormat.TextColor = Color.Black;
            //style18.CharacterFormat.FontSize = 18;
            //style18.CharacterFormat.FontName = "Arial";
            //style18.ParagraphFormat.BeforeSpacing = 0;
            //style18.ParagraphFormat.AfterSpacing = 0;
            //document.Styles.Add(style18);

            //ParagraphStyle style14 = new ParagraphStyle(document);
            //style14.Name = "style14";
            //style14.CharacterFormat.Bold = false;
            //style14.CharacterFormat.TextColor = Color.Black;
            //style14.CharacterFormat.FontSize = 14;
            //style14.CharacterFormat.FontName = "Arial";
            //style14.ParagraphFormat.BeforeSpacing = 0;
            //style14.ParagraphFormat.AfterSpacing = 0;
            //document.Styles.Add(style14);

            //ParagraphStyle style16 = new ParagraphStyle(document);
            //style16.Name = "style16";
            //style16.CharacterFormat.Bold = false;
            //style16.CharacterFormat.TextColor = Color.Black;
            //style16.CharacterFormat.FontSize = 16;
            //style16.CharacterFormat.FontName = "Arial";
            //style16.ParagraphFormat.BeforeSpacing = 0;
            //style16.ParagraphFormat.AfterSpacing = 0;
            //document.Styles.Add(style16);

            //ParagraphStyle style16WhiteAndBold = new ParagraphStyle(document);
            //style16WhiteAndBold.Name = "style16WhiteAndBold";
            //style16WhiteAndBold.CharacterFormat.Bold = true;
            //style16WhiteAndBold.CharacterFormat.TextColor = Color.White;
            //style16WhiteAndBold.CharacterFormat.FontSize = 16;
            //style16WhiteAndBold.CharacterFormat.FontName = "Arial";
            //style16WhiteAndBold.ParagraphFormat.BeforeSpacing = 0;
            //style16WhiteAndBold.ParagraphFormat.AfterSpacing = 0;
            //document.Styles.Add(style16WhiteAndBold);

            //ParagraphStyle style11 = new ParagraphStyle(document);
            //style11.Name = "style11";
            //style11.CharacterFormat.Bold = false;
            //style11.CharacterFormat.TextColor = Color.Black;
            //style11.CharacterFormat.FontSize = 11;
            //style11.CharacterFormat.FontName = "Arial";
            //style11.ParagraphFormat.BeforeSpacing = 0;
            //style11.ParagraphFormat.AfterSpacing = 0;
            //style11.ParagraphFormat.LineSpacing = 10;
            //document.Styles.Add(style11);

            //ParagraphStyle style11WhiteAndBold = new ParagraphStyle(document);
            //style11WhiteAndBold.Name = "style11WhiteAndBold";
            //style11WhiteAndBold.CharacterFormat.Bold = true;
            //style11WhiteAndBold.CharacterFormat.TextColor = Color.White;
            //style11WhiteAndBold.CharacterFormat.FontSize = 11;
            //style11WhiteAndBold.CharacterFormat.FontName = "Arial";
            //style11WhiteAndBold.ParagraphFormat.BeforeSpacing = 0;
            //style11WhiteAndBold.ParagraphFormat.AfterSpacing = 0;
            //style11WhiteAndBold.ParagraphFormat.LineSpacing = 10;
            //document.Styles.Add(style11WhiteAndBold);

            //ParagraphStyle style12 = new ParagraphStyle(document);
            //style12.Name = "style12";
            //style12.CharacterFormat.Bold = false;
            //style12.CharacterFormat.TextColor = Color.Black;
            //style12.CharacterFormat.FontSize = 12;
            //style12.CharacterFormat.FontName = "Arial";
            //style12.ParagraphFormat.BeforeSpacing = 0;
            //style12.ParagraphFormat.AfterSpacing = 0;
            //style12.ParagraphFormat.LineSpacing = 10;
            //document.Styles.Add(style12);

            ParagraphStyle style10 = new ParagraphStyle(document);
            style10.Name = "style10";
            style10.CharacterFormat.Bold = false;
            style10.CharacterFormat.TextColor = Color.Black;
            style10.CharacterFormat.FontSize = 10;
            style10.CharacterFormat.FontName = "Arial Narrow";
            style10.ParagraphFormat.BeforeSpacing = 0;
            style10.ParagraphFormat.AfterSpacing = 0;
            style10.ParagraphFormat.LineSpacing = 10;
            document.Styles.Add(style10);

            //ParagraphStyle style10Especial = new ParagraphStyle(document);
            //style10Especial.Name = "style10Especial";
            //style10Especial.CharacterFormat.Bold = false;
            //style10Especial.CharacterFormat.TextColor = Color.Black;
            //style10Especial.CharacterFormat.FontSize = 10;
            //style10Especial.CharacterFormat.FontName = "Arial";
            //style10Especial.ParagraphFormat.BeforeSpacing = 0;
            //style10Especial.ParagraphFormat.AfterSpacing = 0;
            ////style10Especial.ParagraphFormat.LineSpacing = 10;
            //document.Styles.Add(style10Especial);

            //ParagraphStyle style15WhiteAndBold = new ParagraphStyle(document);
            //style15WhiteAndBold.Name = "style15WhiteAndBold";
            //style15WhiteAndBold.CharacterFormat.Bold = true;
            //style15WhiteAndBold.CharacterFormat.TextColor = Color.White;
            //style15WhiteAndBold.CharacterFormat.FontSize = 15;
            //style15WhiteAndBold.CharacterFormat.FontName = "Arial";
            //style15WhiteAndBold.ParagraphFormat.BeforeSpacing = 0;
            //style15WhiteAndBold.ParagraphFormat.AfterSpacing = 0;
            //style15WhiteAndBold.ParagraphFormat.LineSpacing = 10;
            //document.Styles.Add(style15WhiteAndBold);
        }

        public void GetBookmarks(Document document)
        {
            BookmarkCollection bookmarks = document.Bookmarks;

            using (StreamWriter sw = File.CreateText(@"C:\Users\TRINITY BUILD\Desktop\bookMarks.txt"))
            {
                foreach (Bookmark bookmark in bookmarks)
                    sw.Write(bookmark.Name + ",\n");

                sw.Write("\n");
                sw.Write("\n");
                sw.Write("\n");

                foreach (Bookmark bookmark in bookmarks)
                    sw.Write($@"AddText(SectionDirectEvapBk.{bookmark.Name}, """", ParaStyle.text, document);" + "\n");
            }
        }

        public void MergerDocuments(Document sourceDocument, Document targetDocument)
        {
            foreach (Section section in sourceDocument.Sections)
            {
                targetDocument.Sections.Add(section.Clone());
            }
        }

        public void FillTableRow(string[] data, Table table)
        {
            TableRow row = table.AddRow(false);

            for (int i = 0; i < data.Length; i++)
            {
                TableCell cell = row.Cells[i];
                Paragraph paragraph = row.Cells[i].AddParagraph();
                paragraph.AppendText(data[i]);
                paragraph.ApplyStyle(ParaStyle.style10.ToString());
                paragraph.Format.HorizontalAlignment = HorizontalAlignment.Center;
                cell.CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            }
        }

        public void LoadStarupData(Document document, Project project, Quote quote)
        {
            AddText(InitBk.to, project.Contractor, ParaStyle.style10, document);
            AddText(InitBk.attention, project.Contact, ParaStyle.style10, document);
            AddText(InitBk.engineer, project.Engineer, ParaStyle.style10, document);
            AddText(InitBk.projectName, project.Name, ParaStyle.style10, document);

            AddText(InitBk.date, project.CreationDate.ToShortDateString(), ParaStyle.style10, document);
            AddText(InitBk.proposalNumber, project.ProposalNumber, ParaStyle.style10, document);
            AddText(InitBk.revision, quote.Name, ParaStyle.style10, document);
            AddText(InitBk.plansDate, project.PlansDate.ToShortDateString(), ParaStyle.style10, document);
            AddText(InitBk.addendum, project.Addendum, ParaStyle.style10, document);
        }

        public string CreateFolders(Project project, IList<Quote> quotes)
        {
            string currentProjectPath = ProjectsPath + $@"\ {project.Name}({DateTime.Now.ToString("MM-dd-yy HH.mm.ss")})";
            Directory.CreateDirectory(ProjectsPath);
            Directory.CreateDirectory(currentProjectPath);
            Directory.CreateDirectory(currentProjectPath + $@"\Pricing");

            foreach (Quote quote in quotes)
            {
                File.Copy(pricingFilePath, currentProjectPath + $@"\Pricing\{project.Name} ({quote.Name.ToUpper()}).docx", true);
            }

            return currentProjectPath;
        }

        public enum InitBk
        {
            to,
            attention,
            engineer,
            projectName,
            date,
            proposalNumber,
            revision,
            plansDate,
            addendum,
            //from,
            //email,
            //telephone,
            //quote,
            sumaryTable,
        }

        public enum ParaStyle
        {
            //style24,
            //style20,
            //style18,
            //style16WhiteAndBold,
            //style16,
            //style14,
            //style12,
            //style11,
            //style11WhiteAndBold,
            style10,
            //style15WhiteAndBold,
            //style10Especial,

            //calibriStyle10,
            //calibriStyle12,
        }

        public enum UnitBk
        {
            unitNumber,
            projectName,
            projectNumber,
            unitTag,
            date,
        }

        public enum WeightBk
        {
            totalWeight
        }

        public void AddText(Enum bookmark, string text, ParaStyle style, Document document, HorizontalAlignment alignment = HorizontalAlignment.Left)
        {
            BookmarksNavigator navigator = new BookmarksNavigator(document);
            navigator.MoveToBookmark(bookmark.ToString());
            Paragraph paragraph = new Paragraph(document);
            paragraph.AppendText(text);
            paragraph.ApplyStyle(style.ToString());
            TextBodyPart textBodyPart = new TextBodyPart(document);
            textBodyPart.BodyItems.Add(paragraph);
            paragraph.Format.HorizontalAlignment = alignment;
            navigator.ReplaceBookmarkContent(textBodyPart, true);
        }

        public Table GetTable(DocTable unitInfoTable, Document document)
        {
            Table table = null;

            SectionCollection sections = document.Sections;

            foreach (Section section in sections)
            {
                foreach (Table tb in section.Tables)
                {
                    if (tb.Title.ToFormat() == unitInfoTable.ToString().ToFormat())
                    {
                        table = tb;
                        break;
                    }
                }
            }
            if (table == null)
            {

            }

            return table;
        }

        public (int,int) CreateHeaders(int column, int row, IXLWorksheet worksheet)
        {
            worksheet.Cell(row, column).Value = "Item";
            worksheet.Cell(row, column + 1).Value = "Tags";
            worksheet.Cell(row, column + 2).Value = "Quantity";
            worksheet.Cell(row, column + 3).Value = "Product Name";
            worksheet.Cell(row, column + 4).Value = "List Price";
            worksheet.Cell(row, column + 5).Value = "List Adders";
            worksheet.Cell(row, column + 6).Value = "Cost Multiplier";
            worksheet.Cell(row, column + 7).Value = "Each Cost";
            worksheet.Cell(row, column + 8).Value = "Each Freight";
            worksheet.Cell(row, column + 9).Value = "Start-Up";
            worksheet.Cell(row, column + 10).Value = "Net Adders";
            worksheet.Cell(row, column + 11).Value = "Total Cost";
            worksheet.Cell(row, column + 12).Value = "Sell Margin (%)";
            worksheet.Cell(row, column + 13).Value = "Unit Sell Price";
            worksheet.Cell(row, column + 14).Value = "Total";

            worksheet.Cell(row, column + 16).Value = "Profit";


            IXLRange range = worksheet.Range(row, column, row, column + 16);

            range.Style.Font.FontSize = 10;
            range.Style.Font.FontName = "Century Gothic";
            range.Style.Fill.BackgroundColor = XLColor.FromArgb(155, 194, 230);
            range.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            range.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            range.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            range.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            range.Style.Font.SetBold(true);
            range.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            range.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            worksheet.Columns(column, column + 16).AdjustToContents();

            return (column, row + 1);
        }

        public (int, int) AddItems(IXLWorksheet worksheet, IList<IItem> items, int column, int row)
        {
            int itemNumber = 0;
            int specNumber = 0;

            int startRow = row;

            IItem currentItem = null;
            IItem oldItem = null;

            foreach (IItem item in items)
            {
                currentItem = item;

                if (oldItem == null || currentItem.Catalog.Product.ToFormat() != oldItem.Catalog.Product.ToFormat())
                    itemNumber++;


                string letter = GetColumnName(itemNumber);


                worksheet.Cell(row, column).Value = letter; // B
                worksheet.Cell(row, column + 1).Value = $"[{item.Tag}]"; // C
                worksheet.Cell(row, column + 2).Value = item.Quantity; // D
                worksheet.Cell(row, column + 3).Value = $"{item.Catalog.Company}: {item.Catalog.Product}"; // E
                worksheet.Cell(row, column + 4).Value = item.OverridePrice ? (item.ListPrice).RoundUp() : (item.Catalog.ListPrice).RoundUp(); // F
                worksheet.Cell(row, column + 5).Value = 0; // G -- List Adders
                worksheet.Cell(row, column + 6).Value = item.OverridePrice ? item.CostMultiplier : item.Catalog.CostMultiplier; // H

                worksheet.Cell(row, column + 7).FormulaA1 = $"=CEILING((F{row}+G{row})*H{row}, 1)";//I -- Each Cost

                worksheet.Cell(row, column + 8).Value = (item.Freight).RoundUp();//J -- Each Freight

                worksheet.Cell(row, column + 9).Value = 0;// K -- Start-Up
                worksheet.Cell(row, column + 10).Value = 0;//L -- Net Adders
                worksheet.Cell(row, column + 11).FormulaA1 = $"=SUM(I{row}:L{row})";//M -- Total Each Cost

                worksheet.Cell(row, column + 12).Value = item.OverridePrice ? item.SellMargin / 100.0 : item.Catalog.SellMargin / 100.0;// N -- Sell Margin

                worksheet.Cell(row, column + 13).FormulaA1 = $"=CEILING((I{row}+K{row}+L{row}+J{row})/(1-N{row}),1)"; // O -- Unit Sell Price

                worksheet.Cell(row, column + 14).FormulaA1 = $"=O{row}*D{row}";//P -- Total

                worksheet.Cell(row, column + 16).FormulaA1 = $"=((P{row}) - (SUM(I{row}, K{row}, L{row}) * D{row}))";// -- Profit

                IXLRange itemRange = worksheet.Range(row, column, row, column + 16);
                itemRange.Style.Font.SetBold(true);

                row++;

                foreach (Title title in item.Titles.Where(x => x.Specs.Any(y => y.Price != 0)))
                {
                    worksheet.Cell(row, column + 1).Value = $"[{item.Tag}]";
                    worksheet.Cell(row, column + 1).Style.Font.SetBold(true);
                    worksheet.Cell(row, column + 1).Style.Font.FontColor = XLColor.FromHtml("#00008b");
                    worksheet.Cell(row, column + 3).Value = $"{title.Name}";
                    worksheet.Cell(row, column + 3).Style.Font.SetBold(true);
                    worksheet.Cell(row, column + 3).Style.Font.FontColor = XLColor.FromHtml("#00008b");
                    row++;

                    foreach (Spec spec in title.Specs.Where(x => x.Price != 0))
                    {
                        specNumber++;

                        worksheet.Cell(row, column).Value = letter + specNumber;
                        worksheet.Cell(row, column + 3).Value = $"{spec.Name}";
                        worksheet.Cell(row, column + 14).Value = (spec.Price).RoundUp();
                        worksheet.Cell(row, column + 16).Value = (spec.Price).RoundUp();

                        row++;
                    }
                }

                oldItem = item;
            }

            IXLRange range = worksheet.Range(startRow, column, row - 1, column + 16);

            range.Style.Font.FontSize = 10;
            range.Style.Font.FontName = "Century Gothic";
            range.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            range.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            range.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            range.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            range.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            range.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            worksheet.Column(14).Style.NumberFormat.Format = "0%";

            var currencyFormat = "$ #,##0.00";
            worksheet.Column(6).Style.NumberFormat.Format = currencyFormat;
            worksheet.Column(7).Style.NumberFormat.Format = currencyFormat;
            worksheet.Column(9).Style.NumberFormat.Format = currencyFormat;
            worksheet.Column(10).Style.NumberFormat.Format = currencyFormat;
            worksheet.Column(11).Style.NumberFormat.Format = currencyFormat;
            worksheet.Column(12).Style.NumberFormat.Format = currencyFormat;
            worksheet.Column(13).Style.NumberFormat.Format = currencyFormat;
            worksheet.Column(15).Style.NumberFormat.Format = currencyFormat;
            worksheet.Column(16).Style.NumberFormat.Format = currencyFormat;
            worksheet.Column(18).Style.NumberFormat.Format = currencyFormat;


            IXLRange dataRange = worksheet.Range(startRow, column + 4, row - 1, column + 8);
            dataRange.Style.Font.SetBold(true);
            dataRange.Style.Font.FontColor = XLColor.FromHtml("#4472c4");

            dataRange = worksheet.Range(startRow, column + 9, row - 1, column + 9);
            dataRange.Style.Font.SetBold(true);
            dataRange.Style.Font.FontColor = XLColor.FromHtml("#c65911");


            dataRange = worksheet.Range(startRow, column + 10, row - 1, column + 16);
            dataRange.Style.Font.SetBold(true);
            dataRange.Style.Font.FontColor = XLColor.FromHtml("#4472c4");

            return (column, row);
        }


        public void AddTotalAndProfit(IXLWorksheet worksheet, int column, int startItemsRow, int row)
        {
            worksheet.Cell(row + 1, column + 14).Value = "Grand Total";
            worksheet.Cell(row + 1, column + 14).Style.Font.FontSize = 10;
            worksheet.Cell(row + 1, column + 14).Style.Font.FontName = "Century Gothic";
            worksheet.Cell(row + 1, column + 14).Style.Fill.BackgroundColor = XLColor.FromArgb(155, 194, 230);
            worksheet.Cell(row + 1, column + 14).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 1, column + 14).Style.Border.TopBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 1, column + 14).Style.Border.RightBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 1, column + 14).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 1, column + 14).Style.Font.SetBold(true);
            worksheet.Cell(row + 1, column + 14).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            worksheet.Cell(row + 1, column + 14).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            worksheet.Cell(row + 2, column + 14).FormulaA1 = $"=SUM(P{startItemsRow}:P{row})";
            worksheet.Cell(row + 2, column + 14).Style.Font.FontSize = 10;
            worksheet.Cell(row + 2, column + 14).Style.Font.FontName = "Century Gothic";
            worksheet.Cell(row + 2, column + 14).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 2, column + 14).Style.Border.TopBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 2, column + 14).Style.Border.RightBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 2, column + 14).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 2, column + 14).Style.Font.SetBold(true);
            worksheet.Cell(row + 2, column + 14).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            worksheet.Cell(row + 2, column + 14).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            worksheet.Cell(row + 2, column + 14).Style.Font.FontColor = XLColor.FromHtml("#4472c4");

            worksheet.Cell(row + 1, column + 16).Value = "Grand Total Profit";
            worksheet.Cell(row + 1, column + 16).Style.Font.FontSize = 10;
            worksheet.Cell(row + 1, column + 16).Style.Font.FontName = "Century Gothic";
            worksheet.Cell(row + 1, column + 16).Style.Fill.BackgroundColor = XLColor.FromArgb(155, 194, 230);
            worksheet.Cell(row + 1, column + 16).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 1, column + 16).Style.Border.TopBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 1, column + 16).Style.Border.RightBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 1, column + 16).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 1, column + 16).Style.Font.SetBold(true);
            worksheet.Cell(row + 1, column + 16).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            worksheet.Cell(row + 1, column + 16).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            worksheet.Cell(row + 2, column + 16).FormulaA1 = $"=SUM(R{startItemsRow}:R{row})";
            worksheet.Cell(row + 2, column + 16).Style.Font.FontSize = 10;
            worksheet.Cell(row + 2, column + 16).Style.Font.FontName = "Century Gothic";
            worksheet.Cell(row + 2, column + 16).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 2, column + 16).Style.Border.TopBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 2, column + 16).Style.Border.RightBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 2, column + 16).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(row + 2, column + 16).Style.Font.SetBold(true);
            worksheet.Cell(row + 2, column + 16).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            worksheet.Cell(row + 2, column + 16).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            worksheet.Cell(row + 2, column + 16).Style.Font.FontColor = XLColor.FromHtml("#4472c4");



            worksheet.Columns(column, column + 16).AdjustToContents();

        }


        public (int, int) AddProjectData(IXLWorksheet worksheet, Project project, int column, int row)
        {
            IXLRange range = worksheet.Range(row, column, row, column + 1);

            range.Style.Font.FontSize = 12;
            range.Style.Font.FontName = "Century Gothic";
            range.Style.Fill.BackgroundColor = XLColor.FromHtml("#483D8B");
            range.Style.Font.FontColor = XLColor.White;
            range.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            range.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            range.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            range.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            range.Style.Font.SetBold(true);
            range.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            range.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            range.Merge();


            worksheet.Cell(row,column).Value = "Pricing Report";

            IXLRange dataRange = worksheet.Range(row + 1, column, row + 4, column);

            dataRange.Style.Font.FontSize = 10;
            dataRange.Style.Font.FontName = "Century Gothic";
            dataRange.Style.Fill.BackgroundColor = XLColor.FromArgb(155, 194, 230);
            dataRange.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            dataRange.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            dataRange.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            dataRange.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            dataRange.Style.Font.SetBold(true);
            dataRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            dataRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            IXLRange valuesRange = worksheet.Range(row + 1, column + 1, row + 4, column + 1);

            valuesRange.Style.Font.FontSize = 10;
            valuesRange.Style.Font.FontName = "Century Gothic";
            valuesRange.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            valuesRange.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            valuesRange.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            valuesRange.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            valuesRange.Style.Font.SetBold(true);
            valuesRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            valuesRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            worksheet.Cell(row + 1,column).Value = "Project:";
            worksheet.Cell(row + 1,column + 1).Value = project.Name;

            worksheet.Cell(row + 2,column).Value = "Customer:";
            worksheet.Cell(row + 2,column + 1).Value = project.Contractor;

            worksheet.Cell(row + 3,column).Value = "Contact:";
            worksheet.Cell(row + 3,column + 1).Value = project.Engineer;

            worksheet.Cell(row + 4,column).Value = "Date:";
            worksheet.Cell(row + 4,column + 1).Value = project.CreationDate.ToLongDateString();

            return (column, row + 6);
        }

        public void GetTextBoxes(Document document)
        {
            SectionCollection sections = document.Sections;
            TextBoxCollection textBoxes = document.TextBoxes;

        }

        public enum DocTable
        {
            wallsAndRoof,
            floor,
            openings,
            dampers,
            weight,
        }

        public  void CopyResource(DocumentResource documentResource)
        {
            string sourcePath = Environment.CurrentDirectory + $@"\{documentResource.ToString()}";


            if (!Directory.Exists(TemplatesPath))
            {
                Directory.CreateDirectory(TemplatesPath);
            }

            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, TemplatesPath));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, TemplatesPath), true);
            }
        }

        public enum DocumentResource
        {
            ResourcePricing,
        }
    }
}
