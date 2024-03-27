using Orion.Domain.BACClosedLoopTowers.Related;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogBACClosedLoopTowers;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.EntityItemBACClosedLoopTowers
{
    public class ItemH4 : ItemH
    {
        private int? _catalogH4Id;
        public int? CatalogH4Id
        {
            get => _catalogH4Id;
            set => SetProperty(ref _catalogH4Id, value);
        }

        private CatalogH4 _catalogH4;
        public CatalogH4 CatalogH4
        {
            get => _catalogH4;
            set => SetProperty(ref _catalogH4, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogH4; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogH4Id; } }

        public ItemH4() : base()
        {
        }
    }
}
