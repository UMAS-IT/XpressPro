using Orion.Binding.Binding;
using Orion.Domain.Entity;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.EntityCatalogQuantech
{
    // QUANTECH - Air Cooled Stock Post Coated
    public class CatalogA3 : ValidatableBindableBase , ICatalog
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

        private double _listPrice;
        public double ListPrice
        {
            get => _listPrice;
            set => SetProperty(ref _listPrice, value);
        }

        private double _costMultiplier;
        public double CostMultiplier
        {
            get => _costMultiplier;
            set => SetProperty(ref _costMultiplier, value);
        }

        private double _cost;
        [NotMapped]
        public double Cost
        {
            get => ListPrice * CostMultiplier;
            set => SetProperty(ref _cost, value);
        }

        private double _sellMargin;
        public double SellMargin
        {
            get => _sellMargin;
            set => SetProperty(ref _sellMargin, value);
        }

        private double _SellPrice;
        [NotMapped]
        public double SellPrice
        {
            get => Cost / (1 - (SellMargin / 100));
            set => SetProperty(ref _SellPrice, value);
        }

        private IList<Title> _titles;
        public IList<Title> Titles
        {
            get => _titles;
            set => SetProperty(ref _titles, value);
        }

        private string _unitSize;
        public string UnitSize
        {
            get => _unitSize;
            set => SetProperty(ref _unitSize, value);
        }

        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        private string _voltage;
        public string Voltage
        {
            get => _voltage;
            set => SetProperty(ref _voltage, value);
        }
        public CatalogA3()
        {
            Titles = new ObservableCollection<Title>();
        }
    }
}
