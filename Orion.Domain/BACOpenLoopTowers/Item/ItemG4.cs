using Orion.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using Orion.Domain.EntityCatalogBACOpenLoopTowers;
using Orion.Domain.BACOpenLoopTowers.Related;

namespace Orion.Domain.EntityItemBACOpenLoopTowers
{
    public class ItemG4 : ItemG
    {
        private int? _catalogG4Id;
        public int? CatalogG4Id
        {
            get => _catalogG4Id;
            set => SetProperty(ref _catalogG4Id, value);
        }

        private CatalogG4 _catalogG4;
        public CatalogG4 CatalogG4
        {
            get => _catalogG4;
            set => SetProperty(ref _catalogG4, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogG4; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogG4Id; } }

        public ItemG4() : base()
        {

        }
    }
}
