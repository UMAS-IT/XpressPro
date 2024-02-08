using Orion.Domain.ABOVEAIR.Catalog;
using Orion.Domain.Entity;
using Orion.Domain.Whalen.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Whalen.Item
{
    public class ItemAA1 : Entity.Item
    {

        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private string _voltage;
        public string Voltage
        {
            get => _voltage;
            set => SetProperty(ref _voltage, value);
        }
        private int? _catalogAA1Id;
        public int? CatalogAA1Id
        {
            get => _catalogAA1Id;
            set => SetProperty(ref _catalogAA1Id, value);
        }

        private CatalogAA1 _catalogAA1;
        public CatalogAA1 CatalogAA1
        {
            get => _catalogAA1;
            set => SetProperty(ref _catalogAA1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogAA1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogAA1Id; } }

        public ItemAA1() : base()
        {
            Model = "";
            Voltage = "";
        }
    }
}
