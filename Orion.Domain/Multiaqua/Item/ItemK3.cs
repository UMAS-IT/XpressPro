using Orion.Domain.Entity;
using Orion.Domain.Multiaqua.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Multiaqua.Item
{
    public class ItemK3 : Entity.Item
    {
        private int? _catalogK3Id;
        public int? CatalogK3Id
        {
            get => _catalogK3Id;
            set => SetProperty(ref _catalogK3Id, value);
        }

        private CatalogK3 _catalogK3;
        public CatalogK3 CatalogK3
        {
            get => _catalogK3;
            set => SetProperty(ref _catalogK3, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogK3; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogK3Id; } }

        public ItemK3() : base()
        {
        }
    }
}
