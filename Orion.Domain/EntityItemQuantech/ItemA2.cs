﻿using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogQuantech;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.EntityItem
{
    //QUANTECH - Air Cooled Stock Non Coated
    public class ItemA2 : ValidatableBindableBase, IItem
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

        private int _quantity;
        public int Quantity
        {
            get => _quantity;
            set => SetProperty(ref _quantity, value);
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
                }
                SetProperty(ref _overridePrice, value);
            }
        }

        private IList<Title> _titles;
        public IList<Title> Titles
        {
            get => _titles;
            set => SetProperty(ref _titles, value);
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
            }
        }

        private double _cost;
        public double Cost
        {
            get => _cost;
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
            }
        }

        private double _sellPrice;
        public double SellPrice
        {
            get => _sellPrice;
            set
            {
                if (!OverridePrice && Catalog != null)
                    value = Catalog.SellPrice;

                SetProperty(ref _sellPrice, value);
            }
        }

        private int? _catalogA2Id;
        public int? CatalogA2Id
        {
            get => _catalogA2Id;
            set => SetProperty(ref _catalogA2Id, value);
        }

        private CatalogA2 _catalogA2;
        public CatalogA2 CatalogA2
        {
            get => _catalogA2;
            set => SetProperty(ref _catalogA2, value);
        }

        [NotMapped]
        public ICatalog Catalog { get { return CatalogA2; } }

        [NotMapped]
        public int? CatalogId { get { return CatalogA2Id; } }

        public ItemA2()
        {
            Titles = new ObservableCollection<Title>();
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
