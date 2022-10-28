using Orion.Binding.Binding;
using Orion.Binding.Interfaces;
using Orion.Domain.Entity;
using Orion.Domain.EntityItemCatalog;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityCatalog
{
    public class CatalogUnit : ValidatableBindableBase, IEntity
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private double _cfm;
        public double Cfm
        {
            get => _cfm;
            set => SetProperty(ref _cfm, value);
        }

        private string _voltage;
        public string Voltage
        {
            get => _voltage;
            set => SetProperty(ref _voltage, value);
        }

        private IList<Title> _titles;
        public IList<Title> Titles
        {
            get => _titles;
            set => SetProperty(ref _titles, value);
        }

        private IList<ItemUnitCatalogUnit> _itemAirHandlerCatalogAirHandlers;
        public IList<ItemUnitCatalogUnit> ItemAirHandlerCatalogAirHandlers
        {
            get => _itemAirHandlerCatalogAirHandlers;
            set => SetProperty(ref _itemAirHandlerCatalogAirHandlers, value);
        }

        public CatalogUnit()
        {
            ItemAirHandlerCatalogAirHandlers = new ObservableCollection<ItemUnitCatalogUnit>();
        }
    }
}
