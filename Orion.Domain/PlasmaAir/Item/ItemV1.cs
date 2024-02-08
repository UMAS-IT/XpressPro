using Orion.Domain.ABOVEAIR.Catalog;
using Orion.Domain.Entity;
using Orion.Domain.PlasmaAir.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.PlasmaAir.Item
{
    public class ItemV1 : Entity.Item
    {

        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private string _airFlowCapacity;
        public string AirFlowCapacity
        {
            get => _airFlowCapacity;
            set => SetProperty(ref _airFlowCapacity, value);
        }

        private string _noIonizationModules;
        public string NoIonizationModules
        {
            get => _noIonizationModules;
            set => SetProperty(ref _noIonizationModules, value);
        }

        private string _voltage;
        public string Voltage
        {
            get => _voltage;
            set => SetProperty(ref _voltage, value);
        }

        private int? _catalogV1Id;
        public int? CatalogV1Id
        {
            get => _catalogV1Id;
            set => SetProperty(ref _catalogV1Id, value);
        }

        private CatalogV1 _catalogV1;
        public CatalogV1 CatalogV1
        {
            get => _catalogV1;
            set => SetProperty(ref _catalogV1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogV1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogV1Id; } }

        public ItemV1() : base()
        {
            Model = "";
            AirFlowCapacity = "";
            NoIonizationModules = "";
            Voltage = "";
        }
    }
}
