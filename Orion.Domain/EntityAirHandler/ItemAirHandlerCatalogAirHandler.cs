using Orion.Binding.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityAirHandler
{
    public class ItemAirHandlerCatalogAirHandler : ValidatableBindableBase
    {
        private int _itemAirHandlerId;
        public int ItemAirHandlerId
        {
            get => _itemAirHandlerId;
            set => SetProperty(ref _itemAirHandlerId, value);
        }

        private ItemAirHandler _itemAirHandler;
        public ItemAirHandler ItemAirHandler
        {
            get => _itemAirHandler;
            set => SetProperty(ref _itemAirHandler, value);
        }

        private int _catalogAirHandlerId;
        public int CatalogAirHandlerId
        {
            get => _catalogAirHandlerId;
            set => SetProperty(ref _catalogAirHandlerId, value);
        }

        private CatalogAirHandler _catalogAirHandler;
        public CatalogAirHandler CatalogAirHandler
        {
            get => _catalogAirHandler;
            set => SetProperty(ref _catalogAirHandler, value);
        }
    }
}
