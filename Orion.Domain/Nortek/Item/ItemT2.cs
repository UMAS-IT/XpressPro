using Orion.Domain.Entity;
using Orion.Domain.Nortek.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Nortek.Item
{
    public class ItemT2 : Entity.Item
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

        private int? _catalogT2Id;
        public int? CatalogT2Id
        {
            get => _catalogT2Id;
            set => SetProperty(ref _catalogT2Id, value);
        }

        private CatalogT2 _catalogT2;
        public CatalogT2 CatalogT2
        {
            get => _catalogT2;
            set => SetProperty(ref _catalogT2, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogT2; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogT2Id; } }

        public ItemT2() : base()
        {
            Model = "";
            Cfm = "";
            Voltage = "";
        }
    }
}
