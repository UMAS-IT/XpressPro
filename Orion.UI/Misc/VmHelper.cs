using Orion.Domain.Entity;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Domain.EntityItemBACClosedLoopTowers;
using Orion.Domain.EntityItemBACOpenLoopTowers;
using Orion.Domain.EntityItemGeneralProduct;
using Orion.Domain.EntityItemGroundfos;
using Orion.Domain.EntityItemPuroFlux;
using Orion.Domain.EntityItemUvResources;
using Orion.Domain.Marvair.Item;
using Orion.Domain.Multiaqua.Item;
using Orion.Domain.PACE.Item;
using Orion.Helper.Extension;
using Orion.Helper.Misc;
using Orion.UI.ViewModel.ABB.CatalogList;
using Orion.UI.ViewModel.ABB.EditCatalogItem;
using Orion.UI.ViewModel.ABB.EditQuoteItem;
using Orion.UI.ViewModel.ABB.QuoteItemList;
using Orion.UI.ViewModel.AmericanWheatley.CatalogList;
using Orion.UI.ViewModel.AmericanWheatley.EditCatalogItem;
using Orion.UI.ViewModel.AmericanWheatley.EditQuoteItem;
using Orion.UI.ViewModel.AmericanWheatley.QuoteItemList;
using Orion.UI.ViewModel.BACClosedCircuits.CatalogList;
using Orion.UI.ViewModel.BACClosedCircuits.EditCatalogItem;
using Orion.UI.ViewModel.BACClosedCircuits.EditQuoteItem;
using Orion.UI.ViewModel.BACClosedCircuits.QuoteItemList;
using Orion.UI.ViewModel.BACCoolingTowers.CatalogList;
using Orion.UI.ViewModel.BACCoolingTowers.EditCatalogItem;
using Orion.UI.ViewModel.BACCoolingTowers.EditQuoteItem;
using Orion.UI.ViewModel.BACCoolingTowers.QuoteItemList;
using Orion.UI.ViewModel.GeneralProduct.CatalogList;
using Orion.UI.ViewModel.GeneralProduct.EditCatalogItem;
using Orion.UI.ViewModel.GeneralProduct.EditQuoteItem;
using Orion.UI.ViewModel.GeneralProduct.QuoteItemList;
using Orion.UI.ViewModel.Groundfos.CatalogList;
using Orion.UI.ViewModel.Groundfos.EditCatalogItem;
using Orion.UI.ViewModel.Groundfos.EditQuoteItem;
using Orion.UI.ViewModel.Groundfos.QuoteItemList;
using Orion.UI.ViewModel.Mavair.CatalogList;
using Orion.UI.ViewModel.Mavair.EditCatalogItem;
using Orion.UI.ViewModel.Mavair.EditQuoteItem;
using Orion.UI.ViewModel.Mavair.QuoteItemList;
using Orion.UI.ViewModel.Multiaqua.CatalogList;
using Orion.UI.ViewModel.Multiaqua.EditCatalogItem;
using Orion.UI.ViewModel.Multiaqua.EditQuoteItem;
using Orion.UI.ViewModel.Multiaqua.QuoteItemList;
using Orion.UI.ViewModel.PACE.CatalogList;
using Orion.UI.ViewModel.PACE.EditCatalogItem;
using Orion.UI.ViewModel.PACE.EditQuoteItem;
using Orion.UI.ViewModel.PACE.QuoteItemList;
using Orion.UI.ViewModel.Puroflux.CatalogList;
using Orion.UI.ViewModel.Puroflux.EditCatalogItem;
using Orion.UI.ViewModel.Puroflux.EditQuoteItem;
using Orion.UI.ViewModel.Puroflux.QuoteItemList;
using Orion.UI.ViewModel.Quantech.CatalogList;
using Orion.UI.ViewModel.Quantech.EditCatalogItem;
using Orion.UI.ViewModel.Quantech.EditQuoteItem;
using Orion.UI.ViewModel.Quantech.QuoteItemList;
using Orion.UI.ViewModel.UvResources.CatalogList;
using Orion.UI.ViewModel.UvResources.EditCatalogItem;
using Orion.UI.ViewModel.UvResources.EditQuoteItem;
using Orion.UI.ViewModel.UvResources.QuoteItemList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Orion.Helper.Misc.GV;

