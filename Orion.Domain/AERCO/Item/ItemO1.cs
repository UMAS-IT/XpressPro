using Orion.Domain.ABOVEAIR.Catalog;
using Orion.Domain.AERCO.Catalog;
using Orion.Domain.AERCO.Related;
using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.AERCO.Item
{
    public class ItemO1 : ItemO
    {
        private int? _catalogO1Id;
        public int? CatalogO1Id
        {
            get => _catalogO1Id;
            set => SetProperty(ref _catalogO1Id, value);
        }

        private CatalogO1 _catalogO1;
        public CatalogO1 CatalogO1
        {
            get => _catalogO1;
            set => SetProperty(ref _catalogO1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogO1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogO1Id; } }

        public ItemO1() : base()
        {
        }
    }
}
