using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityAirCooledChiller;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Orion.Domain.EntityAirCooledCondenser
{
    public class ItemAirCooledChiller: ValidatableBindableBase, IItem
    {
        private int _Id;
        public int Id
        {
            get => _Id;
            set => SetProperty(ref _Id, value);
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

        private IList<UnitItemAirCooledChiller> _unitItemAirCooledChillers;
        public IList<UnitItemAirCooledChiller> UnitItemAirCooledChillers
        {
            get => _unitItemAirCooledChillers;
            set => SetProperty(ref _unitItemAirCooledChillers, value);
        }

        private IList<ItemAirCooledChillerCatalogAirCooledChiller> _itemAirCooledChillerCatalogAirCooledChillers;
        public IList<ItemAirCooledChillerCatalogAirCooledChiller> ItemAirCooledChillerCatalogAirCooledChillers
        {
            get => _itemAirCooledChillerCatalogAirCooledChillers;
            set => SetProperty(ref _itemAirCooledChillerCatalogAirCooledChillers, value);
        }

        public ItemAirCooledChiller()
        {
            Titles = new ObservableCollection<Title>();
            UnitItemAirCooledChillers = new ObservableCollection<UnitItemAirCooledChiller>();
            ItemAirCooledChillerCatalogAirCooledChillers = new ObservableCollection<ItemAirCooledChillerCatalogAirCooledChiller>();
        }
    }
}
