using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityItemCatalog;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityItem
{
    public class ItemVfd : ValidatableBindableBase, IItem
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
        public string DefaultItemName { get { return "Vfds"; } }

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

        private IList<ItemVfdCatalogVfd> _itemvfdCatalogVfds;
        public IList<ItemVfdCatalogVfd> ItemVfdCatalogVfds
        {
            get => _itemvfdCatalogVfds;
            set => SetProperty(ref _itemvfdCatalogVfds, value);
        }

        [NotMapped]
        public bool HasItems { get { return ItemVfdCatalogVfds.Any(); } }

        public ItemVfd()
        {
            ItemVfdCatalogVfds = new ObservableCollection<ItemVfdCatalogVfd>();
        }
    }
}
