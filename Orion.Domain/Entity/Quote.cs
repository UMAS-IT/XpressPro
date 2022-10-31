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

        private ItemAirCooledChiller _itemAirCooledChiller;
        public ItemAirCooledChiller ItemAirCooledChiller
        {
            get => _itemAirCooledChiller;
            set => SetProperty(ref _itemAirCooledChiller, value);
        }

        private ItemPump _itemPump;
        public ItemPump ItemPump
        {
            get => _itemPump;
            set => SetProperty(ref _itemPump, value);
        }

        private ItemUnit _itemUnit;
        public ItemUnit ItemUnit
        {
            get => _itemUnit;
            set => SetProperty(ref _itemUnit, value);
        }

        private ItemVfd _itemVfd;
        public ItemVfd ItemVfd
        {
            get => _itemVfd;
            set => SetProperty(ref _itemVfd, value);
        }

        public Quote()
        {
            ItemAirCooledChiller = new ItemAirCooledChiller();
            ItemPump = new ItemPump();
            ItemUnit = new ItemUnit();
            ItemVfd = new ItemVfd();
            Name = "";
        }
    }
    
}
