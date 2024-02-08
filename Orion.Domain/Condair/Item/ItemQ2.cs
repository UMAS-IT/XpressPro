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
    public class ItemQ2 : Entity.Item
    {

        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private string _waterType;
        public string WaterType
        {
            get => _waterType;
            set => SetProperty(ref _waterType, value);
        }

        private string _lbsHr;
        public string LbsHr
        {
            get => _lbsHr;
            set => SetProperty(ref _lbsHr, value);
        }

        private string _voltage;
        public string Voltage
        {
            get => _voltage;
            set => SetProperty(ref _voltage, value);
        }

        private int? _catalogQ2Id;
        public int? CatalogQ2Id
        {
            get => _catalogQ2Id;
            set => SetProperty(ref _catalogQ2Id, value);
        }

        private CatalogQ2 _catalogQ2;
        public CatalogQ2 CatalogQ2
        {
            get => _catalogQ2;
            set => SetProperty(ref _catalogQ2, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogQ2; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogQ2Id; } }

        public ItemQ2() : base()
        {
            Model = "";
            WaterType = "";
            LbsHr = "";
            Voltage = "";
        }
    }
}
