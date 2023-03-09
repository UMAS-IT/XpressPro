﻿using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.UvResources.Related;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityCatalogUvResources
{
    // UV Resources
    public class CatalogF1 : ValidatableBindableBase, ICatalog
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private string _partNumber;
        public string PartNumber
        {
            get => _partNumber;
            set => SetProperty(ref _partNumber, value);
        }

        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        private double _listPrice;
        public double ListPrice
        {
            get => _listPrice;
            set
            {
                SetProperty(ref _listPrice, value);
                Cost = value * CostMultiplier;
                SellPrice = Cost / (1 - (SellMargin / 100));
            }
        }

        private double _costMultiplier;
        public double CostMultiplier
        {
            get => _costMultiplier;
            set
            {
                SetProperty(ref _costMultiplier, value);
                Cost = value * ListPrice;
                SellPrice = Cost / (1 - (SellMargin / 100));
            }
        }

        private double _cost;
        [NotMapped]
        public double Cost
        {
            get => (ListPrice * CostMultiplier).Truncate(2);
            set => SetProperty(ref _cost, value);
        }

        private double _sellMargin;
        public double SellMargin
        {
            get => _sellMargin;
            set
            {
                SetProperty(ref _sellMargin, value);
                SellPrice = Cost / (1 - (value / 100));
            }
        }

        private double _SellPrice;
        [NotMapped]
        public double SellPrice
        {
            get => (Cost / (1 - (SellMargin / 100))).Truncate(2);
            set => SetProperty(ref _SellPrice, value);
        }

        private int? _dataSheetId;
        public int? DataSheetId
        {
            get => _dataSheetId;
            set => SetProperty(ref _dataSheetId, value);
        }

        private DataSheet _dataSheet;
        public DataSheet DataSheet
        {
            get => _dataSheet;
            set => SetProperty(ref _dataSheet, value);
        }

        private int? _catalogF1ProductTypeId;
        public int? CatalogF1ProductTypeId
        {
            get => _catalogF1ProductTypeId;
            set => SetProperty(ref _catalogF1ProductTypeId, value);
        }

        private CatalogF1ProductType _catalogF1ProductType;
        public CatalogF1ProductType CatalogF1ProductType
        {
            get => _catalogF1ProductType;
            set => SetProperty(ref _catalogF1ProductType, value);
        }

        [NotMapped]
        public string Company { get => "UV Resources"; }
        [NotMapped]
        public string Product { get => "UV"; }
        [NotMapped]
        public string Index { get => "f1"; }

        public CatalogF1()
        {
        }
    }
}
