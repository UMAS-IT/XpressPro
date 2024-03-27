using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Domain.Multiaqua.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Multiaqua.Item
{
    public class ItemK1 : Entity.Item
    {
        private int? _catalogK1Id;
        public int? CatalogK1Id
        {
            get => _catalogK1Id;
            set => SetProperty(ref _catalogK1Id, value);
        }

        private CatalogK1 _catalogK1;
        public CatalogK1 CatalogK1
        {
            get => _catalogK1;
            set => SetProperty(ref _catalogK1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogK1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogK1Id; } }

        public ItemK1() : base()
        {
        }
    }
}
