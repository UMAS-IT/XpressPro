using Orion.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using Orion.Domain.EntityCatalogBACOpenLoopTowers;
using Orion.Domain.BACOpenLoopTowers.Related;

namespace Orion.Domain.EntityItemBACOpenLoopTowers
{
    public class ItemG6 : ItemG
    {
        private int? _catalogG6Id;
        public int? CatalogG6Id
        {
            get => _catalogG6Id;
            set => SetProperty(ref _catalogG6Id, value);
        }

        private CatalogG6 _catalogG6;
        public CatalogG6 CatalogG6
        {
            get => _catalogG6;
            set => SetProperty(ref _catalogG6, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogG6; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogG6Id; } }

        public ItemG6() : base()
        {

        }
    }
}
