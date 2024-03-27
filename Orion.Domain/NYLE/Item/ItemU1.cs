using Orion.Domain.ABOVEAIR.Catalog;
using Orion.Domain.Entity;
using Orion.Domain.NYLE.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.NYLE.Item
{
    public class ItemU1 : Entity.Item
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

        private string _compressor;
        public string Compressor
        {
            get => _compressor;
            set => SetProperty(ref _compressor, value);
        }

        private string _voltage;
        public string Voltage
        {
            get => _voltage;
            set => SetProperty(ref _voltage, value);
        }

        private int? _catalogU1Id;
        public int? CatalogU1Id
        {
            get => _catalogU1Id;
            set => SetProperty(ref _catalogU1Id, value);
        }

        private CatalogU1 _catalogU1;
        public CatalogU1 CatalogU1
        {
            get => _catalogU1;
            set => SetProperty(ref _catalogU1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogU1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogU1Id; } }

        public ItemU1() : base()
        {
            Model = "";
            HeatingCapacity = "";
            CoolingCapacity = "";
            Compressor = "";
            Voltage = "";
        }
    }
}
