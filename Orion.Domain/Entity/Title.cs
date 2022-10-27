using Orion.Binding.Binding;
using Orion.Binding.Interfaces;
using Orion.Domain.EntityAirCooledCondenser;
using Orion.Domain.EntityAirHandler;
using Orion.Domain.EntityPump;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Orion.Domain.Entity
{
    public class Title : ValidatableBindableBase, IEntity
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private int? _itemAirCooledChillerId;
        public int? ItemAirCooledChillerId
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

        private int? _itemPumpId;
        public int? ItemPumpId
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

        private int? _itemAirHandlerId;
        public int? ItemAirHandlerId
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

        private IList<Spec> _specs;
        public IList<Spec> Specs
        {
            get => _specs;
            set => SetProperty(ref _specs, value);
        }
        public Title()
        {
            Specs = new ObservableCollection<Spec>();
        }
    }
}