namespace Orion.UI.Misc
{
    public static class VmHelper
    {
        public static Dictionary<ItemType, Type> CatalogListViewModelForItemTypeMap = new Dictionary<ItemType, Type>
    {
        { ItemType.ItemA1, typeof(CatalogA1ListViewModel) },
        { ItemType.ItemA2, typeof(CatalogA2ListViewModel) },
        { ItemType.ItemA3, typeof(CatalogA3ListViewModel) },
        { ItemType.ItemA4, typeof(CatalogA4ListViewModel) },
                                    
        { ItemType.ItemB1, typeof(CatalogB1ListViewModel) },
        { ItemType.ItemB2, typeof(CatalogB2ListViewModel) },
        { ItemType.ItemB3, typeof(CatalogB3ListViewModel) },
        { ItemType.ItemB4, typeof(CatalogB4ListViewModel) },
        { ItemType.ItemB5, typeof(CatalogB5ListViewModel) },
                                    
        { ItemType.ItemC1, typeof(CatalogC1ListViewModel) },
        { ItemType.ItemC2, typeof(CatalogC2ListViewModel) },
        { ItemType.ItemC3, typeof(CatalogC3ListViewModel) },
        { ItemType.ItemC4, typeof(CatalogC4ListViewModel) },
        { ItemType.ItemC5, typeof(CatalogC5ListViewModel) },
        { ItemType.ItemC6, typeof(CatalogC6ListViewModel) },
        { ItemType.ItemC7, typeof(CatalogC7ListViewModel) },
                                    
        { ItemType.ItemD1, typeof(CatalogD1ListViewModel) },
        { ItemType.ItemD2, typeof(CatalogD2ListViewModel) },
                                    
        { ItemType.ItemE1, typeof(CatalogE1ListViewModel) },
        { ItemType.ItemE2, typeof(CatalogE2ListViewModel) },
        { ItemType.ItemE3, typeof(CatalogE3ListViewModel) },
        { ItemType.ItemE4, typeof(CatalogE4ListViewModel) },
        { ItemType.ItemE5, typeof(CatalogE5ListViewModel) },
        { ItemType.ItemE6, typeof(CatalogE6ListViewModel) },
        { ItemType.ItemE7, typeof(CatalogE7ListViewModel) },
                                    
        { ItemType.ItemF1, typeof(CatalogF1ListViewModel) },
                                    
        { ItemType.ItemG1, typeof(CatalogG1ListViewModel) },
        { ItemType.ItemG2, typeof(CatalogG2ListViewModel) },
        { ItemType.ItemG3, typeof(CatalogG3ListViewModel) },
        { ItemType.ItemG4, typeof(CatalogG4ListViewModel) },
        { ItemType.ItemG5, typeof(CatalogG5ListViewModel) },
        { ItemType.ItemG6, typeof(CatalogG6ListViewModel) },
                                    
        { ItemType.ItemH1, typeof(CatalogH1ListViewModel) },
        { ItemType.ItemH2, typeof(CatalogH2ListViewModel) },
        { ItemType.ItemH3, typeof(CatalogH3ListViewModel) },
        { ItemType.ItemH4, typeof(CatalogH4ListViewModel) },
        { ItemType.ItemH5, typeof(CatalogH5ListViewModel) },
                                    
        { ItemType.ItemI1, typeof(CatalogI1ListViewModel) },
        { ItemType.ItemI2, typeof(CatalogI2ListViewModel) },
                                    
        { ItemType.ItemJ1, typeof(CatalogJ1ListViewModel) },
                                    
        { ItemType.ItemK1, typeof(CatalogK1ListViewModel) },
        { ItemType.ItemK2, typeof(CatalogK2ListViewModel) },
        { ItemType.ItemK3, typeof(CatalogK3ListViewModel) },
                                    
        { ItemType.ItemL1, typeof(CatalogL1ListViewModel) }
    };                            
        public static Dictionary<ItemType, Type> EditCatalogViewModelForItemTypeMap = new Dictionary<ItemType, Type>
    {
        { ItemType.ItemA1, typeof(EditA1CatalogViewModel) },
        { ItemType.ItemA2, typeof(EditA2CatalogViewModel) },
        { ItemType.ItemA3, typeof(EditA3CatalogViewModel) },
        { ItemType.ItemA4, typeof(EditA4CatalogViewModel) },
                                        
        { ItemType.ItemB1, typeof(EditB1CatalogViewModel) },
        { ItemType.ItemB2, typeof(EditB2CatalogViewModel) },
        { ItemType.ItemB3, typeof(EditB3CatalogViewModel) },
        { ItemType.ItemB4, typeof(EditB4CatalogViewModel) },
        { ItemType.ItemB5, typeof(EditB5CatalogViewModel) },
                                        
        { ItemType.ItemC1, typeof(EditC1CatalogViewModel) },
        { ItemType.ItemC2, typeof(EditC2CatalogViewModel) },
        { ItemType.ItemC3, typeof(EditC3CatalogViewModel) },
        { ItemType.ItemC4, typeof(EditC4CatalogViewModel) },
        { ItemType.ItemC5, typeof(EditC5CatalogViewModel) },
        { ItemType.ItemC6, typeof(EditC6CatalogViewModel) },
        { ItemType.ItemC7, typeof(EditC7CatalogViewModel) },
                                        
        { ItemType.ItemD1, typeof(EditD1CatalogViewModel) },
        { ItemType.ItemD2, typeof(EditD2CatalogViewModel) },
                                        
        { ItemType.ItemE1, typeof(EditE1CatalogViewModel) },
        { ItemType.ItemE2, typeof(EditE2CatalogViewModel) },
        { ItemType.ItemE3, typeof(EditE3CatalogViewModel) },
        { ItemType.ItemE4, typeof(EditE4CatalogViewModel) },
        { ItemType.ItemE5, typeof(EditE5CatalogViewModel) },
        { ItemType.ItemE6, typeof(EditE6CatalogViewModel) },
        { ItemType.ItemE7, typeof(EditE7CatalogViewModel) },
                                        
        { ItemType.ItemF1, typeof(EditF1CatalogViewModel) },
                                        
        { ItemType.ItemG1, typeof(EditG1CatalogViewModel) },
        { ItemType.ItemG2, typeof(EditG2CatalogViewModel) },
        { ItemType.ItemG3, typeof(EditG3CatalogViewModel) },
        { ItemType.ItemG4, typeof(EditG4CatalogViewModel) },
        { ItemType.ItemG5, typeof(EditG5CatalogViewModel) },
        { ItemType.ItemG6, typeof(EditG6CatalogViewModel) },
                                        
        { ItemType.ItemH1, typeof(EditH1CatalogViewModel) },
        { ItemType.ItemH2, typeof(EditH2CatalogViewModel) },
        { ItemType.ItemH3, typeof(EditH3CatalogViewModel) },
        { ItemType.ItemH4, typeof(EditH4CatalogViewModel) },
        { ItemType.ItemH5, typeof(EditH5CatalogViewModel) },
                                        
        { ItemType.ItemI1, typeof(EditI1CatalogViewModel) },
        { ItemType.ItemI2, typeof(EditI2CatalogViewModel) },
                                        
        { ItemType.ItemJ1, typeof(EditJ1CatalogViewModel) },
                                        
        { ItemType.ItemK1, typeof(EditK1CatalogViewModel) },
        { ItemType.ItemK2, typeof(EditK2CatalogViewModel) },
        { ItemType.ItemK3, typeof(EditK3CatalogViewModel) },
                                        
        { ItemType.ItemL1, typeof(EditL1CatalogViewModel) }
    };

