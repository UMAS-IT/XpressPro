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
    public class ItemX1 : Entity.Item
    {

        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private string _weight;
        public string Weight
        {
            get => _weight;
            set => SetProperty(ref _weight, value);
        }

        private int? _catalogX1Id;
        public int? CatalogX1Id
        {
            get => _catalogX1Id;
            set => SetProperty(ref _catalogX1Id, value);
        }

        private CatalogX1 _catalogX1;
        public CatalogX1 CatalogX1
        {
            get => _catalogX1;
            set => SetProperty(ref _catalogX1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogX1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogX1Id; } }

        public ItemX1() : base()
        {
            Model = "";
            Weight = "";
        }
    }
}
