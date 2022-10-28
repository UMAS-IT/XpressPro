using Orion.Binding.Binding;
using Orion.Domain.EntityCatalog;
using Orion.Domain.EntityItem;

namespace Orion.Domain.EntityItemCatalog
{
    public class ItemPumpCatalogPump : ValidatableBindableBase
    {
        private int _itemPumpId;
        public int ItemPumpId
        {
            get => _itemPumpId;
            set => SetProperty(ref _itemPumpId, value);
        }

        private ItemPump _itemPump;
        public ItemPump ItemPump
        {
            get => _itemPump;
            set => SetProperty(ref _itemPump, value);
        }

        private int _catalogPumpId;
        public int CatalogPumpId
        {
            get => _catalogPumpId;
            set => SetProperty(ref _catalogPumpId, value);
        }

        private CatalogPump _catalogPump;
        public CatalogPump CatalogPump
        {
            get => _catalogPump;
            set => SetProperty(ref _catalogPump, value);
        }
    }
}
