using Orion.Domain.ABOVEAIR.Catalog;
using Orion.Domain.ABOVEAIR.Item;
using Orion.Domain.AERCO.Catalog;
using Orion.Domain.AERCO.Item;
using Orion.Domain.Baldor.Catalog;
using Orion.Domain.Baldor.Item;
using Orion.Domain.Condair.Catalog;
using Orion.Domain.Condair.Item;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityCatalogAmericanWheatley;
using Orion.Domain.EntityCatalogBACClosedLoopTowers;
using Orion.Domain.EntityCatalogBACOpenLoopTowers;
using Orion.Domain.EntityCatalogGeneralProduct;
using Orion.Domain.EntityCatalogGroundfos;
using Orion.Domain.EntityCatalogPuroflux;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Domain.EntityCatalogUvResources;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Domain.EntityItemBACClosedLoopTowers;
using Orion.Domain.EntityItemBACOpenLoopTowers;
using Orion.Domain.EntityItemGeneralProduct;
using Orion.Domain.EntityItemGroundfos;
using Orion.Domain.EntityItemPuroFlux;
using Orion.Domain.EntityItemUvResources;
using Orion.Domain.EnviroTec.Catalog;
using Orion.Domain.EnviroTec.Item;
using Orion.Domain.LYNC.Catalog;
using Orion.Domain.LYNC.Item;
using Orion.Domain.Marvair;
using Orion.Domain.Marvair.Catalog;
using Orion.Domain.Marvair.Item;
using Orion.Domain.Multiaqua.Catalog;
using Orion.Domain.Multiaqua.Item;
using Orion.Domain.Nortek.Catalog;
using Orion.Domain.Nortek.Item;
using Orion.Domain.NYLE.Catalog;
using Orion.Domain.NYLE.Item;
using Orion.Domain.PACE.Catalog;
using Orion.Domain.PACE.Item;
using Orion.Domain.PlasmaAir.Catalog;
using Orion.Domain.PlasmaAir.Item;
using Orion.Domain.Polaris.Catalog;
using Orion.Domain.Polaris.Item;
using Orion.Domain.PVI.Catalog;
using Orion.Domain.PVI.Item;
using Orion.Domain.Robur.Catalog;
using Orion.Domain.Robur.Item;
using Orion.Domain.UMAS.Catalog;
using Orion.Domain.UMAS.Item;
using Orion.Domain.Valent.Catalog;
using Orion.Domain.Valent.Item;
using Orion.Domain.Whalen.Catalog;
using Orion.Domain.Whalen.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Orion.Helper.Misc.GV;

