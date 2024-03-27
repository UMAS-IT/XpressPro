using Orion.Domain.ABOVEAIR.Catalog;
using Orion.Domain.Entity;
using Orion.Domain.PVI.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.PVI.Item
{
    public class ItemX2 : Entity.Item
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

        private int? _catalogX2Id;
        public int? CatalogX2Id
        {
            get => _catalogX2Id;
            set => SetProperty(ref _catalogX2Id, value);
        }

        private CatalogX2 _catalogX2;
        public CatalogX2 CatalogX2
        {
            get => _catalogX2;
            set => SetProperty(ref _catalogX2, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogX2; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogX2Id; } }

        public ItemX2() : base()
        {
            Model = "";
            Capacity = "";
        }
    }
}