        public static Dictionary<ItemType, Type> EditItemViewModelForItemTypeMap = new Dictionary<ItemType, Type>
    {
        { ItemType.ItemA1, typeof(EditA1ItemViewModel) },
        { ItemType.ItemA2, typeof(EditA2ItemViewModel) },
        { ItemType.ItemA3, typeof(EditA3ItemViewModel) },
        { ItemType.ItemA4, typeof(EditA4ItemViewModel) },

        { ItemType.ItemB1, typeof(EditB1ItemViewModel) },
        { ItemType.ItemB2, typeof(EditB2ItemViewModel) },
        { ItemType.ItemB3, typeof(EditB3ItemViewModel) },
        { ItemType.ItemB4, typeof(EditB4ItemViewModel) },
        { ItemType.ItemB5, typeof(EditB5ItemViewModel) },

        { ItemType.ItemC1, typeof(EditC1ItemViewModel) },
        { ItemType.ItemC2, typeof(EditC2ItemViewModel) },
        { ItemType.ItemC3, typeof(EditC3ItemViewModel) },
        { ItemType.ItemC4, typeof(EditC4ItemViewModel) },
        { ItemType.ItemC5, typeof(EditC5ItemViewModel) },
        { ItemType.ItemC6, typeof(EditC6ItemViewModel) },
        { ItemType.ItemC7, typeof(EditC7ItemViewModel) },

        { ItemType.ItemD1, typeof(EditD1ItemViewModel) },
        { ItemType.ItemD2, typeof(EditD2ItemViewModel) },

        { ItemType.ItemE1, typeof(EditE1ItemViewModel) },
        { ItemType.ItemE2, typeof(EditE2ItemViewModel) },
        { ItemType.ItemE3, typeof(EditE3ItemViewModel) },
        { ItemType.ItemE4, typeof(EditE4ItemViewModel) },
        { ItemType.ItemE5, typeof(EditE5ItemViewModel) },
        { ItemType.ItemE6, typeof(EditE6ItemViewModel) },
        { ItemType.ItemE7, typeof(EditE7ItemViewModel) },

        { ItemType.ItemF1, typeof(EditF1ItemViewModel) },

        { ItemType.ItemG1, typeof(EditG1ItemViewModel) },
        { ItemType.ItemG2, typeof(EditG2ItemViewModel) },
        { ItemType.ItemG3, typeof(EditG3ItemViewModel) },
        { ItemType.ItemG4, typeof(EditG4ItemViewModel) },
        { ItemType.ItemG5, typeof(EditG5ItemViewModel) },
        { ItemType.ItemG6, typeof(EditG6ItemViewModel) },

        { ItemType.ItemH1, typeof(EditH1ItemViewModel) },
        { ItemType.ItemH2, typeof(EditH2ItemViewModel) },
        { ItemType.ItemH3, typeof(EditH3ItemViewModel) },
        { ItemType.ItemH4, typeof(EditH4ItemViewModel) },
        { ItemType.ItemH5, typeof(EditH5ItemViewModel) },

        { ItemType.ItemI1, typeof(EditI1ItemViewModel) },
        { ItemType.ItemI2, typeof(EditI2ItemViewModel) },

        { ItemType.ItemJ1, typeof(EditJ1ItemViewModel) },

        { ItemType.ItemK1, typeof(EditK1ItemViewModel) },
        { ItemType.ItemK2, typeof(EditK2ItemViewModel) },
        { ItemType.ItemK3, typeof(EditK3ItemViewModel) },

        { ItemType.ItemL1, typeof(EditL1ItemViewModel) }
    };