namespace Orion.DataAccess.Misc
{
    public static class EntityHelper
    {
        // [new]
        public static readonly Dictionary<Type, ItemType> ItemTypeForItemMap = new Dictionary<Type, ItemType>()
        {
            { typeof(ItemA1), ItemType.ItemA1 },
            { typeof(ItemA2), ItemType.ItemA2 },
            { typeof(ItemA3), ItemType.ItemA3 },
            { typeof(ItemA4), ItemType.ItemA4 },
                             
            { typeof(ItemB1), ItemType.ItemB1 },
            { typeof(ItemB2), ItemType.ItemB2 },
            { typeof(ItemB3), ItemType.ItemB3 },
            { typeof(ItemB4), ItemType.ItemB4 },
            { typeof(ItemB5), ItemType.ItemB5 },
                             
            { typeof(ItemC1), ItemType.ItemC1 },
            { typeof(ItemC2), ItemType.ItemC2 },
            { typeof(ItemC3), ItemType.ItemC3 },
            { typeof(ItemC4), ItemType.ItemC4 },
            { typeof(ItemC5), ItemType.ItemC5 },
            { typeof(ItemC6), ItemType.ItemC6 },
            { typeof(ItemC7), ItemType.ItemC7 },
                             
            { typeof(ItemD1), ItemType.ItemD1 },
            { typeof(ItemD2), ItemType.ItemD2 },
                             
            { typeof(ItemE1), ItemType.ItemE1 },
            { typeof(ItemE2), ItemType.ItemE2 },
            { typeof(ItemE3), ItemType.ItemE3 },
            { typeof(ItemE4), ItemType.ItemE4 },
            { typeof(ItemE5), ItemType.ItemE5 },
            { typeof(ItemE6), ItemType.ItemE6 },
            { typeof(ItemE7), ItemType.ItemE7 },
                             
            { typeof(ItemF1), ItemType.ItemF1 },
                             
            { typeof(ItemG1), ItemType.ItemG1 },
            { typeof(ItemG2), ItemType.ItemG2 },
            { typeof(ItemG3), ItemType.ItemG3 },
            { typeof(ItemG4), ItemType.ItemG4 },
            { typeof(ItemG5), ItemType.ItemG5 },
            { typeof(ItemG6), ItemType.ItemG6 },
                             
            { typeof(ItemH1), ItemType.ItemH1 },
            { typeof(ItemH2), ItemType.ItemH2 },
            { typeof(ItemH3), ItemType.ItemH3 },
            { typeof(ItemH4), ItemType.ItemH4 },
            { typeof(ItemH5), ItemType.ItemH5 },
                             
            { typeof(ItemI1), ItemType.ItemI1 },
            { typeof(ItemI2), ItemType.ItemI2 },
                             
            { typeof(ItemJ1), ItemType.ItemJ1 },
                             
            { typeof(ItemK1), ItemType.ItemK1 },
            { typeof(ItemK2), ItemType.ItemK2 },
            { typeof(ItemK3), ItemType.ItemK3 },
                             
            { typeof(ItemL1), ItemType.ItemL1 },

            { typeof(ItemM1), ItemType.ItemM1 },

            { typeof(ItemN1), ItemType.ItemN1 },

            { typeof(ItemO1), ItemType.ItemO1 },
            { typeof(ItemO2), ItemType.ItemO2 },

            { typeof(ItemP1), ItemType.ItemP1 },

            { typeof(ItemQ1), ItemType.ItemQ1 },
            { typeof(ItemQ2), ItemType.ItemQ2 },
            { typeof(ItemQ3), ItemType.ItemQ3 },
            { typeof(ItemQ4), ItemType.ItemQ4 },

            { typeof(ItemR1), ItemType.ItemR1 },
            { typeof(ItemR2), ItemType.ItemR2 },
            { typeof(ItemR3), ItemType.ItemR3 },
            { typeof(ItemR4), ItemType.ItemR4 },

            { typeof(ItemS1), ItemType.ItemS1 },

            { typeof(ItemT1), ItemType.ItemT1 },
            { typeof(ItemT2), ItemType.ItemT2 },
            { typeof(ItemT3), ItemType.ItemT3 },

            { typeof(ItemU1), ItemType.ItemU1 },

            { typeof(ItemV1), ItemType.ItemV1 },

            { typeof(ItemW1), ItemType.ItemW1 },

            { typeof(ItemX1), ItemType.ItemX1 },
            { typeof(ItemX2), ItemType.ItemX2 },
            { typeof(ItemX3), ItemType.ItemX3 },
            { typeof(ItemX4), ItemType.ItemX4 },
            { typeof(ItemX5), ItemType.ItemX5 },

            { typeof(ItemY1), ItemType.ItemY1 },

            { typeof(ItemZ1), ItemType.ItemZ1 },

            { typeof(ItemAA1), ItemType.ItemAA1 },
        };
        // [new]
        public static readonly Dictionary<ItemType, Type> ItemForItemTypeMap = new Dictionary<ItemType, Type>()
        {
            { ItemType.ItemA1, typeof(ItemA1) },
            { ItemType.ItemA2, typeof(ItemA2) },
            { ItemType.ItemA3, typeof(ItemA3) },
            { ItemType.ItemA4, typeof(ItemA4) },

            { ItemType.ItemB1, typeof(ItemB1) },
            { ItemType.ItemB2, typeof(ItemB2) },
            { ItemType.ItemB3, typeof(ItemB3) },
            { ItemType.ItemB4, typeof(ItemB4) },
            { ItemType.ItemB5, typeof(ItemB5) },

            { ItemType.ItemC1, typeof(ItemC1) },
            { ItemType.ItemC2, typeof(ItemC2) },
            { ItemType.ItemC3, typeof(ItemC3) },
            { ItemType.ItemC4, typeof(ItemC4) },
            { ItemType.ItemC5, typeof(ItemC5) },
            { ItemType.ItemC6, typeof(ItemC6) },
            { ItemType.ItemC7, typeof(ItemC7) },

            { ItemType.ItemD1, typeof(ItemD1) },
            { ItemType.ItemD2, typeof(ItemD2) },

            { ItemType.ItemE1, typeof(ItemE1) },
            { ItemType.ItemE2, typeof(ItemE2) },
            { ItemType.ItemE3, typeof(ItemE3) },
            { ItemType.ItemE4, typeof(ItemE4) },
            { ItemType.ItemE5, typeof(ItemE5) },
            { ItemType.ItemE6, typeof(ItemE6) },
            { ItemType.ItemE7, typeof(ItemE7) },

            { ItemType.ItemF1, typeof(ItemF1) },

            { ItemType.ItemG1, typeof(ItemG1) },
            { ItemType.ItemG2, typeof(ItemG2) },
            { ItemType.ItemG3, typeof(ItemG3) },
            { ItemType.ItemG4, typeof(ItemG4) },
            { ItemType.ItemG5, typeof(ItemG5) },
            { ItemType.ItemG6, typeof(ItemG6) },

            { ItemType.ItemH1, typeof(ItemH1) },
            { ItemType.ItemH2, typeof(ItemH2) },
            { ItemType.ItemH3, typeof(ItemH3) },
            { ItemType.ItemH4, typeof(ItemH4) },
            { ItemType.ItemH5, typeof(ItemH5) },

            { ItemType.ItemI1, typeof(ItemI1) },
            { ItemType.ItemI2, typeof(ItemI2) },

            { ItemType.ItemJ1, typeof(ItemJ1) },

            { ItemType.ItemK1, typeof(ItemK1) },
            { ItemType.ItemK2, typeof(ItemK2) },
            { ItemType.ItemK3, typeof(ItemK3) },

            { ItemType.ItemL1, typeof(ItemL1) },

            { ItemType.ItemM1, typeof(ItemM1) },

            { ItemType.ItemN1, typeof(ItemN1) },

            { ItemType.ItemO1, typeof(ItemO1) },
            { ItemType.ItemO2, typeof(ItemO2) },

            { ItemType.ItemP1, typeof(ItemP1) },

            { ItemType.ItemQ1, typeof(ItemQ1) },
            { ItemType.ItemQ2, typeof(ItemQ2) },
            { ItemType.ItemQ3, typeof(ItemQ3) },
            { ItemType.ItemQ4, typeof(ItemQ4) },

            { ItemType.ItemR1, typeof(ItemR1) },
            { ItemType.ItemR2, typeof(ItemR2) },
            { ItemType.ItemR3, typeof(ItemR3) },
            { ItemType.ItemR4, typeof(ItemR4) },

            { ItemType.ItemS1, typeof(ItemS1) },

            { ItemType.ItemT1, typeof(ItemT1) },
            { ItemType.ItemT2, typeof(ItemT2) },
            { ItemType.ItemT3, typeof(ItemT3) },

            { ItemType.ItemU1, typeof(ItemU1) },

            { ItemType.ItemV1, typeof(ItemV1) },

            { ItemType.ItemW1, typeof(ItemW1) },

            { ItemType.ItemX1, typeof(ItemX1) },
            { ItemType.ItemX2, typeof(ItemX2) },
            { ItemType.ItemX3, typeof(ItemX3) },
            { ItemType.ItemX4, typeof(ItemX4) },
            { ItemType.ItemX5, typeof(ItemX5) },
              
            { ItemType.ItemY1, typeof(ItemY1) },
             
            { ItemType.ItemZ1, typeof(ItemZ1) },
              
            { ItemType.ItemAA1, typeof(ItemAA1) },
        };
        // [new]
        public static readonly Dictionary<ItemType, Type> CatalogForItemTypeMap = new Dictionary<ItemType, Type>
    {
        { ItemType.ItemA1, typeof(CatalogA1) },
        { ItemType.ItemA2, typeof(CatalogA2) },
        { ItemType.ItemA3, typeof(CatalogA3) },
        { ItemType.ItemA4, typeof(CatalogA4) },

        { ItemType.ItemB1, typeof(CatalogB1) },
        { ItemType.ItemB2, typeof(CatalogB2) },
        { ItemType.ItemB3, typeof(CatalogB3) },
        { ItemType.ItemB4, typeof(CatalogB4) },
        { ItemType.ItemB5, typeof(CatalogB5) },

        { ItemType.ItemC1, typeof(CatalogC1) },
        { ItemType.ItemC2, typeof(CatalogC2) },
        { ItemType.ItemC3, typeof(CatalogC3) },
        { ItemType.ItemC4, typeof(CatalogC4) },
        { ItemType.ItemC5, typeof(CatalogC5) },
        { ItemType.ItemC6, typeof(CatalogC6) },
        { ItemType.ItemC7, typeof(CatalogC7) },

        { ItemType.ItemD1, typeof(CatalogD1) },
        { ItemType.ItemD2, typeof(CatalogD2) },

        { ItemType.ItemE1, typeof(CatalogE1) },
        { ItemType.ItemE2, typeof(CatalogE2) },
        { ItemType.ItemE3, typeof(CatalogE3) },
        { ItemType.ItemE4, typeof(CatalogE4) },
        { ItemType.ItemE5, typeof(CatalogE5) },
        { ItemType.ItemE6, typeof(CatalogE6) },
        { ItemType.ItemE7, typeof(CatalogE7) },

        { ItemType.ItemF1, typeof(CatalogF1) },

        { ItemType.ItemG1, typeof(CatalogG1) },
        { ItemType.ItemG2, typeof(CatalogG2) },
        { ItemType.ItemG3, typeof(CatalogG3) },
        { ItemType.ItemG4, typeof(CatalogG4) },
        { ItemType.ItemG5, typeof(CatalogG5) },
        { ItemType.ItemG6, typeof(CatalogG6) },

        { ItemType.ItemH1, typeof(CatalogH1) },
        { ItemType.ItemH2, typeof(CatalogH2) },
        { ItemType.ItemH3, typeof(CatalogH3) },
        { ItemType.ItemH4, typeof(CatalogH4) },
        { ItemType.ItemH5, typeof(CatalogH5) },

        { ItemType.ItemI1, typeof(CatalogI1) },
        { ItemType.ItemI2, typeof(CatalogI2) },

        { ItemType.ItemJ1, typeof(CatalogJ1) },

        { ItemType.ItemK1, typeof(CatalogK1) },
        { ItemType.ItemK2, typeof(CatalogK2) },
        { ItemType.ItemK3, typeof(CatalogK3) },

        { ItemType.ItemL1, typeof(CatalogL1) },

        { ItemType.ItemM1, typeof(CatalogM1) },

        { ItemType.ItemN1, typeof(CatalogN1) },
                                  
        { ItemType.ItemO1, typeof(CatalogO1) },
        { ItemType.ItemO2, typeof(CatalogO2) },
                                  
        { ItemType.ItemP1, typeof(CatalogP1) },
                                  
        { ItemType.ItemQ1, typeof(CatalogQ1) },
        { ItemType.ItemQ2, typeof(CatalogQ2) },
        { ItemType.ItemQ3, typeof(CatalogQ3) },
        { ItemType.ItemQ4, typeof(CatalogQ4) },
                                  
        { ItemType.ItemR1, typeof(CatalogR1) },
        { ItemType.ItemR2, typeof(CatalogR2) },
        { ItemType.ItemR3, typeof(CatalogR3) },
        { ItemType.ItemR4, typeof(CatalogR4) },
                                  
        { ItemType.ItemS1, typeof(CatalogS1) },
                                  
        { ItemType.ItemT1, typeof(CatalogT1) },
        { ItemType.ItemT2, typeof(CatalogT2) },
        { ItemType.ItemT3, typeof(CatalogT3) },
                                  
        { ItemType.ItemU1, typeof(CatalogU1) },
                                  
        { ItemType.ItemV1, typeof(CatalogV1) },
                                  
        { ItemType.ItemW1, typeof(CatalogW1) },
                                  
        { ItemType.ItemX1, typeof(CatalogX1) },
        { ItemType.ItemX2, typeof(CatalogX2) },
        { ItemType.ItemX3, typeof(CatalogX3) },
        { ItemType.ItemX4, typeof(CatalogX4) },
        { ItemType.ItemX5, typeof(CatalogX5) },
                                  
        { ItemType.ItemY1, typeof(CatalogY1) },
                                  
        { ItemType.ItemZ1, typeof(CatalogZ1) },

        { ItemType.ItemAA1, typeof(CatalogAA1) },

    };

