using Orion.Binding.Binding;
using Orion.Binding.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityAirHandler
{
    public class CatalogAirHandler : ValidatableBindableBase, IEntity
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private IList<ItemAirHandlerCatalogAirHandler> _itemAirHandlerCatalogAirHandlers;
        public IList<ItemAirHandlerCatalogAirHandler> ItemAirHandlerCatalogAirHandlers
        {
            get => _itemAirHandlerCatalogAirHandlers;
            set => SetProperty(ref _itemAirHandlerCatalogAirHandlers, value);
        }

        public CatalogAirHandler()
        {
            ItemAirHandlerCatalogAirHandlers = new ObservableCollection<ItemAirHandlerCatalogAirHandler>();
        }
    }
}
