using Orion.Domain.ABOVEAIR.Catalog;
using Orion.Domain.Entity;
using Orion.Domain.Valent.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Valent.Item
{
    public class ItemZ1 : Entity.Item
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
        private int? _catalogZ1Id;
        public int? CatalogZ1Id
        {
            get => _catalogZ1Id;
            set => SetProperty(ref _catalogZ1Id, value);
        }

        private CatalogZ1 _catalogZ1;
        public CatalogZ1 CatalogZ1
        {
            get => _catalogZ1;
            set => SetProperty(ref _catalogZ1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogZ1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogZ1Id; } }

        public ItemZ1() : base()
        {
            Model = "";
            Cfm = "";
            Voltage = "";
        }
    }
}
