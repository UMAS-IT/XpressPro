using Orion.Domain.Condair.Catalog;
using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Condair.Item
{
    public class ItemQ3 : Entity.Item
    {

        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private string _rateCapacicty;
        public string RateCapacity
        {
            get => _rateCapacicty;
            set => SetProperty(ref _rateCapacicty, value);
        }

        private string _roSystemOutput;
        public string RoSystemOutput
        {
            get => _roSystemOutput;
            set => SetProperty(ref _roSystemOutput, value);
        }

        private string _voltage;
        public string Voltage
        {
            get => _voltage;
            set => SetProperty(ref _voltage, value);
        }

        private int? _catalogQ3Id;
        public int? CatalogQ3Id
        {
            get => _catalogQ3Id;
            set => SetProperty(ref _catalogQ3Id, value);
        }

        private CatalogQ3 _catalogQ3;
        public CatalogQ3 CatalogQ3
        {
            get => _catalogQ3;
            set => SetProperty(ref _catalogQ3, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogQ3; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogQ3Id; } }

        public ItemQ3() : base()
        {
            Model = "";
            RateCapacity = "";
            RoSystemOutput = "";
            Voltage = "";
        }
    }
}
