using Orion.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using Orion.Domain.EntityCatalogBACOpenLoopTowers;
using Orion.Domain.BACOpenLoopTowers.Related;

namespace Orion.Domain.EntityItemBACOpenLoopTowers
{
    public class ItemG1 : ItemG
    {
        private int? _catalogG1Id;
        public int? CatalogG1Id
        {
            get => _catalogG1Id;
            set => SetProperty(ref _catalogG1Id, value);
        }

        private CatalogG1 _catalogG1;
        public CatalogG1 CatalogG1
        {
            get => _catalogG1;
            set => SetProperty(ref _catalogG1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogG1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogG1Id; } }

        public ItemG1() : base()
        {
        }
    }
}
