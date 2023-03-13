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

namespace Orion.Domain.EntityCatalogABB
{
    // ABB - BCR
    public class CatalogB4 : Catalog
    {

        private double _Hp;
        public double Hp
        {
            get => _Hp;
            set => SetProperty(ref _Hp, value);
        }

        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        private string _nema;
        public string Nema
        {
            get => _nema;
            set => SetProperty(ref _nema, value);
        }

        private bool _bypass;
        public bool Bypass
        {
            get => _bypass;
            set => SetProperty(ref _bypass, value);
        }

        private bool _circuitBreakerDisconnect;
        public bool CircuitBreakerDisconnect
        {
            get => _circuitBreakerDisconnect;
            set => SetProperty(ref _circuitBreakerDisconnect, value);
        }

        private string _voltage;
        public string Voltage
        {
            get => _voltage;
            set => SetProperty(ref _voltage, value);
        }

        [NotMapped]
        public override string Company { get => "ABB"; }
        [NotMapped]
        public override string Product { get => "BCR"; }
        [NotMapped]
        public override string Index { get => "b4"; }

        public CatalogB4()
        {
            Description = "";
            Nema = "";
            Voltage = "";
        }
    }
}
