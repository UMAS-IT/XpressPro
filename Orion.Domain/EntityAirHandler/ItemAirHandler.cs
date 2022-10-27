using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityAirCooledCondenser;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityAirHandler
{
    public class ItemAirHandler : ValidatableBindableBase, IItem
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

        private IList<UnitItemAirHandler> _unitItemAirHandlers;
        public IList<UnitItemAirHandler> UnitItemAirHandlers
        {
            get => _unitItemAirHandlers;
            set => SetProperty(ref _unitItemAirHandlers, value);
        }

        private IList<ItemAirHandlerCatalogAirHandler> _itemAirHandlerCatalogAirHandlers;
        public IList<ItemAirHandlerCatalogAirHandler> ItemAirHandlerCatalogAirHandlers
        {
            get => _itemAirHandlerCatalogAirHandlers;
            set => SetProperty(ref _itemAirHandlerCatalogAirHandlers, value);
        }

        public ItemAirHandler()
        {
            Titles = new ObservableCollection<Title>();
            UnitItemAirHandlers= new ObservableCollection<UnitItemAirHandler>();
            ItemAirHandlerCatalogAirHandlers = new ObservableCollection<ItemAirHandlerCatalogAirHandler>();
        }
    }
}
