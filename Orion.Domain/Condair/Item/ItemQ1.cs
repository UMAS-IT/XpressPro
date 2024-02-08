using Orion.Domain.ABOVEAIR.Catalog;
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
    public class ItemQ1 : Entity.Item
    {

        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private string _capacity;
        public string Capacity
        {
            get => _capacity;
            set => SetProperty(ref _capacity, value);
        }

        private string _voltage;
        public string Voltage
        {
            get => _voltage;
            set => SetProperty(ref _voltage, value);
        }

        private int? _catalogQ1Id;
        public int? CatalogQ1Id
        {
            get => _catalogQ1Id;
            set => SetProperty(ref _catalogQ1Id, value);
        }

        private CatalogQ1 _catalogQ1;
        public CatalogQ1 CatalogQ1
        {
            get => _catalogQ1;
            set => SetProperty(ref _catalogQ1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogQ1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogQ1Id; } }

        public ItemQ1() : base()
        {
            Model = "";
            Capacity = "";
            Voltage = "";
        }
    }
}
