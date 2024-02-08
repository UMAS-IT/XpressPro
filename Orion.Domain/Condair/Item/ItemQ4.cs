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
    public class ItemQ4 : Entity.Item
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

        private string _distributor;
        public string Distributor
        {
            get => _distributor;
            set => SetProperty(ref _distributor, value);
        }

        private string _voltage;
        public string Voltage
        {
            get => _voltage;
            set => SetProperty(ref _voltage, value);
        }

        private int? _catalogQ4Id;
        public int? CatalogQ4Id
        {
            get => _catalogQ4Id;
            set => SetProperty(ref _catalogQ4Id, value);
        }

        private CatalogQ4 _catalogQ4;
        public CatalogQ4 CatalogQ4
        {
            get => _catalogQ4;
            set => SetProperty(ref _catalogQ4, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogQ4; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogQ4Id; } }

        public ItemQ4() : base()
        {
            Model = "";
            Capacity = "";
            Distributor = "";
            Voltage = "";
        }
    }
}
