using Orion.Binding.Binding;
using Orion.Binding.Interfaces;
using Orion.Domain.EntityCatalog;
using Orion.Domain.EntityItem;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
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

        private int? _catalogAirCooledChillerId;
        public int? CatalogAirCooledChillerId
        {
            get => _catalogAirCooledChillerId;
            set => SetProperty(ref _catalogAirCooledChillerId, value);
        }

        private CatalogAirCooledChiller _catalogAirColledChiller;
        public CatalogAirCooledChiller CatalogAirCooledChiller
        {
            get => _catalogAirColledChiller;
            set => SetProperty(ref _catalogAirColledChiller, value);
        }

        private int? _catalogUnitId;
        public int? CatalogUnitId
        {
            get => _catalogUnitId;
            set => SetProperty(ref _catalogUnitId, value);
        }

        private CatalogUnit _catalogUnit;
        public CatalogUnit CatalogUnit
        {
            get => _catalogUnit;
            set => SetProperty(ref _catalogUnit, value);
        }

        private int? _catalogPumpId;
        public int? CatalogPumpId
        {
            get => _catalogPumpId;
            set => SetProperty(ref _catalogPumpId, value);
        }

        private CatalogPump _catalogPump;
        public CatalogPump CatalogPump
        {
            get => _catalogPump;
            set => SetProperty(ref _catalogPump, value);
        }

        private int? _catalogVdfId;
        public int? CatalogVfdId
        {
            get => _catalogVdfId;
            set => SetProperty(ref _catalogVdfId, value);
        }

        private CatalogVfd _catalogVfd;
        public CatalogVfd CatalogVfd
        {
            get => _catalogVfd;
            set => SetProperty(ref _catalogVfd, value);
        }

        private int? _itemAirCooledChillerId;
        public int? ItemAirCooledChillerId
        {
            get => _itemAirCooledChillerId;
            set => SetProperty(ref _itemAirCooledChillerId, value);
        }

        private ItemAirCooledChiller _itemAirColledChiller;
        public ItemAirCooledChiller ItemAirCooledChiller
        {
            get => _itemAirColledChiller;
            set => SetProperty(ref _itemAirColledChiller, value);
        }

        private int? _itemUnitId;
        public int? ItemUnitId
        {
            get => _itemUnitId;
            set => SetProperty(ref _itemUnitId, value);
        }

        private ItemUnit _itemUnit;
        public ItemUnit ItemUnit
        {
            get => _itemUnit;
            set => SetProperty(ref _itemUnit, value);
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

        private int? _itemVfdId;
        public int? ItemVfdId
        {
            get => _itemVfdId;
            set => SetProperty(ref _itemVfdId, value);
        }

        private ItemVfd _itemVfd;
        public ItemVfd ItemVfd
        {
            get => _itemVfd;
            set => SetProperty(ref _itemVfd, value);
        }

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
