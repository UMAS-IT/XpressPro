using Orion.Binding.Binding;
using Orion.Binding.Interfaces;
using Orion.Domain.Entity;
using Orion.Domain.EntityItemCatalog;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Orion.Domain.EntityCatalog
{
    public class CatalogPump: ValidatableBindableBase, IEntity
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

        private double _flow;
        public double Flow
        {
            get => _flow;
            set => SetProperty(ref _flow, value);
        }

        private double _head;
        public double Head
        {
            get => _head;
            set => SetProperty(ref _head, value);
        }

        private double _hp;
        public double hp
        {
            get => _hp;
            set => SetProperty(ref _hp, value);
        }

        private string _motor;
        public string Motor
        {
            get => _motor;
            set => SetProperty(ref _motor, value);
        }

        private IList<Title> _titles;
        public IList<Title> Titles
        {
            get => _titles;
            set => SetProperty(ref _titles, value);
        }

        private IList<ItemPumpCatalogPump> _itemPumpCatalogPumps;
        public IList<ItemPumpCatalogPump> ItemPumpCatalogPumps
        {
            get => _itemPumpCatalogPumps;
            set => SetProperty(ref _itemPumpCatalogPumps, value);
        }
        public CatalogPump()
        {
            ItemPumpCatalogPumps = new ObservableCollection<ItemPumpCatalogPump>();
        }
    }
}
