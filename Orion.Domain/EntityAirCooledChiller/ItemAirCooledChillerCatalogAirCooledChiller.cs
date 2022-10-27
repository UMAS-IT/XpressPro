using Orion.Binding.Binding;

namespace Orion.Domain.EntityAirCooledCondenser
{
    public class ItemAirCooledChillerCatalogAirCooledChiller : ValidatableBindableBase
    {
        private int _itemAirCooledChillerId;
        public int ItemAirCooledChillerId
        {
            get => _itemAirCooledChillerId;
            set => SetProperty(ref _itemAirCooledChillerId, value);
        }

        private ItemAirCooledChiller _itemAirCooledChiller;
        public ItemAirCooledChiller ItemAirCooledChiller
        {
            get => _itemAirCooledChiller;
            set => SetProperty(ref _itemAirCooledChiller, value);
        }

        private int _catalogAirCooledChillerId;
        public int CatalogAirCooledChillerId
        {
            get => _catalogAirCooledChillerId;
            set => SetProperty(ref _catalogAirCooledChillerId, value);
        }

        private CatalogAirCooledChiller _catalogAirCooledChiller;
        public CatalogAirCooledChiller CatalogAirCooledChiller
        {
            get => _catalogAirCooledChiller;
            set => SetProperty(ref _catalogAirCooledChiller, value);
        }
    }
}
