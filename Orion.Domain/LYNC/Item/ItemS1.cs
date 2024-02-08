using Orion.Domain.ABOVEAIR.Catalog;
using Orion.Domain.Entity;
using Orion.Domain.LYNC.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.LYNC.Item
{
    public class ItemS1 : Entity.Item
    {

        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private string _heatingCapacity;
        public string HeatingCapacity
        {
            get => _heatingCapacity;
            set => SetProperty(ref _heatingCapacity, value);
        }

        private string _coolingCapacity;
        public string CoolingCapacity
        {
            get => _coolingCapacity;
            set => SetProperty(ref _coolingCapacity, value);
        }

        private string _refrigerant;
        public string Refrigerant
        {
            get => _refrigerant;
            set => SetProperty(ref _refrigerant, value);
        }

        private string _voltage;
        public string Voltage
        {
            get => _voltage;
            set => SetProperty(ref _voltage, value);
        }

        private int? _catalogS1Id;
        public int? CatalogS1Id
        {
            get => _catalogS1Id;
            set => SetProperty(ref _catalogS1Id, value);
        }

        private CatalogS1 _catalogS1;
        public CatalogS1 CatalogS1
        {
            get => _catalogS1;
            set => SetProperty(ref _catalogS1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogS1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogS1Id; } }

        public ItemS1() : base()
        {
            Model = "";
            HeatingCapacity = "";
            CoolingCapacity = "";
            Refrigerant = "";
            Voltage = "";
        }
    }
}
