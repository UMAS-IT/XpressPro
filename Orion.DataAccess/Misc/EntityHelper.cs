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
using Orion.Domain.Marvair;
using Orion.Domain.Marvair.Catalog;
using Orion.Domain.Marvair.Item;
using Orion.Domain.Multiaqua.Catalog;
using Orion.Domain.Multiaqua.Item;
using Orion.Domain.PACE.Catalog;
using Orion.Domain.PACE.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Orion.Helper.Misc.GV;

namespace Orion.DataAccess.Misc
{
    public static class EntityHelper
    {
        public static Type GetItemForItemType(ItemType itemType)
        {
            // Crea un diccionario que mapee ItemType a su tipo de ViewModel correspondiente
            Dictionary<ItemType, Type> viewModelTypeMap = new Dictionary<ItemType, Type>
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

        { ItemType.ItemL1, typeof(ItemL1) }
    };

            // Verifica si el ItemType está en el diccionario, y si es así, devuelve el tipo de ViewModel correspondiente
            if (viewModelTypeMap.ContainsKey(itemType))
            {
                return viewModelTypeMap[itemType];
            }

            // Si el ItemType no se encuentra en el diccionario, puedes manejarlo según tus necesidades.
            return null; // Tipo no compatible
        }

        public static Type GetCatalogForItemType(ItemType itemType)
        {
            // Crea un diccionario que mapee ItemType a su tipo de ViewModel correspondiente
            Dictionary<ItemType, Type> viewModelTypeMap = new Dictionary<ItemType, Type>
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
                                  
        { ItemType.ItemL1, typeof(CatalogL1) }
    };

            // Verifica si el ItemType está en el diccionario, y si es así, devuelve el tipo de ViewModel correspondiente
            if (viewModelTypeMap.ContainsKey(itemType))
            {
                return viewModelTypeMap[itemType];
            }

            // Si el ItemType no se encuentra en el diccionario, puedes manejarlo según tus necesidades.
            return null; // Tipo no compatible
        }


    }
}
