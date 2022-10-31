using Orion.Binding.Binding;
using Orion.Binding.Interfaces;
using Orion.Domain.EntityCatalog;
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
