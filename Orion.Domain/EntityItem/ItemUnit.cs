using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityItemCatalog;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

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

        [NotMapped]
        public string DefaultItemName { get { return "Units"; } }

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

        [NotMapped]
        public bool HasItems { get { return ItemUnitCatalogUnits.Any(); } }

        public ItemUnit()
        {
            ItemUnitCatalogUnits = new ObservableCollection<ItemUnitCatalogUnit>();
        }
    }
}
