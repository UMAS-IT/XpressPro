using Orion.Domain.Entity;
using Orion.Domain.PACE.Catalog;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.PACE.Item
{
    public class ItemJ1 : Entity.Item
    {
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

        private string _Weight;
        public string Weight
        {
            get => _Weight;
            set => SetProperty(ref _Weight, value);
        }

        private int? _catalogJ1Id;
        public int? CatalogJ1Id
        {
            get => _catalogJ1Id;
            set => SetProperty(ref _catalogJ1Id, value);
        }

        private CatalogJ1 _catalogJ1;
        public CatalogJ1 CatalogJ1
        {
            get => _catalogJ1;
            set => SetProperty(ref _catalogJ1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogJ1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogJ1Id; } }

        public ItemJ1() : base()
        {
            Cfm = "";
            Voltage = "";
            Weight = "";
        }
    }
}
