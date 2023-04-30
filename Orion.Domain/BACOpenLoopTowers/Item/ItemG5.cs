using Orion.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using Orion.Domain.EntityCatalogBACOpenLoopTowers;
using Orion.Domain.BACOpenLoopTowers.Related;

namespace Orion.Domain.EntityItemBACOpenLoopTowers
{
    public class ItemG5 : ItemG
    {
        private int? _catalogG5Id;
        public int? CatalogG5Id
        {
            get => _catalogG5Id;
            set => SetProperty(ref _catalogG5Id, value);
        }

        private CatalogG5 _catalogG5;
        public CatalogG5 CatalogG5
        {
            get => _catalogG5;
            set => SetProperty(ref _catalogG5, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogG5; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogG5Id; } }

        public ItemG5() : base()
        {

        }
    }
}
