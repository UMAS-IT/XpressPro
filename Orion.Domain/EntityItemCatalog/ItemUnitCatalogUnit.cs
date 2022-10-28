using Orion.Binding.Binding;
using Orion.Domain.EntityCatalog;
using Orion.Domain.EntityItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityItemCatalog
{
    public class ItemUnitCatalogUnit : ValidatableBindableBase
    {
        private int _itemUnitId;
        public int ItemUnitId
        {
            get => _itemUnitId;
            set => SetProperty(ref _itemUnitId, value);
        }

        private ItemUnit _itemUnit;
        public ItemUnit ItemUnit
        {
            get => _itemUnit;
            set => SetProperty(ref _itemUnit, value);
        }

        private int _catalogUnitId;
        public int CatalogUnitId
        {
            get => _catalogUnitId;
            set => SetProperty(ref _catalogUnitId, value);
        }

        private CatalogUnit _catalogUnit;
        public CatalogUnit CatalogUnit
        {
            get => _catalogUnit;
            set => SetProperty(ref _catalogUnit, value);
        }
    }
}
