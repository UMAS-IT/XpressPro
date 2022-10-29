using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityItemCatalog;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.EntityItem
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

        [NotMapped]
        public string DefaultItemName { get { return "Pumps"; } }

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

        private IList<ItemPumpCatalogPump> _itemPumpCatalogPumps;
        public IList<ItemPumpCatalogPump> ItemPumpCatalogPumps
        {
            get => _itemPumpCatalogPumps;
            set => SetProperty(ref _itemPumpCatalogPumps, value);
        }

        public ItemPump()
        {
            ItemPumpCatalogPumps = new ObservableCollection<ItemPumpCatalogPump>();
        }
    }
}
