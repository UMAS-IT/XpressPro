using Orion.Binding.Binding;
using Orion.Domain.Entity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Orion.Domain.EntityCatalog
{
    public class CatalogVfd : BindableBase, ICatalog
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private string _modelModel;
        public string Model
        {
            get => _modelModel;
            set => SetProperty(ref _modelModel, value);
        }

        private double _hp;
        public double Hp
        {
            get => _hp;
            set => SetProperty(ref _hp, value);
        }

        private string _voltage;
        public string Voltage
        {
            get => _voltage;
            set => SetProperty(ref _voltage, value);
        }

        private string _enclosure;
        public string Enclosure
        {
            get => _enclosure;
            set => SetProperty(ref _enclosure, value);
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

        public CatalogVfd()
        {
            Titles = new ObservableCollection<Title>();
        }

    }
}
