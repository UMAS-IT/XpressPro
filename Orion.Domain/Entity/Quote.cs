using Orion.Binding.Binding;
using Orion.Binding.Interfaces;
using Orion.Domain.EntityItem;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Orion.Domain.Entity
{
    public class Quote : ValidatableBindableBase, IEntity
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private string _Name;
        public string Name
        {
            get => _Name;
            set => SetProperty(ref _Name, value);
        }

        private int _projectId;
        public int ProjectId
        {
            get => _projectId;
            set => SetProperty(ref _projectId, value);
        }

        private Project _project;
        public Project Project
        {
            get => _project;
            set => SetProperty(ref _project, value);
        }

        private IList<ItemAirCooledChiller> _itemAirCooledChillers;
        public IList<ItemAirCooledChiller> ItemAirCooledChillers
        {
            get => _itemAirCooledChillers;
            set => SetProperty(ref _itemAirCooledChillers, value);
        }

        private IList<ItemPump> _itemPumps;
        public IList<ItemPump> ItemPumps
        {
            get => _itemPumps;
            set => SetProperty(ref _itemPumps, value);
        }

        private IList<ItemUnit> _itemUnits;
        public IList<ItemUnit> ItemUnits
        {
            get => _itemUnits;
            set => SetProperty(ref _itemUnits, value);
        }

        private IList<ItemVfd> _itemVfds;
        public IList<ItemVfd> ItemVfds
        {
            get => _itemVfds;
            set => SetProperty(ref _itemVfds, value);
        }

        public Quote()
        {
            ItemAirCooledChillers = new ObservableCollection<ItemAirCooledChiller>();
            ItemPumps = new ObservableCollection<ItemPump>();
            ItemUnits = new ObservableCollection<ItemUnit>();
            ItemVfds = new ObservableCollection<ItemVfd>();
        }
    }
    
}
