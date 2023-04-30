using Orion.Domain.BACClosedLoopTowers.Related;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogBACClosedLoopTowers;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.EntityItemBACClosedLoopTowers
{
    public class ItemH1 : ItemH
    {
        private int? _catalogH1Id;
        public int? CatalogH1Id
        {
            get => _catalogH1Id;
            set => SetProperty(ref _catalogH1Id, value);
        }

        private CatalogH1 _catalogH1;
        public CatalogH1 CatalogH1
        {
            get => _catalogH1;
            set => SetProperty(ref _catalogH1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogH1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogH1Id; } }

        public ItemH1() : base()
        {
        }
    }
}
