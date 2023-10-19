using Orion.Binding.Binding;
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
    // American Wheatley - Suction Diffusers
    public class CatalogC2 : Catalog
    {
        private string _systemFlange;
        public string SystemFlange
        {
            get => _systemFlange;
            set => SetProperty(ref _systemFlange, value);
        }

        private string _pumpFlange;
        public string PumpFlange
        {
            get => _pumpFlange;
            set => SetProperty(ref _pumpFlange, value);
        }

        private string _shippingWeight;
        public string ShippingWeight
        {
            get => _shippingWeight;
            set => SetProperty(ref _shippingWeight, value);
        }
        [NotMapped]
        public override string Company { get => "American Wheatley"; }
        [NotMapped]
        public override string Product { get => "Suction Diffusers"; }
        [NotMapped]
        public override string Index { get => "C2"; }

        public CatalogC2() : base()
        {
            SystemFlange = "";
            PumpFlange = "";
            ShippingWeight = "";
        }
    }
}

