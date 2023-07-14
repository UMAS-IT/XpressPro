using Orion.Binding.Binding;
using Orion.Binding.Interfaces;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Domain.EntityItemBACClosedLoopTowers;
using Orion.Domain.EntityItemBACOpenLoopTowers;
using Orion.Domain.EntityItemGroundfos;
using Orion.Domain.EntityItemPuroFlux;
using Orion.Domain.EntityItemUvResources;
using Orion.Domain.Marvair.Item;
using Orion.Domain.Multiaqua.Item;
using Orion.Domain.PACE.Item;
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

        private IList<ItemC5> _itemC5s;
        public IList<ItemC5> ItemC5s
        {
            get => _itemC5s;
            set => SetProperty(ref _itemC5s, value);
        }

        private IList<ItemC6> _itemC6s;
        public IList<ItemC6> ItemC6s
        {
            get => _itemC6s;
            set => SetProperty(ref _itemC6s, value);
        }

        private IList<ItemC7> _itemC7s;
        public IList<ItemC7> ItemC7s
        {
            get => _itemC7s;
            set => SetProperty(ref _itemC7s, value);
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



        #region Groundfos Items

        private IList<ItemE1> _itemE1s;
        public IList<ItemE1> ItemE1s
        {
            get => _itemE1s;
            set => SetProperty(ref _itemE1s, value);
        }

        private IList<ItemE2> _itemE2s;
        public IList<ItemE2> ItemE2s
        {
            get => _itemE2s;
            set => SetProperty(ref _itemE2s, value);
        }

        private IList<ItemE3> _itemE3s;
        public IList<ItemE3> ItemE3s
        {
            get => _itemE3s;
            set => SetProperty(ref _itemE3s, value);
        }

        private IList<ItemE4> _itemE4s;
        public IList<ItemE4> ItemE4s
        {
            get => _itemE4s;
            set => SetProperty(ref _itemE4s, value);
        }

        private IList<ItemE5> _itemE5s;
        public IList<ItemE5> ItemE5s
        {
            get => _itemE5s;
            set => SetProperty(ref _itemE5s, value);
        }

        private IList<ItemE6> _itemE6s;
        public IList<ItemE6> ItemE6s
        {
            get => _itemE6s;
            set => SetProperty(ref _itemE6s, value);
        }

        private IList<ItemE7> _itemE7s;
        public IList<ItemE7> ItemE7s
        {
            get => _itemE7s;
            set => SetProperty(ref _itemE7s, value);
        }
        #endregion



        #region UV Resources Items
        private IList<ItemF1> _itemF1s;
        public IList<ItemF1> ItemF1s
        {
            get => _itemF1s;
            set => SetProperty(ref _itemF1s, value);
        }
        #endregion



        #region BAC Cooling Towers Items

        private IList<ItemG1> _itemG1s;
        public IList<ItemG1> ItemG1s
        {
            get => _itemG1s;
            set => SetProperty(ref _itemG1s, value);
        }

        private IList<ItemG2> _itemG2s;
        public IList<ItemG2> ItemG2s
        {
            get => _itemG2s;
            set => SetProperty(ref _itemG2s, value);
        }

        private IList<ItemG3> _itemG3s;
        public IList<ItemG3> ItemG3s
        {
            get => _itemG3s;
            set => SetProperty(ref _itemG3s, value);
        }

        private IList<ItemG4> _itemG4s;
        public IList<ItemG4> ItemG4s
        {
            get => _itemG4s;
            set => SetProperty(ref _itemG4s, value);
        }

        private IList<ItemG5> _itemG5s;
        public IList<ItemG5> ItemG5s
        {
            get => _itemG5s;
            set => SetProperty(ref _itemG5s, value);
        }

        private IList<ItemG6> _itemG6s;
        public IList<ItemG6> ItemG6s
        {
            get => _itemG6s;
            set => SetProperty(ref _itemG6s, value);
        }
        #endregion



        #region BAC Closed Circuits Items

        private IList<ItemH1> _itemH1s;
        public IList<ItemH1> ItemH1s
        {
            get => _itemH1s;
            set => SetProperty(ref _itemH1s, value);
        }

        private IList<ItemH2> _itemH2s;
        public IList<ItemH2> ItemH2s
        {
            get => _itemH2s;
            set => SetProperty(ref _itemH2s, value);
        }

        private IList<ItemH3> _itemH3s;
        public IList<ItemH3> ItemH3s
        {
            get => _itemH3s;
            set => SetProperty(ref _itemH3s, value);
        }

        private IList<ItemH4> _itemH4s;
        public IList<ItemH4> ItemH4s
        {
            get => _itemH4s;
            set => SetProperty(ref _itemH4s, value);
        }

        private IList<ItemH5> _itemH5s;
        public IList<ItemH5> ItemH5s
        {
            get => _itemH5s;
            set => SetProperty(ref _itemH5s, value);
        }
        #endregion



        #region Marvair Items
        private IList<ItemI1> _itemI1s;
        public IList<ItemI1> ItemI1s
        {
            get => _itemI1s;
            set => SetProperty(ref _itemI1s, value);
        }

        private IList<ItemI2> _itemI2s;
        public IList<ItemI2> ItemI2s
        {
            get => _itemI2s;
            set => SetProperty(ref _itemI2s, value);
        }
        #endregion



        #region PACE AHU Items       
        private IList<ItemJ1> _itemJ1s;
        public IList<ItemJ1> ItemJ1s
        {
            get => _itemJ1s;
            set => SetProperty(ref _itemJ1s, value);
        }
        #endregion



        #region Multiaqua
        private IList<ItemK1> _itemK1s;
        public IList<ItemK1> ItemK1s
        {
            get => _itemK1s;
            set => SetProperty(ref _itemK1s, value);
        }

        private IList<ItemK2> _itemK2s;
        public IList<ItemK2> ItemK2s
        {
            get => _itemK2s;
            set => SetProperty(ref _itemK2s, value);
        }

        private IList<ItemK3> _itemK3s;
        public IList<ItemK3> ItemK3s
        {
            get => _itemK3s;
            set => SetProperty(ref _itemK3s, value);
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


        private IList<IItem> _items;
        [NotMapped]
        public IList<IItem> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
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
            ItemC5s = new ObservableCollection<ItemC5>();
            ItemC6s = new ObservableCollection<ItemC6>();
            ItemC7s = new ObservableCollection<ItemC7>();

            ItemD1s = new ObservableCollection<ItemD1>();
            ItemD2s = new ObservableCollection<ItemD2>();

            ItemE1s = new ObservableCollection<ItemE1>();
            ItemE2s = new ObservableCollection<ItemE2>();
            ItemE3s = new ObservableCollection<ItemE3>();
            ItemE4s = new ObservableCollection<ItemE4>();
            ItemE5s = new ObservableCollection<ItemE5>();
            ItemE6s = new ObservableCollection<ItemE6>();
            ItemE7s = new ObservableCollection<ItemE7>();

            ItemF1s = new ObservableCollection<ItemF1>();

            ItemG1s = new ObservableCollection<ItemG1>();
            ItemG2s = new ObservableCollection<ItemG2>();
            ItemG3s = new ObservableCollection<ItemG3>();
            ItemG4s = new ObservableCollection<ItemG4>();
            ItemG5s = new ObservableCollection<ItemG5>();
            ItemG6s = new ObservableCollection<ItemG6>();

            ItemH1s = new ObservableCollection<ItemH1>();
            ItemH2s = new ObservableCollection<ItemH2>();
            ItemH3s = new ObservableCollection<ItemH3>();
            ItemH4s = new ObservableCollection<ItemH4>();
            ItemH5s = new ObservableCollection<ItemH5>();

            ItemI1s = new ObservableCollection<ItemI1>();
            ItemI2s = new ObservableCollection<ItemI2>();

            ItemJ1s = new ObservableCollection<ItemJ1>();

            ItemK1s = new ObservableCollection<ItemK1>();
            ItemK2s = new ObservableCollection<ItemK2>();
            ItemK3s = new ObservableCollection<ItemK3>();


            Name = "";
        }
    }
    
}
