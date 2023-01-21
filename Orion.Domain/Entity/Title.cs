using Orion.Binding.Binding;
using Orion.Binding.Interfaces;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityCatalogAmericanWheatley;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

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

        private IList<Spec> _specs;
        public IList<Spec> Specs
        {
            get => _specs;
            set => SetProperty(ref _specs, value);
        }

        #region Quantech Items Id
        private int? _itemA1Id;
        public int? ItemA1Id
        {
            get => _itemA1Id;
            set => SetProperty(ref _itemA1Id, value);
        }

        private ItemA1 _itemA1;
        public ItemA1 ItemA1
        {
            get => _itemA1;
            set => SetProperty(ref _itemA1, value);
        }

        private int? _itemA2Id;
        public int? ItemA2Id
        {
            get => _itemA2Id;
            set => SetProperty(ref _itemA2Id, value);
        }

        private ItemA2 _itemA2;
        public ItemA2 ItemA2
        {
            get => _itemA2;
            set => SetProperty(ref _itemA2, value);
        }

        private int? _itemA3Id;
        public int? ItemA3Id
        {
            get => _itemA3Id;
            set => SetProperty(ref _itemA3Id, value);
        }

        private ItemA3 _itemA3;
        public ItemA3 ItemA3
        {
            get => _itemA3;
            set => SetProperty(ref _itemA3, value);
        }

        private int? _itemA4Id;
        public int? ItemA4Id
        {
            get => _itemA4Id;
            set => SetProperty(ref _itemA4Id, value);
        }

        private ItemA4 _itemA4;
        public ItemA4 ItemA4
        {
            get => _itemA4;
            set => SetProperty(ref _itemA4, value);
        }
        #endregion

        #region Quantech Catalogs Id
        private int? _catalogA1Id;
        public int? CatalogA1Id
        {
            get => _catalogA1Id;
            set => SetProperty(ref _catalogA1Id, value);
        }

        private CatalogA1 _catalogA1;
        public CatalogA1 CatalogA1
        {
            get => _catalogA1;
            set => SetProperty(ref _catalogA1, value);
        }

        private int? _catalogA2Id;
        public int? CatalogA2Id
        {
            get => _catalogA2Id;
            set => SetProperty(ref _catalogA2Id, value);
        }

        private CatalogA2 _catalogA2;
        public CatalogA2 CatalogA2
        {
            get => _catalogA2;
            set => SetProperty(ref _catalogA2, value);
        }

        private int? _catalogA3Id;
        public int? CatalogA3Id
        {
            get => _catalogA3Id;
            set => SetProperty(ref _catalogA3Id, value);
        }

        private CatalogA3 _catalogA3;
        public CatalogA3 CatalogA3
        {
            get => _catalogA3;
            set => SetProperty(ref _catalogA3, value);
        }

        private int? _catalogA4Id;
        public int? CatalogA4Id
        {
            get => _catalogA4Id;
            set => SetProperty(ref _catalogA4Id, value);
        }

        private CatalogA4 _catalogA4;
        public CatalogA4 CatalogA4
        {
            get => _catalogA4;
            set => SetProperty(ref _catalogA4, value);
        }
        #endregion

        #region ABB Items Id
        private int? _itemB1Id;
        public int? ItemB1Id
        {
            get => _itemB1Id;
            set => SetProperty(ref _itemB1Id, value);
        }

        private ItemB1 _itemB1;
        public ItemB1 ItemB1
        {
            get => _itemB1;
            set => SetProperty(ref _itemB1, value);
        }

        private int? _itemB2Id;
        public int? ItemB2Id
        {
            get => _itemB2Id;
            set => SetProperty(ref _itemB2Id, value);
        }

        private ItemB2 _itemB2;
        public ItemB2 ItemB2
        {
            get => _itemB2;
            set => SetProperty(ref _itemB2, value);
        }

        private int? _itemB3Id;
        public int? ItemB3Id
        {
            get => _itemB3Id;
            set => SetProperty(ref _itemB3Id, value);
        }

        private ItemB3 _itemB3;
        public ItemB3 ItemB3
        {
            get => _itemB3;
            set => SetProperty(ref _itemB3, value);
        }

        private int? _itemB4Id;
        public int? ItemB4Id
        {
            get => _itemB4Id;
            set => SetProperty(ref _itemB4Id, value);
        }

        private ItemB4 _itemB4;
        public ItemB4 ItemB4
        {
            get => _itemB4;
            set => SetProperty(ref _itemB4, value);
        }

        private int? _itemB5Id;
        public int? ItemB5Id
        {
            get => _itemB5Id;
            set => SetProperty(ref _itemB5Id, value);
        }

        private ItemB5 _itemB5;
        public ItemB5 ItemB5
        {
            get => _itemB5;
            set => SetProperty(ref _itemB5, value);
        }
        #endregion

        #region ABB Catalogs Id

        private int? _catalogB1Id;
        public int? CatalogB1Id
        {
            get => _catalogB1Id;
            set => SetProperty(ref _catalogB1Id, value);
        }

        private CatalogB1 _catalogB1;
        public CatalogB1 CatalogB1
        {
            get => _catalogB1;
            set => SetProperty(ref _catalogB1, value);
        }

        private int? _catalogB2Id;
        public int? CatalogB2Id
        {
            get => _catalogB2Id;
            set => SetProperty(ref _catalogB2Id, value);
        }

        private CatalogB2 _catalogB2;
        public CatalogB2 CatalogB2
        {
            get => _catalogB2;
            set => SetProperty(ref _catalogB2, value);
        }

        private int? _catalogB3Id;
        public int? CatalogB3Id
        {
            get => _catalogB3Id;
            set => SetProperty(ref _catalogB3Id, value);
        }

        private CatalogB3 _catalogB3;
        public CatalogB3 CatalogB3
        {
            get => _catalogB3;
            set => SetProperty(ref _catalogB3, value);
        }

        private int? _catalogB4Id;
        public int? CatalogB4Id
        {
            get => _catalogB4Id;
            set => SetProperty(ref _catalogB4Id, value);
        }

        private CatalogB4 _catalogB4;
        public CatalogB4 CatalogB4
        {
            get => _catalogB4;
            set => SetProperty(ref _catalogB4, value);
        }

        private int? _catalogB5Id;
        public int? CatalogB5Id
        {
            get => _catalogB5Id;
            set => SetProperty(ref _catalogB5Id, value);
        }

        private CatalogB5 _catalogB5;
        public CatalogB5 CatalogB5
        {
            get => _catalogB5;
            set => SetProperty(ref _catalogB5, value);
        }
        #endregion

        #region American Wheatley Items Id
        private int? _itemC1Id;
        public int? ItemC1Id
        {
            get => _itemC1Id;
            set => SetProperty(ref _itemC1Id, value);
        }

        private ItemC1 _itemC1;
        public ItemC1 ItemC1
        {
            get => _itemC1;
            set => SetProperty(ref _itemC1, value);
        }

        private int? _itemC2Id;
        public int? ItemC2Id
        {
            get => _itemC2Id;
            set => SetProperty(ref _itemC2Id, value);
        }

        private ItemC2 _itemC2;
        public ItemC2 ItemC2
        {
            get => _itemC2;
            set => SetProperty(ref _itemC2, value);
        }

        private int? _itemC3Id;
        public int? ItemC3Id
        {
            get => _itemC3Id;
            set => SetProperty(ref _itemC3Id, value);
        }

        private ItemC3 _itemC3;
        public ItemC3 ItemC3
        {
            get => _itemC3;
            set => SetProperty(ref _itemC3, value);
        }

        private int? _itemC4Id;
        public int? ItemC4Id
        {
            get => _itemC4Id;
            set => SetProperty(ref _itemC4Id, value);
        }

        private ItemC4 _itemC4;
        public ItemC4 ItemC4
        {
            get => _itemC4;
            set => SetProperty(ref _itemC4, value);
        }
        #endregion

        #region American Wheatley Catalogs Id
        private int? _catalogC1Id;
        public int? CatalogC1Id
        {
            get => _catalogC1Id;
            set => SetProperty(ref _catalogC1Id, value);
        }

        private CatalogC1 _catalogC1;
        public CatalogC1 CatalogC1
        {
            get => _catalogC1;
            set => SetProperty(ref _catalogC1, value);
        }

        private int? _catalogC2Id;
        public int? CatalogC2Id
        {
            get => _catalogC2Id;
            set => SetProperty(ref _catalogC2Id, value);
        }

        private CatalogC2 _catalogC2;
        public CatalogC2 CatalogC2
        {
            get => _catalogC2;
            set => SetProperty(ref _catalogC2, value);
        }

        private int? _catalogC3Id;
        public int? CatalogC3Id
        {
            get => _catalogC3Id;
            set => SetProperty(ref _catalogC3Id, value);
        }

        private CatalogC3 _catalogC3;
        public CatalogC3 CatalogC3
        {
            get => _catalogC3;
            set => SetProperty(ref _catalogC3, value);
        }

        private int? _catalogC4Id;
        public int? CatalogC4Id
        {
            get => _catalogC4Id;
            set => SetProperty(ref _catalogC4Id, value);
        }

        private CatalogC4 _catalogC4;
        public CatalogC4 CatalogC4
        {
            get => _catalogC4;
            set => SetProperty(ref _catalogC4, value);
        }
        #endregion

        private bool _saved;
        [NotMapped]
        public bool Saved
        {
            get => _saved;
            set => SetProperty(ref _saved, value);
        }

        public Title()
        {
            Specs = new ObservableCollection<Spec>();
            Name = "Default Title Name";
        }
    }
}
