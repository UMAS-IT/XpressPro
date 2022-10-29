using Microsoft.EntityFrameworkCore.Internal;
using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityItemCatalog;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.EntityItem
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

        [NotMapped]
        public string DefaultItemName { get { return "Air Cooled Chillers"; } }

        private int _quoteId;
        public int QuoteId
        {
            get => _quoteId;
            set => SetProperty(ref _quoteId, value);
        }

        private Quote _quote;
        public Quote Quote
        {
            get => _quote;
            set => SetProperty(ref _quote, value);
        }

        private IList<ItemAirCooledChillerCatalogAirCooledChiller> _itemAirCooledChillerCatalogAirCooledChillers;
        public IList<ItemAirCooledChillerCatalogAirCooledChiller> ItemAirCooledChillerCatalogAirCooledChillers
        {
            get => _itemAirCooledChillerCatalogAirCooledChillers;
            set => SetProperty(ref _itemAirCooledChillerCatalogAirCooledChillers, value);
        }

        [NotMapped]
        public bool HasItems { get { return ItemAirCooledChillerCatalogAirCooledChillers.Any(); } }

        public ItemAirCooledChiller()
        {
            ItemAirCooledChillerCatalogAirCooledChillers = new ObservableCollection<ItemAirCooledChillerCatalogAirCooledChiller>();
        }
    }
}
