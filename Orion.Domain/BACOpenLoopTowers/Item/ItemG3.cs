using Orion.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using Orion.Domain.EntityCatalogBACOpenLoopTowers;
using Orion.Domain.BACOpenLoopTowers.Related;

namespace Orion.Domain.EntityItemBACOpenLoopTowers
{
    public class ItemG3 : ItemG
    {
        private int? _catalogG3Id;
        public int? CatalogG3Id
        {
            get => _catalogG3Id;
            set => SetProperty(ref _catalogG3Id, value);
        }

        private CatalogG3 _catalogG3;
        public CatalogG3 CatalogG3
        {
            get => _catalogG3;
            set => SetProperty(ref _catalogG3, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogG3; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogG3Id; } }

        public ItemG3() : base()
        {
        }
    }
}
