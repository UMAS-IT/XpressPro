using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalog;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.EntityItem
{
    public class ItemAirCooledChiller: ValidatableBindableBase, IItem, ICloneable
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

        private int? _catalogAirCooledChillerId;
        public int? CatalogAirCooledChillerId
        {
            get => _catalogAirCooledChillerId;
            set => SetProperty(ref _catalogAirCooledChillerId, value);
        }

        private CatalogAirCooledChiller _catalogAirCooledChiller;
        public CatalogAirCooledChiller CatalogAirCooledChiller
        {
            get => _catalogAirCooledChiller;
            set => SetProperty(ref _catalogAirCooledChiller, value);
        }

        [NotMapped]
        public ICatalog Catalog { get { return CatalogAirCooledChiller; } }

        [NotMapped]
        public int? CatalogId { get { return CatalogAirCooledChillerId; } }

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

        public ItemAirCooledChiller()
        {
            Tag = "";
            Titles = new ObservableCollection<Title>();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
