using Orion.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using Orion.Domain.EntityCatalogBACOpenLoopTowers;
using Orion.Domain.BACOpenLoopTowers.Related;

namespace Orion.Domain.EntityItemBACOpenLoopTowers
{
    public class ItemG2 : ItemG
    {
        private int? _catalogG2Id;
        public int? CatalogG2Id
        {
            get => _catalogG2Id;
            set => SetProperty(ref _catalogG2Id, value);
        }

        private CatalogG2 _catalogG2;
        public CatalogG2 CatalogG2
        {
            get => _catalogG2;
            set => SetProperty(ref _catalogG2, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogG2; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogG2Id; } }

        public ItemG2() : base()
        {
        }
    }
}
