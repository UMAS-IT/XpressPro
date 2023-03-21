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
    public class ItemK2 : Entity.Item
    {
        private int? _catalogK2Id;
        public int? CatalogK2Id
        {
            get => _catalogK2Id;
            set => SetProperty(ref _catalogK2Id, value);
        }

        private CatalogK2 _catalogK2;
        public CatalogK2 CatalogK2
        {
            get => _catalogK2;
            set => SetProperty(ref _catalogK2, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogK2; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogK2Id; } }

        public ItemK2() : base()
        {
        }
    }
}
