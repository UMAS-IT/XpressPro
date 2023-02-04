﻿using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogPuroflux;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityItemPuroFlux
{
    public class ItemD1 : ValidatableBindableBase, IItem
    {

        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

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

        private string _tag;
        public string Tag
        {
            get => _tag;
            set => SetProperty(ref _tag, value);
        }

        private bool _isExcluded;
        public bool IsExcluded
        {
            get => _isExcluded;
            set => SetProperty(ref _isExcluded, value);
        }

        private int _designIndex;
        public int DesignIndex
        {
            get => _designIndex;
            set => SetProperty(ref _designIndex, value);
        }

        private IList<Title> _titles;
        public IList<Title> Titles
        {
            get => _titles;
            set => SetProperty(ref _titles, value);
        }

        private int _quantity;
        public int Quantity
        {
            get => _quantity;
            set
            {
                SetProperty(ref _quantity, value);
                TotalPrice = SellPrice * value;
            }
        }

        private bool _overridePrice;
        public bool OverridePrice
        {
            get => _overridePrice;
            set
            {
                if (!value && Catalog != null)
                {
                    ListPrice = Catalog.ListPrice;
                    CostMultiplier = Catalog.CostMultiplier;
                    Cost = Catalog.Cost;
                    SellMargin = Catalog.SellMargin;
                    SellPrice = Catalog.SellPrice;
                    TotalPrice = Catalog.SellPrice * Quantity;
                }
                SetProperty(ref _overridePrice, value);
            }
        }

        private double _listPrice;
        public double ListPrice
        {
            get => _listPrice;
            set
            {
                if (!OverridePrice && Catalog != null)
                    value = Catalog.ListPrice;

                SetProperty(ref _listPrice, value);
                Cost = value * CostMultiplier;
                SellPrice = Cost / (1 - (SellMargin / 100));
                TotalPrice = SellPrice * Quantity;

            }
        }

        private double _costMultiplier;
        public double CostMultiplier
        {
            get => _costMultiplier;
            set
            {
                if (!OverridePrice && Catalog != null)
                    value = Catalog.CostMultiplier;

                SetProperty(ref _costMultiplier, value);
                Cost = value * ListPrice;
                SellPrice = Cost / (1 - (SellMargin / 100));
                TotalPrice = SellPrice * Quantity;
            }
        }

        private double _cost;
        [NotMapped]
        public double Cost
        {
            get => (ListPrice * CostMultiplier).Truncate(2);
            set
            {
                if (!OverridePrice && Catalog != null)
                    value = Catalog.Cost;

                SetProperty(ref _cost, value);
            }
        }

        private double _sellMargin;
        public double SellMargin
        {
            get => _sellMargin;
            set
            {
                if (!OverridePrice && Catalog != null)
                    value = Catalog.SellMargin;

                SetProperty(ref _sellMargin, value);
                SellPrice = Cost / (1 - (value / 100));
                TotalPrice = SellPrice * Quantity;
            }
        }

        private double _sellPrice;
        [NotMapped]
        public double SellPrice
        {
            get => (Cost / (1 - (SellMargin / 100))).Truncate(2);
            set
            {
                if (!OverridePrice && Catalog != null)
                    value = Catalog.SellPrice;

                SetProperty(ref _sellPrice, value);
            }
        }

        private double _totalPrice;
        [NotMapped]
        public double TotalPrice
        {
            get => (SellPrice * Quantity).Truncate(2);
            set
            {
                if (!OverridePrice && Catalog != null)
                    value = Catalog.SellPrice * Quantity;

                SetProperty(ref _totalPrice, value);
            }
        }

        private int? _catalogD1Id;
        public int? CatalogD1Id
        {
            get => _catalogD1Id;
            set => SetProperty(ref _catalogD1Id, value);
        }

        private CatalogD1 _catalogD1;
        public CatalogD1 CatalogD1
        {
            get => _catalogD1;
            set => SetProperty(ref _catalogD1, value);
        }

        [NotMapped]
        public ICatalog Catalog { get { return CatalogD1; } }

        [NotMapped]
        public int? CatalogId { get { return CatalogD1Id; } }

        public ItemD1()
        {
            Titles = new ObservableCollection<Title>();
            Quantity = 1;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}