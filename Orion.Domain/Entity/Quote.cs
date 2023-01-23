using Orion.Binding.Binding;
using Orion.Binding.Interfaces;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Domain.EntityItemPuroFlux;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

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

        #region Quantech Items
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
        #endregion

        #region ABB Items

        private IList<ItemB1> _itemB1s;
        public IList<ItemB1> ItemB1s
        {
            get => _itemB1s;
            set => SetProperty(ref _itemB1s, value);
        }

        private IList<ItemB2> _itemB2s;
        public IList<ItemB2> ItemB2s
        {
            get => _itemB2s;
            set => SetProperty(ref _itemB2s, value);
        }

        private IList<ItemB3> _itemB3s;
        public IList<ItemB3> ItemB3s
        {
            get => _itemB3s;
            set => SetProperty(ref _itemB3s, value);
        }

        private IList<ItemB4> _itemB4s;
        public IList<ItemB4> ItemB4s
        {
            get => _itemB4s;
            set => SetProperty(ref _itemB4s, value);
        }

        private IList<ItemB5> _itemB5s;
        public IList<ItemB5> ItemB5s
        {
            get => _itemB5s;
            set => SetProperty(ref _itemB5s, value);
        }
        #endregion

        #region American Wheatley Items
        private IList<ItemC1> _itemC1s;
        public IList<ItemC1> ItemC1s
        {
            get => _itemC1s;
            set => SetProperty(ref _itemC1s, value);
        }

        private IList<ItemC2> _itemC2s;
        public IList<ItemC2> ItemC2s
        {
            get => _itemC2s;
            set => SetProperty(ref _itemC2s, value);
        }

        private IList<ItemC3> _itemC3s;
        public IList<ItemC3> ItemC3s
        {
            get => _itemC3s;
            set => SetProperty(ref _itemC3s, value);
        }
        private IList<ItemC4> _itemC4s;
        public IList<ItemC4> ItemC4s
        {
            get => _itemC4s;
            set => SetProperty(ref _itemC4s, value);
        }
        #endregion

        #region Puroflux Items
        private IList<ItemD1> _itemD1s;
        public IList<ItemD1> ItemD1s
        {
            get => _itemD1s;
            set => SetProperty(ref _itemD1s, value);
        }

        private IList<ItemD2> _itemD2s;
        public IList<ItemD2> ItemD2s
        {
            get => _itemD2s;
            set => SetProperty(ref _itemD2s, value);
        }
        #endregion

        private bool _isSelected;
        [NotMapped]
        public bool IsSelected
        {
            get => _isSelected;
            set => SetProperty(ref _isSelected, value);
        }

        private bool _canCreateReports;
        [NotMapped]
        public bool CanCreateReports
        {
            get => _canCreateReports;
            set => SetProperty(ref _canCreateReports, value);
        }

        public Quote()
        {
            ItemA1s = new ObservableCollection<ItemA1>();
            ItemA2s = new ObservableCollection<ItemA2>();
            ItemA3s = new ObservableCollection<ItemA3>();
            ItemA4s = new ObservableCollection<ItemA4>();

            ItemB1s = new ObservableCollection<ItemB1>();
            ItemB2s = new ObservableCollection<ItemB2>();
            ItemB3s = new ObservableCollection<ItemB3>();
            ItemB4s = new ObservableCollection<ItemB4>();
            ItemB5s = new ObservableCollection<ItemB5>();

            ItemC1s = new ObservableCollection<ItemC1>();
            ItemC2s = new ObservableCollection<ItemC2>();
            ItemC3s = new ObservableCollection<ItemC3>();
            ItemC4s = new ObservableCollection<ItemC4>();

            ItemD1s = new ObservableCollection<ItemD1>();
            ItemD2s = new ObservableCollection<ItemD2>();
            Name = "";
        }
    }
    
}