        public static Dictionary<Subfix, Type> ItemListViewModelTypeMap = new Dictionary<Subfix, Type>
    {
        { Subfix.A, typeof(AItemListViewModel) },
        { Subfix.B, typeof(BItemListViewModel) },
        { Subfix.C, typeof(CItemListViewModel) },
        { Subfix.D, typeof(DItemListViewModel) },
        { Subfix.E, typeof(EItemListViewModel) },
        { Subfix.F, typeof(FItemListViewModel) },
        { Subfix.G, typeof(GItemListViewModel) },
        { Subfix.H, typeof(HItemListViewModel) },
        { Subfix.I, typeof(IItemListViewModel) },
        { Subfix.J, typeof(JItemListViewModel) },
        { Subfix.K, typeof(KItemListViewModel) },
        { Subfix.L, typeof(LItemListViewModel) },

    };



        public static ItemType GetItemType(string itemsName)
        {
            return (ItemType)Enum.Parse(typeof(ItemType), "Item" + itemsName.ToFormat(), true);
        }

        public static ItemType GetItemType(IItem item)
        {
            return (ItemType)Enum.Parse(typeof(ItemType), item.GetType().Name, true);
        }

        public static Subfix GetSubfix(ItemType itemType)
        {
            string itemName = itemType.ToString().Substring(4);
            string subfixPart = Regex.Replace(itemName, "[0-9]", "");
            return (Subfix)Enum.Parse(typeof(Subfix), subfixPart, true);
        }

        public static Subfix GetSubfix(string itemsName)
        {
            ItemType itemType = GetItemType(itemsName);

            return GetSubfix(itemType);
        }

        public static string GetItemListPropertyName(IItem item)
        {
            return item.GetType().Name + "s";
        }

        public static string GetItemListPropertyName(ItemType itemType)
        {
            return itemType.ToString() + "s";
        }

        public static Type GetEditViewModelTypeForItemType(ItemType itemType)
        {
                return EditItemViewModelForItemTypeMap[itemType];
        }

        public static Type GetEditCatalogViewModelTypeForItemType(ItemType itemType)
        {
            return EditCatalogViewModelForItemTypeMap[itemType];
        }
        public static Type GetCatalogListViewModelTypeForItemType(ItemType itemType)
        {
            return CatalogListViewModelForItemTypeMap[itemType];
        }

        public static Type GetItemListViewModelTypeForSubfix(Subfix subfix)
        {
                return ItemListViewModelTypeMap[subfix];
        }
    }
}
