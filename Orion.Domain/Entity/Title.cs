using Orion.Binding.Binding;
using Orion.Binding.Interfaces;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityCatalogAmericanWheatley;
using Orion.Domain.EntityCatalogGroundfos;
using Orion.Domain.EntityCatalogPuroflux;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Domain.EntityItemGroundfos;
using Orion.Domain.EntityItemPuroFlux;
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

        #region Puroflux Items Id
        private int? _itemD1Id;
        public int? ItemD1Id
        {
            get => _itemD1Id;
            set => SetProperty(ref _itemD1Id, value);
        }

        private ItemD1 _itemD1;
        public ItemD1 ItemD1
        {
            get => _itemD1;
            set => SetProperty(ref _itemD1, value);
        }

        private int? _itemD2Id;
        public int? ItemD2Id
        {
            get => _itemD2Id;
            set => SetProperty(ref _itemD2Id, value);
        }

        private ItemD2 _itemD2;
        public ItemD2 ItemD2
        {
            get => _itemD2;
            set => SetProperty(ref _itemD2, value);
        }
        #endregion

        #region Puroflux Catalogs Id
        private int? _catalogD1Id;
        public int? CatalogD1Id
        {
            get => _catalogD1Id;
            set => SetProperty(ref _catalogD1Id, value);
        }

        private CatalogD1 _catalogD1;
        public CatalogD1 CatalogD1
        {
            get => _catalogD1;
            set => SetProperty(ref _catalogD1, value);
        }

        private int? _catalogD2Id;
        public int? CatalogD2Id
        {
            get => _catalogD2Id;
            set => SetProperty(ref _catalogD2Id, value);
        }

        private CatalogD2 _catalogD2;
        public CatalogD2 CatalogD2
        {
            get => _catalogD2;
            set => SetProperty(ref _catalogD2, value);
        }
        #endregion

        #region Groundfos Items Id
        private int? _itemE1Id;
        public int? ItemE1Id
        {
            get => _itemE1Id;
            set => SetProperty(ref _itemE1Id, value);
        }

        private ItemE1 _itemE1;
        public ItemE1 ItemE1
        {
            get => _itemE1;
            set => SetProperty(ref _itemE1, value);
        }

        private int? _itemE2Id;
        public int? ItemE2Id
        {
            get => _itemE2Id;
            set => SetProperty(ref _itemE2Id, value);
        }

        private ItemE2 _itemE2;
        public ItemE2 ItemE2
        {
            get => _itemE2;
            set => SetProperty(ref _itemE2, value);
        }

        private int? _itemE3Id;
        public int? ItemE3Id
        {
            get => _itemE3Id;
            set => SetProperty(ref _itemE3Id, value);
        }

        private ItemE3 _itemE3;
        public ItemE3 ItemE3
        {
            get => _itemE3;
            set => SetProperty(ref _itemE3, value);
        }

        private int? _itemE4Id;
        public int? ItemE4Id
        {
            get => _itemE4Id;
            set => SetProperty(ref _itemE4Id, value);
        }

        private ItemE4 _itemE4;
        public ItemE4 ItemE4
        {
            get => _itemE4;
            set => SetProperty(ref _itemE4, value);
        }

        private int? _itemE5Id;
        public int? ItemE5Id
        {
            get => _itemE5Id;
            set => SetProperty(ref _itemE5Id, value);
        }

        private ItemE5 _itemE5;
        public ItemE5 ItemE5
        {
            get => _itemE5;
            set => SetProperty(ref _itemE5, value);
        }

        private int? _itemE6Id;
        public int? ItemE6Id
        {
            get => _itemE6Id;
            set => SetProperty(ref _itemE6Id, value);
        }

        private ItemE6 _itemE6;
        public ItemE6 ItemE6
        {
            get => _itemE6;
            set => SetProperty(ref _itemE6, value);
        }

        private int? _itemE7Id;
        public int? ItemE7Id
        {
            get => _itemE7Id;
            set => SetProperty(ref _itemE7Id, value);
        }

        private ItemE7 _itemE7;
        public ItemE7 ItemE7
        {
            get => _itemE7;
            set => SetProperty(ref _itemE7, value);
        }
        #endregion

        #region Groudfos Catalogs Id

        private int? _catalogE1Id;
        public int? CatalogE1Id
        {
            get => _catalogE1Id;
            set => SetProperty(ref _catalogE1Id, value);
        }

        private CatalogE1 _catalogE1;
        public CatalogE1 CatalogE1
        {
            get => _catalogE1;
            set => SetProperty(ref _catalogE1, value);
        }

        private int? _catalogE2Id;
        public int? CatalogE2Id
        {
            get => _catalogE2Id;
            set => SetProperty(ref _catalogE2Id, value);
        }

        private CatalogE2 _catalogE2;
        public CatalogE2 CatalogE2
        {
            get => _catalogE2;
            set => SetProperty(ref _catalogE2, value);
        }

        private int? _catalogE3Id;
        public int? CatalogE3Id
        {
            get => _catalogE3Id;
            set => SetProperty(ref _catalogE3Id, value);
        }

        private CatalogE3 _catalogE3;
        public CatalogE3 CatalogE3
        {
            get => _catalogE3;
            set => SetProperty(ref _catalogE3, value);
        }

        private int? _catalogE4Id;
        public int? CatalogE4Id
        {
            get => _catalogE4Id;
            set => SetProperty(ref _catalogE4Id, value);
        }

        private CatalogE4 _catalogE4;
        public CatalogE4 CatalogE4
        {
            get => _catalogE4;
            set => SetProperty(ref _catalogE4, value);
        }

        private int? _catalogE5Id;
        public int? CatalogE5Id
        {
            get => _catalogE5Id;
            set => SetProperty(ref _catalogE5Id, value);
        }

        private CatalogE5 _catalogE5;
        public CatalogE5 CatalogE5
        {
            get => _catalogE5;
            set => SetProperty(ref _catalogE5, value);
        }

        private int? _catalogE6Id;
        public int? CatalogE6Id
        {
            get => _catalogE6Id;
            set => SetProperty(ref _catalogE6Id, value);
        }

        private CatalogE6 _catalogE6;
        public CatalogE6 CatalogE6
        {
            get => _catalogE6;
            set => SetProperty(ref _catalogE6, value);
        }

        private int? _catalogE7Id;
        public int? CatalogE7Id
        {
            get => _catalogE7Id;
            set => SetProperty(ref _catalogE7Id, value);
        }

        private CatalogE7 _catalogE7;
        public CatalogE7 CatalogE7
        {
            get => _catalogE7;
            set => SetProperty(ref _catalogE7, value);
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
