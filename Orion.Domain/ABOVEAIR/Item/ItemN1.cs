using Orion.Domain.ABOVEAIR.Catalog;
using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.ABOVEAIR.Item
{
    public class ItemN1 : Entity.Item
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

        private int? _catalogN1Id;
        public int? CatalogN1Id
        {
            get => _catalogN1Id;
            set => SetProperty(ref _catalogN1Id, value);
        }

        private CatalogN1 _catalogN1;
        public CatalogN1 CatalogN1
        {
            get => _catalogN1;
            set => SetProperty(ref _catalogN1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogN1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogN1Id; } }

        public ItemN1() : base()
        {
            Model = "";
            Cfm = "";
            CoolingCapacity = "";
            Refrigerant = "";
            Voltage = "";
        }
    }
}

