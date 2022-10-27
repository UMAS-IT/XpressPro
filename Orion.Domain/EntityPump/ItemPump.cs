using Orion.Binding.Binding;
using Orion.Domain.Entity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Orion.Domain.EntityPump
{
    public class ItemPump : ValidatableBindableBase, IItem
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

        private IList<Title> _titles;
        public IList<Title> Titles
        {
            get => _titles;
            set => SetProperty(ref _titles, value);
        }

        private IList<UnitItemPump> _unitItempPumps;
        public IList<UnitItemPump> UnitItemPumps
        {
            get => _unitItempPumps;
            set => SetProperty(ref _unitItempPumps, value);
        }

        private IList<ItemPumpCatalogPump> _itemPumpCatalogPumps;
        public IList<ItemPumpCatalogPump> ItemPumpCatalogPumps
        {
            get => _itemPumpCatalogPumps;
            set => SetProperty(ref _itemPumpCatalogPumps, value);
        }

        public ItemPump()
        {
            Titles = new ObservableCollection<Title>();
            UnitItemPumps = new ObservableCollection<UnitItemPump>();
            ItemPumpCatalogPumps = new ObservableCollection<ItemPumpCatalogPump>();
        }
    }
}
