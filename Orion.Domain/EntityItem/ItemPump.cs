using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalog;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.EntityItem
{
    public class ItemPump : ValidatableBindableBase, IItem
    {
        private int _Id;
        public int Id
        {
            get => _Id;
            set => SetProperty(ref _Id, value);
        }

        private string _tag;
        public string Tag
        {
            get => _tag;
            set => SetProperty(ref _tag, value);
        }

        private int _designIndex;
        public int DesignIndex
        {
            get => _designIndex;
            set => SetProperty(ref _designIndex, value);
        }

        private int _quantity;
        public int Quantity
        {
            get => _quantity;
            set => SetProperty(ref _quantity, value);
        }

        private bool _isExclded;
        public bool IsExcluded
        {
            get => _isExclded;
            set => SetProperty(ref _isExclded, value);
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

        private int? _catalogPumpId;
        public int? CatalogPumpId
        {
            get => _catalogPumpId;
            set => SetProperty(ref _catalogPumpId, value);
        }

        private CatalogPump _catalogPump;
        public CatalogPump CatalogPump
        {
            get => _catalogPump;
            set => SetProperty(ref _catalogPump, value);
        }

        [NotMapped]
        public ICatalog Catalog { get { return CatalogPump; } }

        [NotMapped]
        public int? CatalogId { get { return CatalogPumpId; } }

        private IList<Title> _titles;
        public IList<Title> Titles
        {
            get => _titles;
            set => SetProperty(ref _titles, value);
        }

        private bool _overridePrice;
        public bool OverridePrice
        {
            get => _overridePrice;
            set
            {
                if (!value && Catalog != null)
                {
                    Price = Catalog.Price;
                }
                SetProperty(ref _overridePrice, value);
            }
        }

        private double _price;
        public double Price
        {
            get => _price;
            set
            {
                if (!OverridePrice && Catalog != null)
                    value = Catalog.Price;

                SetProperty(ref _price, value);
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public ItemPump()
        {
            Tag = "";
            Titles = new ObservableCollection<Title>();
        }
    }
}
