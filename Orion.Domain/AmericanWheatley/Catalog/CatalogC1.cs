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
    // American Wheatley - Triple Duty Valves
    public class CatalogC1 : Catalog
    {

        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        private string _size;
        public string Size
        {
            get => _size;
            set => SetProperty(ref _size, value);
        }

        private string _shippingWeight;
        public string ShippingWeight
        {
            get => _shippingWeight;
            set => SetProperty(ref _shippingWeight, value);
        }

        private string _endConnection;
        public string EndConnection
        {
            get => _endConnection;
            set => SetProperty(ref _endConnection, value);
        }

        private int? _catalogC1ProductTypeId;
        public int? CatalogC1ProductTypeId
        {
            get => _catalogC1ProductTypeId;
            set => SetProperty(ref _catalogC1ProductTypeId, value);
        }

        private CatalogC1ProductType _catalogC1ProductType;
        public CatalogC1ProductType CatalogC1ProductType
        {
            get => _catalogC1ProductType;
            set => SetProperty(ref _catalogC1ProductType, value);
        }
        [NotMapped]
        public override string Company { get => "American Wheatley"; }
        [NotMapped]
        public override string Product { get => "Triple Duty Valves"; }
        [NotMapped]
        public override string Index { get => "C1"; }

        public CatalogC1() : base()
        {
            Description = "";
            Size = "";
            ShippingWeight = "";
            EndConnection = "";
        }
    }
}

