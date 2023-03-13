using Orion.Binding.Binding;
using Orion.Domain.AmericanWheatley.Related;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityCatalogAmericanWheatley
{
    // American Wheatley - Tanks
    public class CatalogC3 : ValidatableBindableBase, ICatalog
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private string _partNumber;
        public string PartNumber
        {
            get => _partNumber;
            set => SetProperty(ref _partNumber, value);
        }

        private string _acceptableVolume;
        public string AcceptableVolume
        {
            get => _acceptableVolume;
            set => SetProperty(ref _acceptableVolume, value);
        }

        private string _diameterA;
        public string DiameterA
        {
            get => _diameterA;
            set => SetProperty(ref _diameterA, value);
        }

        private string _HeightB;
        public string HeightB
        {
            get => _HeightB;
            set => SetProperty(ref _HeightB, value);
        }

        private string _systemConnect;
        public string SystemConnect
        {
            get => _systemConnect;
            set => SetProperty(ref _systemConnect, value);
        }

        private string _weight;
        public string Weight
        {
            get => _weight;
            set => SetProperty(ref _weight, value);
        }

        private string _workingPressure;
        public string WorkingPressure
        {
            get => _workingPressure;
            set => SetProperty(ref _workingPressure, value);
        }

        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
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

        private int? _catalogC3ProductTypeId;
        public int? CatalogC3ProductTypeId
        {
            get => _catalogC3ProductTypeId;
            set => SetProperty(ref _catalogC3ProductTypeId, value);
        }

        private CatalogC3ProductType _catalogC3ProductType;
        public CatalogC3ProductType CatalogC3ProductType
        {
            get => _catalogC3ProductType;
            set => SetProperty(ref _catalogC3ProductType, value);
        }

        [NotMapped]
        public string Company { get => "American Wheatley"; }
        [NotMapped]
        public string Product { get => "Tanks"; }
        [NotMapped]
        public string Index { get => "C3"; }

        public CatalogC3()
        {
        }
    }
}
