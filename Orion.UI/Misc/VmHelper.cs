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
using Orion.UI.ViewModel.ABB.EditQuoteItem;
using Orion.UI.ViewModel.ABB.QuoteItemList;
using Orion.UI.ViewModel.AmericanWheatley.EditQuoteItem;
using Orion.UI.ViewModel.BACClosedCircuits.EditQuoteItem;
using Orion.UI.ViewModel.BACCoolingTowers.EditQuoteItem;
using Orion.UI.ViewModel.GeneralProduct.EditQuoteItem;
using Orion.UI.ViewModel.Groundfos.EditQuoteItem;
using Orion.UI.ViewModel.Mavair.EditQuoteItem;
using Orion.UI.ViewModel.Multiaqua.EditQuoteItem;
using Orion.UI.ViewModel.PACE.EditQuoteItem;
using Orion.UI.ViewModel.Puroflux.EditQuoteItem;
using Orion.UI.ViewModel.Quantech.EditQuoteItem;
using Orion.UI.ViewModel.Quantech.QuoteItemList;
using Orion.UI.ViewModel.UvResources.EditQuoteItem;
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
            // Crea un diccionario que mapee ItemType a su tipo de ViewModel correspondiente
            Dictionary<ItemType, Type> viewModelTypeMap = new Dictionary<ItemType, Type>
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

            // Verifica si el ItemType está en el diccionario, y si es así, devuelve el tipo de ViewModel correspondiente
            if (viewModelTypeMap.ContainsKey(itemType))
            {
                return viewModelTypeMap[itemType];
            }

            // Si el ItemType no se encuentra en el diccionario, puedes manejarlo según tus necesidades.
            return null; // Tipo no compatible
        }


        public static Type GetItemListViewModelTypeForSubfix(Subfix subfix)
        {
            // Crea un diccionario que mapee ItemType a su tipo de ViewModel correspondiente
            Dictionary<Subfix, Type> viewModelTypeMap = new Dictionary<Subfix, Type>
    {
        { Subfix.A, typeof(AItemListViewModel) },

        { Subfix.B, typeof(BItemListViewModel) },

    };

            // Verifica si el ItemType está en el diccionario, y si es así, devuelve el tipo de ViewModel correspondiente
            if (viewModelTypeMap.ContainsKey(subfix))
            {
                return viewModelTypeMap[subfix];
            }

            // Si el ItemType no se encuentra en el diccionario, puedes manejarlo según tus necesidades.
            return null; // Tipo no compatible
        }
    }
}