        public static ItemType ConvertIItemToItemType(IItem item)
        {
            return (ItemType)Enum.Parse(typeof(ItemType), item.GetType().Name, true);
        }

        public static ItemType GetItemTypeForItemClassType(Type itemClassType)
        {
            return ItemTypeForItemMap[itemClassType];
        }

        public static Type GetItemClassTypeForItemType(ItemType itemType)
        {
            return ItemForItemTypeMap[itemType];
        }

        public static Type GetCatalogClassTypeForItemType(ItemType itemType)
        {
            return CatalogForItemTypeMap[itemType];
        }

        public static Subfix ConvertItemTypeToSubfix(ItemType itemType)
        {
            string itemName = itemType.ToString().Substring(4);
            string subfixPart = Regex.Replace(itemName, "[0-9]", "");
            return (Subfix)Enum.Parse(typeof(Subfix), subfixPart, true);
        }

        public static Subfix GetSubfixFromCompanty(Company company)
        {
            return (Subfix)Enum.Parse(typeof(Subfix), company.Subfix, true);
        }
    }
}



//public struct ItemsData
//{
//    public Subfix Subfix;
//    public ItemType ItemType;
//    public CatalogType CatalogType;
//    public Type ItemClassType;
//    public Type CatalogClassType;

//    public ItemsData(Subfix subfix, ItemType itemType, CatalogType catalogType, Type itemClassType, Type CatalogClassType)
//    {
//        this.Subfix = subfix;
//        this.ItemType = itemType;
//        this.CatalogType = catalogType;
//        this.ItemClassType = itemClassType;
//        this.CatalogClassType = CatalogClassType;
//    }
//}
