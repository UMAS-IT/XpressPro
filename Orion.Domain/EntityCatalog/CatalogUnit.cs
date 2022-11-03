using Orion.Binding.Binding;
using Orion.Domain.Entity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Orion.Domain.EntityCatalog
{
    public class CatalogUnit : ValidatableBindableBase, ICatalog
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

        private double _price;
        public double Price
        {
            get => _price;
            set => SetProperty(ref _price, value);
        }

        public CatalogUnit()
        {
            Titles = new ObservableCollection<Title>();
        }
    }
}
