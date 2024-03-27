using Orion.Domain.Entity;
using Orion.Domain.PACE.Catalog;
using Orion.Domain.UMAS.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.UMAS.Item
{
    public class ItemM1 : Entity.Item
    {
        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private string _cfm;
        public string Cfm
        {
            get => _cfm;
            set => SetProperty(ref _cfm, value);
        }

        private string _voltage;
        public string Voltage
        {
            get => _voltage;
            set => SetProperty(ref _voltage, value);
        }

        private string _Weight;
        public string Weight
        {
            get => _Weight;
            set => SetProperty(ref _Weight, value);
        }

        private int? _catalogM1Id;
        public int? CatalogM1Id
        {
            get => _catalogM1Id;
            set => SetProperty(ref _catalogM1Id, value);
        }

        private CatalogM1 _catalogM1;
        public CatalogM1 CatalogM1
        {
            get => _catalogM1;
            set => SetProperty(ref _catalogM1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogM1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogM1Id; } }

        public ItemM1() : base()
        {
            Model = "";
            Cfm = "";
            Voltage = "";
            Weight = "";
            OverridePrice = true;
        }
    }
}
