using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityCatalogABB
{
    // ABB - BCR
    public class CatalogB4 : ValidatableBindableBase, ICatalog
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

        private double _Hp;
        public double Hp
        {
            get => _Hp;
            set => SetProperty(ref _Hp, value);
        }

        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        private string _nema;
        public string Nema
        {
            get => _nema;
            set => SetProperty(ref _nema, value);
        }

        private bool _bypass;
        public bool Bypass
        {
            get => _bypass;
            set => SetProperty(ref _bypass, value);
        }

        private bool _circuitBreakerDisconnect;
        public bool CircuitBreakerDisconnect
        {
            get => _circuitBreakerDisconnect;
            set => SetProperty(ref _circuitBreakerDisconnect, value);
        }

        private string _voltage;
        public string Voltage
        {
            get => _voltage;
            set => SetProperty(ref _voltage, value);
        }
















        private double _listPrice;
        public double ListPrice
        {
            get => _listPrice;
            set
            {
                SetProperty(ref _listPrice, value);
                Cost = value * CostMultiplier;
                SellPrice = Cost / (1 - (SellMargin / 100));
            }
        }

        private double _costMultiplier;
        public double CostMultiplier
        {
            get => _costMultiplier;
            set
            {
                SetProperty(ref _costMultiplier, value);
                Cost = value * ListPrice;
                SellPrice = Cost / (1 - (SellMargin / 100));
            }
        }

        private double _cost;
        [NotMapped]
        public double Cost
        {
            get => (ListPrice * CostMultiplier).Truncate(2);
            set => SetProperty(ref _cost, value);
        }

        private double _sellMargin;
        public double SellMargin
        {
            get => _sellMargin;
            set
            {
                SetProperty(ref _sellMargin, value);
                SellPrice = Cost / (1 - (value / 100));
            }
        }

        private double _SellPrice;
        [NotMapped]
        public double SellPrice
        {
            get => (Cost / (1 - (SellMargin / 100))).Truncate(2);
            set => SetProperty(ref _SellPrice, value);
        }

        private IList<Title> _titles;
        public IList<Title> Titles
        {
            get => _titles;
            set => SetProperty(ref _titles, value);
        }

        [NotMapped]
        public string Company { get => "ABB"; }
        [NotMapped]
        public string Product { get => "BCR"; }
        [NotMapped]
        public string Index { get => "b4"; }

        public CatalogB4()
        {
            Titles = new ObservableCollection<Title>();
        }
    }
}
