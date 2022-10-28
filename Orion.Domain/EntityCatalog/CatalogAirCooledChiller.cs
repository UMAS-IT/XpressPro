using Orion.Binding.Binding;
using Orion.Binding.Interfaces;
using Orion.Domain.Entity;
using Orion.Domain.EntityItemCatalog;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Orion.Domain.EntityCatalog
{
    public class CatalogAirCooledChiller: ValidatableBindableBase, IEntity
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private double _nominalCapacity;
        public double NominalCapacity
        {
            get => _nominalCapacity;
            set => SetProperty(ref _nominalCapacity, value);
        }

        private double _chwGpm;
        public double ChwGpm
        {
            get => _chwGpm;
            set => SetProperty(ref _chwGpm, value);
        }

        private string _chwEwtLwt;
        public string ChwEwtLwt
        {
            get => _chwEwtLwt;
            set => SetProperty(ref _chwEwtLwt, value);
        }

        private double _ambient;
        public double Ambient
        {
            get => _ambient;
            set => SetProperty(ref _ambient, value);
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

        private IList<ItemAirCooledChillerCatalogAirCooledChiller> _itemAirCooledChillerCatalogAirCooledChillers;
        public IList<ItemAirCooledChillerCatalogAirCooledChiller> ItemAirCooledChillerCatalogAirCooledChillers
        {
            get => _itemAirCooledChillerCatalogAirCooledChillers;
            set => SetProperty(ref _itemAirCooledChillerCatalogAirCooledChillers, value);
        }

        public CatalogAirCooledChiller()
        {
            ItemAirCooledChillerCatalogAirCooledChillers = new ObservableCollection<ItemAirCooledChillerCatalogAirCooledChiller>();
            Titles = new ObservableCollection<Title>();
        }
    }
}
