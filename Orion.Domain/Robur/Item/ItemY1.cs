using Orion.Domain.ABOVEAIR.Catalog;
using Orion.Domain.Entity;
using Orion.Domain.Robur.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Robur.Item
{
    public class ItemY1 : Entity.Item
    {

        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private string _coolingNominalTons;
        public string CoolingNominalTons
        {
            get => _coolingNominalTons;
            set => SetProperty(ref _coolingNominalTons, value);
        }

        private string _heatingMbhOutput;
        public string HeatingMbhOutput
        {
            get => _heatingMbhOutput;
            set => SetProperty(ref _heatingMbhOutput, value);
        }

        private string _fuel;
        public string Fuel
        {
            get => _fuel;
            set => SetProperty(ref _fuel, value);
        }

        private string _voltage;
        public string Voltage
        {
            get => _voltage;
            set => SetProperty(ref _voltage, value);
        }

        private int? _catalogY1Id;
        public int? CatalogY1Id
        {
            get => _catalogY1Id;
            set => SetProperty(ref _catalogY1Id, value);
        }

        private CatalogY1 _catalogY1;
        public CatalogY1 CatalogY1
        {
            get => _catalogY1;
            set => SetProperty(ref _catalogY1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogY1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogY1Id; } }

        public ItemY1() : base()
        {
            Model = "";
            CoolingNominalTons = "";
            HeatingMbhOutput = "";
            Fuel = "";
            Voltage = "";
        }
    }
}
