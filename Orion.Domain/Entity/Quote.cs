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

        private IList<ItemA1> _itemA1s;
        public IList<ItemA1> ItemA1s
        {
            get => _itemA1s;
            set => SetProperty(ref _itemA1s, value);
        }

        private IList<ItemA2> _itemA2s;
        public IList<ItemA2> ItemA2s
        {
            get => _itemA2s;
            set => SetProperty(ref _itemA2s, value);
        }

        private IList<ItemA3> _itemA3s;
        public IList<ItemA3> ItemA3s
        {
            get => _itemA3s;
            set => SetProperty(ref _itemA3s, value);
        }
        private IList<ItemA4> _itemA4s;
        public IList<ItemA4> ItemA4s
        {
            get => _itemA4s;
            set => SetProperty(ref _itemA4s, value);
        }

        public Quote()
        {
            ItemA1s = new ObservableCollection<ItemA1>();
            ItemA2s = new ObservableCollection<ItemA2>();
            ItemA3s = new ObservableCollection<ItemA3>();
            ItemA4s = new ObservableCollection<ItemA4>();
            Name = "";
        }
    }
    
}
