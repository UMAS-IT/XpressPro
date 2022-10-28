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
    public class CatalogVfd : BindableBase, IEntity
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
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

        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
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

        private IList<ItemVfdCatalogVfd> _itemvfdCatalogVfds;
        public IList<ItemVfdCatalogVfd> ItemVfdCatalogVfds
        {
            get => _itemvfdCatalogVfds;
            set => SetProperty(ref _itemvfdCatalogVfds, value);
        }

        public CatalogVfd()
        {
            ItemVfdCatalogVfds = new ObservableCollection<ItemVfdCatalogVfd>();
        }

    }
}
