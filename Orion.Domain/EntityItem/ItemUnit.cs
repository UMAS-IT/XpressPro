using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityItemCatalog;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.EntityItem
{
    public class ItemUnit : ValidatableBindableBase, IItem
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

        private int _designIndex;
        public int DesignIndex
        {
            get => _designIndex;
            set => SetProperty(ref _designIndex, value);
        }

        [NotMapped]
        public string DefaultItemName { get { return "Unit"; } }

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

        private IList<ItemUnitCatalogUnit> _itemUnitCatalogUnits;
        public IList<ItemUnitCatalogUnit> ItemUnitCatalogUnits
        {
            get => _itemUnitCatalogUnits;
            set => SetProperty(ref _itemUnitCatalogUnits, value);
        }

        public ItemUnit()
        {
            ItemUnitCatalogUnits = new ObservableCollection<ItemUnitCatalogUnit>();
        }
    }
}
